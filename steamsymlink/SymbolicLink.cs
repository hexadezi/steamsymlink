using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace steamsymlink
{
	public static class SymbolicLink
	{

		[DllImport("Kernel32.dll", CharSet = CharSet.Unicode)]
		static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SymLinkFlags dwFlags);
		enum SymLinkFlags
		{
			File = 0,
			Directory = 1
		}

		public static void Create(string target, string source)
		{
			if (Directory.Exists(source))
			{
				CreateSymbolicLink(target, source, SymLinkFlags.Directory);
			}
			else if (File.Exists(source))
			{
				CreateSymbolicLink(target, source, SymLinkFlags.File);
			}
		}

		public static void Delete(string path)
		{
			if (Directory.Exists(path))
				Directory.Delete(path);
			if (File.Exists(path))
				File.Delete(path);
		}

	}
}
