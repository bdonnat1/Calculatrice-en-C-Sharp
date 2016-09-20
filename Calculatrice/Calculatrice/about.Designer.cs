/*
 * Created by SharpDevelop.
 * User: DONNAT JOSEPHIN
 * Date: 20/09/2016
 * Time: 10:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculatrice
{
	partial class about
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// PictureBox1
			// 
			this.PictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureBox1.BackgroundImage")));
			this.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PictureBox1.Location = new System.Drawing.Point(12, 12);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(106, 96);
			this.PictureBox1.TabIndex = 1;
			this.PictureBox1.TabStop = false;
			// 
			// Label6
			// 
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label6.ForeColor = System.Drawing.Color.Blue;
			this.Label6.Location = new System.Drawing.Point(136, 58);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(132, 13);
			this.Label6.TabIndex = 15;
			this.Label6.Text = "www.dna-webhosting.com";
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.ForeColor = System.Drawing.Color.Navy;
			this.Label3.Location = new System.Drawing.Point(136, 45);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(188, 13);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "bdonnat1@yahoo.fr | skype: bdonnat1";
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(136, 32);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(102, 13);
			this.Label2.TabIndex = 13;
			this.Label2.Text = "By Donnat Josephin";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.Label1.Location = new System.Drawing.Point(135, 12);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(103, 20);
			this.Label1.TabIndex = 12;
			this.Label1.Text = "Calculatrice";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(244, 81);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 27);
			this.button1.TabIndex = 16;
			this.button1.Text = "Fermer";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// about
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 117);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.PictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "about";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "A propos ...";
			((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.PictureBox PictureBox1;
	}
}
