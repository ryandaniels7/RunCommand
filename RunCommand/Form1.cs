using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RunCommand
{
    public partial class Form1 : Form
    {
        public string oCurrent;
        public string oLast;
        public string oShared;
        public bool oStack;
        public bool oFailed;
        public Form1()
        {
            InitializeComponent();
        }
        public void oHandle(string oErrorMessage)
        {
            MessageBox.Show(oErrorMessage);
            TextEntry.Text = "";
            oFailed = true;
        }
        public void oProcess(string oCommand)
        {
            try
            {
                Process.Start(oCommand);
            }
            catch (Exception oError)
            {
                oHandle(oError.Message);
            }
        }
        public void RunCommand()
        {
            oShared = @"S:\";
            oFailed = false;
            oCurrent = TextEntry.Text.ToUpper().Trim();
            if (oCurrent == "")
            {
                Dispose();
            }
            else if (oCurrent == "C")
            {
                oProcess(@"C:\");
            }
            else if (oCurrent == "CALC")
            {
                oProcess(@"calc.exe");
            }
            else if (oCurrent == "DOS")
            {
                oProcess(@"C:\Program Files (x86)\DOSBox SVN-Daum\dosbox.lnk");
            }
            else if (oCurrent == "DOSCONFIG")
            {
                oProcess(@"C:\Program Files (x86)\DOSBox SVN-Daum\TOOLS\Run DOSBox configuration.bat");
            }
            else if (oCurrent == "SCAN")
            {
                oProcess(@"C:\Program Files (x86)\NAPS2\NAPS2.exe");
            }
            else if (oCurrent == "VIS")
            {
                oProcess(@"C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\devenv.exe");
            }
            else if (oCurrent == "SATS")
            {
                oProcess(@"C:\Users\Ryan Daniels\Documents\Shortcuts\SATS 1.rdp");
            }
            else if (oCurrent == "PROGRESS")
            {
                oProcess( oShared + @"PROGRAMS\In Progress\");
            }
            else if (oCurrent == "MLOK")
            {
                oProcess(@"C:\Users\Ryan Daniels\Documents\Visual Studio 2017\Projects\OmahaUtilities\MicrolokTools\MicrolokTools\bin\Debug\MicrolokTools.exe");
            }
            else if (oCurrent == "FINAL")
            {
                oProcess(oShared + @"PROGRAMS\Final\");
            }
            else if (oCurrent == "TO BE")
            {
                oProcess(oShared + @"PROGRAMS\To Be Tested\");
            }
            else if (oCurrent == "SDU")
            {
                oProcess(oShared + @"DOCUMENTS\SDU CALC.xlsx");
            }
            else if (oCurrent == "HELP")
            {
                oProcess(@"C:\Users\Ryan Daniels\Documents\Commands.txt");
            }
            else if (oCurrent == "LADDER")
            {
                oProcess(@"C:\Utilities\LadderView.exe");
            }
            else if (oCurrent == "ULTI")
            {
                oProcess(@"https://n11.ultipro.com/Login.aspx?ReturnUrl=%2f");
                System.Threading.Thread.Sleep(2000);
                SendKeys.SendWait("{ENTER}");
            }
            else if (oCurrent == "EDM")
            {
                try
                {
                    Process.Start(@"IExplore.exe", "https://employees.www.uprr.com/emp/engineering/apps/secure/efms/edm/index.cfm");
                }
                catch (Exception oError)
                {
                    oHandle(oError.Message);
                }
                System.Threading.Thread.Sleep(1000);
                SendKeys.SendWait("xcng813");
                SendKeys.SendWait("{TAB}");
                SendKeys.SendWait("quest50c");
                SendKeys.SendWait("{ENTER}");
            }
            else if (oCurrent == "TIME")
            {
                oProcess(@"https://secure.tickspot.com/");
            }
            else if (oCurrent == "CHROME")
            {
                oProcess(@"chrome.exe");
            }
            else if (oCurrent == "FIREFOX")
            {
                oProcess(@"firefox.exe");
            }
            else if (oCurrent == "EXCEL")
            {
                oProcess(@"excel.exe");
            }
            else if (oCurrent == "WORD")
            {
                oProcess(@"winword.exe");
            }
            else if (oCurrent == "NOTE")
            {
                oProcess(@"notepad.exe");
            }
            else if (oCurrent == "CLEAN")
            {
                oProcess(@"ccleaner.exe");
            }
            else if (oStack = true && oCurrent == oLast)
            {
                oProcess("https://www.google.com/search?q=stackoverflow+C%23+" + oCurrent.Replace(" ", "+"));
            }
            else
            {
                oStack = true;
                oLast = oCurrent;
                return;
            }
            if (oFailed == false)
            {
                Dispose();
            }
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            RunCommand();
        }
        private void TextEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
