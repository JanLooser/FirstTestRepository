
namespace MiniPixel
{
	partial class MiniPixel
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pbGround = new System.Windows.Forms.PictureBox();
			this.pbPlayer = new System.Windows.Forms.PictureBox();
			this.tmrGravity = new System.Windows.Forms.Timer(this.components);
			this.tmrSpringen = new System.Windows.Forms.Timer(this.components);
			this.tmrLinks = new System.Windows.Forms.Timer(this.components);
			this.tmrRechts = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbGround)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
			this.SuspendLayout();
			// 
			// pbGround
			// 
			this.pbGround.BackColor = System.Drawing.Color.Green;
			this.pbGround.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pbGround.Location = new System.Drawing.Point(0, 332);
			this.pbGround.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbGround.Name = "pbGround";
			this.pbGround.Size = new System.Drawing.Size(700, 65);
			this.pbGround.TabIndex = 0;
			this.pbGround.TabStop = false;
			// 
			// pbPlayer
			// 
			this.pbPlayer.BackColor = System.Drawing.Color.Black;
			this.pbPlayer.Location = new System.Drawing.Point(343, 144);
			this.pbPlayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pbPlayer.Name = "pbPlayer";
			this.pbPlayer.Size = new System.Drawing.Size(59, 46);
			this.pbPlayer.TabIndex = 1;
			this.pbPlayer.TabStop = false;
			this.pbPlayer.Click += new System.EventHandler(this.pbPlayer_Click);
			// 
			// tmrGravity
			// 
			this.tmrGravity.Enabled = true;
			this.tmrGravity.Interval = 10;
			this.tmrGravity.Tick += new System.EventHandler(this.tmrGravity_Tick);
			// 
			// tmrSpringen
			// 
			this.tmrSpringen.Interval = 10;
			this.tmrSpringen.Tick += new System.EventHandler(this.tmrSpringen_Tick);
			// 
			// tmrLinks
			// 
			this.tmrLinks.Interval = 10;
			this.tmrLinks.Tick += new System.EventHandler(this.tmrLink_Tick);
			// 
			// tmrRechts
			// 
			this.tmrRechts.Interval = 10;
			this.tmrRechts.Tick += new System.EventHandler(this.tmrRechts_Tick);
			// 
			// MiniPixel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.ClientSize = new System.Drawing.Size(700, 397);
			this.Controls.Add(this.pbPlayer);
			this.Controls.Add(this.pbGround);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MiniPixel";
			this.Text = "MiniPixel";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MiniPixel_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MiniPixel_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pbGround)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbGround;
		private System.Windows.Forms.PictureBox pbPlayer;
		private System.Windows.Forms.Timer tmrGravity;
		private System.Windows.Forms.Timer tmrSpringen;
		private System.Windows.Forms.Timer tmrLinks;
		private System.Windows.Forms.Timer tmrRechts;
	}
}

