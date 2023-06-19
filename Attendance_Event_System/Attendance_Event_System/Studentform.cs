/*
 * Created by SharpDevelop.
 * User: Name
 * Date: 19/06/2023
 * Time: 5:17 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Attendance_Event_System
{
	/// <summary>
	/// Description of Studentform.
	/// </summary>
	public partial class Studentform : Form
	{
		public Studentform()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void GroupBox1Enter(object sender, EventArgs e)
		{
	
		}
		 void Button1Click(object sender, EventArgs e)
        {
            // Check if any textbox is empty
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(textBox7.Text) ||
                string.IsNullOrEmpty(textBox8.Text) ||
                string.IsNullOrEmpty(textBox9.Text) ||
                string.IsNullOrEmpty(textBox10.Text) ||
                string.IsNullOrEmpty(textBox11.Text))
            {
                // Alert the user to fill up the blank textbox
                MessageBox.Show("Please fill in all the blanks.");
            }
            else
            {	
            	label12.Text = textBox1.Text;
                label13.Text = textBox2.Text;
                label14.Text = textBox3.Text;
                label15.Text = textBox4.Text;
                label16.Text = textBox6.Text;
                label17.Text = textBox10.Text;
                // Alert the user that the textbox is submitted
                MessageBox.Show("Attendance Event submitted.");
            }
        }
		void StudentformLoad(object sender, EventArgs e)
		{
	
		}
		void Label9Click(object sender, EventArgs e)
		{
	
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox2TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox4TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox3TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox5TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox6TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox7TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox8TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox9TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox10TextChanged(object sender, EventArgs e)
		{
	
		}
		void TextBox11TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button2Click(object sender, EventArgs e)
		{
	     Home home = new Home();
         home.Show();
         this.Hide();
		}
	}
}
