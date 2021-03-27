/*
 * Created by SharpDevelop.
 * User: DIANA
 * Date: 16/03/2021
 * Time: 05:20 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Circulos
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
			this.pictureBoximage = new System.Windows.Forms.PictureBox();
			this.Boton1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.buttonAnalizar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Show = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoximage)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoximage
			// 
			this.pictureBoximage.AccessibleName = "imagen";
			this.pictureBoximage.Location = new System.Drawing.Point(12, 12);
			this.pictureBoximage.Name = "pictureBoximage";
			this.pictureBoximage.Size = new System.Drawing.Size(554, 321);
			this.pictureBoximage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoximage.TabIndex = 0;
			this.pictureBoximage.TabStop = false;
			// 
			// Boton1
			// 
			this.Boton1.AccessibleName = "ShowImage";
			this.Boton1.Location = new System.Drawing.Point(588, 12);
			this.Boton1.Name = "Boton1";
			this.Boton1.Size = new System.Drawing.Size(98, 27);
			this.Boton1.TabIndex = 1;
			this.Boton1.Text = "Mostrar imagen";
			this.Boton1.UseVisualStyleBackColor = true;
			this.Boton1.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// buttonAnalizar
			// 
			this.buttonAnalizar.AccessibleName = "ShowImage";
			this.buttonAnalizar.Location = new System.Drawing.Point(588, 55);
			this.buttonAnalizar.Name = "buttonAnalizar";
			this.buttonAnalizar.Size = new System.Drawing.Size(98, 27);
			this.buttonAnalizar.TabIndex = 2;
			this.buttonAnalizar.Text = "Analizar imagen";
			this.buttonAnalizar.UseVisualStyleBackColor = true;
			this.buttonAnalizar.Click += new System.EventHandler(this.ButtonAnalizarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(588, 208);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 96);
			this.label1.TabIndex = 4;
			this.label1.Text = "Centro";
			// 
			// Show
			// 
			this.Show.Location = new System.Drawing.Point(588, 97);
			this.Show.Name = "Show";
			this.Show.Size = new System.Drawing.Size(98, 27);
			this.Show.TabIndex = 5;
			this.Show.Text = "Mostrar";
			this.Show.UseVisualStyleBackColor = true;
			this.Show.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(718, 345);
			this.Controls.Add(this.Show);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAnalizar);
			this.Controls.Add(this.Boton1);
			this.Controls.Add(this.pictureBoximage);
			this.Name = "MainForm";
			this.Text = "Circulos";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoximage)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button Show;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonAnalizar;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button Boton1;
		private System.Windows.Forms.PictureBox pictureBoximage;
	}
}
