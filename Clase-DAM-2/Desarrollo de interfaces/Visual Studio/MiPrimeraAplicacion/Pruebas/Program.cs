using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            StartPanel myStackPanel = new StackPanel();
            Button myButton = new Button();
            myButton.Content = "Press me";
            myStackPanel.Children.Add(myButton);
        }
    }
}
