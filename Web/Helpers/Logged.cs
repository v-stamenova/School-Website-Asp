using DataAccess.Models;

namespace Web.Helpers
{
	public class Logged
	{
		public static User User { get; set; }

		public static bool IsLogged()
		{
			if (Logged.User is not null)
			{
				return true;
			}

			return false;
		}
	}
}
