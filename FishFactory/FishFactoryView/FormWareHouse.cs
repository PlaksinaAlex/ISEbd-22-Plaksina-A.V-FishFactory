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
    public partial class FormWareHouse : Form
    {
        public int Id { set { id = value; } }
        private readonly IWareHouseLogic _logic;
        private int? id;

        private Dictionary<int, (string, int)> warehouseComponents;
        public FormWareHouse(IWareHouseLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void FormWareHouse_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    WareHouseViewModel view = _logic.Read(new WareHouseBindingModel { Id = id.Value })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.WareHouseName;
                        textBoxResponsibleFace.Text = view.ResponsibleFace.ToString();
                        warehouseComponents = view.WareHouseComponents;
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                warehouseComponents = new Dictionary<int, (string, int)>();
            }
        }
        private void LoadData()
        {
            try
            {
                if (warehouseComponents != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var wh in warehouseComponents)
                    {
                        dataGridView.Rows.Add(new object[] { wh.Key, wh.Value.Item1, wh.Value.Item2 });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxResponsibleFace.Text))
            {
                MessageBox.Show("Заполните ответственноt лицо", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logic.CreateOrUpdate(new WareHouseBindingModel
                {
                    Id = id,
                    WareHouseName = textBoxName.Text,
                    ResponsibleFace = textBoxResponsibleFace.Text,
                    DateCreate = DateTime.Now,
                    WareHouseComponents = warehouseComponents
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
