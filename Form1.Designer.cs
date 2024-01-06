namespace HexenLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.episodeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.netModeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.skillComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.playersComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.joinRadioButton = new System.Windows.Forms.RadioButton();
            this.hostRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gameComboBox = new System.Windows.Forms.ComboBox();
            this.loadGameComboBox = new System.Windows.Forms.ComboBox();
            this.loadGameCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.debugTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.episodeComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.levelComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.netModeComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.skillComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.playersComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ipTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.joinRadioButton);
            this.groupBox1.Controls.Add(this.hostRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Network";
            // 
            // episodeComboBox
            // 
            this.episodeComboBox.Enabled = false;
            this.episodeComboBox.FormattingEnabled = true;
            this.episodeComboBox.Location = new System.Drawing.Point(409, 46);
            this.episodeComboBox.Name = "episodeComboBox";
            this.episodeComboBox.Size = new System.Drawing.Size(58, 21);
            this.episodeComboBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Episode";
            // 
            // levelComboBox
            // 
            this.levelComboBox.Enabled = false;
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Location = new System.Drawing.Point(512, 46);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(58, 21);
            this.levelComboBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Level";
            // 
            // netModeComboBox
            // 
            this.netModeComboBox.FormattingEnabled = true;
            this.netModeComboBox.Items.AddRange(new object[] {
            "0",
            "1"});
            this.netModeComboBox.Location = new System.Drawing.Point(294, 46);
            this.netModeComboBox.Name = "netModeComboBox";
            this.netModeComboBox.Size = new System.Drawing.Size(58, 21);
            this.netModeComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Net Mode";
            // 
            // skillComboBox
            // 
            this.skillComboBox.FormattingEnabled = true;
            this.skillComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.skillComboBox.Location = new System.Drawing.Point(170, 46);
            this.skillComboBox.Name = "skillComboBox";
            this.skillComboBox.Size = new System.Drawing.Size(58, 21);
            this.skillComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Skill";
            // 
            // playersComboBox
            // 
            this.playersComboBox.FormattingEnabled = true;
            this.playersComboBox.Location = new System.Drawing.Point(74, 47);
            this.playersComboBox.Name = "playersComboBox";
            this.playersComboBox.Size = new System.Drawing.Size(58, 21);
            this.playersComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº Players";
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(599, 46);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // joinRadioButton
            // 
            this.joinRadioButton.AutoSize = true;
            this.joinRadioButton.Location = new System.Drawing.Point(65, 19);
            this.joinRadioButton.Name = "joinRadioButton";
            this.joinRadioButton.Size = new System.Drawing.Size(44, 17);
            this.joinRadioButton.TabIndex = 1;
            this.joinRadioButton.Text = "Join";
            this.joinRadioButton.UseVisualStyleBackColor = true;
            this.joinRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // hostRadioButton
            // 
            this.hostRadioButton.AutoSize = true;
            this.hostRadioButton.Location = new System.Drawing.Point(12, 19);
            this.hostRadioButton.Name = "hostRadioButton";
            this.hostRadioButton.Size = new System.Drawing.Size(47, 17);
            this.hostRadioButton.TabIndex = 0;
            this.hostRadioButton.Text = "Host";
            this.hostRadioButton.UseVisualStyleBackColor = true;
            this.hostRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.gameComboBox);
            this.groupBox2.Controls.Add(this.loadGameComboBox);
            this.groupBox2.Controls.Add(this.loadGameCheckBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Misc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Game";
            // 
            // gameComboBox
            // 
            this.gameComboBox.FormattingEnabled = true;
            this.gameComboBox.Items.AddRange(new object[] {
            "hexen.hexen",
            "heretic.shadow",
            "doom.id.doom1.ultimate",
            "rekkr",
            "strife.strife"});
            this.gameComboBox.Location = new System.Drawing.Point(53, 17);
            this.gameComboBox.Name = "gameComboBox";
            this.gameComboBox.Size = new System.Drawing.Size(121, 21);
            this.gameComboBox.TabIndex = 4;
            this.gameComboBox.SelectedIndexChanged += new System.EventHandler(this.gameComboBox_SelectedIndexChanged);
            // 
            // loadGameComboBox
            // 
            this.loadGameComboBox.Enabled = false;
            this.loadGameComboBox.FormattingEnabled = true;
            this.loadGameComboBox.Location = new System.Drawing.Point(265, 17);
            this.loadGameComboBox.Name = "loadGameComboBox";
            this.loadGameComboBox.Size = new System.Drawing.Size(121, 21);
            this.loadGameComboBox.TabIndex = 3;
            // 
            // loadGameCheckBox
            // 
            this.loadGameCheckBox.AutoSize = true;
            this.loadGameCheckBox.Location = new System.Drawing.Point(180, 19);
            this.loadGameCheckBox.Name = "loadGameCheckBox";
            this.loadGameCheckBox.Size = new System.Drawing.Size(79, 17);
            this.loadGameCheckBox.TabIndex = 2;
            this.loadGameCheckBox.Text = "Load game";
            this.loadGameCheckBox.UseVisualStyleBackColor = true;
            this.loadGameCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(714, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // debugTextBox
            // 
            this.debugTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.debugTextBox.Location = new System.Drawing.Point(0, 141);
            this.debugTextBox.Name = "debugTextBox";
            this.debugTextBox.Size = new System.Drawing.Size(714, 20);
            this.debugTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 192);
            this.Controls.Add(this.debugTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexen Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton joinRadioButton;
        private System.Windows.Forms.RadioButton hostRadioButton;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox loadGameComboBox;
        private System.Windows.Forms.CheckBox loadGameCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox playersComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox skillComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox netModeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox debugTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox gameComboBox;
        private System.Windows.Forms.ComboBox episodeComboBox;
        private System.Windows.Forms.Label label7;
    }
}

