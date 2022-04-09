
namespace FishFactoryView
{
	partial class FormReportCannedComponents
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
			this.ButtonSaveToExcel = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Canned = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ButtonSaveToExcel
			// 
			this.ButtonSaveToExcel.Location = new System.Drawing.Point(12, 12);
			this.ButtonSaveToExcel.Name = "ButtonSaveToExcel";
			this.ButtonSaveToExcel.Size = new System.Drawing.Size(161, 27);
			this.ButtonSaveToExcel.TabIndex = 0;
			this.ButtonSaveToExcel.Text = "Сохранить в Excel";
			this.ButtonSaveToExcel.UseVisualStyleBackColor = true;
			this.ButtonSaveToExcel.Click += new System.EventHandler(this.ButtonSaveToExcel_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Canned,
            this.Component,
            this.Count});
			this.dataGridView.Location = new System.Drawing.Point(22, 64);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 25;
			this.dataGridView.Size = new System.Drawing.Size(508, 243);
			this.dataGridView.TabIndex = 1;
			// 
			// Canned
			// 
			this.Canned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Canned.HeaderText = "Изделие";
			this.Canned.Name = "Canned";
			// 
			// Component
			// 
			this.Component.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Component.HeaderText = "Компонент";
			this.Component.Name = "Component";
			// 
			// Count
			// 
			this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Count.HeaderText = "Количество";
			this.Count.Name = "Count";
			// 
			// FormReportCannedComponents
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 450);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.ButtonSaveToExcel);
			this.Name = "FormReportCannedComponents";
			this.Text = "Изделия с компонентами";
			this.Load += new System.EventHandler(this.FormReportCannedComponents_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button ButtonSaveToExcel;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Canned;
		private System.Windows.Forms.DataGridViewTextBoxColumn Component;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
	}
}