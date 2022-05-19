using DataAccess;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Web.Services
{
	public class MemberService
	{
		private SchoolDbContext _dbContext;

		public MemberService(SchoolDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public List<Member> GetAllMembers() => this._dbContext.Members.Include(x => x.Role).ToList();

		public List<Member> GetSchoolBoardMembers() => GetAllMembers().Where(x => x.IsInSchoolBoard).ToList();

		public List<Member> GetMuncipalityBoardMembers() => GetAllMembers().Where(x => !x.IsInSchoolBoard).ToList();
	}
}
