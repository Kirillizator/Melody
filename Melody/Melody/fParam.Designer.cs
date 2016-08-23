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
            this.chlboxInclud = new System.Windows.Forms.CheckBox();
            this.btnCans = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(559, 394);
            this.listBox1.TabIndex = 0;
            // 
            // btnBrsFold
            // 
            this.btnBrsFold.Location = new System.Drawing.Point(13, 425);
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
            this.btnCkrList.Location = new System.Drawing.Point(13, 490);
            this.btnCkrList.Name = "btnCkrList";
            this.btnCkrList.Size = new System.Drawing.Size(150, 50);
            this.btnCkrList.TabIndex = 2;
            this.btnCkrList.Text = "Очистить список";
            this.btnCkrList.UseVisualStyleBackColor = true;
            // 
            // chlboxInclud
            // 
            this.chlboxInclud.AutoSize = true;
            this.chlboxInclud.Location = new System.Drawing.Point(237, 425);
            this.chlboxInclud.Name = "chlboxInclud";
            this.chlboxInclud.Size = new System.Drawing.Size(118, 17);
            this.chlboxInclud.TabIndex = 3;
            this.chlboxInclud.Text = "Вложенные папки";
            this.chlboxInclud.UseVisualStyleBackColor = true;
            this.chlboxInclud.CheckedChanged += new System.EventHandler(this.chlboxInclud_CheckedChanged);
            // 
            // btnCans
            // 
            this.btnCans.Location = new System.Drawing.Point(422, 490);
            this.btnCans.Name = "btnCans";
            this.btnCans.Size = new System.Drawing.Size(150, 50);
            this.btnCans.TabIndex = 4;
            this.btnCans.Text = "Отмена";
            this.btnCans.UseVisualStyleBackColor = true;
            this.btnCans.Click += new System.EventHandler(this.btnCans_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(422, 425);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 50);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // fParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCans);
            this.Controls.Add(this.chlboxInclud);
            this.Controls.Add(this.btnCkrList);
            this.Controls.Add(this.btnBrsFold);
            this.Controls.Add(this.listBox1);
            this.Name = "fParam";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.fParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBrsFold;
        private System.Windows.Forms.Button btnCkrList;
        private System.Windows.Forms.CheckBox chlboxInclud;
        private System.Windows.Forms.Button btnCans;
        private System.Windows.Forms.Button btnOK;
    }
}