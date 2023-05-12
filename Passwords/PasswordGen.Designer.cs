namespace Passwords
{
    partial class PasswordGen
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxMixedChar = new System.Windows.Forms.CheckBox();
            this.checkBoxStrnChar = new System.Windows.Forms.CheckBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.passwordLenght = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.checkBoxCurse = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(56, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Длина пароля:";
            // 
            // checkBoxMixedChar
            // 
            this.checkBoxMixedChar.AutoSize = true;
            this.checkBoxMixedChar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMixedChar.Location = new System.Drawing.Point(56, 147);
            this.checkBoxMixedChar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMixedChar.Name = "checkBoxMixedChar";
            this.checkBoxMixedChar.Size = new System.Drawing.Size(399, 30);
            this.checkBoxMixedChar.TabIndex = 4;
            this.checkBoxMixedChar.Text = "Исключить символы: i, l, 1, L, o, 0, O ";
            this.checkBoxMixedChar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkBoxMixedChar.UseVisualStyleBackColor = true;
            // 
            // checkBoxStrnChar
            // 
            this.checkBoxStrnChar.AutoSize = true;
            this.checkBoxStrnChar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxStrnChar.Location = new System.Drawing.Point(56, 187);
            this.checkBoxStrnChar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxStrnChar.Name = "checkBoxStrnChar";
            this.checkBoxStrnChar.Size = new System.Drawing.Size(495, 30);
            this.checkBoxStrnChar.TabIndex = 5;
            this.checkBoxStrnChar.Text = "Исключить символы: { } [ ] ( ) / \\ \' \" ` ~ , ; : . < >";
            this.checkBoxStrnChar.UseVisualStyleBackColor = true;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.BackColor = System.Drawing.Color.MediumPurple;
            this.btnGeneratePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeneratePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGeneratePassword.Location = new System.Drawing.Point(633, 227);
            this.btnGeneratePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(231, 39);
            this.btnGeneratePassword.TabIndex = 6;
            this.btnGeneratePassword.Text = "Сгенерировать пароль";
            this.btnGeneratePassword.UseVisualStyleBackColor = false;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // passwordLenght
            // 
            this.passwordLenght.BackColor = System.Drawing.Color.OldLace;
            this.passwordLenght.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passwordLenght.FormattingEnabled = true;
            this.passwordLenght.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.passwordLenght.Location = new System.Drawing.Point(217, 116);
            this.passwordLenght.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordLenght.Name = "passwordLenght";
            this.passwordLenght.Size = new System.Drawing.Size(110, 28);
            this.passwordLenght.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(559, 112);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(305, 105);
            this.textBoxPassword.TabIndex = 10;
            // 
            // checkBoxCurse
            // 
            this.checkBoxCurse.AutoSize = true;
            this.checkBoxCurse.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCurse.Location = new System.Drawing.Point(56, 227);
            this.checkBoxCurse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxCurse.Name = "checkBoxCurse";
            this.checkBoxCurse.Size = new System.Drawing.Size(316, 30);
            this.checkBoxCurse.TabIndex = 12;
            this.checkBoxCurse.Text = "Генератор итальянского мата";
            this.checkBoxCurse.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(56, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Генератор паролей";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PasswordGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxCurse);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.passwordLenght);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.checkBoxStrnChar);
            this.Controls.Add(this.checkBoxMixedChar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PasswordGen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxMixedChar;
        private System.Windows.Forms.CheckBox checkBoxStrnChar;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.ComboBox passwordLenght;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxCurse;
        private Label label4;
    }
}