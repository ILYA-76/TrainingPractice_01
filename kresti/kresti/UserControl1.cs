using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Security;
namespace AppCSharp
    {
        public partial class UserControl1 : UserControl
        {
            private int score1 = 0, score2 = 0;
            private int z = 1;
            private int x = 12, y = 12;
            private Button[,] buttons = new Button[3, 3];
            private int player;
            public UserControl1()
            {
                InitializeComponent();
                this.Height = 850;
                this.Width = 1050;
                player = 1;
                label1.Text = ($"Текущий ход: Игрок {z}");
                label2.Text = ($"Игрок 1 побед: {score1}");
                label3.Text = ($"Игрок 2 побед: {score2}");
            for (int i = 0; i < buttons.Length / 3; i++)
                {
                    for (int j = 0; j < buttons.Length / 3; j++)
                    {
                        buttons[i, j] = new Button();
                        buttons[i, j].Size = new Size(250, 250);
                    }
                }
                setButtons();

            }

            private void setButtons()
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        buttons[i, j].Location = new Point(12 + 248 * j, 12 + 248 * i);
                        buttons[i, j].Click += button1_Click;
                        buttons[i, j].Font = new Font(new FontFamily("Microsoft Sans Serif"), 138);
                        buttons[i, j].Text = "";
                        this.Controls.Add(buttons[i, j]);
                    }
                }
            }

            private void button1_Click(object sender, EventArgs e)
            {
                switch (player)
                {
                    case 1:
                        sender.GetType().GetProperty("Text").SetValue(sender, "x");
                        player = 0;
                        z = 1;
                        label1.Text = ($"Текущий ход: Игрок 2");
                        break;
                    case 0:
                        sender.GetType().GetProperty("Text").SetValue(sender, "o");
                        player = 1;
                        z = 2;
                        label1.Text = ($"Текущий ход: Игрок 1");
                        break;
                }
                sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                checkWin();
            }
            private void checkWin()
            {

                if (buttons[0, 0].Text == buttons[0, 1].Text && buttons[0, 1].Text == buttons[0, 2].Text)
                {
                    if (buttons[0, 0].Text != "")
                    {
                        MessageBox.Show($"Победил игрок {z}");
                    Scores(); 
                    return;
                    }
                }
                if (buttons[1, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[1, 2].Text)
                {
                    if (buttons[1, 0].Text != "")
                {
                    MessageBox.Show($"Победил игрок {z}");
                    Scores(); 
                    return;
                }
            }
                if (buttons[2, 0].Text == buttons[2, 1].Text && buttons[2, 1].Text == buttons[2, 2].Text)
                {
                    if (buttons[2, 0].Text != "")
                {
                    MessageBox.Show($"Победил игрок {z}");
                    Scores();
                    return;
                }
            }
                if (buttons[0, 0].Text == buttons[1, 0].Text && buttons[1, 0].Text == buttons[2, 0].Text)
                {
                    if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show($"Победил игрок {z}");
                    Scores(); 
                    return;
                }
            }
                if (buttons[0, 1].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 1].Text)
                {
                    if (buttons[0, 1].Text != "")
                {
                    MessageBox.Show($"Победил игрок {z}");
                    Scores(); 
                    return;
                }
            }
                if (buttons[0, 2].Text == buttons[1, 2].Text && buttons[1, 2].Text == buttons[2, 2].Text)
                {
                    if (buttons[0, 2].Text != "")
                {
                    MessageBox.Show($"Победил игрок {z}");
                    Scores(); 
                    return;
                }
            }
                if (buttons[0, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[2, 2].Text)
                {
                    if (buttons[0, 0].Text != "")
                {
                    MessageBox.Show($"Победил игрок {z}");
                    Scores(); 
                    return;
                }
            }
                if (buttons[2, 0].Text == buttons[1, 1].Text && buttons[1, 1].Text == buttons[0, 2].Text)
                {
                    if (buttons[2, 0].Text != "")
                {
                    MessageBox.Show($"Победил игрок {z}");
                    Scores();

                    return;
                }
            }

            }
        public void End(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (buttons[i, j].Text == "")
                        sender.GetType().GetProperty("Enabled").SetValue(sender, false);
                }
            }



        }
        private void Scores()
        {
            if (z == 1)
                score1 += 1;
            if (z == 2)
                score2 += 1;
            label2.Text = ($"Игрок 1 побед: {score1}");
            label3.Text = ($"Игрок 2 побед: {score2}");
          
        }
           
        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    buttons[i, j].Text = "";
                    buttons[i, j].Enabled = true;

                }
            }

            player = 1;
            label1.Text = ($"Текущий ход: Игрок 1");
        }
       


    }
    }