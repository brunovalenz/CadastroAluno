﻿using MySql.Data.MySqlClient;
using ReaLTaiizor.Forms;
using Spire.Pdf;
using Spire.Pdf.Graphics;
using Spire.Pdf.Tables;
using System.Data;
using System.Diagnostics;

namespace projeto4
{
    public partial class RelatórioAluno : MaterialForm
    {
        public RelatórioAluno()
        {
            InitializeComponent();
            CarregaImpressoras();
        }

        string cs = @"server=localhost;" +
            "uid=root;" +
            "pwd=;" +
            "database=academico";

        private void MontaRelatorio()
        {

            //Consulta ao banco de dados
            var con = new MySqlConnection(cs);
            con.Open();

            var sql = "SELECT * FROM aluno WHERE 1 = 1";

            if(cboEstado.Text != "") sql += " and estado = @estado";
            if (txtCidade.Text != "") sql += " and cidade = @cidade";

            var sqlAd = new MySqlDataAdapter();
            sqlAd.SelectCommand = new MySqlCommand(sql, con);

            if(cboEstado.Text != "") sqlAd.SelectCommand.Parameters.AddWithValue("@estado", cboEstado.Text);

            if (txtCidade.Text != "") sqlAd.SelectCommand.Parameters.AddWithValue("@cidade", txtCidade.Text);


            var dt = new DataTable();
            sqlAd.Fill(dt);

            //Inicio geração PDF
            PdfDocument doc = new PdfDocument();
            PdfSection sec = doc.Sections.Add();
            sec.PageSettings.Width = PdfPageSize.A4.Width;
            PdfPageBase page = sec.Pages.Add();
            float y = 20;
            PdfBrush brush1 = PdfBrushes.Black;

            PdfTrueTypeFont font1 = new PdfTrueTypeFont(new Font("Arial", 16f, FontStyle.Bold));
            PdfStringFormat format1 = new PdfStringFormat(PdfTextAlignment.Center);

            page.Canvas.DrawString("Relatório de Alunos", font1, brush1, page.Canvas.ClientSize.Width / 2, y, format1);

            PdfTable table = new PdfTable();
            table.Style.CellPadding= 2;
            table.Style.BorderPen = new PdfPen(brush1, 0.75f);
            table.Style.HeaderStyle.StringFormat= new PdfStringFormat(PdfTextAlignment.Center);
            table.Style.HeaderSource = PdfHeaderSource.ColumnCaptions;
            //table.Style.HeaderRowCount= 1;
            table.Style.ShowHeader = true;
            table.Style.HeaderStyle.BackgroundBrush = PdfBrushes.Red;
            table.DataSource= dt;

            foreach(PdfColumn col in table.Columns)
            {
                col.StringFormat = new PdfStringFormat(PdfTextAlignment.Center, PdfVerticalAlignment.Middle);
            }

            table.Draw(page, new PointF(0,y+30));


            doc.SaveToFile("RelatorioAlunos.pdf");


            con.Close();
        }

        private void CarregaImpressoras()
        {
            foreach(string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cboImpressora.Items.Add(printer);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            //envia para impressora
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MontaRelatorio();
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"RelatorioAlunos.pdf")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
}
