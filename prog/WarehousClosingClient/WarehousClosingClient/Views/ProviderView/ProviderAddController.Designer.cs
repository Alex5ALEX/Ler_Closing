namespace WarehousClosingClient.Views.ProviderView
{
    partial class ProviderAddController
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
            labelCompany = new Label();
            labelContactPersom = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelAddres = new Label();
            textBoxContactPerson = new TextBox();
            textBoxCompany = new TextBox();
            textBoxPhone = new TextBox();
            textBoxEmail = new TextBox();
            textBoxAddres = new TextBox();
            buttonAdd = new Button();
            buttonBack = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(7, 24);
            label.Name = "label";
            label.Size = new Size(196, 42);
            label.TabIndex = 0;
            label.Text = "Add Provider";
            // 
            // labelCompany
            // 
            labelCompany.AutoSize = true;
            labelCompany.Font = new Font("Segoe UI", 12F);
            labelCompany.Location = new Point(31, 153);
            labelCompany.Name = "labelCompany";
            labelCompany.Size = new Size(96, 25);
            labelCompany.TabIndex = 1;
            labelCompany.Text = "Company:";
            // 
            // labelContactPersom
            // 
            labelContactPersom.AutoSize = true;
            labelContactPersom.Font = new Font("Segoe UI", 12F);
            labelContactPersom.Location = new Point(31, 199);
            labelContactPersom.Name = "labelContactPersom";
            labelContactPersom.Size = new Size(77, 50);
            labelContactPersom.TabIndex = 2;
            labelContactPersom.Text = "Contact\nPerson:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(37, 285);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(70, 25);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Phone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(37, 348);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(62, 25);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(37, 412);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(75, 25);
            labelAddres.TabIndex = 5;
            labelAddres.Text = "Addres:";
            // 
            // textBoxContactPerson
            // 
            textBoxContactPerson.Font = new Font("Segoe UI", 12F);
            textBoxContactPerson.Location = new Point(129, 215);
            textBoxContactPerson.Margin = new Padding(3, 4, 3, 4);
            textBoxContactPerson.Name = "textBoxContactPerson";
            textBoxContactPerson.Size = new Size(332, 32);
            textBoxContactPerson.TabIndex = 6;
            // 
            // textBoxCompany
            // 
            textBoxCompany.Font = new Font("Segoe UI", 12F);
            textBoxCompany.Location = new Point(129, 143);
            textBoxCompany.Margin = new Padding(3, 4, 3, 4);
            textBoxCompany.Name = "textBoxCompany";
            textBoxCompany.Size = new Size(332, 32);
            textBoxCompany.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(129, 275);
            textBoxPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(332, 32);
            textBoxPhone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(129, 338);
            textBoxEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(332, 32);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(129, 402);
            textBoxAddres.Margin = new Padding(3, 4, 3, 4);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(332, 32);
            textBoxAddres.TabIndex = 10;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(351, 645);
            buttonAdd.Margin = new Padding(3, 4, 3, 4);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(139, 89);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(7, 645);
            buttonBack.Margin = new Padding(3, 4, 3, 4);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(139, 89);
            buttonBack.TabIndex = 12;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(labelCompany);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(labelContactPersom);
            groupBox1.Controls.Add(textBoxAddres);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(labelAddres);
            groupBox1.Controls.Add(textBoxCompany);
            groupBox1.Controls.Add(textBoxContactPerson);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(497, 741);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // ProviderAddController
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProviderAddController";
            Size = new Size(497, 741);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label;
        private Label labelCompany;
        private Label labelContactPersom;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelAddres;
        private TextBox textBoxContactPerson;
        private TextBox textBoxCompany;
        private TextBox textBoxPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxAddres;
        private Button buttonAdd;
        private Button buttonBack;
        private GroupBox groupBox1;
    }
}
