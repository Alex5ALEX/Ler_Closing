namespace WarehousClosingClient.Views.CustomerView
{
    partial class CustomerRowControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            labelId = new Label();
            labelIdText = new Label();
            labelName = new Label();
            labelSurname = new Label();
            labelSurnameText = new Label();
            labelNameText = new Label();
            labelPhone = new Label();
            labelPhoneText = new Label();
            labelEmail = new Label();
            labelEmailText = new Label();
            labelAddres = new Label();
            labelAddresText = new Label();
            buttonCopy = new Button();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F);
            labelId.Location = new Point(16, 10);
            labelId.Name = "labelId";
            labelId.Size = new Size(26, 21);
            labelId.TabIndex = 0;
            labelId.Text = "Id:";
            // 
            // labelIdText
            // 
            labelIdText.AutoSize = true;
            labelIdText.Font = new Font("Segoe UI", 12F);
            labelIdText.Location = new Point(42, 10);
            labelIdText.Name = "labelIdText";
            labelIdText.Size = new Size(65, 21);
            labelIdText.TabIndex = 1;
            labelIdText.Text = "TEXT_ID";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(15, 45);
            labelName.Name = "labelName";
            labelName.Size = new Size(42, 15);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(15, 70);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(57, 15);
            labelSurname.TabIndex = 3;
            labelSurname.Text = "Surname:";
            // 
            // labelSurnameText
            // 
            labelSurnameText.AutoSize = true;
            labelSurnameText.Location = new Point(76, 70);
            labelSurnameText.Name = "labelSurnameText";
            labelSurnameText.Size = new Size(92, 15);
            labelSurnameText.TabIndex = 5;
            labelSurnameText.Text = "TEXT_SURNAME";
            // 
            // labelNameText
            // 
            labelNameText.AutoSize = true;
            labelNameText.Location = new Point(76, 45);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(71, 15);
            labelNameText.TabIndex = 4;
            labelNameText.Text = "TEXT_NAME";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(15, 95);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(44, 15);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Phone:";
            // 
            // labelPhoneText
            // 
            labelPhoneText.AutoSize = true;
            labelPhoneText.Location = new Point(76, 95);
            labelPhoneText.Name = "labelPhoneText";
            labelPhoneText.Size = new Size(77, 15);
            labelPhoneText.TabIndex = 7;
            labelPhoneText.Text = "TEXT_PHONE";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(250, 45);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email:";
            // 
            // labelEmailText
            // 
            labelEmailText.AutoSize = true;
            labelEmailText.Location = new Point(300, 45);
            labelEmailText.Name = "labelEmailText";
            labelEmailText.Size = new Size(71, 15);
            labelEmailText.TabIndex = 9;
            labelEmailText.Text = "TEXT_EMAIL";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Location = new Point(250, 70);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(47, 15);
            labelAddres.TabIndex = 10;
            labelAddres.Text = "Addres:";
            // 
            // labelAddresText
            // 
            labelAddresText.AutoSize = true;
            labelAddresText.Location = new Point(300, 70);
            labelAddresText.Name = "labelAddresText";
            labelAddresText.Size = new Size(80, 15);
            labelAddresText.TabIndex = 11;
            labelAddresText.Text = "TEXT_ADDRES";
            // 
            // buttonCopy
            // 
            buttonCopy.Font = new Font("Segoe UI", 12F);
            buttonCopy.Location = new Point(354, 4);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(75, 33);
            buttonCopy.TabIndex = 12;
            buttonCopy.Text = "Copy Id";
            buttonCopy.UseVisualStyleBackColor = true;
            // 
            // CustomerRowControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonCopy);
            Controls.Add(labelAddresText);
            Controls.Add(labelAddres);
            Controls.Add(labelEmailText);
            Controls.Add(labelEmail);
            Controls.Add(labelPhoneText);
            Controls.Add(labelPhone);
            Controls.Add(labelSurnameText);
            Controls.Add(labelNameText);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(labelIdText);
            Controls.Add(labelId);
            Name = "CustomerRowControl";
            Size = new Size(580, 120);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Label labelIdText;
        private Label labelName;
        private Label labelSurname;
        private Label labelSurnameText;
        private Label labelNameText;
        private Label labelPhone;
        private Label labelPhoneText;
        private Label labelEmail;
        private Label labelEmailText;
        private Label labelAddres;
        private Label labelAddresText;
        private Button buttonCopy;
    }
}
