using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Term_Project_Version_1.Models
{
	public class SeekingAllahContext : DbContext
	{
		public SeekingAllahContext(DbContextOptions<SeekingAllahContext> options)
			: base(options)
		{ }
		public DbSet<Members> Membership { get; set; }
		public DbSet<Purchases> Purchases { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Members>().HasData(
				new Members
				{
					ID = 1,
					name = "Michelle Vanwettere",
					email = "michelle@vanwetteregroup.com"
				},
				new Members
				{
					ID = 2,
					name = "Tito Nugauily",
					email = "tito.nugaily@gmail.com"
				},
				new Members
				{
					ID = 3,
					name = "David Wood",
					email = "david.wood@acts17.com"
				},
								new Members
								{
									ID = 4,
									name = "Matthew Gibson",
									email = "mgibson@makeitrain.com"
								},
												new Members
												{
													ID = 5,
													name = "Mohamed Ayew",
													email = "mohamedayew@gmail.com"
												},
																new Members
																{
																	ID = 6,
																	name = "Meda Doyle",
																	email = "mayadamohamed@gmail.com"
																}
			);
			modelBuilder.Entity<Purchases>().HasData(
				 new Purchases
				 {
					 ID = "SA",
					 Description="Seeking Allah Finding Jesus Paperback",
					Price = "$19.99",
					 MembersID = 1
				 },
				 new Purchases
				 {
					 ID = "SG",
					 Description = "Study Guide including hard cover book, study guide and blu-ray",
					Price = "$79.99",
					 MembersID = 6
				 },
				 new Purchases
				 {
					 ID = "FA",
					 Description = "Full Access including study guide and access to all podcasts and articles",
					 Price = "$109.99",
					 MembersID = 5
				 }
			 );
		}
	}
}
