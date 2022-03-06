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
    public partial class FormWareHouseRestocking : Form
    {
        private readonly IWareHouseLogic _logicWareHouse;

        private readonly IComponentLogic _logicComp;

        public FormWareHouseRestocking(IWareHouseLogic logicWareHouse, IComponentLogic logicComp)
        {
            InitializeComponent();
            _logicWareHouse = logicWareHouse;
            _logicComp = logicComp;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxComponent.SelectedValue == null)
            {
                MessageBox.Show("Выберите ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxName.SelectedValue == null)
            {
                MessageBox.Show("Выберите склад", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                List<ComponentViewModel> listComponent = _logicComp.Read(null);
                _logicWareHouse.Restocking(new WareHouseRestockingBindingModel
                {
                    WareHouseId = Convert.ToInt32(comboBoxName.SelectedValue),
                    ComponentId = listComponent[comboBoxComponent.SelectedIndex].Id,
                    Count = Convert.ToInt32(textBoxCount.Text)
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

		private void FormWareHouseRestocking_Load(object sender, EventArgs e)
		{
            try
            {
                List<ComponentViewModel> listComponent = _logicComp.Read(null);
                List<WareHouseViewModel> listWareHouse = _logicWareHouse.Read(null);
                if (listComponent != null)
                {
                    comboBoxComponent.DisplayMember = "ComponentName";
                    comboBoxComponent.ValueMember = "Id";
                    comboBoxComponent.DataSource = listComponent;
                    comboBoxComponent.SelectedItem = null;
                }
                if (listWareHouse != null)
                {
                    comboBoxName.DisplayMember = "WareHouseName";
                    comboBoxName.ValueMember = "Id";
                    comboBoxName.DataSource = listWareHouse;
                    comboBoxName.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
	}
}
