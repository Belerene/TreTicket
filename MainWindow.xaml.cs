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

namespace TreTicket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string activeTask;
        public string selectedClu;
        public string selectedTask;
        public string selectedSubtask;
        public bool activeSubtaskSelected = false;
        public int activeSubtaskID = 0;
        public int activeTicketID = int.MaxValue;
        public bool pauseButtonReady = false;

        public string[] tasksNwe = new string[] { "User Management Request", "Signature Management Request", "Bank Account Administration", "Bank Account Attestation", "Deal Confirmation", "Deal Settlement", "PCMB", "Hedge Effectiveness Test", "Bank Fee Controlling", "RTC Services", "Cross Check", "Special Services" };
        public string[] tasksMea = new string[] { "User Management Request", "Signature Management Request", "Bank Account Administration", "Bank Account Attestation", "Deal Confirmation", "Deal Settlement", "PCMB", "Hedge Effectiveness Test", "Bank Fee Controlling", "RTC Services", "Cross Check", "Special Services" };
        public string[] tasksCee = new string[] { "User Management Request", "Signature Management Request", "Bank Account Administration", "Bank Account Attestation", "Deal Confirmation", "Deal Settlement", "PCMB", "Hedge Effectiveness Test", "Bank Fee Controlling", "RTC Services", "Cross Check", "Special Services" };
        public string[] tasksSwe = new string[] { "User Management Request", "Signature Management Request", "Bank Account Administration", "Bank Account Attestation", "Deal Confirmation", "Deal Settlement", "PCMB", "Hedge Effectiveness Test", "Bank Fee Controlling", "RTC Services", "Cross Check", "Special Services" };
        public string[] tasksMuc = new string[] { "User Management Request", "Signature Management Request", "Bank Account Administration", "Bank Account Attestation", "Deal Confirmation", "Deal Settlement", "PCMB", "Hedge Effectiveness Test", "Bank Fee Controlling", "RTC Services", "Cross Check", "Special Services" };
        public string[] tasksGer = new string[] { "User Management Request", "Signature Management Request", "Bank Account Attestation", "Deal Confirmation", "Deal Settlement", "PCMB", "Hedge Effectiveness Test", "Bank Fee Controlling", "RTC Services", "Cross Check", "Special Services" };

        public string[][,] subtaskNwe = new string[12][,]
        {
            new string[,] { { "Registration form - standard roles and rights", "Paperless registration - standard roles and rights", "Special roles and additional rights", "Management of finavigate public key", "Re-activation of finavigate accounts", "Deletion of rights / Deactivation of user accounts", "Update / Review documents / Improvements", "Meetings", "Advisory", "Other" } },
            new string[,] { { "New Signatory / New Level", "Elimination of Signatory", "Advisory" } },
            new string[,] { { "Account Closure", "Account Opening", "BA IDs Update", "BIC / NSC Update", "FAX Statements", "IBAN Update", "Live Meeting", "Signatories Update", "Signatories Upload", "Change of Opening Date", "Ticket", "Upload of Bank Documents" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "Corruption Index", "Adjustment of the Daylight saving time", "Holiday Calendar", "Violation Run", "Zero-balance IC Accounts", "1st Level Support" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } }
        };
        public string[][,] subtaskMea = new string[12][,]
        {
            new string[,] { { "Registration form - standard roles and rights", "Paperless registration - standard roles and rights", "Special roles and additional rights", "Management of finavigate public key", "Re-activation of finavigate accounts", "Deletion of rights / Deactivation of user accounts", "Update / Review documents / Improvements", "Meetings", "Advisory", "Other" } },
            new string[,] { { "New Signatory / New Level", "Elimination of Signatory", "Advisory" } },
            new string[,] { { "Account Closure", "Account Opening", "BA IDs Update", "BIC / NSC Update", "FAX Statements", "IBAN Update", "Live Meeting", "Signatories Update", "Signatories Upload", "Change of Opening Date", "Ticket", "Upload of Bank Documents" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "Corruption Index", "Adjustment of the Daylight saving time", "Holiday Calendar", "Violation Run", "Zero-balance IC Accounts", "1st Level Support" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } }
        };
        public string[][,] subtaskCee = new string[12][,]
        {
            new string[,] { { "Registration form - standard roles and rights", "Paperless registration - standard roles and rights", "Special roles and additional rights", "Management of finavigate public key", "Re-activation of finavigate accounts", "Deletion of rights / Deactivation of user accounts", "Update / Review documents / Improvements", "Meetings", "Advisory", "Other" } },
            new string[,] { { "New Signatory / New Level", "Elimination of Signatory", "Advisory" } },
            new string[,] { { "Account Closure", "Account Opening", "BA IDs Update", "BIC / NSC Update", "FAX Statements", "IBAN Update", "Live Meeting", "Signatories Update", "Signatories Upload", "Change of Opening Date", "Ticket", "Upload of Bank Documents" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "Corruption Index", "Adjustment of the Daylight saving time", "Holiday Calendar", "Violation Run", "Zero-balance IC Accounts", "1st Level Support" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } }
        };
        public string[][,] subtaskSwe = new string[12][,]
        {
            new string[,] { { "Registration form - standard roles and rights", "Paperless registration - standard roles and rights", "Special roles and additional rights", "Management of finavigate public key", "Re-activation of finavigate accounts", "Deletion of rights / Deactivation of user accounts", "Update / Review documents / Improvements", "Meetings", "Advisory", "Other" } },
            new string[,] { { "New Signatory / New Level", "Elimination of Signatory", "Advisory" } },
            new string[,] { { "Account Closure", "Account Opening", "BA IDs Update", "BIC / NSC Update", "FAX Statements", "IBAN Update", "Live Meeting", "Signatories Update", "Signatories Upload", "Change of Opening Date", "Ticket", "Upload of Bank Documents" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "Corruption Index", "Adjustment of the Daylight saving time", "Holiday Calendar", "Violation Run", "Zero-balance IC Accounts", "1st Level Support" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } }
        };
        public string[][,] subtaskMuc = new string[12][,]
        {
            new string[,] { { "Registration form - standard roles and rights", "Paperless registration - standard roles and rights", "Special roles and additional rights", "Management of finavigate public key", "Re-activation of finavigate accounts", "Deletion of rights / Deactivation of user accounts", "Update / Review documents / Improvements", "Meetings", "Advisory", "Other" } },
            new string[,] { { "New Signatory / New Level", "Elimination of Signatory", "Advisory" } },
            new string[,] { { "Account Closure", "Account Opening", "BA IDs Update", "BIC / NSC Update", "FAX Statements", "IBAN Update", "Live Meeting", "Signatories Update", "Signatories Upload", "Change of Opening Date", "Ticket", "Upload of Bank Documents" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "Corruption Index", "Adjustment of the Daylight saving time", "Holiday Calendar", "Violation Run", "Zero-balance IC Accounts", "1st Level Support" } },
            new string[,] { { "muc41", "muc42" } },
            new string[,] { { "muc41", "muc42" } }
        };
        public string[][,] subtaskGer = new string[11][,]
        {
            new string[,] { { "Registration form - standard roles and rights", "Paperless registration - standard roles and rights", "Special roles and additional rights", "Management of finavigate public key", "Re-activation of finavigate accounts", "Deletion of rights / Deactivation of user accounts", "Update / Review documents / Improvements", "Meetings", "Advisory", "Other" } },
            new string[,] { { "New Signatory / New Level", "Elimination of Signatory", "Advisory" } },
            new string[,] { { "ger31", "ger32", "ger33", "ger34" } },
            new string[,] { { "ger31", "ger32", "ger33", "ger34" } },
            new string[,] { { "ger31", "ger32", "ger33", "ger34" } },
            new string[,] { { "ger31", "ger32", "ger33", "ger34" } },
            new string[,] { { "ger31", "ger32", "ger33", "ger34" } },
            new string[,] { { "ger31", "ger32", "ger33", "ger34" } },
            new string[,] { { "Corruption Index", "Adjustment of the Daylight saving time", "Holiday Calendar", "Violation Run", "Zero-balance IC Accounts", "1st Level Support" } },
            new string[,] { { "ger31", "ger32", "ger33", "ger34" } },
            new string[,] { { "ger41", "ger42" } }
        };

        public MainWindow()
        {
            InitializeComponent();

        }

        private void cluClick(string clu)
        {
            int cluId = 0;
            string[] tasks = new string[0];
            foreach (Button btn in gridClu.Children)
            {
                if ((string)btn.Content == clu)
                {
                    btn.Background = new SolidColorBrush(Colors.LightSkyBlue);
                    btn.FontWeight = FontWeights.Bold;
                }
                else
                {
                    btn.Background = new SolidColorBrush(Colors.LightYellow);
                    btn.FontWeight = FontWeights.Normal;
                }
            }
            switch (clu)
            {
                case "NWE":
                    cluId = 0;
                    tasks = tasksNwe;
                    break;
                case "MEA":
                    cluId = 1;
                    tasks = tasksMea;
                    break;
                case "CEE":
                    cluId = 2;
                    tasks = tasksCee;
                    break;
                case "SWE":
                    cluId = 3;
                    tasks = tasksSwe;
                    break;
                case "MUC":
                    cluId = 4;
                    tasks = tasksMuc;
                    break;
                case "GER":
                    cluId = 5;
                    tasks = tasksGer;
                    break;
            }
            deselectActiveTicket();
            removeButtons(stkTask);
            removeButtons(stkSubtask);
            for (int row = 0; row < tasks.Length; row++)
            {
                Button taskBtn = new Button();
                {
                    taskBtn.Name = "_" + row.ToString() + "_" + cluId.ToString();
                    taskBtn.Height = 35;
                    taskBtn.Width = 282;
                    taskBtn.Foreground = new SolidColorBrush(Colors.Black);
                    taskBtn.Background = new SolidColorBrush(Color.FromScRgb(1, 243, 243, 243));
                    taskBtn.Content = tasks[row];
                    taskBtn.Tag = row;
                }
                taskBtn.Click += taskBtn_Click;
                stkTask.Children.Add(taskBtn);
            }
        }
        private void taskBtn_Click(object sender, RoutedEventArgs e)
        {
            var taskBtn = (Button)sender;
            string[] taskBtnName = taskBtn.Name.Split('_');
            string cluId = taskBtnName[2];
            int btnId = Convert.ToInt32(taskBtnName[1]);
            string[,] subtasks = new string[0,0];
            switch (cluId)
            {
                case "0":
                    subtasks = subtaskNwe[btnId];
                    break;
                case "1":
                    subtasks = subtaskMea[btnId];
                    break;
                case "2":
                    subtasks = subtaskCee[btnId];
                    break;
                case "3":
                    subtasks = subtaskSwe[btnId];
                    break;
                case "4":
                    subtasks = subtaskMuc[btnId];
                    break;
                case "5":
                    subtasks = subtaskGer[btnId];
                    break;
            }
            selectedSubtask = "";
            selectedTask = " > " + taskBtn.Content;
            setActiveSelections();
            deselectActiveTicket();
            highlightButton(stkTask, btnId);
            removeButtons(stkSubtask);
            for (int row = 0; row < subtasks.Length; row++)
            {
                Button subtaskBtn = new Button();
                {
                    subtaskBtn.Name = "_" + row.ToString() + taskBtn.Name;
                    subtaskBtn.Height = 35;
                    subtaskBtn.Width = 291;
                    subtaskBtn.Foreground = new SolidColorBrush(Colors.Black);
                    subtaskBtn.Background = new SolidColorBrush(Color.FromScRgb(1, 243, 243, 243));
                    subtaskBtn.Content = subtasks[0,row];
                    subtaskBtn.Tag = row;
                }
                subtaskBtn.Click += subtaskBtn_click;
                stkSubtask.Children.Add(subtaskBtn);
            }
        }

        private void setActiveSelections()
        {
            activeSelections.Text = selectedClu + selectedTask + selectedSubtask;
        }

        private void subtaskBtn_click(object sender, RoutedEventArgs e)
        {
            activeSubtaskSelected = true;
            var subtaskBtn = (Button)sender;
            selectedSubtask = " > " + subtaskBtn.Content;
            setActiveSelections();
            activeTask = subtaskBtn.Content.ToString();
            deselectActiveTicket();
            highlightButton(stkSubtask,(int)subtaskBtn.Tag);

        }

        private void removeButtons(StackPanel stkPanel)
        {
            activeSubtaskSelected = false;
            stkPanel.Children.Clear();
        }

        private void buttonNWE_Click(object sender, RoutedEventArgs e)
        {
            selectedClu = "NWE";
            selectedTask = "";
            selectedSubtask = "";
            setActiveSelections();
            cluClick("NWE");
        }

        private void buttonMEA_Click(object sender, RoutedEventArgs e)
        {
            selectedClu = "MEA";
            selectedTask = "";
            selectedSubtask = "";
            setActiveSelections();
            cluClick("MEA");
        }

        private void buttonCEE_Click(object sender, RoutedEventArgs e)
        {
            selectedClu = "CEE";
            selectedTask = "";
            selectedSubtask = "";
            setActiveSelections();
            cluClick("CEE");
        }

        private void buttonSWE_Click(object sender, RoutedEventArgs e)
        {
            selectedClu = "SWE";
            selectedTask = "";
            selectedSubtask = "";
            setActiveSelections();
            cluClick("SWE");
        }

        private void buttonMUC_Click(object sender, RoutedEventArgs e)
        {
            selectedClu = "MUC";
            selectedTask = "";
            selectedSubtask = "";
            setActiveSelections();
            cluClick("MUC");
        }

        private void buttonGER_Click(object sender, RoutedEventArgs e)
        {
            selectedClu = "GER";
            selectedTask = "";
            selectedSubtask = "";
            setActiveSelections();
            cluClick("GER");
        }

        private void buttonStart_Click(object sender, RoutedEventArgs e)
        {
            if (pauseButtonReady)
            {
                Button btnToChange = null;
                foreach (Button btn in stkActiveTickets.Children)
                {
                    string tagID = btn.Tag.ToString().Split('_')[0];
                    if (Int32.Parse(tagID) == activeTicketID)
                    {
                        btnToChange = btn;
                    }
                }
                if((btnToChange.Background as SolidColorBrush).Color == Colors.Orange) // Check if the button is in Paused state
                {
                    string[] tags = btnToChange.Tag.ToString().Split('_');
                    tags[3] = (DateTime.Now - Convert.ToDateTime(tags[2])).Minutes.ToString();
                    btnToChange.Background = new SolidColorBrush(Colors.LightGreen);
                    btnToChange.Tag = String.Join("_", tags);
                }
                else
                {
                    btnToChange.Background = new SolidColorBrush(Colors.Orange);
                    string[] tags = btnToChange.Tag.ToString().Split('_');
                    tags[2] = DateTime.Now.ToString();
                    btnToChange.Tag = String.Join("_", tags);
                }
            }
            else
            {
                if (activeSubtaskSelected)
                {
                    var subtaskBtn = (Button)sender;
                    activeTask = selectedClu + selectedTask + Environment.NewLine + selectedSubtask + Environment.NewLine + txtRemarks.Text;
                    //selectedClu = "";
                    //selectedTask = "";
                    //selectedSubtask = "";
                    //setActiveSelections();
                    //removeButtons(stkTask);
                    //removeButtons(stkSubtask);
                    txtRemarks.Text = "";
                    Button ticketBtn = new Button();
                    {
                        ticketBtn.Name = subtaskBtn.Name;
                        ticketBtn.Height = 60;
                        ticketBtn.Width = 284;
                        ticketBtn.Foreground = new SolidColorBrush(Colors.Black);
                        ticketBtn.Background = new SolidColorBrush(Colors.LightGreen);
                        ticketBtn.Content = activeTask;
                        ticketBtn.Tag = activeSubtaskID + "_" + DateTime.Now.ToString()+ "_" + DateTime.Now.ToString() + "_" + 0.ToString() + "_" + txtRemarks.Text;
                        ticketBtn.HorizontalContentAlignment = HorizontalAlignment.Left;
                    }
                    ticketBtn.Click += ticketBtn_click;
                    ticketBtn.MouseRightButtonUp += ticketBtn_rightClick;
                    stkActiveTickets.Children.Add(ticketBtn);
                    activeSubtaskID++;
                    //activeSubtaskSelected = false;
                    //activeTask = "";
                }
            }
        }
        private void ticketBtn_click(object sender, RoutedEventArgs e)
        {
            var ticketBtn = (Button)sender;
            string tagID = ticketBtn.Tag.ToString().Split('_')[0];
            if (activeTicketID != int.MaxValue && Int32.Parse(tagID) == activeTicketID)
            {
                deselectActiveTicket();
            }
            else
            {
                foreach (Button btn in stkActiveTickets.Children)
                {
                    btn.BorderBrush = new SolidColorBrush(Color.FromArgb(100, 112, 112, 112));
                    //setDefaultButtonColor(btn);
                    //btn.Background = new SolidColorBrush(Colors.Red);
                }
                pauseButtonReady = true;
                buttonStart.Content = "Pause";
                activeTicketID = Int32.Parse(tagID);
                ticketBtn.BorderBrush = new SolidColorBrush(Colors.Red);
                //ticketBtn.Background = new SolidColorBrush(Colors.Brown);
                setupPathToTicket((string)ticketBtn.Content);
            }
        }

        private void buttonFinish_Click(object sender, RoutedEventArgs e)
        {
            if (activeTicketID != int.MaxValue) {
                Button btnToDelete = null;
                foreach (Button btn in stkActiveTickets.Children)
                {
                    string tagID = btn.Tag.ToString().Split('_')[0];
                    if (Int32.Parse(tagID) == activeTicketID)
                    {
                        btnToDelete = btn;
                    }
                }
                if (btnToDelete != null)
                {
                    stkActiveTickets.Children.Remove(btnToDelete);
                    activeTicketID = int.MaxValue;
                }
            }
        }
        private void deselectActiveTicket()
        {
            pauseButtonReady = false;
            buttonStart.Content = "Start";
            foreach (Button btn in stkActiveTickets.Children)
            {
                btn.BorderBrush = new SolidColorBrush(Color.FromArgb(100, 112, 112, 112));
            }
            activeTicketID = int.MaxValue;
        }
        private void setDefaultButtonColor(Button btn)
        {
            LinearGradientBrush vertGradient = new LinearGradientBrush();
            vertGradient.StartPoint = new Point(0.5, 0);
            vertGradient.EndPoint = new Point(0.5, 1);
            vertGradient.GradientStops.Add(new GradientStop(Color.FromScRgb(1,243,243,243) ,0.0));
            vertGradient.GradientStops.Add(new GradientStop(Color.FromScRgb(1, 221, 221, 221), 0.5));
            vertGradient.GradientStops.Add(new GradientStop(Color.FromScRgb(1, 235, 235, 235), 0.5));
            vertGradient.GradientStops.Add(new GradientStop(Color.FromScRgb(1, 205, 205, 205), 1.0));
            //btn.
            btn.Background = vertGradient;
        }

        private void resize_Click(object sender, RoutedEventArgs e)
        {
            MinimalisticWindow win2 = new MinimalisticWindow();
            win2.Show();
            this.Close();
        }
        private void highlightButton(StackPanel pnl, int id)
        {
            foreach(Button btn in pnl.Children)
            {
                if((int)btn.Tag == id)
                {
                    btn.Background = new SolidColorBrush(Colors.LightSkyBlue);
                    btn.FontWeight = FontWeights.Bold;
                }
                else
                {
                    btn.Background = new SolidColorBrush(Colors.LightYellow);
                    btn.FontWeight = FontWeights.Normal;
                }
            }
        }
        private void ticketBtn_rightClick(object sender, MouseButtonEventArgs e)
        {
            var ticketBtn = (Button)sender;
            string[] tags = ticketBtn.Tag.ToString().Split('_');
            DetailsWindow details = new DetailsWindow(this, tags, ticketBtn.Content.ToString());
            details.Owner = this;
            details.Show();
        }
        public void dataFromDetails(string newTag, string newRemark,bool flagFinish)
        {
            string[] tags = newTag.ToString().Split('_');
            Button toEditBtn = null;
            foreach (Button btn in stkActiveTickets.Children)
            {
                string[] btnTags = btn.Tag.ToString().Split('_');
                if (Int32.Parse(btnTags[0])== Int32.Parse(tags[0]))
                {
                    toEditBtn = btn;
                }
            }
                if (flagFinish)
            {
                toEditBtn.Tag = newTag;
                string[] result = toEditBtn.Content.ToString().Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                toEditBtn.Content = result[0] + Environment.NewLine + result[1] + Environment.NewLine + newRemark;
                stkActiveTickets.Children.Remove(toEditBtn);
                activeTicketID = int.MaxValue;
            }
            else
            {
                toEditBtn.Tag = newTag;
                string[] result = toEditBtn.Content.ToString().Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                toEditBtn.Content = result[0] + Environment.NewLine + result[1] + Environment.NewLine + newRemark;
            }
        }
        private void setupPathToTicket(string path)
        {
            string[] result = path.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            string clu = result[0].Split('>')[0].Trim();
            string task = result[0].Split('>')[1].Trim();
            string subTask = result[1].Split('>')[1].Trim();
            cluClick(clu);
            foreach (Button btn in stkTask.Children)
            {
                if ((string)btn.Content == task)
                {
                    taskBtn_Click(btn, new RoutedEventArgs());
                }
            }
            foreach (Button btn in stkSubtask.Children)
            {
                if ((string)btn.Content == subTask)
                {
                    subtaskBtn_click(btn, new RoutedEventArgs());
                }
            }
        }
    }  
}
