/*
 * Created by SharpDevelop.
 * User: DONNAT JOSEPHIN
 * Date: 20/09/2016
 * Time: 09:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculatrice
{
	/// <summary>
	/// Description of scientifique.
	/// </summary>
	public partial class scientifique : Form
	{
		public scientifique()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ScientifiqueLoad(object sender, EventArgs e)
		{
			
		}
		
		void QuitterToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form formulaire = new MainForm();
			formulaire.Show();
			this.Hide();
		}
		
		void AProposToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form formulaire = new about();
			formulaire.ShowDialog();
		}
	}
}
