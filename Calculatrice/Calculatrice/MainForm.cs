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
		
		// Ajouter un texte dans la zone de texte resultat
		void ajoutDansText(string valeur) {
			
			if(IsNumeric(txtResultat.Text)) {
				// Si le texte encours est à 0, alors on l'ecrase,
				// Sinon, on ajouter le nouveau chiffre à l'ancienne
				if(txtResultat.Text != "0") {
					// txtegaleState = 1 si l'utilisateur à précédement appuyer sur =
					// Donc si txtegaleState = 1, alors on ecrase le texte du txtResultat
					// et on initialise txtegaleState à 0
					if (txtegaleState.Text == "1") {
						txtResultat.Text = valeur;
						txtegaleState.Text = "0";
					// Si le txtResultat = txtResultatPartiel, alors on ecrase le text dans txtResultat
					// ----/---- Celà veu dire que l'utilisateur va ajouter un autre chiffre pour le calcul
					} else if (txtResultat.Text == txtResultatPartiel.Text) {
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
				// Calcul de l'opération
				// L'opération se fait à partir du signe ajouter dans txtSigne.
				if(txtSigne.Text == "+") {
					double rep = double.Parse(txtResultatPartiel.Text) + double.Parse(txtResultat.Text);
					txtResultatPartiel.Text = rep.ToString();
				} else if(txtSigne.Text == "-") {
					double rep = double.Parse(txtResultatPartiel.Text) - double.Parse(txtResultat.Text);
					txtResultatPartiel.Text = rep.ToString();
				} else if(txtSigne.Text == "*") {
					double rep = double.Parse(txtResultatPartiel.Text) * double.Parse(txtResultat.Text);
					txtResultatPartiel.Text = rep.ToString();
				} else if(txtSigne.Text == "/") {
					// Ici, on initialise le nombre de chiffre après virgule à 6
					double rep = double.Parse(txtResultatPartiel.Text) / double.Parse(txtResultat.Text);
					txtResultatPartiel.Text = Math.Round(rep, 6).ToString();
				} else {
					txtResultatPartiel.Text = txtResultat.Text;
				}
				txtResultat.Text = txtResultatPartiel.Text;
				
				
				if(txtSigne.Text != "" && txtCalcul.Text != "" && txtResultat.Text != "0") {
					txtCalcul.Text += " " + txtSigne.Text + " " + txtResultat.Text;
				} else if(txtSigne.Text == "")  {
					txtCalcul.Text += txtResultat.Text;
				}
				
				txtSigne.Text = signe;
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
			txtResultatPartiel.Text = "0";
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
			txtegaleState.Text = "1";
			ajoutSigne("");
			txtResultat.Text = txtResultatPartiel.Text;
			txtSigne.Text = "";
			txtCalcul.Text = "";
			txtResultatPartiel.Text = "0";
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
				txtegaleState.Text = "1";
				txtResultat.Text = Math.Round((1/double.Parse(txtResultat.Text)), 6).ToString();
			}
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			if(IsNumeric(txtResultat.Text)) {
				txtegaleState.Text = "1";
				txtResultat.Text = Math.Round(Math.Sqrt(double.Parse(txtResultat.Text)),6).ToString();
			}
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			/*if(IsNumeric(txtResultat.Text)) {
				txtegaleState.Text = "1";
				double nombre = double.Parse(txtResultat.Text);
				nombre = nombre + (nombre/100);
				txtResultat.Text = Math.Round(nombre,6).ToString();
			}*/
		}
	}
}
