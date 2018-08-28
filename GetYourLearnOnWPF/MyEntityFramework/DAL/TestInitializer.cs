using GetYourLearnOnWPF.MyEntityFramework.Models;
using GetYourLearnOnWPF.MyEntityFramework.MyDbContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetYourLearnOnWPF.MyEntityFramework.DAL
{
	public class TestInitializer: DropCreateDatabaseIfModelChanges<TestContext>
	{
		protected override void Seed(TestContext context)
		{
			var testObjectList = new List<TestClass>
			{
				new TestClass(1, "testName1"),
				new TestClass(2, "testName2"),
				new TestClass(3, "testName3")
			};

			testObjectList.ForEach(t => context.TestList.Add(t));
			context.SaveChanges();
		}
	}
}
