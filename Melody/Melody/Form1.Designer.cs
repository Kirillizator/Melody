namespace Melody
{
    partial class fMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.Play = new System.Windows.Forms.Button();
            this.Properties = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Play.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.Location = new System.Drawing.Point(81, 45);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(448, 105);
            this.Play.TabIndex = 1;
            this.Play.Text = "Игра";
            this.Play.UseVisualStyleBackColor = false;
            // 
            // Properties
            // 
            this.Properties.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Properties.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Properties.Location = new System.Drawing.Point(81, 213);
            this.Properties.Name = "Properties";
            this.Properties.Size = new System.Drawing.Size(448, 105);
            this.Properties.TabIndex = 2;
            this.Properties.Text = "Настройка";
            this.Properties.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(81, 372);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(448, 105);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Melody.Properties.Resources.Bankoboev_Ru_krasivyi_fon;
            this.ClientSize = new System.Drawing.Size(614, 528);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Properties);
            this.Controls.Add(this.Play);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fMain";
            this.Text = "Угадай мелодию";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Properties;
        private System.Windows.Forms.Button Exit;
    }
}

