﻿
namespace FishFactoryView
{
	partial class FormReportOrders
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
			this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
			this.panel = new System.Windows.Forms.Panel();
			this.buttonToPdf = new System.Windows.Forms.Button();
			this.buttonMake = new System.Windows.Forms.Button();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "С";
			// 
			// dateTimePickerFrom
			// 
			this.dateTimePickerFrom.Location = new System.Drawing.Point(40, 13);
			this.dateTimePickerFrom.Name = "dateTimePickerFrom";
			this.dateTimePickerFrom.Size = new System.Drawing.Size(150, 23);
			this.dateTimePickerFrom.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(217, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "по";
			// 
			// dateTimePickerTo
			// 
			this.dateTimePickerTo.Location = new System.Drawing.Point(261, 13);
			this.dateTimePickerTo.Name = "dateTimePickerTo";
			this.dateTimePickerTo.Size = new System.Drawing.Size(151, 23);
			this.dateTimePickerTo.TabIndex = 3;
			// 
			// panel
			// 
			this.panel.Controls.Add(this.buttonToPdf);
			this.panel.Controls.Add(this.buttonMake);
			this.panel.Controls.Add(this.label1);
			this.panel.Controls.Add(this.dateTimePickerTo);
			this.panel.Controls.Add(this.dateTimePickerFrom);
			this.panel.Controls.Add(this.label2);
			this.panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(800, 54);
			this.panel.TabIndex = 4;
			// 
			// buttonToPdf
			// 
			this.buttonToPdf.Location = new System.Drawing.Point(656, 14);
			this.buttonToPdf.Name = "buttonToPdf";
			this.buttonToPdf.Size = new System.Drawing.Size(125, 24);
			this.buttonToPdf.TabIndex = 5;
			this.buttonToPdf.Text = "в Pdf";
			this.buttonToPdf.UseVisualStyleBackColor = true;
			this.buttonToPdf.Click += new System.EventHandler(this.buttonToPdf_Click);
			// 
			// buttonMake
			// 
			this.buttonMake.Location = new System.Drawing.Point(430, 9);
			this.buttonMake.Name = "buttonMake";
			this.buttonMake.Size = new System.Drawing.Size(156, 35);
			this.buttonMake.TabIndex = 4;
			this.buttonMake.Text = "Сформировать";
			this.buttonMake.UseVisualStyleBackColor = true;
			this.buttonMake.Click += new System.EventHandler(this.buttonMake_Click);
			// 
			// FormReportOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel);
			this.Name = "FormReportOrders";
			this.Text = "Заказы";
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePickerTo;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Button buttonToPdf;
		private System.Windows.Forms.Button buttonMake;
	}
}