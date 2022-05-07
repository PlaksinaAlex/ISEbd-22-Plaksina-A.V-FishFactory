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
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using System.IO;

namespace FishFactoryView
{
	public partial class FormReportOrdersByDate : Form
	{
      
         private readonly ReportViewer reportViewer;

         private readonly IReportLogic _logic;

         public FormReportOrdersByDate(IReportLogic logic)
          {
                InitializeComponent();
                _logic = logic;

                reportViewer = new ReportViewer
                {
                    Dock = DockStyle.Fill
                };
                reportViewer.LocalReport.LoadReportDefinition(new FileStream("C:\\Users\\user\\source\\repos\\exexex2\\FishFactory\\FishFactoryView\\ReportOrdersByDate.rdlc", FileMode.Open));
                Controls.Clear();
                Controls.Add(reportViewer);
                Controls.Add(panel);
            }

         private void buttonForm_Click(object sender, EventArgs e)
		 {
            try
            {
                var dataSource = _logic.GetOrdersByDate();

                var source = new ReportDataSource("DataSetOrdersByDate", dataSource);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.DataSources.Add(source);
                reportViewer.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }

		private void buttonFormPdf_Click(object sender, EventArgs e)
		{
            using var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _logic.SaveOrdersByDateToPdfFile(new ReportBindingModel
                    {
                        FileName = dialog.FileName
                    });
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
	}
}
