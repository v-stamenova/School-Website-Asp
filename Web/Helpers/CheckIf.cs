using System.Collections.Generic;

namespace Web.Helpers
{
	public static class CheckIf
	{
		private static List<string> ImageExtensions = new List<string> { ".JPG", ".JPE", ".BMP", ".GIF", ".PNG" };

		public static bool PathIsOfImage(string path)
		{
			foreach(string extension in ImageExtensions)
			{
				if (path.ToUpper().EndsWith(extension))
					return true;
			}

			return false;
		}
	}
}
