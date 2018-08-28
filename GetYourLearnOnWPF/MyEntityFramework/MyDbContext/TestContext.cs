using GetYourLearnOnWPF.MyEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetYourLearnOnWPF.MyEntityFramework.MyDbContext
{
	public class TestContext: DbContext
	{
		public TestContext(): base("GetYourLearnOn")
		{

		}

		public DbSet<TestClass> TestList
		{
			get;
			set;
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//auto generated code from VS method creator
			//base.OnModelCreating(modelBuilder);

			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}

	}
}
