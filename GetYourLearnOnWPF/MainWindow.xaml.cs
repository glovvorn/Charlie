using GetYourLearnOnWPF.MyEntityFramework.DAL;
using GetYourLearnOnWPF.MyEntityFramework.MyDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GetYourLearnOnWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				TestContext TC = new TestContext();
				TestInitializer TI = new TestInitializer();
				var blah = TC.TestList.ToList();

			}
			catch(Exception ex)
			{
				var asdasd = 0;
			}

			//MessageBox.Show("hello world", "blah", MessageBoxButton.YesNoCancel);
		}
	}
}
