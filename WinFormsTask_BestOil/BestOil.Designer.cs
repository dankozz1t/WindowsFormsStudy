
namespace WinFormsTask_BestOil
{
    partial class BestOil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestOil));
            this.groupBoxGasStation = new System.Windows.Forms.GroupBox();
            this.textBoxGSPrice = new System.Windows.Forms.TextBox();
            this.labelGSPrice = new System.Windows.Forms.Label();
            this.labelGSPetrol = new System.Windows.Forms.Label();
            this.labelGSCurrency1 = new System.Windows.Forms.Label();
            this.comboBoxGSPetrol = new System.Windows.Forms.ComboBox();
            this.labelGSCurrency2 = new System.Windows.Forms.Label();
            this.labelGSLiters = new System.Windows.Forms.Label();
            this.textBoxGSMoney = new System.Windows.Forms.TextBox();
            this.textBoxGSLiters = new System.Windows.Forms.TextBox();
            this.groupBoxGSChoice = new System.Windows.Forms.GroupBox();
            this.radioButtonGSSum = new System.Windows.Forms.RadioButton();
            this.radioButtonGSCount = new System.Windows.Forms.RadioButton();
            this.groupBoxGSTo = new System.Windows.Forms.GroupBox();
            this.labelGSResult = new System.Windows.Forms.Label();
            this.labelGSUnit = new System.Windows.Forms.Label();
            this.groupBoxToPay = new System.Windows.Forms.GroupBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.pictureBoxFrayMoney = new System.Windows.Forms.PictureBox();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelCurrency = new System.Windows.Forms.Label();
            this.groupBoxMiniCafe = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMCMoney = new System.Windows.Forms.Label();
            this.labelMCCount = new System.Windows.Forms.Label();
            this.groupBoxMCToPay = new System.Windows.Forms.GroupBox();
            this.labelMCSumGlobal = new System.Windows.Forms.Label();
            this.labelMCCurrency = new System.Windows.Forms.Label();
            this.groupBoxGasStation.SuspendLayout();
            this.groupBoxGSChoice.SuspendLayout();
            this.groupBoxGSTo.SuspendLayout();
            this.groupBoxToPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrayMoney)).BeginInit();
            this.groupBoxMiniCafe.SuspendLayout();
            this.groupBoxMCToPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGasStation
            // 
            this.groupBoxGasStation.Controls.Add(this.textBoxGSPrice);
            this.groupBoxGasStation.Controls.Add(this.labelGSPrice);
            this.groupBoxGasStation.Controls.Add(this.labelGSPetrol);
            this.groupBoxGasStation.Controls.Add(this.labelGSCurrency1);
            this.groupBoxGasStation.Controls.Add(this.comboBoxGSPetrol);
            this.groupBoxGasStation.Controls.Add(this.labelGSCurrency2);
            this.groupBoxGasStation.Controls.Add(this.labelGSLiters);
            this.groupBoxGasStation.Controls.Add(this.textBoxGSMoney);
            this.groupBoxGasStation.Controls.Add(this.textBoxGSLiters);
            this.groupBoxGasStation.Controls.Add(this.groupBoxGSChoice);
            this.groupBoxGasStation.Controls.Add(this.groupBoxGSTo);
            this.groupBoxGasStation.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGasStation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(56)))), ((int)(((byte)(41)))));
            this.groupBoxGasStation.Location = new System.Drawing.Point(12, 12);
            this.groupBoxGasStation.Name = "groupBoxGasStation";
            this.groupBoxGasStation.Size = new System.Drawing.Size(246, 284);
            this.groupBoxGasStation.TabIndex = 0;
            this.groupBoxGasStation.TabStop = false;
            this.groupBoxGasStation.Text = "Автозаправка";
            // 
            // textBoxGSPrice
            // 
            this.textBoxGSPrice.BackColor = System.Drawing.Color.LightGray;
            this.textBoxGSPrice.Enabled = false;
            this.textBoxGSPrice.ForeColor = System.Drawing.Color.Black;
            this.textBoxGSPrice.Location = new System.Drawing.Point(83, 59);
            this.textBoxGSPrice.Name = "textBoxGSPrice";
            this.textBoxGSPrice.Size = new System.Drawing.Size(121, 23);
            this.textBoxGSPrice.TabIndex = 11;
            // 
            // labelGSPrice
            // 
            this.labelGSPrice.AutoSize = true;
            this.labelGSPrice.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGSPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelGSPrice.Location = new System.Drawing.Point(9, 61);
            this.labelGSPrice.Name = "labelGSPrice";
            this.labelGSPrice.Size = new System.Drawing.Size(52, 21);
            this.labelGSPrice.TabIndex = 10;
            this.labelGSPrice.Text = "Цена";
            // 
            // labelGSPetrol
            // 
            this.labelGSPetrol.AutoSize = true;
            this.labelGSPetrol.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGSPetrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelGSPetrol.Location = new System.Drawing.Point(9, 27);
            this.labelGSPetrol.Name = "labelGSPetrol";
            this.labelGSPetrol.Size = new System.Drawing.Size(70, 21);
            this.labelGSPetrol.TabIndex = 9;
            this.labelGSPetrol.Text = "Бензин";
            // 
            // labelGSCurrency1
            // 
            this.labelGSCurrency1.AutoSize = true;
            this.labelGSCurrency1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelGSCurrency1.Location = new System.Drawing.Point(207, 64);
            this.labelGSCurrency1.Name = "labelGSCurrency1";
            this.labelGSCurrency1.Size = new System.Drawing.Size(36, 18);
            this.labelGSCurrency1.TabIndex = 8;
            this.labelGSCurrency1.Text = "грн.";
            // 
            // comboBoxGSPetrol
            // 
            this.comboBoxGSPetrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGSPetrol.FormattingEnabled = true;
            this.comboBoxGSPetrol.Location = new System.Drawing.Point(83, 27);
            this.comboBoxGSPetrol.Name = "comboBoxGSPetrol";
            this.comboBoxGSPetrol.Size = new System.Drawing.Size(121, 26);
            this.comboBoxGSPetrol.TabIndex = 6;
            this.comboBoxGSPetrol.SelectedIndexChanged += new System.EventHandler(this.comboBoxGSPetrol_SelectedIndexChanged);
            // 
            // labelGSCurrency2
            // 
            this.labelGSCurrency2.AutoSize = true;
            this.labelGSCurrency2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelGSCurrency2.Location = new System.Drawing.Point(207, 147);
            this.labelGSCurrency2.Name = "labelGSCurrency2";
            this.labelGSCurrency2.Size = new System.Drawing.Size(36, 18);
            this.labelGSCurrency2.TabIndex = 5;
            this.labelGSCurrency2.Text = "грн.";
            // 
            // labelGSLiters
            // 
            this.labelGSLiters.AutoSize = true;
            this.labelGSLiters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelGSLiters.Location = new System.Drawing.Point(207, 112);
            this.labelGSLiters.Name = "labelGSLiters";
            this.labelGSLiters.Size = new System.Drawing.Size(20, 18);
            this.labelGSLiters.TabIndex = 4;
            this.labelGSLiters.Text = "л.";
            // 
            // textBoxGSMoney
            // 
            this.textBoxGSMoney.BackColor = System.Drawing.Color.LightGray;
            this.textBoxGSMoney.Enabled = false;
            this.textBoxGSMoney.Location = new System.Drawing.Point(149, 144);
            this.textBoxGSMoney.Name = "textBoxGSMoney";
            this.textBoxGSMoney.Size = new System.Drawing.Size(52, 23);
            this.textBoxGSMoney.TabIndex = 3;
            this.textBoxGSMoney.EnabledChanged += new System.EventHandler(this.TextBox_EnabledChanged);
            this.textBoxGSMoney.TextChanged += new System.EventHandler(this.textBoxGSMoney_TextChanged);
            // 
            // textBoxGSLiters
            // 
            this.textBoxGSLiters.BackColor = System.Drawing.Color.LightGray;
            this.textBoxGSLiters.Enabled = false;
            this.textBoxGSLiters.Location = new System.Drawing.Point(149, 107);
            this.textBoxGSLiters.Name = "textBoxGSLiters";
            this.textBoxGSLiters.Size = new System.Drawing.Size(52, 23);
            this.textBoxGSLiters.TabIndex = 2;
            this.textBoxGSLiters.EnabledChanged += new System.EventHandler(this.TextBox_EnabledChanged);
            this.textBoxGSLiters.TextChanged += new System.EventHandler(this.textBoxGSLiters_TextChanged);
            // 
            // groupBoxGSChoice
            // 
            this.groupBoxGSChoice.Controls.Add(this.radioButtonGSSum);
            this.groupBoxGSChoice.Controls.Add(this.radioButtonGSCount);
            this.groupBoxGSChoice.Location = new System.Drawing.Point(6, 97);
            this.groupBoxGSChoice.Name = "groupBoxGSChoice";
            this.groupBoxGSChoice.Size = new System.Drawing.Size(130, 70);
            this.groupBoxGSChoice.TabIndex = 1;
            this.groupBoxGSChoice.TabStop = false;
            // 
            // radioButtonGSSum
            // 
            this.radioButtonGSSum.AutoSize = true;
            this.radioButtonGSSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.radioButtonGSSum.Location = new System.Drawing.Point(7, 42);
            this.radioButtonGSSum.Name = "radioButtonGSSum";
            this.radioButtonGSSum.Size = new System.Drawing.Size(73, 22);
            this.radioButtonGSSum.TabIndex = 1;
            this.radioButtonGSSum.Text = "Сумма";
            this.radioButtonGSSum.UseVisualStyleBackColor = true;
            this.radioButtonGSSum.CheckedChanged += new System.EventHandler(this.radioButtonGSSum_CheckedChanged);
            // 
            // radioButtonGSCount
            // 
            this.radioButtonGSCount.AutoSize = true;
            this.radioButtonGSCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.radioButtonGSCount.Location = new System.Drawing.Point(7, 11);
            this.radioButtonGSCount.Name = "radioButtonGSCount";
            this.radioButtonGSCount.Size = new System.Drawing.Size(111, 22);
            this.radioButtonGSCount.TabIndex = 0;
            this.radioButtonGSCount.Text = "Количество";
            this.radioButtonGSCount.UseVisualStyleBackColor = true;
            this.radioButtonGSCount.CheckedChanged += new System.EventHandler(this.radioButtonGSCount_CheckedChanged);
            // 
            // groupBoxGSTo
            // 
            this.groupBoxGSTo.Controls.Add(this.labelGSResult);
            this.groupBoxGSTo.Controls.Add(this.labelGSUnit);
            this.groupBoxGSTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(56)))), ((int)(((byte)(41)))));
            this.groupBoxGSTo.Location = new System.Drawing.Point(6, 203);
            this.groupBoxGSTo.Name = "groupBoxGSTo";
            this.groupBoxGSTo.Size = new System.Drawing.Size(234, 75);
            this.groupBoxGSTo.TabIndex = 0;
            this.groupBoxGSTo.TabStop = false;
            this.groupBoxGSTo.Text = "К оплате";
            // 
            // labelGSResult
            // 
            this.labelGSResult.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGSResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelGSResult.Location = new System.Drawing.Point(50, 19);
            this.labelGSResult.Name = "labelGSResult";
            this.labelGSResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelGSResult.Size = new System.Drawing.Size(138, 37);
            this.labelGSResult.TabIndex = 7;
            this.labelGSResult.Text = "0.00";
            // 
            // labelGSUnit
            // 
            this.labelGSUnit.AutoSize = true;
            this.labelGSUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelGSUnit.Location = new System.Drawing.Point(194, 38);
            this.labelGSUnit.Name = "labelGSUnit";
            this.labelGSUnit.Size = new System.Drawing.Size(36, 18);
            this.labelGSUnit.TabIndex = 6;
            this.labelGSUnit.Text = "грн.";
            // 
            // groupBoxToPay
            // 
            this.groupBoxToPay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.groupBoxToPay.Controls.Add(this.buttonCalculate);
            this.groupBoxToPay.Controls.Add(this.pictureBoxFrayMoney);
            this.groupBoxToPay.Controls.Add(this.labelSum);
            this.groupBoxToPay.Controls.Add(this.labelCurrency);
            this.groupBoxToPay.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxToPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(56)))), ((int)(((byte)(41)))));
            this.groupBoxToPay.Location = new System.Drawing.Point(12, 314);
            this.groupBoxToPay.Name = "groupBoxToPay";
            this.groupBoxToPay.Size = new System.Drawing.Size(502, 108);
            this.groupBoxToPay.TabIndex = 8;
            this.groupBoxToPay.TabStop = false;
            this.groupBoxToPay.Text = "К оплате";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.buttonCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalculate.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(22)))), ((int)(((byte)(11)))));
            this.buttonCalculate.Location = new System.Drawing.Point(130, 27);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(150, 57);
            this.buttonCalculate.TabIndex = 9;
            this.buttonCalculate.Text = "Посчитать";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // pictureBoxFrayMoney
            // 
            this.pictureBoxFrayMoney.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFrayMoney.Image")));
            this.pictureBoxFrayMoney.Location = new System.Drawing.Point(1, 17);
            this.pictureBoxFrayMoney.Name = "pictureBoxFrayMoney";
            this.pictureBoxFrayMoney.Size = new System.Drawing.Size(123, 87);
            this.pictureBoxFrayMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFrayMoney.TabIndex = 8;
            this.pictureBoxFrayMoney.TabStop = false;
            // 
            // labelSum
            // 
            this.labelSum.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelSum.Location = new System.Drawing.Point(286, 29);
            this.labelSum.Name = "labelSum";
            this.labelSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelSum.Size = new System.Drawing.Size(173, 44);
            this.labelSum.TabIndex = 7;
            this.labelSum.Text = "0.00";
            // 
            // labelCurrency
            // 
            this.labelCurrency.AutoSize = true;
            this.labelCurrency.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelCurrency.Location = new System.Drawing.Point(454, 66);
            this.labelCurrency.Name = "labelCurrency";
            this.labelCurrency.Size = new System.Drawing.Size(36, 18);
            this.labelCurrency.TabIndex = 6;
            this.labelCurrency.Text = "грн.";
            // 
            // groupBoxMiniCafe
            // 
            this.groupBoxMiniCafe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMiniCafe.Controls.Add(this.panel1);
            this.groupBoxMiniCafe.Controls.Add(this.labelMCMoney);
            this.groupBoxMiniCafe.Controls.Add(this.labelMCCount);
            this.groupBoxMiniCafe.Controls.Add(this.groupBoxMCToPay);
            this.groupBoxMiniCafe.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxMiniCafe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(56)))), ((int)(((byte)(41)))));
            this.groupBoxMiniCafe.Location = new System.Drawing.Point(268, 12);
            this.groupBoxMiniCafe.Name = "groupBoxMiniCafe";
            this.groupBoxMiniCafe.Size = new System.Drawing.Size(246, 284);
            this.groupBoxMiniCafe.TabIndex = 1;
            this.groupBoxMiniCafe.TabStop = false;
            this.groupBoxMiniCafe.Text = "Мини-Кафе";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(6, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 135);
            this.panel1.TabIndex = 24;
            // 
            // labelMCMoney
            // 
            this.labelMCMoney.AutoSize = true;
            this.labelMCMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelMCMoney.Location = new System.Drawing.Point(123, 11);
            this.labelMCMoney.Name = "labelMCMoney";
            this.labelMCMoney.Size = new System.Drawing.Size(44, 18);
            this.labelMCMoney.TabIndex = 10;
            this.labelMCMoney.Text = "Цена";
            // 
            // labelMCCount
            // 
            this.labelMCCount.AutoSize = true;
            this.labelMCCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelMCCount.Location = new System.Drawing.Point(183, 11);
            this.labelMCCount.Name = "labelMCCount";
            this.labelMCCount.Size = new System.Drawing.Size(44, 18);
            this.labelMCCount.TabIndex = 9;
            this.labelMCCount.Text = "Колв";
            // 
            // groupBoxMCToPay
            // 
            this.groupBoxMCToPay.Controls.Add(this.labelMCSumGlobal);
            this.groupBoxMCToPay.Controls.Add(this.labelMCCurrency);
            this.groupBoxMCToPay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(56)))), ((int)(((byte)(41)))));
            this.groupBoxMCToPay.Location = new System.Drawing.Point(6, 203);
            this.groupBoxMCToPay.Name = "groupBoxMCToPay";
            this.groupBoxMCToPay.Size = new System.Drawing.Size(234, 75);
            this.groupBoxMCToPay.TabIndex = 0;
            this.groupBoxMCToPay.TabStop = false;
            this.groupBoxMCToPay.Text = "К оплате";
            // 
            // labelMCSumGlobal
            // 
            this.labelMCSumGlobal.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMCSumGlobal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelMCSumGlobal.Location = new System.Drawing.Point(50, 19);
            this.labelMCSumGlobal.Name = "labelMCSumGlobal";
            this.labelMCSumGlobal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelMCSumGlobal.Size = new System.Drawing.Size(136, 37);
            this.labelMCSumGlobal.TabIndex = 7;
            this.labelMCSumGlobal.Text = "0.00";
            // 
            // labelMCCurrency
            // 
            this.labelMCCurrency.AutoSize = true;
            this.labelMCCurrency.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(152)))), ((int)(((byte)(169)))));
            this.labelMCCurrency.Location = new System.Drawing.Point(192, 38);
            this.labelMCCurrency.Name = "labelMCCurrency";
            this.labelMCCurrency.Size = new System.Drawing.Size(36, 18);
            this.labelMCCurrency.TabIndex = 6;
            this.labelMCCurrency.Text = "грн.";
            // 
            // BestOil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(47)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(526, 434);
            this.Controls.Add(this.groupBoxToPay);
            this.Controls.Add(this.groupBoxMiniCafe);
            this.Controls.Add(this.groupBoxGasStation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BestOil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestOil";
            this.groupBoxGasStation.ResumeLayout(false);
            this.groupBoxGasStation.PerformLayout();
            this.groupBoxGSChoice.ResumeLayout(false);
            this.groupBoxGSChoice.PerformLayout();
            this.groupBoxGSTo.ResumeLayout(false);
            this.groupBoxGSTo.PerformLayout();
            this.groupBoxToPay.ResumeLayout(false);
            this.groupBoxToPay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrayMoney)).EndInit();
            this.groupBoxMiniCafe.ResumeLayout(false);
            this.groupBoxMiniCafe.PerformLayout();
            this.groupBoxMCToPay.ResumeLayout(false);
            this.groupBoxMCToPay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGasStation;
        private System.Windows.Forms.Label labelGSCurrency2;
        private System.Windows.Forms.Label labelGSLiters;
        private System.Windows.Forms.TextBox textBoxGSMoney;
        private System.Windows.Forms.TextBox textBoxGSLiters;
        private System.Windows.Forms.GroupBox groupBoxGSChoice;
        private System.Windows.Forms.RadioButton radioButtonGSSum;
        private System.Windows.Forms.RadioButton radioButtonGSCount;
        private System.Windows.Forms.GroupBox groupBoxGSTo;
        private System.Windows.Forms.Label labelGSResult;
        private System.Windows.Forms.Label labelGSUnit;
        private System.Windows.Forms.TextBox textBoxGSPrice;
        private System.Windows.Forms.Label labelGSPrice;
        private System.Windows.Forms.Label labelGSPetrol;
        private System.Windows.Forms.Label labelGSCurrency1;
        private System.Windows.Forms.ComboBox comboBoxGSPetrol;
        private System.Windows.Forms.GroupBox groupBoxToPay;
        private System.Windows.Forms.Label labelCurrency;
        private System.Windows.Forms.GroupBox groupBoxMiniCafe;
        private System.Windows.Forms.Label labelMCMoney;
        private System.Windows.Forms.Label labelMCCount;
        private System.Windows.Forms.GroupBox groupBoxMCToPay;
        private System.Windows.Forms.Label labelMCSumGlobal;
        private System.Windows.Forms.Label labelMCCurrency;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.PictureBox pictureBoxFrayMoney;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Panel panel1;
    }
}

