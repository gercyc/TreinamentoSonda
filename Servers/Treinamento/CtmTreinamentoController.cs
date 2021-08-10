using Procwork.Software.Framework.Server.BaseClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Procwork.Software.SATI.COM.Servers.Treinamento
{
    [ProcworkBusinessObject(typeof(CtmTreinamentoController))]
    public partial class CtmTreinamentoController : BusinessServer
    {
        public CtmTreinamentoController()
        {
            InitializeComponent();
        }

        public CtmTreinamentoController(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
