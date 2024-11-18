namespace WarehousClosingClient.Views.CustomerView
{
    partial class CustomerAddController
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
            label = new Label();
            labelName = new Label();
            labelSurname = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelAddres = new Label();
            textBoxSurname = new TextBox();
            textBoxName = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAddres = new TextBox();
            buttonAdd = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 14F);
            label.Location = new Point(17, 11);
            label.Name = "label";
            label.Size = new Size(93, 50);
            label.TabIndex = 0;
            label.Text = "Add new \nCustomer";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(20, 80);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(20, 130);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(76, 21);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Surname:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(20, 180);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Phone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(20, 230);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(20, 280);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 5;
            labelAddres.Text = "Addres:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(103, 130);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(291, 23);
            textBoxSurname.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(103, 78);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 23);
            textBoxName.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(103, 178);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(291, 23);
            textBoxPhone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(103, 228);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(291, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxAddres
            // 
            textBoxAddres.Location = new Point(103, 278);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(291, 23);
            textBoxAddres.TabIndex = 10;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(425, 363);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(130, 40);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(17, 363);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(130, 40);
            buttonBack.TabIndex = 12;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // CustomerAddController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonBack);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAddres);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
            Controls.Add(textBoxSurname);
            Controls.Add(labelAddres);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelSurname);
            Controls.Add(labelName);
            Controls.Add(label);
            Name = "CustomerAddController";
            Size = new Size(590, 420);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label labelName;
        private Label labelSurname;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelAddres;
        private TextBox textBoxSurname;
        private TextBox textBoxName;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxAddres;
        private Button buttonAdd;
        private Button buttonBack;
    }
}
