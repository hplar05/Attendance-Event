/*
 * Created by SharpDevelop.
 * User: Name
 * Date: 19/06/2023
 * Time: 4:59 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Attendance_Event_System
{
	/// <summary>
	/// Description of Home.
	/// </summary>
	public partial class Home : Form
	{
		public Home()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void LogoutbuttonClick(object sender, EventArgs e)
{
    DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

    if (result == DialogResult.Yes)
    {
        // Perform logout actions
        Form1 form1 = new Form1();
        form1.Show();
        this.Hide();
    }
}

		void StudentformClick(object sender, EventArgs e)
		{
	 	 Studentform studentform = new Studentform();
         studentform.Show();
         this.Hide();
		}
	}
}
