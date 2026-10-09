namespace plus_game
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.pictureBoxPlus = new System.Windows.Forms.PictureBox();
            this.pictureMult = new System.Windows.Forms.PictureBox();
            this.buttonThrowOff = new System.Windows.Forms.Button();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonSetNum = new System.Windows.Forms.Button();
            this.labelStepsCounter = new System.Windows.Forms.Label();
            this.labelCurrentSteps = new System.Windows.Forms.Label();
            this.labelGuessedNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMult)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPlus
            // 
            this.pictureBoxPlus.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPlus.Image")));
            this.pictureBoxPlus.Location = new System.Drawing.Point(37, 76);
            this.pictureBoxPlus.Name = "pictureBoxPlus";
            this.pictureBoxPlus.Size = new System.Drawing.Size(150, 134);
            this.pictureBoxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlus.TabIndex = 0;
            this.pictureBoxPlus.TabStop = false;
            this.pictureBoxPlus.Click += new System.EventHandler(this.pictureBoxPlus_Click);
            // 
            // pictureMult
            // 
            this.pictureMult.Image = ((System.Drawing.Image)(resources.GetObject("pictureMult.Image")));
            this.pictureMult.Location = new System.Drawing.Point(388, 76);
            this.pictureMult.Name = "pictureMult";
            this.pictureMult.Size = new System.Drawing.Size(149, 134);
            this.pictureMult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMult.TabIndex = 1;
            this.pictureMult.TabStop = false;
            this.pictureMult.Click += new System.EventHandler(this.pictureMult_Click);
            // 
            // buttonThrowOff
            // 
            this.buttonThrowOff.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThrowOff.Location = new System.Drawing.Point(37, 279);
            this.buttonThrowOff.Name = "buttonThrowOff";
            this.buttonThrowOff.Size = new System.Drawing.Size(119, 53);
            this.buttonThrowOff.TabIndex = 2;
            this.buttonThrowOff.Text = "Сбросить";
            this.buttonThrowOff.UseVisualStyleBackColor = true;
            this.buttonThrowOff.Click += new System.EventHandler(this.buttonThrowOff_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandom.Location = new System.Drawing.Point(223, 279);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(142, 53);
            this.buttonRandom.TabIndex = 3;
            this.buttonRandom.Text = "Поменять число на случайное";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonSetNum
            // 
            this.buttonSetNum.Font = new System.Drawing.Font("Microsoft Uighur", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetNum.Location = new System.Drawing.Point(418, 279);
            this.buttonSetNum.Name = "buttonSetNum";
            this.buttonSetNum.Size = new System.Drawing.Size(119, 53);
            this.buttonSetNum.TabIndex = 4;
            this.buttonSetNum.Text = "Задать число";
            this.buttonSetNum.UseVisualStyleBackColor = true;
            // 
            // labelStepsCounter
            // 
            this.labelStepsCounter.AutoSize = true;
            this.labelStepsCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStepsCounter.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStepsCounter.Location = new System.Drawing.Point(32, 227);
            this.labelStepsCounter.Name = "labelStepsCounter";
            this.labelStepsCounter.Size = new System.Drawing.Size(297, 49);
            this.labelStepsCounter.TabIndex = 5;
            this.labelStepsCounter.Text = "Количество шагов: 0";
            this.labelStepsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelStepsCounter.Click += new System.EventHandler(this.labelStepsCounter_Click);
            // 
            // labelCurrentSteps
            // 
            this.labelCurrentSteps.AutoSize = true;
            this.labelCurrentSteps.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCurrentSteps.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentSteps.Location = new System.Drawing.Point(269, 161);
            this.labelCurrentSteps.Name = "labelCurrentSteps";
            this.labelCurrentSteps.Size = new System.Drawing.Size(33, 49);
            this.labelCurrentSteps.TabIndex = 6;
            this.labelCurrentSteps.Text = "1";
            this.labelCurrentSteps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCurrentSteps.Click += new System.EventHandler(this.labelCurrentSteps_Click);
            // 
            // labelGuessedNum
            // 
            this.labelGuessedNum.AutoSize = true;
            this.labelGuessedNum.BackColor = System.Drawing.Color.Cyan;
            this.labelGuessedNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGuessedNum.Location = new System.Drawing.Point(256, 76);
            this.labelGuessedNum.Name = "labelGuessedNum";
            this.labelGuessedNum.Size = new System.Drawing.Size(60, 42);
            this.labelGuessedNum.TabIndex = 7;
            this.labelGuessedNum.Text = "15";
            this.labelGuessedNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGuessedNum.Click += new System.EventHandler(this.labelGuessedNum_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 420);
            this.Controls.Add(this.labelGuessedNum);
            this.Controls.Add(this.labelCurrentSteps);
            this.Controls.Add(this.labelStepsCounter);
            this.Controls.Add(this.buttonSetNum);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.buttonThrowOff);
            this.Controls.Add(this.pictureMult);
            this.Controls.Add(this.pictureBoxPlus);
            this.Name = "GameForm";
            this.Text = "Game_of_not_thrones_because_it_pluse_game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPlus;
        private System.Windows.Forms.PictureBox pictureMult;
        private System.Windows.Forms.Button buttonThrowOff;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonSetNum;
        private System.Windows.Forms.Label labelStepsCounter;
        private System.Windows.Forms.Label labelCurrentSteps;
        private System.Windows.Forms.Label labelGuessedNum;
    }
}

