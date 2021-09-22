using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steamsymlink
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public void Log(string line)
		{
			TxtLog.AppendText(line + Environment.NewLine);
		}

		private void BtnCreate_Click(object sender, EventArgs e)
		{
			try
			{
				DirectoryInfo steamCommon = new DirectoryInfo(Path.Combine(TxtSteamPath.Text, "steamapps", "common"));
				DirectoryInfo steamSteamapps = new DirectoryInfo(Path.Combine(TxtSteamPath.Text, "steamapps"));

				DirectoryInfo gameDir = new DirectoryInfo(Path.Combine(TxtGamePath.Text, "steamapps", "common"));
				DirectoryInfo[] games = gameDir.GetDirectories();

				DirectoryInfo manifestDir = new DirectoryInfo(Path.Combine(TxtGamePath.Text, "steamapps"));
				FileInfo[] manifests = manifestDir.GetFiles("appmanifest_*.acf");

				Log("Creating link");

				foreach (var game in games)
				{
					SymbolicLink.Create(Path.Combine(steamCommon.FullName, game.Name), game.FullName);
					Log(" + " + Path.Combine(steamCommon.FullName, game.Name));
				}
				Log("");


				Log("Creating manifest");

				foreach (var manifest in manifests)
				{
					SymbolicLink.Create(Path.Combine(steamSteamapps.FullName, manifest.Name), manifest.FullName);
					Log(" + " + Path.Combine(steamSteamapps.FullName, manifest.Name));
				}
				Log("");
			}
			catch (DirectoryNotFoundException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (Exception exx)
			{
				MessageBox.Show(exx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{

			try
			{
				DirectoryInfo steamCommon = new DirectoryInfo(Path.Combine(TxtSteamPath.Text, "steamapps", "common"));
				DirectoryInfo steamSteamapps = new DirectoryInfo(Path.Combine(TxtSteamPath.Text, "steamapps"));

				DirectoryInfo gameDir = new DirectoryInfo(Path.Combine(TxtGamePath.Text, "steamapps", "common"));
				DirectoryInfo[] games = gameDir.GetDirectories();

				DirectoryInfo manifestDir = new DirectoryInfo(Path.Combine(TxtGamePath.Text, "steamapps"));
				FileInfo[] manifests = manifestDir.GetFiles("appmanifest_*.acf");

				Log("Deleting link");

				foreach (var game in games)
				{
					SymbolicLink.Delete(Path.Combine(steamCommon.FullName, game.Name));
					Log(" + " + Path.Combine(steamCommon.FullName, game.Name));
				}
				Log("");

				Log("Deleting manifest");

				foreach (var manifest in manifests)
				{
					SymbolicLink.Delete(Path.Combine(steamSteamapps.FullName, manifest.Name));
					Log(" + " + Path.Combine(steamSteamapps.FullName, manifest.Name));
				}
				Log("");
			}
			catch (DirectoryNotFoundException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch(Exception exx)
			{
				MessageBox.Show(exx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnPathSteam_Click(object sender, EventArgs e)
		{
			DialogResult objResult = folderBrowserDialog1.ShowDialog(this);
			if (objResult == DialogResult.OK)
			{
				TxtSteamPath.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void BtnPathGame_Click(object sender, EventArgs e)
		{
			DialogResult objResult = folderBrowserDialog1.ShowDialog(this);
			if (objResult == DialogResult.OK)
			{
				TxtGamePath.Text = folderBrowserDialog1.SelectedPath;
			}
		}
	}
}
