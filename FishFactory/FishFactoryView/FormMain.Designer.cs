
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
			this.ButtonIssuedOrder = new System.Windows.Forms.Button();
			this.ButtonRef = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.компонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.изделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ComponentCannedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.CannedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.запускРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.письмаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.исполнителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ButtonCreateOrder
			// 
			this.ButtonCreateOrder.Location = new System.Drawing.Point(680, 68);
			this.ButtonCreateOrder.Name = "ButtonCreateOrder";
			this.ButtonCreateOrder.Size = new System.Drawing.Size(190, 60);
			this.ButtonCreateOrder.TabIndex = 0;
			this.ButtonCreateOrder.Text = "Создать заказ";
			this.ButtonCreateOrder.UseVisualStyleBackColor = true;
			this.ButtonCreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
			// 
			// ButtonIssuedOrder
			// 
			this.ButtonIssuedOrder.Location = new System.Drawing.Point(680, 165);
			this.ButtonIssuedOrder.Name = "ButtonIssuedOrder";
			this.ButtonIssuedOrder.Size = new System.Drawing.Size(190, 60);
			this.ButtonIssuedOrder.TabIndex = 3;
			this.ButtonIssuedOrder.Text = "Заказ выдан";
			this.ButtonIssuedOrder.UseVisualStyleBackColor = true;
			this.ButtonIssuedOrder.Click += new System.EventHandler(this.ButtonIssuedOrder_Click);
			// 
			// ButtonRef
			// 
			this.ButtonRef.Location = new System.Drawing.Point(680, 258);
			this.ButtonRef.Name = "ButtonRef";
			this.ButtonRef.Size = new System.Drawing.Size(190, 60);
			this.ButtonRef.TabIndex = 4;
			this.ButtonRef.Text = "Обновить список";
			this.ButtonRef.UseVisualStyleBackColor = true;
			this.ButtonRef.Click += new System.EventHandler(this.ButtonRef_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(12, 29);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.Height = 25;
			this.dataGridView.Size = new System.Drawing.Size(636, 373);
			this.dataGridView.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
			this.запускРаботToolStripMenuItem,
			 this.письмаToolStripMenuItem});
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
            this.изделияToolStripMenuItem,
			this.клиентыToolStripMenuItem,
			this.исполнителиToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// компонентыToolStripMenuItem
			// 
			this.компонентыToolStripMenuItem.Name = "компонентыToolStripMenuItem";
			this.компонентыToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.компонентыToolStripMenuItem.Text = "Компоненты";
			this.компонентыToolStripMenuItem.Click += new System.EventHandler(this.компонентыToolStripMenuItem_Click);
			// 
			// изделияToolStripMenuItem
			// 
			this.изделияToolStripMenuItem.Name = "изделияToolStripMenuItem";
			this.изделияToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.изделияToolStripMenuItem.Text = "Изделия";
			this.изделияToolStripMenuItem.Click += new System.EventHandler(this.изделияToolStripMenuItem_Click);
			// 
			// отчетыToolStripMenuItem
			// 
			this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ComponentCannedToolStripMenuItem,
            this.CannedsToolStripMenuItem,
            this.OrdersToolStripMenuItem});
			this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
			this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.отчетыToolStripMenuItem.Text = "Отчеты";
			// 
			// ComponentCannedToolStripMenuItem
			// 
			this.ComponentCannedToolStripMenuItem.Name = "ComponentCannedToolStripMenuItem";
			this.ComponentCannedToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.ComponentCannedToolStripMenuItem.Text = "Список изделий";
			this.ComponentCannedToolStripMenuItem.Click += new System.EventHandler(this.ComponentCannedToolStripMenuItem_Click);
			// 
			// CannedsToolStripMenuItem
			// 
			this.CannedsToolStripMenuItem.Name = "CannedsToolStripMenuItem";
			this.CannedsToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.CannedsToolStripMenuItem.Text = "Изделия с компонентами";
			this.CannedsToolStripMenuItem.Click += new System.EventHandler(this.CannedsToolStripMenuItem_Click);
			// 
			// OrdersToolStripMenuItem
			// 
			this.OrdersToolStripMenuItem.Name = "OrdersToolStripMenuItem";
			this.OrdersToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
			this.OrdersToolStripMenuItem.Text = "Список заказов";
			this.OrdersToolStripMenuItem.Click += new System.EventHandler(this.OrdersToolStripMenuItem_Click);
			// 
			// клиентыToolStripMenuItem
			// 
			this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
			this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.клиентыToolStripMenuItem.Text = "Клиенты";
			this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
			// 
			// исполнителиToolStripMenuItem
			// 
			this.исполнителиToolStripMenuItem.Name = "исполнителиToolStripMenuItem";
			this.исполнителиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.исполнителиToolStripMenuItem.Text = "Исполнители";
			this.исполнителиToolStripMenuItem.Click += new System.EventHandler(this.исполнителиToolStripMenuItem_Click);
			// 
			// запускРаботToolStripMenuItem
			// 
			this.запускРаботToolStripMenuItem.Name = "запускРаботToolStripMenuItem";
			this.запускРаботToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
			this.запускРаботToolStripMenuItem.Text = "Запуск работ";
			this.запускРаботToolStripMenuItem.Click += new System.EventHandler(this.запускРаботToolStripMenuItem_Click);
			// 
			// письмаToolStripMenuItem
			// 
			this.письмаToolStripMenuItem.Name = "письмаToolStripMenuItem";
			this.письмаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
			this.письмаToolStripMenuItem.Text = "Письма";
			this.письмаToolStripMenuItem.Click += new System.EventHandler(this.письмаToolStripMenuItem_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 450);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.ButtonRef);
			this.Controls.Add(this.ButtonIssuedOrder);
			this.Controls.Add(this.ButtonCreateOrder);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Рыбный завод";
			this.Load += new System.EventHandler(this.FormMain_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonCreateOrder;
		private System.Windows.Forms.Button ButtonIssuedOrder;
		private System.Windows.Forms.Button ButtonRef;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem компонентыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem изделияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ComponentCannedToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem CannedsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem OrdersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem исполнителиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem запускРаботToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem письмаToolStripMenuItem;
	}
}