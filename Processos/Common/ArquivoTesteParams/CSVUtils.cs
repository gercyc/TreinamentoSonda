using Procwork.Software.Framework.BaseClasses;
using Procwork.Software.Framework.Server.BaseClasses;
using Procwork.Software.SATI.PROC.Common.ArquivoMagnetico;
using Procwork.Software.SATI.PROC.Common.CoordenadorProcesso;
using Procwork.Software.SATI.PROC.Common.TPArtefato;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace Procwork.Software.SATI.COM.Common.ArquivoTesteParams
{
    public static class CSVUtils
    {
        public static void WriteFileHeader(DataTable tableStructure, string name, TextWriter textWriter, StringBuilder stringBuilder, ref Dictionary<string, Type> colunasQuery, bool tabulado)
        {
            var header = "";

            for (int i = 0; i <= tableStructure.Columns.Count - 1; i++)
            {
                if (!colunasQuery.ContainsKey(tableStructure.Columns[i].ColumnName))
                    colunasQuery.Add(tableStructure.Columns[i].ColumnName, tableStructure.Columns[i].DataType);
            }
            //write file reader
            //remocao da coluna CHAVE_PROCESSO <<- Utilizada para processamento em massa
            if (colunasQuery.ContainsKey("CHAVE_PROCESSO"))
                colunasQuery.Remove("CHAVE_PROCESSO");

            foreach (var col in colunasQuery)
            {
                header += (tabulado) ? col.Key + "\t" : col.Key + ";";
            }
            header = header.Substring(0, header.Length - 1);
            stringBuilder.AppendLine(header);
            textWriter.Write(stringBuilder.ToString());
            //terminou o header, limpa o sb
            stringBuilder.Clear();
            textWriter.Flush();
        }
        public static void WriteLineOnFile(IDataReader reader, TextWriter textWriter, StringBuilder stringBuilder, Dictionary<string, Type> colunasQuery, bool tabulado, bool totalizador, string lastLine, out string lineOutput)
        {
            lineOutput = string.Empty;

            if (reader != null)
            {
                try
                {
                    foreach (var coluna in colunasQuery)
                    {
                        stringBuilder.Append(GetValueDataReader(reader, coluna));

                        if (colunasQuery.Where(c => c.Key.Equals(coluna.Key)).FirstOrDefault().Key != colunasQuery.Last().Key)
                            stringBuilder.Append(tabulado ? "\t" : ";");
                    }
                    if (totalizador && !tabulado) stringBuilder.Append(";");
                    //stringBuilder.AppendLine();
                    lineOutput = stringBuilder.ToString();
                    //textWriter.Write(stringBuilder.ToString());

                    stringBuilder.Clear();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public static object GetValueDataReader(IDataReader dbReader, KeyValuePair<string, Type> coluna)
        {
            switch (coluna.Value.Name)
            {
                case "Int16":
                case "Int32":
                case "Int64":
                    try
                    {
                        return dbReader.GetInt64(dbReader.GetOrdinal(coluna.Key));
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                case "Single":
                    try
                    {
                        return dbReader.GetFloat(dbReader.GetOrdinal(coluna.Key));
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                case "Double":
                    try
                    {
                        var retorno = dbReader.GetDouble(dbReader.GetOrdinal(coluna.Key));
                        decimal vlr = 0M;
                        Decimal.TryParse(retorno.ToString(), out vlr);
                        return vlr;
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                case "Decimal":
                    try
                    {
                        return dbReader.GetDecimal(dbReader.GetOrdinal(coluna.Key));
                    }
                    catch (Exception)
                    {
                        return 0;
                    }
                case "DateTime":
                    try
                    {
                        return dbReader.GetDateTime(dbReader.GetOrdinal(coluna.Key)).ToShortDateString();
                    }
                    catch (Exception)
                    {
                        return new DateTime(99, 1, 1);
                    }
                default:
                    try
                    {
                        var hResult = dbReader.GetString(dbReader.GetOrdinal(coluna.Key)).Replace("\0", " ");
                        return hResult;
                    }
                    catch (Exception)
                    {
                        return string.Empty;
                    }
            };
        }
        public static int PersisteArquivo(int totalLinhas, ContextoExecucao context, string nomeArquivo, BusinessServer server)
        {
            var filename = nomeArquivo.Split('\\').Last();
            var fullpath = Path.Combine(Utils.GetServerDirectory(), filename);

            var persistData = new PersistenciaArquivoData
            {
                CusID = context.CusId,
                BusID = context.BusId,
                BuoID = null,
                TagID = 10001,
                PeriodoIni = context.DataInicial,
                PeriodoFim = context.DataFinal,
                DataHoraGeracao = DateTime.Now,
                NomeArquivo = filename,
                Descricao = filename,
                TotalLinhas = totalLinhas,
                Comprimido = true,
                DestinoGeracao = DestinoPersistenciaSATI.BancoDeDados
            };

            var persistSati = new PersistenciaArquivoSATI(fullpath, persistData, server.SessionID);
            var ret = persistSati.PersisteArquivo(server.CallServer<IPersistenciaGeradorArquivo>("Procwork.Software.SATI.PROC.Servers.ArquivoMagnetico.ArquivoMagneticoController.soap"));

            //adicionar o artefato na central
            context.RuntimeService.AdicionarArtefato(server.SessionID,
               context,
               ArtefatoType.ArquivoMagnetico,
               ret,
               filename,
               true);
            return ret;
        }
        public static string BasePath { get { return Utils.GetServerDirectory(); } }
        public static string GetFileName(string filename, ContextoExecucao contexto)
        {
            try
            {
                string codMatriz = contexto.ParametrosAdicionais.Where(t => t.Key == "Matriz").FirstOrDefault().Value.ToString();
                string codFilial = contexto.ParametrosAdicionais.Where(t => t.Key == "Filial").FirstOrDefault().Value.ToString();
                return filename + "_" + codMatriz + "_" + codFilial + "_" + contexto.DataInicial.ToString("ddMMyyyy") + "_" + contexto.DataFinal.ToString("ddMMyyyy") + "_" + DateTime.Now.ToString("HHmmss") + ".txt";

            }
            catch (Exception)
            {
                return filename + "_" + Utils.NewGuid() + ".txt";
            }
        }
        private static string getfileNamePainel(string filename, ContextoExecucao contexto)
        {
            string tipoArq = contexto.ParametrosAdicionais.Where(t => t.Key == "tabulado").FirstOrDefault().Value.ToString();
            tipoArq = tipoArq.Equals("True") ? "_tabulado" : "";

            string totalizador = "";
            if (contexto.ParametrosAdicionais.ContainsKey("totalizador"))
            {
                totalizador = contexto.ParametrosAdicionais.Where(t => t.Key == "totalizador").FirstOrDefault().Value.ToString();
                totalizador = totalizador.Equals("True") ? "_totalizador" : "";
            }
            return filename + tipoArq + totalizador;
        }

    }
}
