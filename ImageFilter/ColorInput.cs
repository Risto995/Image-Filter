using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework;

namespace ImageFilter
{
	/// <summary>
	/// Summary description for ColorInput.
	/// </summary>
	public class ColorInput : MetroFramework.Forms.MetroForm
	{
		private System.Windows.Forms.TextBox Blue;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Green;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Red;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.Button Cancel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ColorInput()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			OK.DialogResult = System.Windows.Forms.DialogResult.OK;
			Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		public int red
		{
			get 
			{
				return (Convert.ToInt32(Red.Text, 10));
			}
			set{Red.Text = value.ToString();}
		}

		public int green
		{
			get 
			{
				return (Convert.ToInt32(Green.Text, 10));
			}
			set{Green.Text = value.ToString();}
		}

		public int blue
		{
			get 
			{
				return (Convert.ToInt32(Blue.Text, 10));
			}
			set{Blue.Text = value.ToString();}
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.Blue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Green = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Red = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(96, 177);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(120, 22);
            this.Blue.TabIndex = 17;
            this.Blue.Text = "textBox3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Blue";
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(96, 140);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(120, 22);
            this.Green.TabIndex = 15;
            this.Green.Text = "textBox2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(28, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Green";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(96, 103);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(120, 22);
            this.Red.TabIndex = 13;
            this.Red.Text = "textBox1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Red";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter values between -255 and 255";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(19, 223);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(90, 27);
            this.OK.TabIndex = 10;
            this.OK.Text = "OK";
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(124, 223);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(90, 27);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            // 
            // ColorInput
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(269, 259);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.Cancel);
            this.Name = "ColorInput";
            this.Text = "ColorInput";
            this.Load += new System.EventHandler(this.ColorInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private void ColorInput_Load(object sender, System.EventArgs e)
		{
		
		}

		private void OK_Click(object sender, System.EventArgs e)
		{
		
		}

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
