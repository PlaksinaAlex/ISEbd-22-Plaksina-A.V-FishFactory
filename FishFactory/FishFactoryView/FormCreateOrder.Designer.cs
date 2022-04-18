
namespace FishFactoryView
{
	partial class FormCreateOrder
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.ComboBoxCanned = new System.Windows.Forms.ComboBox();
			this.TextBoxCount = new System.Windows.Forms.TextBox();
			this.TextBoxSum = new System.Windows.Forms.TextBox();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.labelClient = new System.Windows.Forms.Label();
			this.comboBoxClient = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Изделие:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Количество:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(38, 116);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Сумма:";
			// 
			// ComboBoxCanned
			// 
			this.ComboBoxCanned.FormattingEnabled = true;
			this.ComboBoxCanned.Location = new System.Drawing.Point(123, 41);
			this.ComboBoxCanned.Name = "ComboBoxCanned";
			this.ComboBoxCanned.Size = new System.Drawing.Size(189, 23);
			this.ComboBoxCanned.TabIndex = 3;
			this.ComboBoxCanned.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCanned_SelectedIndexChanged);
			// 
			// TextBoxCount
			// 
			this.TextBoxCount.Location = new System.Drawing.Point(123, 76);
			this.TextBoxCount.Name = "TextBoxCount";
			this.TextBoxCount.Size = new System.Drawing.Size(189, 23);
			this.TextBoxCount.TabIndex = 4;
			this.TextBoxCount.TextChanged += new System.EventHandler(this.TextBoxCount_TextChanged);
			// 
			// TextBoxSum
			// 
			this.TextBoxSum.Location = new System.Drawing.Point(123, 113);
			this.TextBoxSum.Name = "TextBoxSum";
			this.TextBoxSum.Size = new System.Drawing.Size(189, 23);
			this.TextBoxSum.TabIndex = 5;
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Location = new System.Drawing.Point(233, 152);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.ButtonCancel.Size = new System.Drawing.Size(79, 26);
			this.ButtonCancel.TabIndex = 6;
			this.ButtonCancel.Text = "Отмена";
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
			// 
			// ButtonSave
			// 
			this.ButtonSave.Location = new System.Drawing.Point(123, 152);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(88, 26);
			this.ButtonSave.TabIndex = 7;
			this.ButtonSave.Text = "Сохранить";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// labelClient
			// 
			this.labelClient.AutoSize = true;
			this.labelClient.Location = new System.Drawing.Point(45, 9);
			this.labelClient.Name = "labelClient";
			this.labelClient.Size = new System.Drawing.Size(49, 15);
			this.labelClient.TabIndex = 8;
			this.labelClient.Text = "Клиент:";
			// 
			// comboBoxClient
			// 
			this.comboBoxClient.FormattingEnabled = true;
			this.comboBoxClient.Location = new System.Drawing.Point(123, 6);
			this.comboBoxClient.Name = "comboBoxClient";
			this.comboBoxClient.Size = new System.Drawing.Size(189, 23);
			this.comboBoxClient.TabIndex = 9;
			// 
			// FormCreateOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(377, 204);
			this.Controls.Add(this.comboBoxClient);
			this.Controls.Add(this.labelClient);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.TextBoxSum);
			this.Controls.Add(this.TextBoxCount);
			this.Controls.Add(this.ComboBoxCanned);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormCreateOrder";
			this.Text = "Заказ";
			this.Load += new System.EventHandler(this.FormCreateOrder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox ComboBoxCanned;
		private System.Windows.Forms.TextBox TextBoxCount;
		private System.Windows.Forms.TextBox TextBoxSum;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonSave;
		private System.Windows.Forms.Label labelClient;
		private System.Windows.Forms.ComboBox comboBoxClient;
	}
}