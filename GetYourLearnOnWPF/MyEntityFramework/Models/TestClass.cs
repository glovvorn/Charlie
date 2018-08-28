using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetYourLearnOnWPF.MyEntityFramework.Models
{
	public class TestClass
	{
		public TestClass(int _id, string _name)
		{
			this.Id = _id;
			this.Name = _name;
		}

		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int Id
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}
	}
}
