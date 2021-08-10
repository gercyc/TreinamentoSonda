using Procwork.Software.Framework.BaseClasses;
using Procwork.Software.Framework.Server.BaseClasses;
using Procwork.Software.SATI.COM.Common.ArquivoTesteParams;
using Procwork.Software.SATI.PROC.Common.CoordenadorProcesso;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace Procwork.Software.SATI.COM.Servers.CtmArquivoTeste
{
    [ProcworkBusinessObject(typeof(CtmArquivoTesteController))]
    public partial class CtmArquivoTesteController : BusinessServer, IExecutorProcesso
    {
        Dictionary<string, Type> colunasQuery2;
        public CtmArquivoTesteController()
        {
            InitializeComponent();
        }

        public CtmArquivoTesteController(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }


        public Type ControleParametrizacaoCustomizada(string sessionID)
        {
            return null;
        }

        public ResultadoProcesso IniciarExecucao(ContextoExecucao contexto, string sessionID)
        {
            ConnectToDatabase();
            InitSession(sessionID);
            string p_valor = contexto.ParametrosAdicionais.Where(t => t.Key == "P_VALOR").FirstOrDefault().Value.ToString();
            this.colunasQuery2 = new Dictionary<string, Type>();
            var filename = CSVUtils.GetFileName("ARQ_TESTE", contexto);
            var basePath = Utils.GetServerDirectory();
            var finalPath = Path.Combine(CSVUtils.BasePath, filename);
            TextWriter textWriter = new StreamWriter(finalPath, true, Encoding.UTF8, 65536);
            StringBuilder builder = new StringBuilder(2048);
            string lastLine = string.Empty, lineOut = string.Empty;


            #region HeaderCSV
            var par = new ParameterList();
            //escreve o header do arquivo.
            CSVUtils.WriteFileHeader(this.ServerDataAccess.Select("QUERY", "SELECT * FROM BSC_TP_OBRIGACAO", par),
                finalPath, textWriter, builder, ref this.colunasQuery2, false);
            #endregion

            #region Consulta
            int lines = 0;
            try
            {
                contexto.RuntimeService.InformacaoExecucao(this.SessionID, contexto, "Iniciando execução totalizador...", true);

                using (IDataReader reader = this.ServerDataAccess.ExecuteReader("SELECT * FROM BSC_TP_OBRIGACAO", par))
                {
                    while (reader.Read())
                    {
                        CSVUtils.WriteLineOnFile(reader, textWriter, builder, this.colunasQuery2, false, true, lastLine, out lineOut);
                        textWriter.Write(lineOut);
                        lastLine = lineOut;
                        lines++;
                    }
                }
                textWriter.Flush();
                textWriter.Close();
                builder.Clear();
                var rpt = CSVUtils.PersisteArquivo(lines, contexto, finalPath, this);
            }
            catch (Exception err)
            {
                lines = -1;
            }

            #endregion

            return new ResultadoProcesso(StatusProcesso.Sucesso, "Processo executado com sucesso!");

        }

        public ResultadoProcesso IniciarLimpeza(ContextoExecucao contexto, string sessionID)
        {
            return new ResultadoProcesso(StatusProcesso.Sucesso, "");
        }

        public PermissaoExecucao PodeExecutar(ContextoExecucao contexto, string sessionID)
        {
            InitSession(sessionID);
            var per = new PermissaoExecucao() { Permissoes = new List<PermissaoExecucaoInfo>() };
            per.Permissoes.Add(new PermissaoExecucaoInfo() { Permissao = RespostaPermitirExecucao.Permitido });
            return per;
        }

        public PermissaoExecucao PodeLimpar(ContextoExecucao contexto, string sessionID)
        {
            InitSession(sessionID);
            var per = new PermissaoExecucao() { Permissoes = new List<PermissaoExecucaoInfo>() };
            per.Permissoes.Add(new PermissaoExecucaoInfo() { Permissao = RespostaPermitirExecucao.NaoPermitido });
            return per;
        }

        public PermissaoExecucao PodeReprocessar(ContextoExecucao contexto, string sessionID)
        {
            InitSession(sessionID);
            var per = new PermissaoExecucao() { Permissoes = new List<PermissaoExecucaoInfo>() };
            per.Permissoes.Add(new PermissaoExecucaoInfo() { Permissao = RespostaPermitirExecucao.Permitido });
            return per;
        }
    }
}
