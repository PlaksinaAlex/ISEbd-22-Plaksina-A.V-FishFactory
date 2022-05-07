﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishFactoryContracts.BusinessLogicsContracts;

namespace FishFactoryView
{
	public partial class FormMessageInfoes : Form
	{
		private readonly IMessageInfoLogic logic;

		public FormMessageInfoes(IMessageInfoLogic logic)
		{
			InitializeComponent();
			this.logic = logic;
		}
        private void LoadData()
        {
            try
            {
                var list = logic.Read(null);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormMessageInfoes_Load(object sender, EventArgs e)
		{
            LoadData();
		}
	}
}
