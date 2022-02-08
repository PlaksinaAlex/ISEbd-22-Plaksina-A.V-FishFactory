
namespace FishFactoryView
{
	partial class FormMain
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
			this.ButtonCreateOrder = new System.Windows.Forms.Button();
			this.ButtonTakeOrderInWork = new System.Windows.Forms.Button();
			this.ButtonOrderReady = new System.Windows.Forms.Button();
			this.ButtonIssuedOrder = new System.Windows.Forms.Button();
			this.ButtonRef = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cannedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Canned = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonCreateOrder
			// 
			this.ButtonCreateOrder.Location = new System.Drawing.Point(684, 56);
			this.ButtonCreateOrder.Name = "ButtonCreateOrder";
			this.ButtonCreateOrder.Size = new System.Drawing.Size(194, 41);
			this.ButtonCreateOrder.TabIndex = 0;
			this.ButtonCreateOrder.Text = "Создать заказ";
			this.ButtonCreateOrder.UseVisualStyleBackColor = true;
			this.ButtonCreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
			// 
			// ButtonTakeOrderInWork
			// 
			this.ButtonTakeOrderInWork.Location = new System.Drawing.Point(685, 115);
			this.ButtonTakeOrderInWork.Name = "ButtonTakeOrderInWork";
			this.ButtonTakeOrderInWork.Size = new System.Drawing.Size(193, 46);
			this.ButtonTakeOrderInWork.TabIndex = 1;
			this.ButtonTakeOrderInWork.Text = "Отдать на выполнение";
			this.ButtonTakeOrderInWork.UseVisualStyleBackColor = true;
			this.ButtonTakeOrderInWork.Click += new System.EventHandler(this.ButtonTakeOrderInWork_Click);
			// 
			// ButtonOrderReady
			// 
			this.ButtonOrderReady.Location = new System.Drawing.Point(687, 178);
			this.ButtonOrderReady.Name = "ButtonOrderReady";
			this.ButtonOrderReady.Size = new System.Drawing.Size(191, 58);
			this.ButtonOrderReady.TabIndex = 2;
			this.ButtonOrderReady.Text = "Заказ готов";
			this.ButtonOrderReady.UseVisualStyleBackColor = true;
			this.ButtonOrderReady.Click += new System.EventHandler(this.ButtonOrderReady_Click);
			// 
			// ButtonIssuedOrder
			// 
			this.ButtonIssuedOrder.Location = new System.Drawing.Point(689, 256);
			this.ButtonIssuedOrder.Name = "ButtonIssuedOrder";
			this.ButtonIssuedOrder.Size = new System.Drawing.Size(189, 52);
			this.ButtonIssuedOrder.TabIndex = 3;
			this.ButtonIssuedOrder.Text = "Заказ выдан";
			this.ButtonIssuedOrder.UseVisualStyleBackColor = true;
			this.ButtonIssuedOrder.Click += new System.EventHandler(this.ButtonIssuedOrder_Click);
			// 
			// ButtonRef
			// 
			this.ButtonRef.Location = new System.Drawing.Point(693, 343);
			this.ButtonRef.Name = "ButtonRef";
			this.ButtonRef.Size = new System.Drawing.Size(185, 57);
			this.ButtonRef.TabIndex = 4;
			this.ButtonRef.Text = "Обновить список";
			this.ButtonRef.UseVisualStyleBackColor = true;
			this.ButtonRef.Click += new System.EventHandler(this.ButtonRef_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.cannedId,
            this.Canned,
            this.Count,
            this.Sum,
            this.Status,
            this.DateStart,
            this.DateEnd});
			this.dataGridView.Location = new System.Drawing.Point(12, 39);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(636, 387);
			this.dataGridView.TabIndex = 6;
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Visible = false;
			// 
			// cannedId
			// 
			this.cannedId.HeaderText = "cannedId";
			this.cannedId.Name = "cannedId";
			this.cannedId.Visible = false;
			// 
			// Canned
			// 
			this.Canned.HeaderText = "Изделие";
			this.Canned.Name = "Canned";
			// 
			// Count
			// 
			this.Count.HeaderText = "Количество";
			this.Count.Name = "Count";
			// 
			// Sum
			// 
			this.Sum.HeaderText = "Сумма";
			this.Sum.Name = "Sum";
			// 
			// Status
			// 
			this.Status.HeaderText = "Статус";
			this.Status.Name = "Status";
			// 
			// DateStart
			// 
			this.DateStart.HeaderText = "Дата создания";
			this.DateStart.Name = "DateStart";
			// 
			// DateEnd
			// 
			this.DateEnd.HeaderText = "Дата выполнения";
			this.DateEnd.Name = "DateEnd";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(915, 24);
			this.menuStrip1.TabIndex = 6;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.компонентыToolStripMenuItem,
            this.изделияToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// компонентыToolStripMenuItem
			// 
			this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
			this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.компонентыToolStripMenuItem.Text = "Компоненты";
			this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.компонентыToolStripMenuItem_Click);
			// 
			// изделияToolStripMenuItem
			// 
			this.изделияToolStripMenuItem.Name = "изделияToolStripMenuItem";
			this.изделияToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.изделияToolStripMenuItem.Text = "Изделия";
			this.изделияToolStripMenuItem.Click += new System.EventHandler(this.изделияToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 450);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.ButtonRef);
			this.Controls.Add(this.ButtonIssuedOrder);
			this.Controls.Add(this.ButtonOrderReady);
			this.Controls.Add(this.ButtonTakeOrderInWork);
			this.Controls.Add(this.ButtonCreateOrder);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Рыбный завод";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonCreateOrder;
		private System.Windows.Forms.Button ButtonTakeOrderInWork;
		private System.Windows.Forms.Button ButtonOrderReady;
		private System.Windows.Forms.Button ButtonIssuedOrder;
		private System.Windows.Forms.Button ButtonRef;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn cannedId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Canned;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateEnd;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem изделияToolStripMenuItem;
	}
}