/*
 * Created by SharpDevelop.
 * User: Name
 * Date: 19/06/2023
 * Time: 4:30 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Attendance_Event_System
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Form1Load(object sender, EventArgs e)
		{
	
		}
		private void Button1Click(object sender, EventArgs e)
		{
			string username = tbusername.Text;
			string password = tbpassword.Text;

			if (username == "admin" && password == "admin") {
				// Navigate to home or perform desired action
				MessageBox.Show("Login successful. Navigating to home...");
				// TODO: Navigate to home form or perform other actions.
				this.Hide();
				Home home = new Home();
				home.ShowDialog();
			} else {
				MessageBox.Show("Wrong email or password. Please try again.");
			}
		}
		void TbusernameTextChanged(object sender, EventArgs e)
		{
	
		}
		void TbpasswordTextChanged(object sender, EventArgs e)
		{
			TextBox textBox = (TextBox)sender;
    textBox.UseSystemPasswordChar = true;
		}
	}
}