using DataAccess.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Helpers
{
	public static class ParseEnum
	{
		public static TargetGroup TargetGroup(string group)
		{
			switch (group)
			{
				case "Всички":
					return DataAccess.Models.Enums.TargetGroup.All;
				case "Ученици":
					return DataAccess.Models.Enums.TargetGroup.Students;
				case "Учители":
					return DataAccess.Models.Enums.TargetGroup.Teachers;
				case "Родители":
					return DataAccess.Models.Enums.TargetGroup.Parents;
			}

			throw new ArgumentException("Invalid target group");
		}

		public static NormDocumentType NormDocumentType(string type)
		{
			switch (type)
			{
				case "Закон":
					return DataAccess.Models.Enums.NormDocumentType.Law;
				case "Заповед":
					return DataAccess.Models.Enums.NormDocumentType.Order;
				case "Наредба":
					return DataAccess.Models.Enums.NormDocumentType.Regulation;
				case "Училищен документ":
					return DataAccess.Models.Enums.NormDocumentType.School;
			}

			throw new ArgumentException("Invalid norm document type");
		}
	}
}
