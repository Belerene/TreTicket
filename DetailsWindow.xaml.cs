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
using System.Windows.Shapes;

namespace TreTicket
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        MainWindow mainWind = null;
        string newTag = "";
        string[] oTags = null;
        public DetailsWindow(MainWindow mainWnd,string[] tags, string activeSelect)
        {
            InitializeComponent();
            oTags = tags;
            timeTotal.Text = tags[3];
            string[] result = activeSelect.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            if (result.Length > 2)
            {
                remarkTxt.Text = result[2];
            }
            else
            {
                remarkTxt.Text = "";
            }
            activeSelections.Text = result[0] + result[1];
            startTime.DisplayDate = Convert.ToDateTime(tags[1]);
            startTime.Text = Convert.ToDateTime(tags[1]).ToString();
            mainWind = mainWnd;
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            constructNewTag();
            mainWind.dataFromDetails(newTag, remarkTxt.Text, false);
            this.Close();
        }

        private void finish_Click(object sender, RoutedEventArgs e)
        {
            constructNewTag();
            mainWind.dataFromDetails(newTag,remarkTxt.Text, true);
            this.Close();
        }
        private void constructNewTag()
        {
            string[] nTag = oTags;
            nTag[3] = timeTotal.Text;
            nTag[1] = startTime.SelectedDate.ToString();
            newTag = String.Join("_", nTag);
        }
    }
}
