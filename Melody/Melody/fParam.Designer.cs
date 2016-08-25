namespace Melody
{
    partial class fParam
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBrsFold = new System.Windows.Forms.Button();
            this.btnCkrList = new System.Windows.Forms.Button();
            this.cbAllDir = new System.Windows.Forms.CheckBox();
            this.btnCans = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbGameDuration = new System.Windows.Forms.ComboBox();
            this.cbMusicDuration = new System.Windows.Forms.ComboBox();
            this.cbRandomStart = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 329);
            this.listBox1.TabIndex = 0;
            // 
            // btnBrsFold
            // 
            this.btnBrsFold.Location = new System.Drawing.Point(13, 357);
            this.btnBrsFold.Name = "btnBrsFold";
            this.btnBrsFold.Size = new System.Drawing.Size(150, 50);
            this.btnBrsFold.TabIndex = 1;
            this.btnBrsFold.Text = "Выбрать папку";
            this.btnBrsFold.UseVisualStyleBackColor = true;
            this.btnBrsFold.Click += new System.EventHandler(this.btnBrsFold_Click);
            // 
            // btnCkrList
            // 
            this.btnCkrList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCkrList.Location = new System.Drawing.Point(422, 357);
            this.btnCkrList.Name = "btnCkrList";
            this.btnCkrList.Size = new System.Drawing.Size(150, 50);
            this.btnCkrList.TabIndex = 2;
            this.btnCkrList.Text = "Очистить список";
            this.btnCkrList.UseVisualStyleBackColor = true;
            this.btnCkrList.Click += new System.EventHandler(this.btnCkrList_Click);
            // 
            // cbAllDir
            // 
            this.cbAllDir.AutoSize = true;
            this.cbAllDir.Location = new System.Drawing.Point(181, 375);
            this.cbAllDir.Name = "cbAllDir";
            this.cbAllDir.Size = new System.Drawing.Size(118, 17);
            this.cbAllDir.TabIndex = 3;
            this.cbAllDir.Text = "Вложенные папки";
            this.cbAllDir.UseVisualStyleBackColor = true;
            this.cbAllDir.CheckedChanged += new System.EventHandler(this.chlboxInclud_CheckedChanged);
            // 
            // btnCans
            // 
            this.btnCans.Location = new System.Drawing.Point(422, 500);
            this.btnCans.Name = "btnCans";
            this.btnCans.Size = new System.Drawing.Size(150, 50);
            this.btnCans.TabIndex = 4;
            this.btnCans.Text = "Отмена";
            this.btnCans.UseVisualStyleBackColor = true;
            this.btnCans.Click += new System.EventHandler(this.btnCans_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(422, 424);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 50);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRandomStart);
            this.groupBox1.Controls.Add(this.cbMusicDuration);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbGameDuration);
            this.groupBox1.Location = new System.Drawing.Point(13, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 137);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки игры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продолжительность игры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время на ответ";
            // 
            // cbGameDuration
            // 
            this.cbGameDuration.FormattingEnabled = true;
            this.cbGameDuration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "90",
            "120",
            "240"});
            this.cbGameDuration.Location = new System.Drawing.Point(168, 22);
            this.cbGameDuration.Name = "cbGameDuration";
            this.cbGameDuration.Size = new System.Drawing.Size(43, 21);
            this.cbGameDuration.TabIndex = 2;
            this.cbGameDuration.Text = "60";
            // 
            // cbMusicDuration
            // 
            this.cbMusicDuration.FormattingEnabled = true;
            this.cbMusicDuration.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbMusicDuration.Location = new System.Drawing.Point(168, 61);
            this.cbMusicDuration.Name = "cbMusicDuration";
            this.cbMusicDuration.Size = new System.Drawing.Size(43, 21);
            this.cbMusicDuration.TabIndex = 3;
            this.cbMusicDuration.Text = "20";
            // 
            // cbRandomStart
            // 
            this.cbRandomStart.AutoSize = true;
            this.cbRandomStart.Location = new System.Drawing.Point(17, 105);
            this.cbRandomStart.Name = "cbRandomStart";
            this.cbRandomStart.Size = new System.Drawing.Size(133, 17);
            this.cbRandomStart.TabIndex = 4;
            this.cbRandomStart.Text = "Со случайного места";
            this.cbRandomStart.UseVisualStyleBackColor = true;
            // 
            // fParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCans);
            this.Controls.Add(this.cbAllDir);
            this.Controls.Add(this.btnCkrList);
            this.Controls.Add(this.btnBrsFold);
            this.Controls.Add(this.listBox1);
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "fParam";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fParam_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBrsFold;
        private System.Windows.Forms.Button btnCkrList;
        private System.Windows.Forms.CheckBox cbAllDir;
        private System.Windows.Forms.Button btnCans;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMusicDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGameDuration;
        private System.Windows.Forms.CheckBox cbRandomStart;
    }
}