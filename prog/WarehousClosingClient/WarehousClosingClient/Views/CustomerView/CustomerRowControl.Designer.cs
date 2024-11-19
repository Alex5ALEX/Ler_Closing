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
            labelId.Location = new Point(18, 13);
            labelId.Name = "labelId";
            labelId.Size = new Size(32, 25);
            labelId.TabIndex = 0;
            labelId.Text = "Id:";
            // 
            // labelIdText
            // 
            labelIdText.AutoSize = true;
            labelIdText.Font = new Font("Segoe UI", 12F);
            labelIdText.Location = new Point(48, 13);
            labelIdText.Name = "labelIdText";
            labelIdText.Size = new Size(79, 25);
            labelIdText.TabIndex = 1;
            labelIdText.Text = "TEXT_ID";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(17, 57);
            labelName.Name = "labelName";
            labelName.Size = new Size(48, 19);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Location = new Point(17, 89);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(66, 19);
            labelSurname.TabIndex = 3;
            labelSurname.Text = "Surname:";
            // 
            // labelSurnameText
            // 
            labelSurnameText.AutoSize = true;
            labelSurnameText.Location = new Point(87, 89);
            labelSurnameText.Name = "labelSurnameText";
            labelSurnameText.Size = new Size(108, 19);
            labelSurnameText.TabIndex = 5;
            labelSurnameText.Text = "TEXT_SURNAME";
            // 
            // labelNameText
            // 
            labelNameText.AutoSize = true;
            labelNameText.Location = new Point(87, 57);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(83, 19);
            labelNameText.TabIndex = 4;
            labelNameText.Text = "TEXT_NAME";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(17, 120);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(51, 19);
            labelPhone.TabIndex = 6;
            labelPhone.Text = "Phone:";
            // 
            // labelPhoneText
            // 
            labelPhoneText.AutoSize = true;
            labelPhoneText.Location = new Point(87, 120);
            labelPhoneText.Name = "labelPhoneText";
            labelPhoneText.Size = new Size(90, 19);
            labelPhoneText.TabIndex = 7;
            labelPhoneText.Text = "TEXT_PHONE";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(286, 57);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 19);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email:";
            // 
            // labelEmailText
            // 
            labelEmailText.AutoSize = true;
            labelEmailText.Location = new Point(343, 57);
            labelEmailText.Name = "labelEmailText";
            labelEmailText.Size = new Size(84, 19);
            labelEmailText.TabIndex = 9;
            labelEmailText.Text = "TEXT_EMAIL";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Location = new Point(286, 89);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(55, 19);
            labelAddres.TabIndex = 10;
            labelAddres.Text = "Addres:";
            // 
            // labelAddresText
            // 
            labelAddresText.AutoSize = true;
            labelAddresText.Location = new Point(343, 89);
            labelAddresText.Name = "labelAddresText";
            labelAddresText.Size = new Size(95, 19);
            labelAddresText.TabIndex = 11;
            labelAddresText.Text = "TEXT_ADDRES";
            // 
            // buttonCopy
            // 
            buttonCopy.Font = new Font("Segoe UI", 12F);
            buttonCopy.Location = new Point(442, 4);
            buttonCopy.Margin = new Padding(3, 4, 3, 4);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(86, 42);
            buttonCopy.TabIndex = 12;
            buttonCopy.Text = "Copy Id";
            buttonCopy.UseVisualStyleBackColor = true;
            // 
            // CustomerRowControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerRowControl";
            Size = new Size(663, 152);
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
