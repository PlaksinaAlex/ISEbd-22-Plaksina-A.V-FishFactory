using System;
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
using FishFactoryContracts.ViewModels;

namespace FishFactoryView
{
	public partial class FormCreateOrder : Form
	{
		private readonly ICannedLogic _logicP;
		private readonly IOrderLogic _logicO;
		public FormCreateOrder(ICannedLogic logicP, IOrderLogic logicO)
		{
			InitializeComponent();
			_logicP = logicP;
			_logicO = logicO;
		}
		private void FormCreateOrder_Load(object sender, EventArgs e)
		{
			try
			{
				var list = _logicP.Read(null);
				foreach (var component in list)
				{
					ComboBoxProduct.DisplayMember = "CannedName";
					ComboBoxProduct.ValueMember = "Id";
					ComboBoxProduct.DataSource = list;
					ComboBoxProduct.SelectedItem = null;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void CalcSum()
		{
			if (ComboBoxProduct.SelectedValue != null && !string.IsNullOrEmpty(TextBoxCount.Text))
			{
				try
				{
					int id = Convert.ToInt32(ComboBoxProduct.SelectedValue);
					CannedViewModel canned = _logicP.Read(new CannedBindingModel
					{
						Id = id
					})?[0];
					int count = Convert.ToInt32(TextBoxCount.Text);
					TextBoxSum.Text = (count * canned?.Price ?? 0).ToString();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
			}
		}
		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(TextBoxCount.Text))
			{
				MessageBox.Show("Заполните поле Количество", "Ошибка",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (ComboBoxProduct.SelectedValue == null)
			{
				MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
				return;
			}
			try
			{
				_logicO.CreateOrder(new CreateOrderBindingModel
				{
					CannedId = Convert.ToInt32(ComboBoxProduct.SelectedValue),
					Count = Convert.ToInt32(TextBoxCount.Text),
					Sum = Convert.ToDecimal(TextBoxSum.Text)
				});
				MessageBox.Show("Сохранение прошло успешно", "Сообщение",
			   MessageBoxButtons.OK, MessageBoxIcon.Information);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
			}
		}

		private void ComboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
		{
			CalcSum();
		}

		private void TextBoxCount_TextChanged(object sender, EventArgs e)
		{
			CalcSum();
		}

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
