﻿
namespace FishFactoryView
{
	partial class FormComponents
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
			this.ButtonAdd = new System.Windows.Forms.Button();
			this.ButtonUpd = new System.Windows.Forms.Button();
			this.ButtonDel = new System.Windows.Forms.Button();
			this.ButtonRef = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonAdd
			// 
			this.ButtonAdd.Location = new System.Drawing.Point(388, 24);
			this.ButtonAdd.Name = "ButtonAdd";
			this.ButtonAdd.Size = new System.Drawing.Size(85, 31);
			this.ButtonAdd.TabIndex = 1;
			this.ButtonAdd.Text = "Добавить";
			this.ButtonAdd.UseVisualStyleBackColor = true;
			this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// ButtonUpd
			// 
			this.ButtonUpd.Location = new System.Drawing.Point(388, 73);
			this.ButtonUpd.Name = "ButtonUpd";
			this.ButtonUpd.Size = new System.Drawing.Size(85, 31);
			this.ButtonUpd.TabIndex = 2;
			this.ButtonUpd.Text = "Изменить";
			this.ButtonUpd.UseVisualStyleBackColor = true;
			this.ButtonUpd.Click += new System.EventHandler(this.ButtonUpd_Click);
			// 
			// ButtonDel
			// 
			this.ButtonDel.Location = new System.Drawing.Point(388, 124);
			this.ButtonDel.Name = "ButtonDel";
			this.ButtonDel.Size = new System.Drawing.Size(85, 31);
			this.ButtonDel.TabIndex = 3;
			this.ButtonDel.Text = "Удалить";
			this.ButtonDel.UseVisualStyleBackColor = true;
			this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
			// 
			// ButtonRef
			// 
			this.ButtonRef.Location = new System.Drawing.Point(388, 177);
			this.ButtonRef.Name = "ButtonRef";
			this.ButtonRef.Size = new System.Drawing.Size(85, 31);
			this.ButtonRef.TabIndex = 4;
			this.ButtonRef.Text = "Обновить";
			this.ButtonRef.UseVisualStyleBackColor = true;
			this.ButtonRef.Click += new System.EventHandler(this.ButtonRef_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.ColumnHeadersVisible = false;
			this.dataGridView.Location = new System.Drawing.Point(12, 15);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(313, 308);
			this.dataGridView.TabIndex = 5;
			// 
			// FormComponents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 367);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.ButtonRef);
			this.Controls.Add(this.ButtonDel);
			this.Controls.Add(this.ButtonUpd);
			this.Controls.Add(this.ButtonAdd);
			this.Name = "FormComponents";
			this.Text = "Компоненты";
			this.Load += new System.EventHandler(this.FormComponents_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button ButtonAdd;
		private System.Windows.Forms.Button ButtonUpd;
		private System.Windows.Forms.Button ButtonDel;
		private System.Windows.Forms.Button ButtonRef;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}
