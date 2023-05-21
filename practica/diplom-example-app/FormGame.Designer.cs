namespace diplom_example_app
{
    partial class FormGame
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
            this.groupBoxComponents = new System.Windows.Forms.GroupBox();
            this.listViewGamePlayers = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBoxMasterName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewGames = new System.Windows.Forms.ListView();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.игрокиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelPLayerName = new System.Windows.Forms.Label();
            this.comboBoxPlayers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDeleteGame = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEditGame = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownScore = new System.Windows.Forms.NumericUpDown();
            this.buttonEditPlayer = new System.Windows.Forms.Button();
            this.buttonDeletePlayer = new System.Windows.Forms.Button();
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.buttonSavePlayer = new System.Windows.Forms.Button();
            this.dateTimePickerDeath = new System.Windows.Forms.DateTimePicker();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonSerealize = new System.Windows.Forms.Button();
            this.buttonDeserealize = new System.Windows.Forms.Button();
            this.groupBoxComponents.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxComponents
            // 
            this.groupBoxComponents.Controls.Add(this.listViewGamePlayers);
            this.groupBoxComponents.Controls.Add(this.btnDelete);
            this.groupBoxComponents.Location = new System.Drawing.Point(51, 228);
            this.groupBoxComponents.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxComponents.Name = "groupBoxComponents";
            this.groupBoxComponents.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxComponents.Size = new System.Drawing.Size(381, 257);
            this.groupBoxComponents.TabIndex = 19;
            this.groupBoxComponents.TabStop = false;
            this.groupBoxComponents.Text = "Игроки";
            // 
            // listViewGamePlayers
            // 
            this.listViewGamePlayers.HideSelection = false;
            this.listViewGamePlayers.Location = new System.Drawing.Point(29, 45);
            this.listViewGamePlayers.Name = "listViewGamePlayers";
            this.listViewGamePlayers.Size = new System.Drawing.Size(345, 123);
            this.listViewGamePlayers.TabIndex = 39;
            this.listViewGamePlayers.UseCompatibleStateImageBehavior = false;
            this.listViewGamePlayers.View = System.Windows.Forms.View.List;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(29, 185);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(352, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Удалить выбранного игрока из списка игры";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBoxMasterName
            // 
            this.textBoxMasterName.Location = new System.Drawing.Point(142, 78);
            this.textBoxMasterName.Name = "textBoxMasterName";
            this.textBoxMasterName.Size = new System.Drawing.Size(290, 22);
            this.textBoxMasterName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ведущий";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(54, 502);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(378, 52);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(142, 133);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(290, 22);
            this.dateTimePickerDate.TabIndex = 14;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(229, -38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(427, 22);
            this.textBoxName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Дата";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, -32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // listViewGames
            // 
            this.listViewGames.HideSelection = false;
            this.listViewGames.Location = new System.Drawing.Point(476, 21);
            this.listViewGames.Name = "listViewGames";
            this.listViewGames.Size = new System.Drawing.Size(250, 267);
            this.listViewGames.TabIndex = 20;
            this.listViewGames.UseCompatibleStateImageBehavior = false;
            this.listViewGames.View = System.Windows.Forms.View.List;
            this.listViewGames.SelectedIndexChanged += new System.EventHandler(this.listViewGames_SelectedIndexChanged);
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Location = new System.Drawing.Point(142, 23);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(290, 22);
            this.textBoxGameName.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Название";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игрокиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1427, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // игрокиToolStripMenuItem
            // 
            this.игрокиToolStripMenuItem.Name = "игрокиToolStripMenuItem";
            this.игрокиToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.игрокиToolStripMenuItem.Text = "Игроки";
            this.игрокиToolStripMenuItem.Click += new System.EventHandler(this.игрокиToolStripMenuItem_Click);
            // 
            // labelPLayerName
            // 
            this.labelPLayerName.AutoSize = true;
            this.labelPLayerName.Location = new System.Drawing.Point(51, 183);
            this.labelPLayerName.Name = "labelPLayerName";
            this.labelPLayerName.Size = new System.Drawing.Size(46, 16);
            this.labelPLayerName.TabIndex = 24;
            this.labelPLayerName.Text = "Игрок";
            // 
            // comboBoxPlayers
            // 
            this.comboBoxPlayers.FormattingEnabled = true;
            this.comboBoxPlayers.Location = new System.Drawing.Point(154, 183);
            this.comboBoxPlayers.Name = "comboBoxPlayers";
            this.comboBoxPlayers.Size = new System.Drawing.Size(278, 24);
            this.comboBoxPlayers.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Добавить игрока";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDeleteGame
            // 
            this.buttonDeleteGame.Location = new System.Drawing.Point(476, 317);
            this.buttonDeleteGame.Name = "buttonDeleteGame";
            this.buttonDeleteGame.Size = new System.Drawing.Size(256, 48);
            this.buttonDeleteGame.TabIndex = 27;
            this.buttonDeleteGame.Text = "Удалить выбранную игру";
            this.buttonDeleteGame.UseVisualStyleBackColor = true;
            this.buttonDeleteGame.Click += new System.EventHandler(this.buttonDeleteGame_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEditGame);
            this.groupBox1.Controls.Add(this.buttonDeleteGame);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePickerDate);
            this.groupBox1.Controls.Add(this.comboBoxPlayers);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.labelPLayerName);
            this.groupBox1.Controls.Add(this.textBoxGameName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxMasterName);
            this.groupBox1.Controls.Add(this.listViewGames);
            this.groupBox1.Controls.Add(this.groupBoxComponents);
            this.groupBox1.Location = new System.Drawing.Point(644, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 597);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Игра";
            // 
            // buttonEditGame
            // 
            this.buttonEditGame.Location = new System.Drawing.Point(476, 393);
            this.buttonEditGame.Name = "buttonEditGame";
            this.buttonEditGame.Size = new System.Drawing.Size(256, 48);
            this.buttonEditGame.TabIndex = 28;
            this.buttonEditGame.Text = "Редактировать выбранную игру";
            this.buttonEditGame.UseVisualStyleBackColor = true;
            this.buttonEditGame.Click += new System.EventHandler(this.buttonEditGame_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownScore);
            this.groupBox2.Controls.Add(this.buttonEditPlayer);
            this.groupBox2.Controls.Add(this.buttonDeletePlayer);
            this.groupBox2.Controls.Add(this.listViewPlayers);
            this.groupBox2.Controls.Add(this.buttonSavePlayer);
            this.groupBox2.Controls.Add(this.dateTimePickerDeath);
            this.groupBox2.Controls.Add(this.textBoxNickname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(30, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 597);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Игрок";
            // 
            // numericUpDownScore
            // 
            this.numericUpDownScore.Location = new System.Drawing.Point(140, 166);
            this.numericUpDownScore.Name = "numericUpDownScore";
            this.numericUpDownScore.Size = new System.Drawing.Size(187, 22);
            this.numericUpDownScore.TabIndex = 41;
            // 
            // buttonEditPlayer
            // 
            this.buttonEditPlayer.Location = new System.Drawing.Point(266, 405);
            this.buttonEditPlayer.Name = "buttonEditPlayer";
            this.buttonEditPlayer.Size = new System.Drawing.Size(207, 51);
            this.buttonEditPlayer.TabIndex = 40;
            this.buttonEditPlayer.Text = "Редактировать выбранного игрока";
            this.buttonEditPlayer.UseVisualStyleBackColor = true;
            this.buttonEditPlayer.Click += new System.EventHandler(this.buttonEditPlayer_Click);
            // 
            // buttonDeletePlayer
            // 
            this.buttonDeletePlayer.Location = new System.Drawing.Point(35, 405);
            this.buttonDeletePlayer.Name = "buttonDeletePlayer";
            this.buttonDeletePlayer.Size = new System.Drawing.Size(207, 52);
            this.buttonDeletePlayer.TabIndex = 39;
            this.buttonDeletePlayer.Text = "Удалить выбранного игрока";
            this.buttonDeletePlayer.UseVisualStyleBackColor = true;
            this.buttonDeletePlayer.Click += new System.EventHandler(this.buttonDeletePlayer_Click);
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(35, 251);
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(438, 134);
            this.listViewPlayers.TabIndex = 38;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.List;
            this.listViewPlayers.SelectedIndexChanged += new System.EventHandler(this.listViewPlayers_SelectedIndexChanged);
            // 
            // buttonSavePlayer
            // 
            this.buttonSavePlayer.Location = new System.Drawing.Point(361, 44);
            this.buttonSavePlayer.Name = "buttonSavePlayer";
            this.buttonSavePlayer.Size = new System.Drawing.Size(138, 52);
            this.buttonSavePlayer.TabIndex = 36;
            this.buttonSavePlayer.Text = "Сохранить";
            this.buttonSavePlayer.UseVisualStyleBackColor = true;
            this.buttonSavePlayer.Click += new System.EventHandler(this.buttonSavePlayer_Click);
            // 
            // dateTimePickerDeath
            // 
            this.dateTimePickerDeath.Location = new System.Drawing.Point(140, 109);
            this.dateTimePickerDeath.Name = "dateTimePickerDeath";
            this.dateTimePickerDeath.Size = new System.Drawing.Size(187, 22);
            this.dateTimePickerDeath.TabIndex = 35;
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.Location = new System.Drawing.Point(140, 38);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(187, 22);
            this.textBoxNickname.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Очки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Дата смерти:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Никнейм";
            // 
            // buttonSerealize
            // 
            this.buttonSerealize.Location = new System.Drawing.Point(428, 651);
            this.buttonSerealize.Name = "buttonSerealize";
            this.buttonSerealize.Size = new System.Drawing.Size(156, 23);
            this.buttonSerealize.TabIndex = 30;
            this.buttonSerealize.Text = "Сереализировать";
            this.buttonSerealize.UseVisualStyleBackColor = true;
            this.buttonSerealize.Click += new System.EventHandler(this.buttonSerealize_Click);
            // 
            // buttonDeserealize
            // 
            this.buttonDeserealize.Location = new System.Drawing.Point(654, 651);
            this.buttonDeserealize.Name = "buttonDeserealize";
            this.buttonDeserealize.Size = new System.Drawing.Size(170, 23);
            this.buttonDeserealize.TabIndex = 31;
            this.buttonDeserealize.Text = "Десереализировать";
            this.buttonDeserealize.UseVisualStyleBackColor = true;
            this.buttonDeserealize.Click += new System.EventHandler(this.buttonDeserealize_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 683);
            this.Controls.Add(this.buttonDeserealize);
            this.Controls.Add(this.buttonSerealize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.groupBoxComponents.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComponents;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBoxMasterName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewGames;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem игрокиToolStripMenuItem;
        private System.Windows.Forms.Label labelPLayerName;
        private System.Windows.Forms.ComboBox comboBoxPlayers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDeleteGame;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownScore;
        private System.Windows.Forms.Button buttonEditPlayer;
        private System.Windows.Forms.Button buttonDeletePlayer;
        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.Button buttonSavePlayer;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeath;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEditGame;
        private System.Windows.Forms.ListView listViewGamePlayers;
        private System.Windows.Forms.Button buttonSerealize;
        private System.Windows.Forms.Button buttonDeserealize;
    }
}