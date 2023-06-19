/*
 * Created by SharpDevelop.
 * User: Name
 * Date: 19/06/2023
 * Time: 3:37 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Attendance_Event_System
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel Pnl1;
		private System.Windows.Forms.Panel Pnl2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer Timer;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Pnl1 = new System.Windows.Forms.Panel();
			this.Pnl2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Timer = new System.Windows.Forms.Timer(this.components);
			this.Pnl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Pnl1
			// 
			this.Pnl1.BackColor = System.Drawing.Color.White;
			this.Pnl1.Controls.Add(this.Pnl2);
			this.Pnl1.Location = new System.Drawing.Point(102, 359);
			this.Pnl1.Margin = new System.Windows.Forms.Padding(0);
			this.Pnl1.Name = "Pnl1";
			this.Pnl1.Padding = new System.Windows.Forms.Padding(4);
			this.Pnl1.Size = new System.Drawing.Size(600, 50);
			this.Pnl1.TabIndex = 0;
			// 
			// Pnl2
			// 
			this.Pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.Pnl2.Dock = System.Windows.Forms.DockStyle.Left;
			this.Pnl2.Location = new System.Drawing.Point(4, 4);
			this.Pnl2.Margin = new System.Windows.Forms.Padding(5);
			this.Pnl2.Name = "Pnl2";
			this.Pnl2.Padding = new System.Windows.Forms.Padding(4);
			this.Pnl2.Size = new System.Drawing.Size(57, 42);
			this.Pnl2.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(79, 108);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(167, 173);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(271, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(454, 201);
			this.label1.TabIndex = 2;
			this.label1.Text = "Welcome to CSU Attendance Event";
			// 
			// Timer
			// 
			this.Timer.Enabled = true;
			this.Timer.Interval = 3000;
			this.Timer.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.Pnl1);
			this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Attendance_Event_System";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.Pnl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
