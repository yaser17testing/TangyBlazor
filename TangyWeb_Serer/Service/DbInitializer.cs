﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tangy_Common;
using Tangy_DataAccess.Data;
using TangyWeb_Serer.Service.IService;

namespace TangyWeb_Serer.Service
{
	public class DbInitializer : IDbInitializer
	{

		private readonly UserManager<IdentityUser> _userManager;
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly ApplicationDbContext _db;
		public DbInitializer(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
		{

			_db = db;
			_roleManager = roleManager;
			_userManager = userManager;



		}


		public void Initialize()
		{
			try
			{

				if (_db.Database.GetPendingMigrations().Count() > 0)
				{
					_db.Database.Migrate();

				}
				if (!_roleManager.RoleExistsAsync(SD.Role_Admin).GetAwaiter().GetResult())
				{

					_roleManager.CreateAsync(new IdentityRole(SD.Role_Admin)).GetAwaiter().GetResult();

					_roleManager.CreateAsync(new IdentityRole(SD.Role_Customer)).GetAwaiter().GetResult();

				}
				else
				{

					return;

				}

				IdentityUser user = new()
				{
					UserName = "Dada90@hotmail.com",
					Email = "Dada90@hotmail.com",
					EmailConfirmed = true

				};

				_userManager.CreateAsync(user, "Dada123*").GetAwaiter().GetResult();

				_userManager.AddToRoleAsync(user, SD.Role_Admin).GetAwaiter().GetResult();


			}
			catch (Exception ex)
			{


			}


			}
		}
	}
