
namespace WinFormsTaskCalculatingTheDate
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.labelGlobal = new System.Windows.Forms.Label();
            this.sendDataButton = new System.Windows.Forms.Button();
            this.radioButtonTime = new System.Windows.Forms.RadioButton();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.textBoxTime = new System.Windows.Forms.MaskedTextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.Left = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelNow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDate.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxDate.Enabled = false;
            this.textBoxDate.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxDate.Location = new System.Drawing.Point(63, 81);
            this.textBoxDate.Mask = "00/00/0000";
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(99, 22);
            this.textBoxDate.TabIndex = 2;
            this.textBoxDate.ValidatingType = typeof(System.DateTime);
            this.textBoxDate.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.textBoxDate_TypeValidationCompleted);
            // 
            // labelGlobal
            // 
            this.labelGlobal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelGlobal.AutoSize = true;
            this.labelGlobal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGlobal.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGlobal.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelGlobal.Location = new System.Drawing.Point(4, 43);
            this.labelGlobal.Name = "labelGlobal";
            this.labelGlobal.Size = new System.Drawing.Size(298, 22);
            this.labelGlobal.TabIndex = 3;
            this.labelGlobal.Text = "Выберите тип и введите данные";
            // 
            // sendDataButton
            // 
            this.sendDataButton.BackColor = System.Drawing.Color.CadetBlue;
            this.sendDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sendDataButton.Location = new System.Drawing.Point(63, 151);
            this.sendDataButton.Name = "sendDataButton";
            this.sendDataButton.Size = new System.Drawing.Size(175, 33);
            this.sendDataButton.TabIndex = 4;
            this.sendDataButton.Text = "Расчитать";
            this.sendDataButton.UseVisualStyleBackColor = false;
            this.sendDataButton.Click += new System.EventHandler(this.sendDataButton_Click);
            // 
            // radioButtonTime
            // 
            this.radioButtonTime.AutoSize = true;
            this.radioButtonTime.Location = new System.Drawing.Point(180, 110);
            this.radioButtonTime.Name = "radioButtonTime";
            this.radioButtonTime.Size = new System.Drawing.Size(58, 17);
            this.radioButtonTime.TabIndex = 5;
            this.radioButtonTime.TabStop = true;
            this.radioButtonTime.Text = "Время";
            this.radioButtonTime.UseVisualStyleBackColor = true;
            this.radioButtonTime.CheckedChanged += new System.EventHandler(this.radioButtonTime_CheckedChanged);
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(180, 81);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(51, 17);
            this.radioButtonDate.TabIndex = 6;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "Дата";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            this.radioButtonDate.CheckedChanged += new System.EventHandler(this.radioButtonDate_CheckedChanged);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxTime.BackColor = System.Drawing.Color.LightYellow;
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTime.Location = new System.Drawing.Point(63, 110);
            this.textBoxTime.Mask = "00:00";
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(99, 22);
            this.textBoxTime.TabIndex = 7;
            this.textBoxTime.ValidatingType = typeof(System.DateTime);
            this.textBoxTime.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.textBoxTime_TypeValidationCompleted);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(63, 216);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(175, 55);
            this.textBoxResult.TabIndex = 8;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Left
            // 
            this.Left.AutoSize = true;
            this.Left.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Left.Location = new System.Drawing.Point(95, 187);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(113, 26);
            this.Left.TabIndex = 9;
            this.Left.Text = "Осталось:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelNow
            // 
            this.labelNow.AutoSize = true;
            this.labelNow.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNow.Location = new System.Drawing.Point(78, 9);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(139, 22);
            this.labelNow.TabIndex = 10;
            this.labelNow.Text = "Время сейчас: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(312, 278);
            this.Controls.Add(this.labelNow);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.radioButtonDate);
            this.Controls.Add(this.radioButtonTime);
            this.Controls.Add(this.sendDataButton);
            this.Controls.Add(this.labelGlobal);
            this.Controls.Add(this.textBoxDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cколько осталось времени";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox textBoxDate;
        private System.Windows.Forms.Label labelGlobal;
        private System.Windows.Forms.Button sendDataButton;
        private System.Windows.Forms.RadioButton radioButtonTime;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.MaskedTextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label Left;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelNow;
    }
}

