namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool playerO = true;
        int move = 0;

        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.whoPlayedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultO = new System.Windows.Forms.Label();
            this.resultX = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(35, 52);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 150);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(191, 52);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 150);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn3.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(347, 52);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 150);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn4.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(35, 208);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 150);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn5.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(191, 208);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(150, 150);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn6.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(347, 208);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(150, 150);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn7.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(35, 364);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(150, 150);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn8.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(191, 364);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(150, 150);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn9.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(347, 364);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(150, 150);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(504, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ruch gracza:";
            // 
            // whoPlayedLabel
            // 
            this.whoPlayedLabel.AutoSize = true;
            this.whoPlayedLabel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.whoPlayedLabel.Location = new System.Drawing.Point(725, 52);
            this.whoPlayedLabel.Name = "whoPlayedLabel";
            this.whoPlayedLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.whoPlayedLabel.Size = new System.Drawing.Size(46, 50);
            this.whoPlayedLabel.TabIndex = 10;
            this.whoPlayedLabel.Text = "O";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(630, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 47);
            this.label2.TabIndex = 11;
            this.label2.Text = "WYNIK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(560, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 47);
            this.label3.TabIndex = 12;
            this.label3.Text = "O:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(755, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 47);
            this.label4.TabIndex = 13;
            this.label4.Text = "X:";
            // 
            // resultO
            // 
            this.resultO.AutoSize = true;
            this.resultO.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultO.Location = new System.Drawing.Point(609, 327);
            this.resultO.Name = "resultO";
            this.resultO.Size = new System.Drawing.Size(39, 47);
            this.resultO.TabIndex = 14;
            this.resultO.Text = "0";
            // 
            // resultX
            // 
            this.resultX.AutoSize = true;
            this.resultX.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultX.Location = new System.Drawing.Point(810, 327);
            this.resultX.Name = "resultX";
            this.resultX.Size = new System.Drawing.Size(39, 47);
            this.resultX.TabIndex = 15;
            this.resultX.Text = "0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewGame.Location = new System.Drawing.Point(548, 453);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(301, 61);
            this.btnNewGame.TabIndex = 16;
            this.btnNewGame.Text = "Nowa Gra";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.resultX);
            this.Controls.Add(this.resultO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.whoPlayedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NewGame();
            resultO.Text = "0";
            resultX.Text = "0";
            whoPlayedLabel.Text = "O";
            playerO = true;
        }

        private void NewGame()
        {
            move = 0;
            Button[] allButtons = new Button[9];
            allButtons[0] = btn1;
            allButtons[1] = btn2;
            allButtons[2] = btn3;
            allButtons[3] = btn4;
            allButtons[4] = btn5;
            allButtons[5] = btn6;
            allButtons[6] = btn7;
            allButtons[7] = btn8;
            allButtons[8] = btn9;

            foreach (Button button in allButtons)
            {
                button.Enabled = true;
                button.Text = "";
                button.BackColor = System.Drawing.Color.Empty;
            }
        }

        private void Check()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                btn1.BackColor = System.Drawing.Color.Green;
                btn2.BackColor = System.Drawing.Color.Green;
                btn3.BackColor = System.Drawing.Color.Green;
                Won();
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text)
            {
                btn4.BackColor = System.Drawing.Color.Green;
                btn5.BackColor = System.Drawing.Color.Green;
                btn6.BackColor = System.Drawing.Color.Green;
                Won();
            }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text)
            {
                btn7.BackColor = System.Drawing.Color.Green;
                btn8.BackColor = System.Drawing.Color.Green;
                btn9.BackColor = System.Drawing.Color.Green;
                Won();
            }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            {
                btn1.BackColor = System.Drawing.Color.Green;
                btn4.BackColor = System.Drawing.Color.Green;
                btn7.BackColor = System.Drawing.Color.Green;
                Won();
            }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text)
            {
                btn2.BackColor = System.Drawing.Color.Green;
                btn5.BackColor = System.Drawing.Color.Green;
                btn8.BackColor = System.Drawing.Color.Green;
                Won();
            }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text)
            {
                btn3.BackColor = System.Drawing.Color.Green;
                btn6.BackColor = System.Drawing.Color.Green;
                btn9.BackColor = System.Drawing.Color.Green;
                Won();
            }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text)
            {
                btn1.BackColor = System.Drawing.Color.Green;
                btn5.BackColor = System.Drawing.Color.Green;
                btn9.BackColor = System.Drawing.Color.Green;
                Won();
            }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text)
            {
                btn3.BackColor = System.Drawing.Color.Green;
                btn5.BackColor = System.Drawing.Color.Green;
                btn7.BackColor = System.Drawing.Color.Green;
                Won();
            }
            else if (move == 9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NewGame();
            }
        }

        private void Won()
        {
            MessageBox.Show("Wygrywa gracz: " + (playerO ? "O" : "X"), "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (playerO)
                resultO.Text = ((int.Parse(resultO.Text)) + 1).ToString();
            else
                resultX.Text = ((int.Parse(resultX.Text)) + 1).ToString();
            NewGame();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = playerO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if(move >= 5)
            {
                Check();
            }
            playerO = !playerO;
            whoPlayedLabel.Text = playerO ? "O" : "X";
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = playerO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                Check();
            }
            playerO = !playerO;
            whoPlayedLabel.Text = playerO ? "O" : "X";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = playerO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                Check();
            }
            playerO = !playerO;
            whoPlayedLabel.Text = playerO ? "O" : "X";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = playerO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                Check();
            }
            playerO = !playerO;
            whoPlayedLabel.Text = playerO ? "O" : "X";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = playerO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                Check();
            }
            playerO = !playerO;
            whoPlayedLabel.Text = playerO ? "O" : "X";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = playerO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                Check();
            }
            playerO = !playerO;
            whoPlayedLabel.Text = playerO ? "O" : "X";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = playerO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                Check();
            }
            playerO = !playerO;
            whoPlayedLabel.Text = playerO ? "O" : "X";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = playerO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                Check();
            }
            playerO = !playerO;
            whoPlayedLabel.Text = playerO ? "O" : "X";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = playerO ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                Check();
            }
            playerO = !playerO;
            whoPlayedLabel.Text = playerO ? "O" : "X";
        }
    }
}