
namespace FishFactoryView
{
	partial class FormCannedComponent
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxComponent = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxCount = new System.Windows.Forms.TextBox();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Компонент:";
			// 
			// comboBoxComponent
			// 
			this.comboBoxComponent.FormattingEnabled = true;
			this.comboBoxComponent.Location = new System.Drawing.Point(107, 15);
			this.comboBoxComponent.Name = "comboBoxComponent";
			this.comboBoxComponent.Size = new System.Drawing.Size(187, 23);
			this.comboBoxComponent.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Количество:";
			// 
			// textBoxCount
			// 
			this.textBoxCount.Location = new System.Drawing.Point(107, 58);
			this.textBoxCount.Name = "textBoxCount";
			this.textBoxCount.Size = new System.Drawing.Size(187, 23);
			this.textBoxCount.TabIndex = 3;
			// 
			// ButtonSave
			// 
			this.ButtonSave.Location = new System.Drawing.Point(120, 98);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(78, 29);
			this.ButtonSave.TabIndex = 4;
			this.ButtonSave.Text = "Сохранить";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Location = new System.Drawing.Point(222, 98);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new System.Drawing.Size(74, 29);
			this.ButtonCancel.TabIndex = 5;
			this.ButtonCancel.Text = "Отмена";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// FormCannedComponent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 149);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.textBoxCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBoxComponent);
			this.Controls.Add(this.label1);
			this.Name = "FormCannedComponent";
			this.Text = "Компонент изделия";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxComponent;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxCount;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Button ButtonCancel;
	}
}