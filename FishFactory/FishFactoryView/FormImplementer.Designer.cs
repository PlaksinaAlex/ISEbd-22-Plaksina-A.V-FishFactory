
namespace FishFactoryView
{
	partial class FormImplementer
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
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonImplementerSave = new System.Windows.Forms.Button();
			this.textBoxPauseTime = new System.Windows.Forms.TextBox();
			this.labelPauseTime = new System.Windows.Forms.Label();
			this.textBoxWorkingTime = new System.Windows.Forms.TextBox();
			this.labelWorkingTime = new System.Windows.Forms.Label();
			this.textBoxImplementerFIO = new System.Windows.Forms.TextBox();
			this.labelImplementerFIO = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(187, 106);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(89, 27);
			this.buttonCancel.TabIndex = 19;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// buttonImplementerSave
			// 
			this.buttonImplementerSave.Location = new System.Drawing.Point(71, 106);
			this.buttonImplementerSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.buttonImplementerSave.Name = "buttonImplementerSave";
			this.buttonImplementerSave.Size = new System.Drawing.Size(89, 27);
			this.buttonImplementerSave.TabIndex = 18;
			this.buttonImplementerSave.Text = "Сохранить";
			this.buttonImplementerSave.UseVisualStyleBackColor = true;
			this.buttonImplementerSave.Click += new System.EventHandler(this.buttonImplementerSave_Click);
			// 
			// textBoxPauseTime
			// 
			this.textBoxPauseTime.Location = new System.Drawing.Point(166, 71);
			this.textBoxPauseTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxPauseTime.Name = "textBoxPauseTime";
			this.textBoxPauseTime.Size = new System.Drawing.Size(182, 23);
			this.textBoxPauseTime.TabIndex = 17;
			// 
			// labelPauseTime
			// 
			this.labelPauseTime.AutoSize = true;
			this.labelPauseTime.Location = new System.Drawing.Point(25, 74);
			this.labelPauseTime.Name = "labelPauseTime";
			this.labelPauseTime.Size = new System.Drawing.Size(112, 15);
			this.labelPauseTime.TabIndex = 16;
			this.labelPauseTime.Text = "Время на перерыв:";
			// 
			// textBoxWorkingTime
			// 
			this.textBoxWorkingTime.Location = new System.Drawing.Point(166, 41);
			this.textBoxWorkingTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxWorkingTime.Name = "textBoxWorkingTime";
			this.textBoxWorkingTime.Size = new System.Drawing.Size(182, 23);
			this.textBoxWorkingTime.TabIndex = 15;
			// 
			// labelWorkingTime
			// 
			this.labelWorkingTime.AutoSize = true;
			this.labelWorkingTime.Location = new System.Drawing.Point(30, 44);
			this.labelWorkingTime.Name = "labelWorkingTime";
			this.labelWorkingTime.Size = new System.Drawing.Size(92, 15);
			this.labelWorkingTime.TabIndex = 14;
			this.labelWorkingTime.Text = "Время на заказ:";
			// 
			// textBoxImplementerFIO
			// 
			this.textBoxImplementerFIO.Location = new System.Drawing.Point(166, 6);
			this.textBoxImplementerFIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBoxImplementerFIO.Name = "textBoxImplementerFIO";
			this.textBoxImplementerFIO.Size = new System.Drawing.Size(182, 23);
			this.textBoxImplementerFIO.TabIndex = 13;
			// 
			// labelImplementerFIO
			// 
			this.labelImplementerFIO.AutoSize = true;
			this.labelImplementerFIO.Location = new System.Drawing.Point(25, 9);
			this.labelImplementerFIO.Name = "labelImplementerFIO";
			this.labelImplementerFIO.Size = new System.Drawing.Size(112, 15);
			this.labelImplementerFIO.TabIndex = 12;
			this.labelImplementerFIO.Text = "ФИО исполнителя:";
			// 
			// FormImplementer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(372, 144);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonImplementerSave);
			this.Controls.Add(this.textBoxPauseTime);
			this.Controls.Add(this.labelPauseTime);
			this.Controls.Add(this.textBoxWorkingTime);
			this.Controls.Add(this.labelWorkingTime);
			this.Controls.Add(this.textBoxImplementerFIO);
			this.Controls.Add(this.labelImplementerFIO);
			this.Name = "FormImplementer";
			this.Text = "Исполнитель";
			this.Load += new System.EventHandler(this.FormImplementer_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonImplementerSave;
		private System.Windows.Forms.TextBox textBoxPauseTime;
		private System.Windows.Forms.Label labelPauseTime;
		private System.Windows.Forms.TextBox textBoxWorkingTime;
		private System.Windows.Forms.Label labelWorkingTime;
		private System.Windows.Forms.TextBox textBoxImplementerFIO;
		private System.Windows.Forms.Label labelImplementerFIO;
	}
}
