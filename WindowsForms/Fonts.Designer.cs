namespace WindowsForms
{
	partial class Fonts
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
			this.cbFont = new System.Windows.Forms.ComboBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblExample = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbFont
			// 
			this.cbFont.FormattingEnabled = true;
			this.cbFont.Location = new System.Drawing.Point(1, 12);
			this.cbFont.Name = "cbFont";
			this.cbFont.Size = new System.Drawing.Size(404, 21);
			this.cbFont.TabIndex = 0;
			this.cbFont.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(239, 109);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(82, 25);
			this.btnOk.TabIndex = 1;
			this.btnOk.Text = "OК";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(338, 109);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(81, 25);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lblExample
			// 
			this.lblExample.AutoSize = true;
			this.lblExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblExample.Location = new System.Drawing.Point(12, 52);
			this.lblExample.Name = "lblExample";
			this.lblExample.Size = new System.Drawing.Size(140, 37);
			this.lblExample.TabIndex = 3;
			this.lblExample.Text = "Example";
			// 
			// Fonts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 146);
			this.Controls.Add(this.lblExample);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.cbFont);
			this.Name = "Fonts";
			this.Text = "Fonts";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbFont;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblExample;
	}
}