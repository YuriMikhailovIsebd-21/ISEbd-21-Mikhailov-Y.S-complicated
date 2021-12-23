
using System;

namespace WindowsFormsTeplovoz
{
    partial class FormTeplo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeplo));
            this.pictureBoxTeplo = new System.Windows.Forms.PictureBox();
            this.buttonСreate = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.ButtonUp = new System.Windows.Forms.Button();
            this.ButtonDown = new System.Windows.Forms.Button();
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeplo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBoxTeplo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTeplo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTeplo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxTeplo.Name = "pictureBox1";
            this.pictureBoxTeplo.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxTeplo.TabIndex = 0;
            this.pictureBoxTeplo.TabStop = false;
            // 
            // buttonСreate
            // 
            this.buttonСreate.Location = new System.Drawing.Point(555, 400);
            this.buttonСreate.Name = "buttonСreate";
            this.buttonСreate.Size = new System.Drawing.Size(213, 55);
            this.buttonСreate.TabIndex = 1;
            this.buttonСreate.Text = "Создать";
            this.buttonСreate.UseVisualStyleBackColor = true;
            this.buttonСreate.Click += new System.EventHandler(this.ButtonCreaten_Click);
            // 
            // buttonLeft1
            // 
            this.ButtonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLeft.BackgroundImage")));
            this.ButtonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonLeft.Location = new System.Drawing.Point(628, 392);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(75, 23);
            this.ButtonLeft.TabIndex = 4;
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.ButtonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRight.BackgroundImage")));
            this.ButtonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRight.Location = new System.Drawing.Point(797, 392);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(75, 23);
            this.ButtonRight.TabIndex = 5;
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.ButtonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonUp.BackgroundImage")));
            this.ButtonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonUp.Location = new System.Drawing.Point(714, 354);
            this.ButtonUp.Name = "ButtonUp";
            this.ButtonUp.Size = new System.Drawing.Size(75, 23);
            this.ButtonUp.TabIndex = 2;
            this.ButtonUp.UseVisualStyleBackColor = true;
            this.ButtonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.ButtonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDown.BackgroundImage")));
            this.ButtonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonDown.Location = new System.Drawing.Point(714, 426);
            this.ButtonDown.Name = "ButtonDown";
            this.ButtonDown.Size = new System.Drawing.Size(75, 23);
            this.ButtonDown.TabIndex = 3;
            this.ButtonDown.UseVisualStyleBackColor = true;
            this.ButtonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxNumber.Location = new System.Drawing.Point(30, 52);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(121, 24);
            this.comboBoxNumber.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Количество труб";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Обычный",
            "Ускоренный",
            "Турбо"});
            this.comboBoxType.Location = new System.Drawing.Point(208, 52);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 24);
            this.comboBoxType.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип трубы";
            // 
            // FormShip
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNumber);
            this.Controls.Add(this.ButtonDown);
            this.Controls.Add(this.ButtonUp);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.buttonСreate);
            this.Controls.Add(this.pictureBoxTeplo);
            this.Name = "FormTeplo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTeplo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
    
        private System.Windows.Forms.PictureBox pictureBoxTeplo;
        private System.Windows.Forms.Button buttonСreate;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonUp;
        private System.Windows.Forms.Button ButtonDown;
        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
    }
}

