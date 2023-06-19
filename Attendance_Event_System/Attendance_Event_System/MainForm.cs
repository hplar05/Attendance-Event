/*
 * Created by SharpDevelop.
 * User: Name
 * Date: 19/06/2023
 * Time: 3:37 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Attendance_Event_System
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
			void MainFormLoad(object sender, EventArgs e)
		{
			Pnl2.Width = 0;
			Timer.Start();
		}
		void Timer1Tick(object sender, EventArgs e)
		{
			for(int i = 0; i < 99; i++)
			{
				Pnl2.Width = Pnl2.Width + 6;
				Thread.Sleep(20);
			}
			Timer.Stop();
			this.Hide();
			Form1 form1 = new Form1();
			form1.ShowDialog();
		}
	
	}
}
