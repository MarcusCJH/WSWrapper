using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSocketWrapper
{
    public partial class WebSocketWrapper : Form
    {
        public WebSocketWrapper()
        {
            InitializeComponent();
            btnInitalizeStart.Enabled = false;
            btnInitalizeReset.Enabled = false;
            btnInitalizeDisconnect.Enabled = false;
            btnInstructionUnlock.Enabled = false;
            
            
        }
        
        private void btnInstructionSearchDirectory_Click(object sender, EventArgs e)
        {
            string filePath = "";

            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
            }
            
            //FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            //{
             //   folderPath = folderBrowserDialog1.SelectedPath;
            //}
            tbxInstructionDirectory.Text = filePath;
        }

       

        private void btnInstructionLockUnlock_Click(object sender, EventArgs e)
        {

            btnInstructionUnlock.Enabled = false;
            Button btn = sender as Button;
            if(btn == btnInstructionLock)
            {
                if (File.Exists(tbxInstructionDirectory.Text))
                {
                    btnInstructionLock.Enabled = false;
                    btnInstructionUnlock.Enabled = true;
                    tbxInstructionDirectory.ReadOnly = true;
                    btnInitalizeStart.Enabled = true;
                }
                else if (tbxInstructionDirectory.Text == "")
                {
                    MessageBox.Show("No Path was given");
                }
                else
                {
                    MessageBox.Show("File Does not exist");
                }
            }
            else if(btn == btnInstructionUnlock)
            {
                btnInstructionLock.Enabled = true;
                btnInstructionUnlock.Enabled = false;
                tbxInstructionDirectory.ReadOnly = false;
                btnInitalizeStart.Enabled = false;
            }
        }


        Process _cmd;

        delegate void SetTextCallback(string text);

        private void SetText(string text)
        {
            if (this.tbxConsoleLog.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tbxConsoleLog.Text += text + Environment.NewLine;
            }
        }

    

        void _cmd_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            UpdateConsole(e.Data);
        }

        void _cmd_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            UpdateConsole(e.Data, Brushes.Red);
        }

        void _cmd_Exited(object sender, EventArgs e)
        {
            _cmd.OutputDataReceived -= new DataReceivedEventHandler(_cmd_OutputDataReceived);
            _cmd.Exited -= new EventHandler(_cmd_Exited);
        }

        private void UpdateConsole(string text)
        {
            UpdateConsole(text, null);
        }
        private void UpdateConsole(string text, Brush color)
        {
            WriteLine(text, color);
        }

        private void WriteLine(string text, Brush color)
        {
            if (text != null)
            {
                SetText(text);
            }
        }

        private void tbxConsoleLog_TextChanged(object sender, EventArgs e)
        {
            tbxConsoleLog.SelectionStart = tbxConsoleLog.Text.Length; //Set the current caret position at the end
            tbxConsoleLog.ScrollToCaret(); //Now scroll it automatically
        }

        // Button Logic
        private void buttonLogic_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            

            if (btn == btnInitalizeStart)
            {
                btnInitalizeStart.Enabled = false;
                btnInitalizeReset.Enabled = true;
                btnInitalizeDisconnect.Enabled = true;
                


                // Process
                String path = tbxInstructionDirectory.Text.ToString();
                ProcessStartInfo cmdStartInfo = new ProcessStartInfo("java.exe");
                cmdStartInfo.Arguments = "-jar " + '"' + path;
                cmdStartInfo.CreateNoWindow = true;
                cmdStartInfo.RedirectStandardInput = true;
                cmdStartInfo.RedirectStandardOutput = true;
                cmdStartInfo.RedirectStandardError = true;
                cmdStartInfo.UseShellExecute = false;
                cmdStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                _cmd = new Process();
                _cmd.StartInfo = cmdStartInfo;

                if (_cmd.Start())
                {
                    _cmd.OutputDataReceived += new DataReceivedEventHandler(_cmd_OutputDataReceived);
                    _cmd.ErrorDataReceived += new DataReceivedEventHandler(_cmd_ErrorDataReceived);
                    _cmd.Exited += new EventHandler(_cmd_Exited);

                    _cmd.BeginOutputReadLine();
                    _cmd.BeginErrorReadLine();
                }
                else
                {
                    _cmd = null;
                }
            }
            else if (btn == btnInitalizeReset)
            {
                btnInitalizeStart.Enabled = false;
                btnInitalizeReset.Enabled = true;
                btnInitalizeDisconnect.Enabled = true;
                

                // Process
                _cmd.Kill();
                String path = tbxInstructionDirectory.Text.ToString();
                ProcessStartInfo cmdStartInfo = new ProcessStartInfo("java.exe");
                cmdStartInfo.Arguments = "-jar " + '"' + path;
                cmdStartInfo.CreateNoWindow = true;
                cmdStartInfo.RedirectStandardInput = true;
                cmdStartInfo.RedirectStandardOutput = true;
                cmdStartInfo.RedirectStandardError = true;
                cmdStartInfo.UseShellExecute = false;
                cmdStartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                _cmd = new Process();
                _cmd.StartInfo = cmdStartInfo;

                if (_cmd.Start())
                {
                    _cmd.OutputDataReceived += new DataReceivedEventHandler(_cmd_OutputDataReceived);
                    _cmd.ErrorDataReceived += new DataReceivedEventHandler(_cmd_ErrorDataReceived);
                    _cmd.Exited += new EventHandler(_cmd_Exited);

                    _cmd.BeginOutputReadLine();
                    _cmd.BeginErrorReadLine();
                }
                else
                {
                    _cmd = null;
                }
            }
            else if (btn == btnInitalizeDisconnect)
            {
                btnInitalizeStart.Enabled = true;
                btnInitalizeReset.Enabled = false;
                btnInitalizeDisconnect.Enabled = false;
                

                // Process
                _cmd.Kill();
                tbxConsoleLog.Text += "\nDisconnected\n\n";
            }
        }

        

        private void TaxiSimulator_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                _cmd.Kill();
            }
            catch(Exception ex)
            {

            }
        }

        

        
        

       
    }
}
