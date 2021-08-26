using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;
using System.Diagnostics;

namespace SysDiarias
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio(string servidor, string cargo, string banco, string agencia, string conta, string cpf,
            string secretaria, string destino, string finalidade, string datasaida, string dataretorno, string qtdealim,
            string valoralim, string totalalim, string qtdehosp, string valorhosp, string totalhosp, string totaldiarias,
            string transporte, string placanome, string horasaida, string horaretorno)


        {
            InitializeComponent();
            reportViewer1.LocalReport.DataSources.Clear();
            this.KeyDown += FrmRelatorio_KeyDown;
            this.MinimizeBox = false;
            this.MaximizeBox = false;


            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[22];

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
            p[18] = new Microsoft.Reporting.WinForms.ReportParameter("Transporte", transporte);
            p[19] = new Microsoft.Reporting.WinForms.ReportParameter("PlacaNome", placanome);
            p[20] = new Microsoft.Reporting.WinForms.ReportParameter("HoraSaida", horasaida);
            p[21] = new Microsoft.Reporting.WinForms.ReportParameter("HoraRetorno", horaretorno);


            var setup = reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(78, 39, 39, 39);
            reportViewer1.SetPageSettings(setup);
            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.RefreshReport();
            reportViewer1.Show();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void FrmRelatorio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
        public void SavePDF(ReportViewer viewer, string savePath)
        {
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");
            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
        }
        private void ReportViewer1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue.Equals(27))
            {
                this.Close();
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ProcessingMode = ProcessingMode.Local;
            //reportViewer.LocalReport.ReportEmbeddedResource = "SysDiarias.Diaria.rdlc";
            //saveFileDialog1.DefaultExt = ".pdf";
            //if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    Warning[] warnings;
            //    string[] streamids;
            //    string mimeType;
            //    string encoding;
            //    string extension;

            //    byte[] bytePDF = reportViewer.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

            //    FileStream fileStreamPDF = null;
            //    string nomeArquivoPDF = saveFileDialog1.FileName;


            //    fileStreamPDF = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            //    fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
            //    fileStreamPDF.Close();
            //    Process.Start(nomeArquivoPDF);

            //    fileStreamPDF = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            //    fileStreamPDF.Write(bytePDF, 0, bytePDF.Length);
            //    fileStreamPDF.Close();
            //    Process.Start(saveFileDialog1.FileName);
            //}
            saveFileDialog1.DefaultExt = "pdf";
            saveFileDialog1.Filter = "Arquivo PDF|*.pdf";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                SavePDF(reportViewer1, saveFileDialog1.FileName);
        }
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            reportViewer1.PrintDialog();

            
        }
        private void ToolStripButton3_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
