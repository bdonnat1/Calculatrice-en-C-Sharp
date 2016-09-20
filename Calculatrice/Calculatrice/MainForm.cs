/*
 * Created by SharpDevelop.
 * User: DONNAT JOSEPHIN
 * Date: 19/09/2016
 * Time: 13:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculatrice
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double resultatPartiel = 0;
		bool estEgale = false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.KeyPreview = true;
            this.KeyPress +=
                new KeyPressEventHandler(MainForm_KeyPress);
		}
		
		// Detecter onpress sur le clavier
		void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
			//MessageBox.Show("Form.KeyPress: '" + e.KeyChar.ToString() + "' pressed.");
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
            	ajoutDansText(e.KeyChar.ToString());
           	// Si on touche sur backspace
            } else if (e.KeyChar == (char)Keys.Back) {
            	Button4Click(null, null);
           	// Operateur
            } else if (e.KeyChar.ToString() == "+" || e.KeyChar.ToString() == "-" || e.KeyChar.ToString() == "*" || e.KeyChar.ToString() == "/") {
            	ajoutSigne(e.KeyChar.ToString());
           	// Touche sur entrer
            } else if (e.KeyChar == (char)Keys.Enter) {
            	Button12Click(null, null);
            } else if (e.KeyChar == (char)Keys.Delete) {
            	Button7Click(null, null);
            }
        }
		
		// Ajouter un texte dans la zone de texte resultat
		void ajoutDansText(string valeur) {
			
			if(IsNumeric(txtResultat.Text)) {
				// Si le texte encours est à 0, alors on l'ecrase,
				// Sinon, on ajouter le nouveau chiffre à l'ancienne
				if(txtResultat.Text != "0") {
					// estEgale = 1 si l'utilisateur à précédement appuyer sur =
					// Donc si estEgale = 1, alors on ecrase le texte du txtResultat
					// et on initialise estEgale à 0
					if (estEgale == true) {
						txtResultat.Text = valeur;
						estEgale = false;
					// Si le txtResultat = resultatPartiel, alors on ecrase le text dans txtResultat
					// ----/---- Celà veu dire que l'utilisateur va ajouter un autre chiffre pour le calcul
					} else if (double.Parse(txtResultat.Text) == resultatPartiel) {
						txtResultat.Text = valeur;
					// Cas si autre
					} else {
						txtResultat.Text += valeur;
					}
					
				} else {
					txtResultat.Text = valeur;
				}
			}
		}
		
		// Ajout signe et calcul
		void ajoutSigne(string signe) {
			
			if(IsNumeric(txtResultat.Text)) {
				// Effectué le calcul
				calculResultat(double.Parse(txtResultat.Text));
				
				
				if(txtSigne.Text != "" && txtCalcul.Text != "" && txtResultat.Text != "0") {
					txtCalcul.Text += " " + txtSigne.Text + " " + txtResultat.Text;
				} else if(txtSigne.Text == "")  {
					txtCalcul.Text += txtResultat.Text;
				}
				
				txtResultat.Text = resultatPartiel.ToString();
				
				txtSigne.Text = signe;
			}
		}
		
		// Calcul de la resultat
		void calculResultat(double nombre) {
			// Calcul de l'opération
			// L'opération se fait à partir du signe ajouter dans txtSigne.
			if(txtSigne.Text == "+") {
				double rep = resultatPartiel + nombre;
				resultatPartiel = rep;
			} else if(txtSigne.Text == "-") {
				double rep = resultatPartiel - nombre;
				resultatPartiel = rep;
			} else if(txtSigne.Text == "*") {
				double rep = resultatPartiel * nombre;
				resultatPartiel = rep;
			} else if(txtSigne.Text == "/") {
				// Ici, on initialise le nombre de chiffre après virgule à 6
				double rep = resultatPartiel / nombre;
				resultatPartiel = Math.Round(rep, 6);
			} else {
				resultatPartiel = nombre;
			}
		}
		
		// Fonction isNumeric
		// La fonction IsNumeric n'existe pas sur c#, donc on l'a crée
		public bool IsNumeric(string input) {
		    double test;
		    return double.TryParse(input, out test);
		}
		
		void Button19Click(object sender, EventArgs e)
		{
			ajoutDansText("1");
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			ajoutSigne("/");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			ajoutSigne("*");
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			ajoutSigne("-");
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			ajoutSigne("+");
		}
		
		void Button20Click(object sender, EventArgs e)
		{
			ajoutDansText("2");
		}
		
		void Button21Click(object sender, EventArgs e)
		{
			ajoutDansText("3");
		}
		
		void Button16Click(object sender, EventArgs e)
		{
			ajoutDansText("4");
		}
		
		void Button17Click(object sender, EventArgs e)
		{
			ajoutDansText("5");
		}
		
		void Button18Click(object sender, EventArgs e)
		{
			ajoutDansText("6");
		}
		
		void Button15Click(object sender, EventArgs e)
		{
			ajoutDansText("7");
		}
		
		void Button14Click(object sender, EventArgs e)
		{
			ajoutDansText("8");
		}
		
		void Button13Click(object sender, EventArgs e)
		{
			ajoutDansText("9");
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			txtResultat.Text = "0";
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			txtResultat.Text = "0";
			txtSigne.Text = "";
			txtCalcul.Text = "";
			resultatPartiel = 0;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double num = double.Parse(txtResultat.Text) * (-1);
			txtResultat.Text = num.ToString();
		}
		
		void Button22Click(object sender, EventArgs e)
		{
			ajoutDansText("0");
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			if(IsNumeric(txtResultat.Text)) {
				estEgale = true;
				calculResultat(double.Parse(txtResultat.Text));
				txtResultat.Text = resultatPartiel.ToString();
				txtSigne.Text = "";
				txtCalcul.Text = "";
				resultatPartiel = 0;
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string texte = txtResultat.Text;
			if(texte.Length > 0 && texte != "0") {
				txtResultat.Text = texte.Substring(0, (texte.Length - 1));
				if(txtResultat.Text.Length == 0) txtResultat.Text = "0";
			} else {
				txtResultat.Text = "0";
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if(IsNumeric(txtResultat.Text)) {
				estEgale = true;
				calculResultat(double.Parse(txtResultat.Text));
				txtCalcul.Text = "1 / " + txtResultat.Text;
				txtResultat.Text = Math.Round((1/resultatPartiel), 6).ToString();
				txtSigne.Text = "";
				//txtCalcul.Text = "";
			}
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			if(IsNumeric(txtResultat.Text)) {
				estEgale = true;
				calculResultat(double.Parse(txtResultat.Text));
				txtCalcul.Text = "√" + txtResultat.Text;
				txtResultat.Text = Math.Round(Math.Sqrt(resultatPartiel),6).ToString();
				txtSigne.Text = "";
				//txtCalcul.Text = "";
			}
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			if(IsNumeric(txtResultat.Text)) {
				estEgale = true;
				txtResultat.Text = Math.Round((resultatPartiel*double.Parse(txtResultat.Text)/100),2).ToString();
				txtSigne.Text = "";
				txtCalcul.Text = "";
			}
		}
		
		void Button24Click(object sender, EventArgs e)
		{
			if (txtResultat.Text.IndexOf(",") <= 0) {
				ajoutDansText(",");
			}
		}
		
		
		
		void ScientifiqueToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form formulaire = new scientifique();
			formulaire.Show();
			this.Hide();
		}
		
		
		
		void AProposToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form formulaire = new about();
			formulaire.ShowDialog();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		
	}
}
