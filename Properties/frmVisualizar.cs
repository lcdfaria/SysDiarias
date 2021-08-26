using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysDiarias.Properties
{
    public partial class frmVisualizar : Form
    {
        public frmVisualizar(string servidor, string cargo, string banco, string agencia, string conta, string cpf,
            string secretaria, string destino, string finalidade, string datasaida, string dataretorno, string qtdealim,
            string valoralim, string totalalim, string qtdehosp, string valorhosp, string totalhosp, string totaldiarias,
            string transporte, string placanome, string datasolicitacao)
        {
            InitializeComponent();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "SysDiárias.Report3.rdlc";

            Microsoft.Reporting.WinForms.ReportParameter[] p = new
                Microsoft.Reporting.WinForms.ReportParameter[21];

            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("Nome", servidor);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Cargo", cargo);
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Banco", banco);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("Agencia", agencia);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("Conta", conta);
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("Cpf", cpf);
            p[6] = new Microsoft.Reporting.WinForms.ReportParameter("Secretaria", secretaria);
            p[7] = new Microsoft.Reporting.WinForms.ReportParameter("Destino", destino);
            p[8] = new Microsoft.Reporting.WinForms.ReportParameter("Finalidade", finalidade);
            p[9] = new Microsoft.Reporting.WinForms.ReportParameter("DataSaida", datasaida);
            p[10] = new Microsoft.Reporting.WinForms.ReportParameter("DataRetorno", dataretorno);
            p[11] = new Microsoft.Reporting.WinForms.ReportParameter("QtdeAlim", qtdealim);
            p[12] = new Microsoft.Reporting.WinForms.ReportParameter("ValorAlim", valoralim);
            p[13] = new Microsoft.Reporting.WinForms.ReportParameter("TotalAlim", totalalim);
            p[14] = new Microsoft.Reporting.WinForms.ReportParameter("QtdeHosp", qtdehosp);
            p[15] = new Microsoft.Reporting.WinForms.ReportParameter("ValorHosp", valorhosp);
            p[16] = new Microsoft.Reporting.WinForms.ReportParameter("TotalHosp", totalhosp);
            p[17] = new Microsoft.Reporting.WinForms.ReportParameter("TotalDiarias", totaldiarias);
            p[18] = new Microsoft.Reporting.WinForms.ReportParameter("Transporte", servidor);
            p[19] = new Microsoft.Reporting.WinForms.ReportParameter("PlacaNome", placanome);
            p[20] = new Microsoft.Reporting.WinForms.ReportParameter("DataSolicitacao", datasolicitacao);

            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
            reportViewer1.Show();
            
        }

        private void FrmVisualizar_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
