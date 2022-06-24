using DataAccess.Models.Enums;
using System;

namespace Web.Helpers
{
	public static class Display
	{
		public static string UserFriendlyTargetGroup(TargetGroup target)
		{
			switch (target)
			{
				case TargetGroup.All:
					return "За всички";
				case TargetGroup.Students:
					return "За ученици";
				case TargetGroup.Parents:
					return "За родители";
				case TargetGroup.Teachers:
					return "За учители";
			}

			return null;
		}

		public static bool IsNewArticle(DateTime creationDate)
		{
			if ((DateTime.Now - creationDate).Days < 3)
			{
				return true;
			}

			return false;
		}

		public static string PageTitle { get; set; }
	}
}
