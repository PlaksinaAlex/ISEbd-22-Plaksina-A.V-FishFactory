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
using Unity;

namespace FishFactoryView
{
	public partial class FormCanned : Form
	{
		public int Id
		{
			set
			{
				id = value;
			}
		}
		private readonly ICannedLogic _logic;

		private int? id;

		private Dictionary<int, (string, int)> cannedComponents;

		public FormCanned(ICannedLogic logic)
		{
			InitializeComponent();
			_logic = logic;
		}
	
		private void LoadData()
		{
			try
			{
				if (cannedComponents != null)
				{
					dataGridView.Rows.Clear();
					foreach (var cn in cannedComponents)
					{
						dataGridView.Rows.Add(new object[] { cn.Key, cn.Value.Item1, cn.Value.Item2 });
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
			}
		}
		private void ButtonAdd_Click(object sender, EventArgs e)
		{
			var form = Program.Container.Resolve<FormCannedComponent>();
			if (form.ShowDialog() == DialogResult.OK)
			{
				if (cannedComponents.ContainsKey(form.Id))
				{
					cannedComponents[form.Id] = (form.ComponentName, form.Count);
				}
				else
				{
					cannedComponents.Add(form.Id, (form.ComponentName, form.Count));
				}
				LoadData();
			}
		}

		private void ButtonUpd_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				var form = Program.Container.Resolve<FormCannedComponent>();
				int id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
				form.Id = id;
				form.Count = cannedComponents[id].Item2;
				if (form.ShowDialog() == DialogResult.OK)
				{
					cannedComponents[form.Id] = (form.ComponentName, form.Count);
					LoadData();
				}
			}
		}

		private void ButtonDel_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count == 1)
			{
				if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
			   MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{

						cannedComponents.Remove(Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value));
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

		private void ButtonRef_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxName.Text))
			{
				MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxPrice.Text))
			{
				MessageBox.Show("Заполните цену", "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
				return;
			}
			if (cannedComponents == null || cannedComponents.Count == 0)
			{
				MessageBox.Show("Заполните компоненты", "Ошибка", MessageBoxButtons.OK,
			   MessageBoxIcon.Error);
				return;
			}
			try
			{
				_logic.CreateOrUpdate(new CannedBindingModel
				{
					Id = id,
					CannedName = textBoxName.Text,
					Price = Convert.ToDecimal(textBoxPrice.Text),
					CannedComponents = cannedComponents
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

		private void ButtonCancel_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		private void FormCanned_Load(object sender, EventArgs e)
		{
			if (id.HasValue)
			{
				try
				{
					CannedViewModel view = _logic.Read(new CannedBindingModel
					{
						Id = id.Value
					})?[0];
					if (view != null)
					{
						textBoxName.Text = view.CannedName;
						textBoxPrice.Text = view.Price.ToString();
						cannedComponents = view.CannedComponents;
						LoadData();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
				   MessageBoxIcon.Error);
				}
			}
			else
			{
				cannedComponents = new Dictionary<int, (string, int)>();
			}
		}

	}
}
