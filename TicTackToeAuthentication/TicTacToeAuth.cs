using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using System.Configuration;
using System.Security.Cryptography;

namespace TicTackToeAuthentication
{
    public partial class TicTacToeAuth : Form
    {
        public TicTacToeAuth()
        {
            InitializeComponent();
        }

        int turn = 1;
        int click1 = 0, click2 = 0, click3 = 0, click4 = 0, click5 = 0, click6 = 0, click7 = 0, click8 = 0, click9 = 0;
        int player1 = 0, player2 = 0;
        int ClickCount = 0;
        int SetupClickCount = 0;
        string input = "";

        public void OpenSecret()
        {
            if (ClickCount > 1)
            {
                ShowSecretKey();
            }
        }

        public void ShowSecretKey()
        {
            button1.Enabled = false;
            button1.Hide();
            button2.Enabled = false;
            button2.Hide();
            button3.Enabled = false;
            button3.Hide();
            button4.Enabled = false;
            button4.Hide();
            button5.Enabled = false;
            button5.Hide();
            button6.Enabled = false;
            button6.Hide();
            button7.Enabled = false;
            button7.Hide();
            button8.Enabled = false;
            button8.Hide();
            button9.Enabled = false;
            button9.Hide();
            GroupBoxTicTacToe.Hide();

            button10.Show();
            button11.Show();
            button12.Show();
            button13.Show();
            button14.Show();
            button15.Show();
            button16.Show();
            button17.Show();
            button18.Show();
            UnlockFolder.Show();
        }

        public void ShowSetup()
        {
            

            SetupClickCount++;
            if (SetupClickCount > 1)
            {
                #region EnabledButton
                button1.Enabled = false;
                button1.Hide();
                button2.Enabled = false;
                button2.Hide();
                button3.Enabled = false;
                button3.Hide();
                button4.Enabled = false;
                button4.Hide();
                button5.Enabled = false;
                button5.Hide();
                button6.Enabled = false;
                button6.Hide();
                button7.Enabled = false;
                button7.Hide();
                button8.Enabled = false;
                button8.Hide();
                button9.Enabled = false;
                button9.Hide();
                GroupBoxTicTacToe.Hide();

                button10.Show();
                button11.Show();
                button12.Show();
                button13.Show();
                button14.Show();
                button15.Show();
                button16.Show();
                button17.Show();
                button18.Show();
                #endregion

                UnlockFolder.Hide();
                GroupBoxTicTacToe.Hide();
                AuthenticationSetup.Show();
            }
            
        }

        public void display()
        {
            if (turn % 2 != 0)
            {
                displayturn.Text = "Player 1";
            }
            else
            {
                displayturn.Text = "Player 2";
            }
        }

        public void checkit()
        {
            if (button1.Text != "" && button2.Text != "" && button3.Text != "")
            {
                if (button1.Text == button2.Text && button1.Text == button3.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();
                    }
                    cleargame();

                }
            }
            if (button4.Text != "" && button5.Text != "" && button6.Text != "")
            {
                if (button4.Text == button5.Text && button4.Text == button6.Text)
                {
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    if (button4.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                if (button7.Text == button8.Text && button7.Text == button9.Text)
                {
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button7.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button1.Text != "" && button4.Text != "" && button7.Text != "")
            {
                if (button1.Text == button4.Text && button1.Text == button7.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button4.BackColor = Color.Green;
                    button4.ForeColor = Color.White;
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button2.Text != "" && button5.Text != "" && button8.Text != "")
            {
                if (button2.Text == button5.Text && button2.Text == button8.Text)
                {
                    button2.BackColor = Color.Green;
                    button2.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button8.BackColor = Color.Green;
                    button8.ForeColor = Color.White;
                    if (button2.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button3.Text != "" && button6.Text != "" && button9.Text != "")
            {
                if (button3.Text == button6.Text && button3.Text == button9.Text)
                {
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    button6.BackColor = Color.Green;
                    button6.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button3.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button1.Text != "" && button5.Text != "" && button9.Text != "")
            {
                if (button1.Text == button5.Text && button1.Text == button9.Text)
                {
                    button1.BackColor = Color.Green;
                    button1.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button9.BackColor = Color.Green;
                    button9.ForeColor = Color.White;
                    if (button1.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
            if (button3.Text != "" && button5.Text != "" && button7.Text != "")
            {
                if (button3.Text == button5.Text && button3.Text == button7.Text)
                {
                    button3.BackColor = Color.Green;
                    button3.ForeColor = Color.White;
                    button5.BackColor = Color.Green;
                    button5.ForeColor = Color.White;
                    button7.BackColor = Color.Green;
                    button7.ForeColor = Color.White;
                    if (button3.Text == "X")
                    {
                        MessageBox.Show("Player 1 Wins!");
                        player1++;
                        player1score.Text = player1.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Player 2 Wins!");
                        player2++;
                        player2score.Text = player2.ToString();

                    }
                    cleargame();
                }
            }
        }

        public void cleargame()
        {
            displayturn.Text = "";
            turn = 1;
            click1 = 0; click2 = 0; click3 = 0; click4 = 0; click5 = 0; click6 = 0; click7 = 0; click8 = 0; click9 = 0;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button1.BackColor = Color.Empty;
            button1.ForeColor = Color.Black;
            button1.UseVisualStyleBackColor = true;
            button2.BackColor = Color.Empty;
            button2.ForeColor = Color.Black;
            button2.UseVisualStyleBackColor = true;
            button3.BackColor = Color.Empty;
            button3.ForeColor = Color.Black;
            button3.UseVisualStyleBackColor = true;
            button4.BackColor = Color.Empty;
            button4.ForeColor = Color.Black;
            button4.UseVisualStyleBackColor = true;
            button5.BackColor = Color.Empty;
            button5.ForeColor = Color.Black;
            button5.UseVisualStyleBackColor = true;
            button6.BackColor = Color.Empty;
            button6.ForeColor = Color.Black;
            button6.UseVisualStyleBackColor = true;
            button7.BackColor = Color.Empty;
            button7.ForeColor = Color.Black;
            button7.UseVisualStyleBackColor = true;
            button8.BackColor = Color.Empty;
            button8.ForeColor = Color.Black;
            button8.UseVisualStyleBackColor = true;
            button9.BackColor = Color.Empty;
            button9.ForeColor = Color.Black;
            button9.UseVisualStyleBackColor = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickCount = 0;
            if (click1 == 0)
            {
                if (turn % 2 != 0)
                {
                    button1.Text = "X";
                    click1++;
                }
                else
                {
                    button1.Text = "O";
                    click1++;
                }
                turn++;
            }
            else
            {
                button1.Text = button1.Text;
            }
            display();
            checkit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            ClickCount = 0;
            if (click2 == 0)
            {
                if (turn % 2 != 0)
                {
                    button2.Text = "X";
                    click2++;
                }
                else
                {
                    button2.Text = "O";
                    click2++;
                }
                turn++;
            }
            else
            {
                button2.Text = button2.Text;
            }
            display();
            checkit();
            ShowSetup();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClickCount = 0;
            if (click3 == 0)
            {
                if (turn % 2 != 0)
                {
                    button3.Text = "X";
                    click3++;
                }
                else
                {
                    button3.Text = "O";
                    click3++;
                }
                turn++;
            }
            else
            {
                button3.Text = button3.Text;
            }
            display();
            checkit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClickCount = 0;
            if (click4 == 0)
            {
                if (turn % 2 != 0)
                {
                    button4.Text = "X";
                    click4++;
                }
                else
                {
                    button4.Text = "O";
                    click4++;
                }
                turn++;
            }
            else
            {
                button4.Text = button4.Text;
            }
            display();
            checkit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ClickCount++;
            OpenSecret();
            if (click5 == 0)
            {
                if (turn % 2 != 0)
                {
                    button5.Text = "X";
                    click5++;
                }
                else
                {
                    button5.Text = "O";
                    click5++;
                }
                turn++;
            }
            else
            {
                button5.Text = button5.Text;
            }
            display();
            checkit();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ClickCount = 0;
            if (click6 == 0)
            {
                if (turn % 2 != 0)
                {
                    button6.Text = "X";
                    click6++;
                }
                else
                {
                    button6.Text = "O";
                    click6++;
                }
                turn++;
            }
            else
            {
                button6.Text = button6.Text;
            }
            display();
            checkit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ClickCount = 0;
            if (click7 == 0)
            {
                if (turn % 2 != 0)
                {
                    button7.Text = "X";
                    click7++;
                }
                else
                {
                    button7.Text = "O";
                    click7++;
                }
                turn++;
            }
            else
            {
                button7.Text = button7.Text;
            }
            display();
            checkit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ClickCount = 0;
            if (click8 == 0)
            {
                if (turn % 2 != 0)
                {
                    button8.Text = "X";
                    click8++;
                }
                else
                {
                    button8.Text = "O";
                    click8++;
                }
                turn++;
            }
            else
            {
                button8.Text = button8.Text;
            }
            display();
            checkit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ClickCount = 0;
            if (click9 == 0)
            {
                if (turn % 2 != 0)
                {
                    button9.Text = "X";
                    click9++;
                }
                else
                {
                    button9.Text = "O";
                    click9++;
                }
                turn++;
            }
            else
            {
                button9.Text = button9.Text;
            }
            display();
            checkit();
        }

        private void playagain_Click(object sender, EventArgs e)
        {
            cleargame();
        }

        private void resetgame_Click(object sender, EventArgs e)
        {
            player1score.Text = "";
            player2score.Text = "";
            player1 = 0;
            player2 = 0;
            cleargame();
        }

        private void TicTacToeAuth_Load(object sender, EventArgs e)
        {
            button10.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            button15.Hide(); 
            button16.Hide();
            button17.Hide();
            button18.Hide();
            AuthenticationSetup.Hide();
            UnlockFolder.Hide();
            txtFilePath.Hide();
            button19.Hide();
            LockBtn.Hide();
        }

        private void Locked_Click(object sender, EventArgs e)
        {
            if (txtFilePath.Text.Length > 0)
            {
                try
                {
                    string folderPath = txtFilePath.Text;
                    string adminUserName = Environment.UserName;// getting your adminUserName
                    DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                    FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                    ds.AddAccessRule(fsa);
                    Directory.SetAccessControl(folderPath, ds);
                    MessageBox.Show("Locked");
                }
                catch
                {
                }
            }
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.PINEntry.Text = "";
            SetupClickCount = 0;
            input += "1";
            this.PINEntry.Text = input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.PINEntry.Text = "";
            SetupClickCount = 0;
            input += "2";
            this.PINEntry.Text = input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.PINEntry.Text = "";
            SetupClickCount = 0;
            input += "3";
            this.PINEntry.Text = input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.PINEntry.Text = "";
            SetupClickCount = 0;
            input += "4";
            this.PINEntry.Text = input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.PINEntry.Text = "";
            SetupClickCount = 0;
            input += "5";
            this.PINEntry.Text = input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.PINEntry.Text = "";
            SetupClickCount = 0;
            input += "6";
            this.PINEntry.Text = input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.PINEntry.Text = "";
            SetupClickCount = 0;
            input += "7";
            this.PINEntry.Text = input;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.PINEntry.Text = "";
            SetupClickCount = 0;
            input += "8";
            this.PINEntry.Text = input;
        }

        private void button18_Click(object sender, EventArgs e)
        {     
            this.PINEntry.Text = "";
            SetupClickCount = 0;
            input += "9";
            this.PINEntry.Text = input;
                
        }

        private void Unlocked_Click(object sender, EventArgs e)
        {
            if (ConfigurationSettings.AppSettings["MasterKey"] == SHA1Hash(PINEntry.Text.ToString()))
            {
                if (txtFilePath2.Text.Length > 0)
                {
                    try
                    {
                        string folderPath = txtFilePath2.Text;
                        string adminUserName = Environment.UserName;// getting your adminUserName
                        DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                        FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                        ds.RemoveAccessRule(fsa);
                        Directory.SetAccessControl(folderPath, ds);
                        MessageBox.Show("Unlocked");
                    }
                    catch 
                    {       
                    }
                }
            }
            else
            {
                PINEntry.Clear();
                input = "";
                MessageBox.Show("Wrong PIN Entry","Status");
            }
        }

        private void GiveSetupAccess_Click(object sender, EventArgs e)
        {
            if (ConfigurationSettings.AppSettings["MasterKey"] == SHA1Hash(PINEntry.Text.ToString()))
            {
                txtFilePath.Show();
                button19.Show();
                LockBtn.Show();
            }
            else
            {
                PINEntry.Clear();
                input = "";
                MessageBox.Show("Wrong PIN Entry", "Status");
            }
        }

        private void Browse2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        public static string SHA1Hash(string input)
        {
            HashAlgorithm algorithm = SHA1.Create();
            byte[] hashdata = algorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashdata.Length; i++)
            {
                sb.Append(hashdata[i].ToString("X2"));
            }
            return sb.ToString();
        }

  
    }
}
