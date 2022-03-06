
namespace FishFactoryView
{
	partial class FormWareHouseRestocking
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBoxName = new System.Windows.Forms.ComboBox();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxCount = new System.Windows.Forms.TextBox();
			this.labelCount = new System.Windows.Forms.Label();
			this.comboBoxComponent = new System.Windows.Forms.ComboBox();
			this.labelComponent = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBoxName
			// 
			this.comboBoxName.FormattingEnabled = true;
			this.comboBoxName.Location = new System.Drawing.Point(148, 31);
			this.comboBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.comboBoxName.Name = "comboBoxName";
			this.comboBoxName.Size = new System.Drawing.Size(140, 23);
			this.comboBoxName.TabIndex = 16;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(34, 35);
			this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(102, 15);
			this.labelName.TabIndex = 15;
			this.labelName.Text = "Название склада:";
			// 
			// textBoxCount
			// 
			this.textBoxCount.Location = new System.Drawing.Point(148, 130);
			this.textBoxCount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBoxCount.Name = "textBoxCount";
			this.textBoxCount.Size = new System.Drawing.Size(116, 23);
			this.textBoxCount.TabIndex = 18;
			// 
			// labelCount
			// 
			this.labelCount.AutoSize = true;
			this.labelCount.Location = new System.Drawing.Point(70, 130);
			this.labelCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(75, 15);
			this.labelCount.TabIndex = 17;
			this.labelCount.Text = "Количество:";
			// 
			// comboBoxComponent
			// 
			this.comboBoxComponent.FormattingEnabled = true;
			this.comboBoxComponent.Location = new System.Drawing.Point(148, 82);
			this.comboBoxComponent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.comboBoxComponent.Name = "comboBoxComponent";
			this.comboBoxComponent.Size = new System.Drawing.Size(140, 23);
			this.comboBoxComponent.TabIndex = 19;
			// 
			// labelComponent
			// 
			this.labelComponent.AutoSize = true;
			this.labelComponent.Location = new System.Drawing.Point(4, 85);
			this.labelComponent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelComponent.Name = "labelComponent";
			this.labelComponent.Size = new System.Drawing.Size(132, 15);
			this.labelComponent.TabIndex = 20;
			this.labelComponent.Text = "Название компонента:";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(57, 195);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 27);
			this.buttonSave.TabIndex = 22;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(213, 195);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 27);
			this.buttonCancel.TabIndex = 21;
			this.buttonCancel.Text = "Отменить";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FormWareHouseRestocking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 260);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelComponent);
			this.Controls.Add(this.comboBoxComponent);
			this.Controls.Add(this.textBoxCount);
			this.Controls.Add(this.labelCount);
			this.Controls.Add(this.comboBoxName);
			this.Controls.Add(this.labelName);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FormWareHouseRestocking";
			this.Text = "Пополнение склада";
			this.Load += new System.EventHandler(this.FormWareHouseRestocking_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBoxName;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxCount;
		private System.Windows.Forms.Label labelCount;
		private System.Windows.Forms.ComboBox comboBoxComponent;
		private System.Windows.Forms.Label labelComponent;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
	}
}