namespace gui_lucky_seven
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_spin = new System.Windows.Forms.Button();
            this.slot1 = new System.Windows.Forms.PictureBox();
            this.slot2 = new System.Windows.Forms.PictureBox();
            this.slot3 = new System.Windows.Forms.PictureBox();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.button_undo = new System.Windows.Forms.Button();
            this.button_insertMoney = new System.Windows.Forms.Button();
            this.button_withdraw = new System.Windows.Forms.Button();
            this.label_introduction = new System.Windows.Forms.Label();
            this.label_subIntro = new System.Windows.Forms.Label();
            this.button_addWallet = new System.Windows.Forms.Button();
            this.label_userWallet = new System.Windows.Forms.Label();
            this.label_slotBalance = new System.Windows.Forms.Label();
            this.label_creditsAmount = new System.Windows.Forms.Label();
            this.label_winAmount = new System.Windows.Forms.Label();
            this.label_betAmount = new System.Windows.Forms.Label();
            this.label_BALANCE = new System.Windows.Forms.Label();
            this.label_CREDITS = new System.Windows.Forms.Label();
            this.label_BET = new System.Windows.Forms.Label();
            this.label_WIN = new System.Windows.Forms.Label();
            this.label_calculation = new System.Windows.Forms.Label();
            this.label_help = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_spin
            // 
            this.button_spin.BackColor = System.Drawing.Color.Transparent;
            this.button_spin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_spin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_spin.FlatAppearance.BorderSize = 0;
            this.button_spin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_spin.ForeColor = System.Drawing.Color.White;
            this.button_spin.Location = new System.Drawing.Point(737, 163);
            this.button_spin.Name = "button_spin";
            this.button_spin.Size = new System.Drawing.Size(46, 51);
            this.button_spin.TabIndex = 0;
            this.button_spin.Text = "L";
            this.button_spin.UseVisualStyleBackColor = false;
            this.button_spin.Click += new System.EventHandler(this.button1_Click);
            // 
            // slot1
            // 
            this.slot1.BackColor = System.Drawing.Color.Transparent;
            this.slot1.Location = new System.Drawing.Point(382, 251);
            this.slot1.Name = "slot1";
            this.slot1.Size = new System.Drawing.Size(73, 73);
            this.slot1.TabIndex = 1;
            this.slot1.TabStop = false;
            // 
            // slot2
            // 
            this.slot2.BackColor = System.Drawing.Color.Transparent;
            this.slot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.slot2.Location = new System.Drawing.Point(480, 251);
            this.slot2.Name = "slot2";
            this.slot2.Size = new System.Drawing.Size(73, 73);
            this.slot2.TabIndex = 2;
            this.slot2.TabStop = false;
            // 
            // slot3
            // 
            this.slot3.BackColor = System.Drawing.Color.Transparent;
            this.slot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.slot3.Location = new System.Drawing.Point(576, 251);
            this.slot3.Name = "slot3";
            this.slot3.Size = new System.Drawing.Size(73, 73);
            this.slot3.TabIndex = 3;
            this.slot3.TabStop = false;
            // 
            // button_left
            // 
            this.button_left.BackColor = System.Drawing.Color.Transparent;
            this.button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_left.FlatAppearance.BorderSize = 0;
            this.button_left.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_left.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_left.ForeColor = System.Drawing.Color.Black;
            this.button_left.Location = new System.Drawing.Point(339, 387);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(30, 25);
            this.button_left.TabIndex = 4;
            this.button_left.Text = "<";
            this.button_left.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_left.UseVisualStyleBackColor = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.BackColor = System.Drawing.Color.Transparent;
            this.button_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_right.FlatAppearance.BorderSize = 0;
            this.button_right.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_right.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_right.ForeColor = System.Drawing.Color.Black;
            this.button_right.Location = new System.Drawing.Point(386, 387);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(30, 25);
            this.button_right.TabIndex = 5;
            this.button_right.Text = ">";
            this.button_right.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_right.UseVisualStyleBackColor = false;
            this.button_right.Click += new System.EventHandler(this.button_right_Click_1);
            // 
            // button_up
            // 
            this.button_up.BackColor = System.Drawing.Color.Transparent;
            this.button_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_up.FlatAppearance.BorderSize = 0;
            this.button_up.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_up.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_up.ForeColor = System.Drawing.Color.White;
            this.button_up.Location = new System.Drawing.Point(437, 387);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(30, 25);
            this.button_up.TabIndex = 6;
            this.button_up.Text = "_";
            this.button_up.UseVisualStyleBackColor = false;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // button_select
            // 
            this.button_select.BackColor = System.Drawing.Color.Transparent;
            this.button_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_select.FlatAppearance.BorderSize = 0;
            this.button_select.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_select.ForeColor = System.Drawing.Color.Black;
            this.button_select.Location = new System.Drawing.Point(496, 360);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(38, 42);
            this.button_select.TabIndex = 7;
            this.button_select.Text = "G";
            this.button_select.UseVisualStyleBackColor = false;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_undo
            // 
            this.button_undo.BackColor = System.Drawing.Color.Transparent;
            this.button_undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_undo.FlatAppearance.BorderSize = 0;
            this.button_undo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_undo.ForeColor = System.Drawing.Color.Transparent;
            this.button_undo.Location = new System.Drawing.Point(564, 387);
            this.button_undo.Name = "button_undo";
            this.button_undo.Size = new System.Drawing.Size(30, 25);
            this.button_undo.TabIndex = 8;
            this.button_undo.Text = "U";
            this.button_undo.UseVisualStyleBackColor = false;
            this.button_undo.Click += new System.EventHandler(this.button_undo_Click);
            // 
            // button_insertMoney
            // 
            this.button_insertMoney.BackColor = System.Drawing.Color.Transparent;
            this.button_insertMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_insertMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_insertMoney.FlatAppearance.BorderSize = 0;
            this.button_insertMoney.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_insertMoney.ForeColor = System.Drawing.Color.Transparent;
            this.button_insertMoney.Location = new System.Drawing.Point(621, 433);
            this.button_insertMoney.Name = "button_insertMoney";
            this.button_insertMoney.Size = new System.Drawing.Size(72, 40);
            this.button_insertMoney.TabIndex = 9;
            this.button_insertMoney.Text = "I";
            this.button_insertMoney.UseVisualStyleBackColor = false;
            this.button_insertMoney.Click += new System.EventHandler(this.button_insertMoney_Click);
            // 
            // button_withdraw
            // 
            this.button_withdraw.BackColor = System.Drawing.Color.Transparent;
            this.button_withdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_withdraw.FlatAppearance.BorderSize = 0;
            this.button_withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_withdraw.ForeColor = System.Drawing.Color.Transparent;
            this.button_withdraw.Location = new System.Drawing.Point(585, 697);
            this.button_withdraw.Name = "button_withdraw";
            this.button_withdraw.Size = new System.Drawing.Size(82, 34);
            this.button_withdraw.TabIndex = 10;
            this.button_withdraw.Text = "W";
            this.button_withdraw.UseVisualStyleBackColor = false;
            this.button_withdraw.Click += new System.EventHandler(this.button_withdraw_Click);
            // 
            // label_introduction
            // 
            this.label_introduction.AutoSize = true;
            this.label_introduction.BackColor = System.Drawing.Color.Transparent;
            this.label_introduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_introduction.Font = new System.Drawing.Font("Miriam Libre", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_introduction.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_introduction.Location = new System.Drawing.Point(338, 91);
            this.label_introduction.Name = "label_introduction";
            this.label_introduction.Size = new System.Drawing.Size(53, 62);
            this.label_introduction.TabIndex = 11;
            this.label_introduction.Text = "_";
            // 
            // label_subIntro
            // 
            this.label_subIntro.AutoSize = true;
            this.label_subIntro.BackColor = System.Drawing.Color.Transparent;
            this.label_subIntro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_subIntro.Font = new System.Drawing.Font("Miriam Libre", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subIntro.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_subIntro.Location = new System.Drawing.Point(399, 148);
            this.label_subIntro.Name = "label_subIntro";
            this.label_subIntro.Size = new System.Drawing.Size(23, 26);
            this.label_subIntro.TabIndex = 12;
            this.label_subIntro.Text = "_";
            this.label_subIntro.Click += new System.EventHandler(this.label_subIntro_Click);
            // 
            // button_addWallet
            // 
            this.button_addWallet.BackColor = System.Drawing.Color.LimeGreen;
            this.button_addWallet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_addWallet.BackgroundImage")));
            this.button_addWallet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_addWallet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addWallet.FlatAppearance.BorderSize = 0;
            this.button_addWallet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_addWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addWallet.ForeColor = System.Drawing.SystemColors.GrayText;
            this.button_addWallet.Image = ((System.Drawing.Image)(resources.GetObject("button_addWallet.Image")));
            this.button_addWallet.Location = new System.Drawing.Point(12, 12);
            this.button_addWallet.Name = "button_addWallet";
            this.button_addWallet.Size = new System.Drawing.Size(32, 35);
            this.button_addWallet.TabIndex = 14;
            this.button_addWallet.UseVisualStyleBackColor = false;
            this.button_addWallet.Click += new System.EventHandler(this.button_addWallet_Click);
            // 
            // label_userWallet
            // 
            this.label_userWallet.AutoSize = true;
            this.label_userWallet.BackColor = System.Drawing.Color.Black;
            this.label_userWallet.Font = new System.Drawing.Font("Miriam Libre", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_userWallet.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_userWallet.Location = new System.Drawing.Point(44, 12);
            this.label_userWallet.Name = "label_userWallet";
            this.label_userWallet.Size = new System.Drawing.Size(30, 35);
            this.label_userWallet.TabIndex = 15;
            this.label_userWallet.Text = "_";
            this.label_userWallet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_userWallet.Click += new System.EventHandler(this.label_userWallet_Click);
            // 
            // label_slotBalance
            // 
            this.label_slotBalance.AutoSize = true;
            this.label_slotBalance.BackColor = System.Drawing.Color.Transparent;
            this.label_slotBalance.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_slotBalance.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_slotBalance.Location = new System.Drawing.Point(372, 158);
            this.label_slotBalance.Name = "label_slotBalance";
            this.label_slotBalance.Size = new System.Drawing.Size(19, 21);
            this.label_slotBalance.TabIndex = 16;
            this.label_slotBalance.Text = "_";
            this.label_slotBalance.Click += new System.EventHandler(this.label_slotBalance_Click);
            // 
            // label_creditsAmount
            // 
            this.label_creditsAmount.AutoSize = true;
            this.label_creditsAmount.BackColor = System.Drawing.Color.Transparent;
            this.label_creditsAmount.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_creditsAmount.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_creditsAmount.Location = new System.Drawing.Point(459, 158);
            this.label_creditsAmount.Name = "label_creditsAmount";
            this.label_creditsAmount.Size = new System.Drawing.Size(19, 21);
            this.label_creditsAmount.TabIndex = 17;
            this.label_creditsAmount.Text = "_";
            this.label_creditsAmount.Click += new System.EventHandler(this.label_betAmount_Click);
            // 
            // label_winAmount
            // 
            this.label_winAmount.AutoSize = true;
            this.label_winAmount.BackColor = System.Drawing.Color.Transparent;
            this.label_winAmount.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_winAmount.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_winAmount.Location = new System.Drawing.Point(631, 158);
            this.label_winAmount.Name = "label_winAmount";
            this.label_winAmount.Size = new System.Drawing.Size(19, 21);
            this.label_winAmount.TabIndex = 18;
            this.label_winAmount.Text = "_";
            // 
            // label_betAmount
            // 
            this.label_betAmount.AutoSize = true;
            this.label_betAmount.BackColor = System.Drawing.Color.Transparent;
            this.label_betAmount.Font = new System.Drawing.Font("Miriam Libre", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_betAmount.ForeColor = System.Drawing.Color.LimeGreen;
            this.label_betAmount.Location = new System.Drawing.Point(543, 158);
            this.label_betAmount.Name = "label_betAmount";
            this.label_betAmount.Size = new System.Drawing.Size(19, 21);
            this.label_betAmount.TabIndex = 19;
            this.label_betAmount.Text = "_";
            this.label_betAmount.Click += new System.EventHandler(this.label_betAmount_Click_1);
            // 
            // label_BALANCE
            // 
            this.label_BALANCE.AutoSize = true;
            this.label_BALANCE.BackColor = System.Drawing.Color.Transparent;
            this.label_BALANCE.Font = new System.Drawing.Font("Miriam Libre", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BALANCE.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_BALANCE.Location = new System.Drawing.Point(372, 179);
            this.label_BALANCE.Name = "label_BALANCE";
            this.label_BALANCE.Size = new System.Drawing.Size(49, 14);
            this.label_BALANCE.TabIndex = 20;
            this.label_BALANCE.Text = "balance";
            // 
            // label_CREDITS
            // 
            this.label_CREDITS.AutoSize = true;
            this.label_CREDITS.BackColor = System.Drawing.Color.Transparent;
            this.label_CREDITS.Font = new System.Drawing.Font("Miriam Libre", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CREDITS.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_CREDITS.Location = new System.Drawing.Point(459, 179);
            this.label_CREDITS.Name = "label_CREDITS";
            this.label_CREDITS.Size = new System.Drawing.Size(47, 14);
            this.label_CREDITS.TabIndex = 21;
            this.label_CREDITS.Text = "credits";
            // 
            // label_BET
            // 
            this.label_BET.AutoSize = true;
            this.label_BET.BackColor = System.Drawing.Color.Transparent;
            this.label_BET.Font = new System.Drawing.Font("Miriam Libre", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BET.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_BET.Location = new System.Drawing.Point(543, 179);
            this.label_BET.Name = "label_BET";
            this.label_BET.Size = new System.Drawing.Size(25, 14);
            this.label_BET.TabIndex = 22;
            this.label_BET.Text = "bet";
            // 
            // label_WIN
            // 
            this.label_WIN.AutoSize = true;
            this.label_WIN.BackColor = System.Drawing.Color.Transparent;
            this.label_WIN.Font = new System.Drawing.Font("Miriam Libre", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WIN.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_WIN.Location = new System.Drawing.Point(631, 179);
            this.label_WIN.Name = "label_WIN";
            this.label_WIN.Size = new System.Drawing.Size(28, 14);
            this.label_WIN.TabIndex = 23;
            this.label_WIN.Text = "win";
            // 
            // label_calculation
            // 
            this.label_calculation.AutoSize = true;
            this.label_calculation.BackColor = System.Drawing.Color.Transparent;
            this.label_calculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_calculation.Font = new System.Drawing.Font("Miriam Libre", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calculation.ForeColor = System.Drawing.Color.Yellow;
            this.label_calculation.Location = new System.Drawing.Point(346, 179);
            this.label_calculation.Name = "label_calculation";
            this.label_calculation.Size = new System.Drawing.Size(13, 14);
            this.label_calculation.TabIndex = 24;
            this.label_calculation.Text = "_";
            // 
            // label_help
            // 
            this.label_help.AutoSize = true;
            this.label_help.BackColor = System.Drawing.Color.Black;
            this.label_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_help.Font = new System.Drawing.Font("Miriam Libre", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_help.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_help.Location = new System.Drawing.Point(12, 237);
            this.label_help.Name = "label_help";
            this.label_help.Size = new System.Drawing.Size(16, 18);
            this.label_help.TabIndex = 25;
            this.label_help.Text = "_";
            this.label_help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1034, 861);
            this.Controls.Add(this.label_help);
            this.Controls.Add(this.label_calculation);
            this.Controls.Add(this.label_WIN);
            this.Controls.Add(this.label_BET);
            this.Controls.Add(this.label_CREDITS);
            this.Controls.Add(this.label_BALANCE);
            this.Controls.Add(this.label_betAmount);
            this.Controls.Add(this.label_winAmount);
            this.Controls.Add(this.label_creditsAmount);
            this.Controls.Add(this.label_slotBalance);
            this.Controls.Add(this.label_userWallet);
            this.Controls.Add(this.button_addWallet);
            this.Controls.Add(this.label_subIntro);
            this.Controls.Add(this.label_introduction);
            this.Controls.Add(this.button_withdraw);
            this.Controls.Add(this.button_insertMoney);
            this.Controls.Add(this.button_undo);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.button_up);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.slot2);
            this.Controls.Add(this.slot1);
            this.Controls.Add(this.button_spin);
            this.Controls.Add(this.slot3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Slot Machine (Lucky 7)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slot3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_spin;
        private System.Windows.Forms.PictureBox slot1;
        private System.Windows.Forms.PictureBox slot2;
        private System.Windows.Forms.PictureBox slot3;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_undo;
        private System.Windows.Forms.Button button_insertMoney;
        private System.Windows.Forms.Button button_withdraw;
        private System.Windows.Forms.Label label_introduction;
        private System.Windows.Forms.Label label_subIntro;
        private System.Windows.Forms.Button button_addWallet;
        private System.Windows.Forms.Label label_userWallet;
        private System.Windows.Forms.Label label_slotBalance;
        private System.Windows.Forms.Label label_creditsAmount;
        private System.Windows.Forms.Label label_winAmount;
        private System.Windows.Forms.Label label_betAmount;
        private System.Windows.Forms.Label label_BALANCE;
        private System.Windows.Forms.Label label_CREDITS;
        private System.Windows.Forms.Label label_BET;
        private System.Windows.Forms.Label label_WIN;
        private System.Windows.Forms.Label label_calculation;
        private System.Windows.Forms.Label label_help;
    }
}

