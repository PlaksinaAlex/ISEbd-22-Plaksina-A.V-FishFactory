
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
			this.ComboBoxProduct = new System.Windows.Forms.ComboBox();
			this.TextBoxCount = new System.Windows.Forms.TextBox();
			this.TextBoxSum = new System.Windows.Forms.TextBox();
			this.ButtonCancel = new System.Windows.Forms.Button();
			this.ButtonSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Изделие:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Количество:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Сумма:";
			// 
			// ComboBoxProduct
			// 
			this.ComboBoxProduct.FormattingEnabled = true;
			this.ComboBoxProduct.Location = new System.Drawing.Point(123, 18);
			this.ComboBoxProduct.Name = "ComboBoxProduct";
			this.ComboBoxProduct.Size = new System.Drawing.Size(189, 23);
			this.ComboBoxProduct.TabIndex = 3;
			this.ComboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProduct_SelectedIndexChanged);
			// 
			// TextBoxCount
			// 
			this.TextBoxCount.Location = new System.Drawing.Point(123, 47);
			this.TextBoxCount.Name = "TextBoxCount";
			this.TextBoxCount.Size = new System.Drawing.Size(189, 23);
			this.TextBoxCount.TabIndex = 4;
			this.TextBoxCount.TextChanged += new System.EventHandler(this.TextBoxCount_TextChanged);
			// 
			// TextBoxSum
			// 
			this.TextBoxSum.Location = new System.Drawing.Point(123, 83);
			this.TextBoxSum.Name = "TextBoxSum";
			this.TextBoxSum.Size = new System.Drawing.Size(189, 23);
			this.TextBoxSum.TabIndex = 5;
			// 
			// ButtonCancel
			// 
			this.ButtonCancel.Location = new System.Drawing.Point(231, 115);
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
			this.ButtonSave.Location = new System.Drawing.Point(123, 115);
			this.ButtonSave.Name = "ButtonSave";
			this.ButtonSave.Size = new System.Drawing.Size(88, 26);
			this.ButtonSave.TabIndex = 7;
			this.ButtonSave.Text = "Сохранить";
			this.ButtonSave.UseVisualStyleBackColor = true;
			this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// FormCreateOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 166);
			this.Controls.Add(this.ButtonSave);
			this.Controls.Add(this.ButtonCancel);
			this.Controls.Add(this.TextBoxSum);
			this.Controls.Add(this.TextBoxCount);
			this.Controls.Add(this.ComboBoxProduct);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormCreateOrder";
			this.Text = "Заказ";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox ComboBoxProduct;
		private System.Windows.Forms.TextBox TextBoxCount;
		private System.Windows.Forms.TextBox TextBoxSum;
		private System.Windows.Forms.Button ButtonCancel;
		private System.Windows.Forms.Button ButtonSave;
	}
}