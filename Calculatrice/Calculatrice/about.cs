/*
 * Created by SharpDevelop.
 * User: DONNAT JOSEPHIN
 * Date: 20/09/2016
 * Time: 10:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculatrice
{
	/// <summary>
	/// Description of about.
	/// </summary>
	public partial class about : Form
	{
		public about()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
