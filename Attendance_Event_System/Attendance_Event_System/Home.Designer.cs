/*
 * Created by SharpDevelop.
 * User: Name
 * Date: 19/06/2023
 * Time: 4:59 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Attendance_Event_System
{
	partial class Home
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Studentform;
		private System.Windows.Forms.Button logoutbutton;
		private System.Windows.Forms.PictureBox pictureBox1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
			this.label1 = new System.Windows.Forms.Label();
			this.Studentform = new System.Windows.Forms.Button();
			this.logoutbutton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(195, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hi CSU STUDENT!";
			// 
			// Studentform
			// 
			this.Studentform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.Studentform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Studentform.ForeColor = System.Drawing.Color.Black;
			this.Studentform.Location = new System.Drawing.Point(12, 84);
			this.Studentform.Name = "Studentform";
			this.Studentform.Size = new System.Drawing.Size(481, 55);
			this.Studentform.TabIndex = 1;
			this.Studentform.Text = "Submit a Student Event Attendance Form";
			this.Studentform.UseVisualStyleBackColor = false;
			this.Studentform.Click += new System.EventHandler(this.StudentformClick);
			// 
			// logoutbutton
			// 
			this.logoutbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.logoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.logoutbutton.Location = new System.Drawing.Point(389, 6);
			this.logoutbutton.Name = "logoutbutton";
			this.logoutbutton.Size = new System.Drawing.Size(104, 34);
			this.logoutbutton.TabIndex = 2;
			this.logoutbutton.Text = "Logout";
			this.logoutbutton.UseVisualStyleBackColor = false;
			this.logoutbutton.Click += new System.EventHandler(this.LogoutbuttonClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(65, 167);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(375, 339);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// Home
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(505, 552);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.logoutbutton);
			this.Controls.Add(this.Studentform);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Home";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Home";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
