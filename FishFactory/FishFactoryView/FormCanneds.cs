﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using Unity;

namespace FishFactoryView
{
	public partial class FormCanneds : Form
	{
        private readonly ICannedLogic _logic;
        public FormCanneds(ICannedLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }
        private void LoadData()
        {
            try
            {
                Program.ConfigGrid(_logic.Read(null), dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
		{
            var form = Program.Container.Resolve<FormCanned>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

		private void buttonUpd_Click(object sender, EventArgs e)
		{
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Program.Container.Resolve<FormCanned>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

		private void buttonDel_Click(object sender, EventArgs e)
		{
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        _logic.Delete(new CannedBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
            }
        }

		private void buttonRef_Click(object sender, EventArgs e)
		{
            LoadData();
        }

		private void FormCanneds_Load_1(object sender, EventArgs e)
		{
            LoadData();
        }
	}
}
