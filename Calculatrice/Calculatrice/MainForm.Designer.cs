/*
 * Created by SharpDevelop.
 * User: DONNAT JOSEPHIN
 * Date: 19/09/2016
 * Time: 13:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculatrice
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.txtResultat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.btnBackspace = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scientifiqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.txtSigne = new System.Windows.Forms.TextBox();
			this.txtCalcul = new System.Windows.Forms.TextBox();
			this.txtResultatPartiel = new System.Windows.Forms.TextBox();
			this.txtegaleState = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtResultat
			// 
			this.txtResultat.BackColor = System.Drawing.Color.White;
			this.txtResultat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtResultat.Enabled = false;
			this.txtResultat.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtResultat.Location = new System.Drawing.Point(13, 52);
			this.txtResultat.Name = "txtResultat";
			this.txtResultat.Size = new System.Drawing.Size(211, 22);
			this.txtResultat.TabIndex = 0;
			this.txtResultat.Text = "0";
			this.txtResultat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(8, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 44);
			this.label1.TabIndex = 2;
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(143, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(42, 33);
			this.button1.TabIndex = 3;
			this.button1.TabStop = false;
			this.button1.Text = "±";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(143, 159);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(42, 33);
			this.button2.TabIndex = 4;
			this.button2.TabStop = false;
			this.button2.Text = "×";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(143, 123);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(42, 33);
			this.button3.TabIndex = 5;
			this.button3.TabStop = false;
			this.button3.Text = "/";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// btnBackspace
			// 
			this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnBackspace.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBackspace.Location = new System.Drawing.Point(8, 87);
			this.btnBackspace.Name = "btnBackspace";
			this.btnBackspace.Size = new System.Drawing.Size(42, 33);
			this.btnBackspace.TabIndex = 6;
			this.btnBackspace.TabStop = false;
			this.btnBackspace.Text = "←";
			this.btnBackspace.UseVisualStyleBackColor = true;
			this.btnBackspace.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(188, 159);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(42, 33);
			this.button5.TabIndex = 7;
			this.button5.TabStop = false;
			this.button5.Text = "1/x";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(53, 87);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(42, 33);
			this.button6.TabIndex = 8;
			this.button6.TabStop = false;
			this.button6.Text = "CE";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.Location = new System.Drawing.Point(98, 87);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(42, 33);
			this.button7.TabIndex = 9;
			this.button7.TabStop = false;
			this.button7.Text = "C";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.Location = new System.Drawing.Point(188, 87);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(42, 33);
			this.button8.TabIndex = 10;
			this.button8.TabStop = false;
			this.button8.Text = "√";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.Location = new System.Drawing.Point(188, 123);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(42, 33);
			this.button9.TabIndex = 11;
			this.button9.TabStop = false;
			this.button9.Text = "%";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button10.Location = new System.Drawing.Point(143, 195);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(42, 33);
			this.button10.TabIndex = 12;
			this.button10.TabStop = false;
			this.button10.Text = "-";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button11
			// 
			this.button11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button11.Location = new System.Drawing.Point(143, 231);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(42, 33);
			this.button11.TabIndex = 13;
			this.button11.TabStop = false;
			this.button11.Text = "+";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// button12
			// 
			this.button12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button12.Location = new System.Drawing.Point(188, 195);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(42, 69);
			this.button12.TabIndex = 14;
			this.button12.TabStop = false;
			this.button12.Text = "=";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// button13
			// 
			this.button13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button13.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button13.Location = new System.Drawing.Point(98, 123);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(42, 33);
			this.button13.TabIndex = 15;
			this.button13.TabStop = false;
			this.button13.Text = "9";
			this.button13.UseVisualStyleBackColor = true;
			this.button13.Click += new System.EventHandler(this.Button13Click);
			// 
			// button14
			// 
			this.button14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button14.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button14.Location = new System.Drawing.Point(53, 123);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(42, 33);
			this.button14.TabIndex = 16;
			this.button14.TabStop = false;
			this.button14.Text = "8";
			this.button14.UseVisualStyleBackColor = true;
			this.button14.Click += new System.EventHandler(this.Button14Click);
			// 
			// button15
			// 
			this.button15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button15.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button15.Location = new System.Drawing.Point(8, 123);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(42, 33);
			this.button15.TabIndex = 17;
			this.button15.TabStop = false;
			this.button15.Text = "7";
			this.button15.UseVisualStyleBackColor = true;
			this.button15.Click += new System.EventHandler(this.Button15Click);
			// 
			// button16
			// 
			this.button16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button16.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button16.Location = new System.Drawing.Point(8, 159);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(42, 33);
			this.button16.TabIndex = 20;
			this.button16.TabStop = false;
			this.button16.Text = "4";
			this.button16.UseVisualStyleBackColor = true;
			this.button16.Click += new System.EventHandler(this.Button16Click);
			// 
			// button17
			// 
			this.button17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button17.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button17.Location = new System.Drawing.Point(53, 159);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(42, 33);
			this.button17.TabIndex = 19;
			this.button17.TabStop = false;
			this.button17.Text = "5";
			this.button17.UseVisualStyleBackColor = true;
			this.button17.Click += new System.EventHandler(this.Button17Click);
			// 
			// button18
			// 
			this.button18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button18.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button18.Location = new System.Drawing.Point(98, 159);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(42, 33);
			this.button18.TabIndex = 18;
			this.button18.TabStop = false;
			this.button18.Text = "6";
			this.button18.UseVisualStyleBackColor = true;
			this.button18.Click += new System.EventHandler(this.Button18Click);
			// 
			// button19
			// 
			this.button19.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button19.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button19.Location = new System.Drawing.Point(8, 195);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(42, 33);
			this.button19.TabIndex = 23;
			this.button19.TabStop = false;
			this.button19.Text = "1";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new System.EventHandler(this.Button19Click);
			// 
			// button20
			// 
			this.button20.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button20.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button20.Location = new System.Drawing.Point(53, 195);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(42, 33);
			this.button20.TabIndex = 22;
			this.button20.TabStop = false;
			this.button20.Text = "2";
			this.button20.UseVisualStyleBackColor = true;
			this.button20.Click += new System.EventHandler(this.Button20Click);
			// 
			// button21
			// 
			this.button21.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button21.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button21.Location = new System.Drawing.Point(98, 195);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(42, 33);
			this.button21.TabIndex = 21;
			this.button21.TabStop = false;
			this.button21.Text = "3";
			this.button21.UseVisualStyleBackColor = true;
			this.button21.Click += new System.EventHandler(this.Button21Click);
			// 
			// button22
			// 
			this.button22.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button22.Location = new System.Drawing.Point(8, 231);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(87, 33);
			this.button22.TabIndex = 26;
			this.button22.TabStop = false;
			this.button22.Text = "0";
			this.button22.UseVisualStyleBackColor = true;
			this.button22.Click += new System.EventHandler(this.Button22Click);
			// 
			// button24
			// 
			this.button24.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button24.Location = new System.Drawing.Point(98, 231);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(42, 33);
			this.button24.TabIndex = 24;
			this.button24.TabStop = false;
			this.button24.Text = ",";
			this.button24.UseVisualStyleBackColor = true;
			this.button24.Click += new System.EventHandler(this.Button24Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.editerToolStripMenuItem,
									this.aideToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(237, 24);
			this.menuStrip1.TabIndex = 27;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// editerToolStripMenuItem
			// 
			this.editerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.quitterToolStripMenuItem,
									this.scientifiqueToolStripMenuItem});
			this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
			this.editerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.editerToolStripMenuItem.Text = "Affichage";
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Checked = true;
			this.quitterToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.quitterToolStripMenuItem.Text = "Standard";
			// 
			// scientifiqueToolStripMenuItem
			// 
			this.scientifiqueToolStripMenuItem.Name = "scientifiqueToolStripMenuItem";
			this.scientifiqueToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.scientifiqueToolStripMenuItem.Text = "Scientifique";
			this.scientifiqueToolStripMenuItem.Click += new System.EventHandler(this.ScientifiqueToolStripMenuItemClick);
			// 
			// aideToolStripMenuItem
			// 
			this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.aProposToolStripMenuItem});
			this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
			this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.aideToolStripMenuItem.Text = "Aide";
			// 
			// aProposToolStripMenuItem
			// 
			this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
			this.aProposToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
			this.aProposToolStripMenuItem.Text = "A propos ...";
			this.aProposToolStripMenuItem.Click += new System.EventHandler(this.AProposToolStripMenuItemClick);
			// 
			// txtSigne
			// 
			this.txtSigne.BackColor = System.Drawing.Color.White;
			this.txtSigne.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSigne.Enabled = false;
			this.txtSigne.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSigne.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtSigne.Location = new System.Drawing.Point(216, 36);
			this.txtSigne.Name = "txtSigne";
			this.txtSigne.Size = new System.Drawing.Size(7, 15);
			this.txtSigne.TabIndex = 28;
			// 
			// txtCalcul
			// 
			this.txtCalcul.BackColor = System.Drawing.Color.White;
			this.txtCalcul.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCalcul.Enabled = false;
			this.txtCalcul.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCalcul.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.txtCalcul.Location = new System.Drawing.Point(11, 36);
			this.txtCalcul.Name = "txtCalcul";
			this.txtCalcul.Size = new System.Drawing.Size(203, 15);
			this.txtCalcul.TabIndex = 29;
			this.txtCalcul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtResultatPartiel
			// 
			this.txtResultatPartiel.BackColor = System.Drawing.Color.White;
			this.txtResultatPartiel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtResultatPartiel.Enabled = false;
			this.txtResultatPartiel.Location = new System.Drawing.Point(12, 61);
			this.txtResultatPartiel.Name = "txtResultatPartiel";
			this.txtResultatPartiel.Size = new System.Drawing.Size(62, 13);
			this.txtResultatPartiel.TabIndex = 30;
			this.txtResultatPartiel.Text = "0";
			this.txtResultatPartiel.Visible = false;
			// 
			// txtegaleState
			// 
			this.txtegaleState.Location = new System.Drawing.Point(290, 85);
			this.txtegaleState.Name = "txtegaleState";
			this.txtegaleState.Size = new System.Drawing.Size(21, 20);
			this.txtegaleState.TabIndex = 31;
			this.txtegaleState.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(237, 276);
			this.Controls.Add(this.txtegaleState);
			this.Controls.Add(this.txtCalcul);
			this.Controls.Add(this.txtSigne);
			this.Controls.Add(this.button22);
			this.Controls.Add(this.button24);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.btnBackspace);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.txtResultat);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtResultatPartiel);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Calculatrice";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem scientifiqueToolStripMenuItem;
		private System.Windows.Forms.TextBox txtegaleState;
		private System.Windows.Forms.TextBox txtResultatPartiel;
		private System.Windows.Forms.TextBox txtCalcul;
		private System.Windows.Forms.TextBox txtSigne;
		private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button btnBackspace;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtResultat;
	}
}
