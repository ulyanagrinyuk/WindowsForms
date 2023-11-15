using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
	public partial class Form1 : Form
	{
		bool show_date;
		bool visible_controls;
		WindowsForms.Fonts choose_font;
		public Form1()
		{
			InitializeComponent();
			this.Location = new System.Drawing.Point
				(
				System.Windows.Forms.Screen.PrimaryScreen.Bounds.Right - this.Width - 50,
				System.Windows.Forms.Screen.PrimaryScreen.Bounds.Top + 100
				);
			show_date = false;
			visible_controls = false;
			btnHideControls.Visible = false;
			btnClose.Visible = false;
			choose_font = new WindowsForms.Fonts(label1.Font);
		}

		private void SetShowDate( bool show_date )
		{
			this.show_date = show_date;
			cbShowDate.Checked = show_date;
			showDateToolStripMenuItem.Enabled = show_date;	
		}
		private void SetControsVisibility(bool visible_controls)
		{
			this.visible_controls = visible_controls;
			this.FormBorderStyle = visible_controls ? FormBorderStyle.Sizable : FormBorderStyle.None;
			this.TransparencyKey = visible_controls ? Color.AliceBlue : SystemColors.Control;

			this.ShowInTaskbar = visible_controls;
			this.cbShowDate.Visible = visible_controls;

			this.btnFont.Visible = visible_controls;
			this.btnHideControls.Visible = visible_controls;
			this.btnClose.Visible = visible_controls;
			//this.notifyIcon1.Visible = !visible_controls;

			this.showControlsToolStripMenuItem.Checked = visible_controls;
		}

		
		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = DateTime.Now.ToString("HH:mm:ss");
			if (cbShowDate.Checked) label1.Text += $"\n{DateTime.Now.ToString("dd.MM.yyyy")}";
			notifyIcon1.Text = DateTime.Now.ToString("hh:mm:ss tt");
		}

		private void label1_DoubleClick(object sender, EventArgs e)
		{
			//this.FormBorderStyle = FormBorderStyle.Sizable;
			//this.TransparencyKey = Color.AliceBlue;
			//this.ShowInTaskbar = true;
			//this.cbShowDate.Visible = true;
			//this.btnHideControls.Visible = true;
			//this.btnClose.Visible = false;
			//this.notifyIcon1.Visible = false;
			SetControsVisibility(true);
		}

		private void btnHideControls_Click(object sender, EventArgs e)
		{
			//this.FormBorderStyle = FormBorderStyle.None;
			//this.TransparencyKey = Color.AliceBlue;
			//this.ShowInTaskbar = false;
			//this.cbShowDate.Visible = true;
			//this.btnHideControls.Visible = true;
			//this.btnClose.Visible = false;
			//this.notifyIcon1.Visible = true;
			SetControsVisibility(false);
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void showDateToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.show_date = showDateToolStripMenuItem.Checked;
			SetShowDate(show_date);
		}

		private void showControlsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (showDateToolStripMenuItem.Checked) label1_DoubleClick(sender, e);
			else btnHideControls_Click(sender, e);
		}

		private void cbShowDate_CheckedChanged(object sender, EventArgs e)
		{
			SetShowDate(cbShowDate.Checked);
		}

		private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			label1_DoubleClick(sender, e);
		}

		private void btnFont_Click(object sender, EventArgs e)
		{
			//Fonts font = new Fonts(label1.Font);
			choose_font.ShowDialog(this);
			label1.Font = choose_font.OldFont;
		}

		private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog(this);
			label1.ForeColor = colorDialog1.Color;
		}

		private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colorDialog1.ShowDialog(this);
			label1.BackColor = colorDialog1.Color;
		}

		private void toolStripMenuItemFont_Click(object sender, EventArgs e)
		{
			btnFont_Click(sender, e);
		}
	}
}
