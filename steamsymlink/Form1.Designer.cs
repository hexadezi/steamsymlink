
namespace steamsymlink
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TxtSteamPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtGamePath = new System.Windows.Forms.TextBox();
			this.BtnPathSteam = new System.Windows.Forms.Button();
			this.BtnPathGame = new System.Windows.Forms.Button();
			this.TxtLog = new System.Windows.Forms.TextBox();
			this.BtnDelete = new System.Windows.Forms.Button();
			this.BtnCreate = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// TxtSteamPath
			// 
			this.TxtSteamPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtSteamPath.Location = new System.Drawing.Point(12, 25);
			this.TxtSteamPath.Name = "TxtSteamPath";
			this.TxtSteamPath.Size = new System.Drawing.Size(490, 20);
			this.TxtSteamPath.TabIndex = 1;
			this.TxtSteamPath.Text = "C:\\Program Files (x86)\\Steam";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Steam Directory";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Game Directory";
			// 
			// TxtGamePath
			// 
			this.TxtGamePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtGamePath.Location = new System.Drawing.Point(12, 64);
			this.TxtGamePath.Name = "TxtGamePath";
			this.TxtGamePath.Size = new System.Drawing.Size(490, 20);
			this.TxtGamePath.TabIndex = 3;
			this.TxtGamePath.Text = "E:\\Steam";
			// 
			// BtnPathSteam
			// 
			this.BtnPathSteam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnPathSteam.Location = new System.Drawing.Point(508, 24);
			this.BtnPathSteam.Name = "BtnPathSteam";
			this.BtnPathSteam.Size = new System.Drawing.Size(27, 22);
			this.BtnPathSteam.TabIndex = 4;
			this.BtnPathSteam.Text = "...";
			this.BtnPathSteam.UseVisualStyleBackColor = true;
			this.BtnPathSteam.Click += new System.EventHandler(this.BtnPathSteam_Click);
			// 
			// BtnPathGame
			// 
			this.BtnPathGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnPathGame.Location = new System.Drawing.Point(508, 63);
			this.BtnPathGame.Name = "BtnPathGame";
			this.BtnPathGame.Size = new System.Drawing.Size(27, 22);
			this.BtnPathGame.TabIndex = 5;
			this.BtnPathGame.Text = "...";
			this.BtnPathGame.UseVisualStyleBackColor = true;
			this.BtnPathGame.Click += new System.EventHandler(this.BtnPathGame_Click);
			// 
			// TxtLog
			// 
			this.TxtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxtLog.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TxtLog.Location = new System.Drawing.Point(12, 91);
			this.TxtLog.Multiline = true;
			this.TxtLog.Name = "TxtLog";
			this.TxtLog.ReadOnly = true;
			this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.TxtLog.Size = new System.Drawing.Size(522, 237);
			this.TxtLog.TabIndex = 1;
			// 
			// BtnDelete
			// 
			this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnDelete.Location = new System.Drawing.Point(379, 338);
			this.BtnDelete.Name = "BtnDelete";
			this.BtnDelete.Size = new System.Drawing.Size(75, 23);
			this.BtnDelete.TabIndex = 8;
			this.BtnDelete.Text = "Delete";
			this.BtnDelete.UseVisualStyleBackColor = true;
			this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// BtnCreate
			// 
			this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnCreate.Location = new System.Drawing.Point(460, 338);
			this.BtnCreate.Name = "BtnCreate";
			this.BtnCreate.Size = new System.Drawing.Size(75, 23);
			this.BtnCreate.TabIndex = 0;
			this.BtnCreate.Text = "Create";
			this.BtnCreate.UseVisualStyleBackColor = true;
			this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 373);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnPathGame);
			this.Controls.Add(this.BtnCreate);
			this.Controls.Add(this.TxtSteamPath);
			this.Controls.Add(this.BtnDelete);
			this.Controls.Add(this.BtnPathSteam);
			this.Controls.Add(this.TxtLog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.TxtGamePath);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtSteamPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtGamePath;
		private System.Windows.Forms.Button BtnPathSteam;
		private System.Windows.Forms.Button BtnPathGame;
		private System.Windows.Forms.TextBox TxtLog;
		private System.Windows.Forms.Button BtnDelete;
		private System.Windows.Forms.Button BtnCreate;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}

