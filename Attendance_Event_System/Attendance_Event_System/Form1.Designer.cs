/*
 * Created by SharpDevelop.
 * User: Name
 * Date: 19/06/2023
 * Time: 4:30 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Attendance_Event_System
{
	partial class Form1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbusername;
		private System.Windows.Forms.TextBox tbpassword;
		private System.Windows.Forms.Button button1;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbusername = new System.Windows.Forms.TextBox();
			this.tbpassword = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(72, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(234, 201);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(159, 234);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 42);
			this.label1.TabIndex = 1;
			this.label1.Text = "Login";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 306);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Username:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(40, 351);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Password:";
			// 
			// tbusername
			// 
			this.tbusername.Location = new System.Drawing.Point(181, 306);
			this.tbusername.Name = "tbusername";
			this.tbusername.Size = new System.Drawing.Size(136, 30);
			this.tbusername.TabIndex = 4;
			this.tbusername.TextChanged += new System.EventHandler(this.TbusernameTextChanged);
			// 
			// tbpassword
			// 
			this.tbpassword.Location = new System.Drawing.Point(181, 351);
			this.tbpassword.Name = "tbpassword";
			this.tbpassword.Size = new System.Drawing.Size(136, 30);
			this.tbpassword.TabIndex = 5;
			this.tbpassword.TextChanged += new System.EventHandler(this.TbpasswordTextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.button1.Location = new System.Drawing.Point(146, 416);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(88, 38);
			this.button1.TabIndex = 6;
			this.button1.Text = "Sign In";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ClientSize = new System.Drawing.Size(378, 503);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbpassword);
			this.Controls.Add(this.tbusername);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
