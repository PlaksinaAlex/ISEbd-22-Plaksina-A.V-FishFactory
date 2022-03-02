
namespace FishFactoryView
{
	partial class FormWareHouse
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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxResponsibleFace = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.labelResponsibleFace = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ColumnId,
			this.Component,
			this.Count});
			this.dataGridView.Location = new System.Drawing.Point(26, 112);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(344, 331);
			this.dataGridView.TabIndex = 0;
			// 
			// ColumnId
			// 
			this.ColumnId.HeaderText = "ColumnId";
			this.ColumnId.Name = "ColumnId";
			this.ColumnId.Visible = false;
			// 
			// Component
			// 
			this.Component.HeaderText = "Компонет";
			this.Component.Name = "Component";
			this.Component.Width = 200;
			// 
			// Count
			// 
			this.Count.HeaderText = "Количество";
			this.Count.Name = "Count";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new System.Drawing.Point(178, 14);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(180, 23);
			this.textBoxName.TabIndex = 21;
			// 
			// textBoxResponsibleFace
			// 
			this.textBoxResponsibleFace.Location = new System.Drawing.Point(178, 62);
			this.textBoxResponsibleFace.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBoxResponsibleFace.Name = "textBoxResponsibleFace";
			this.textBoxResponsibleFace.Size = new System.Drawing.Size(180, 23);
			this.textBoxResponsibleFace.TabIndex = 22;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(44, 22);
			this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(99, 15);
			this.labelName.TabIndex = 23;
			this.labelName.Text = "Название склада";
			// 
			// labelResponsibleFace
			// 
			this.labelResponsibleFace.AutoSize = true;
			this.labelResponsibleFace.Location = new System.Drawing.Point(44, 65);
			this.labelResponsibleFace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelResponsibleFace.Name = "labelResponsibleFace";
			this.labelResponsibleFace.Size = new System.Drawing.Size(119, 15);
			this.labelResponsibleFace.TabIndex = 24;
			this.labelResponsibleFace.Text = "Ответственное лицо";
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(406, 205);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 27);
			this.buttonSave.TabIndex = 26;
			this.buttonSave.Text = "Сохранить";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(406, 278);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 27);
			this.buttonCancel.TabIndex = 25;
			this.buttonCancel.Text = "Отменить";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// FormWareHouse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(542, 461);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelResponsibleFace);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.textBoxResponsibleFace);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.dataGridView);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "FormWareHouse";
			this.Text = "Добавление склада";
			this.Load += new System.EventHandler(this.FormWareHouse_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxResponsibleFace;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.Label labelResponsibleFace;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Component;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
	}
}