using DataAccess;
using DataAccess.Models;
using System;
using System.Linq;
using Web.Helpers;

namespace Web.Services
{
	public class UserService
	{
		private SchoolDbContext _dbContext;

		public UserService(SchoolDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public User GetUser(string username) => this._dbContext.Users.FirstOrDefault(x => x.Username == username);

		public void Login(string username, string password)
		{
			if (this._dbContext.Users.Any(x => x.Username == username))
			{
				if (this._dbContext.Users.FirstOrDefault(x => x.Username == username).Password == password)
				{
					Logged.User = this._dbContext.Users.FirstOrDefault(x => x.Username == username);
				}
				else
				{
					throw new ArgumentException("Incorrect username or password");
				}
			}
			else
			{
				throw new ArgumentException("Incorrect username or password");
			}
		}
	}
}
