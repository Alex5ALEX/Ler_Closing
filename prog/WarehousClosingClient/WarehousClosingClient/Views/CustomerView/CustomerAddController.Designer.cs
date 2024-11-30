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
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 20F);
            label.Location = new Point(6, 19);
            label.Name = "label";
            label.Size = new Size(187, 37);
            label.TabIndex = 0;
            label.Text = "Add Customer";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(27, 115);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 1;
            labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Segoe UI", 12F);
            labelSurname.Location = new Point(27, 157);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(76, 21);
            labelSurname.TabIndex = 2;
            labelSurname.Text = "Surname:";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F);
            labelPhone.Location = new Point(27, 203);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(57, 21);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "Phone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F);
            labelEmail.Location = new Point(27, 253);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 21);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email:";
            // 
            // labelAddres
            // 
            labelAddres.AutoSize = true;
            labelAddres.Font = new Font("Segoe UI", 12F);
            labelAddres.Location = new Point(27, 303);
            labelAddres.Name = "labelAddres";
            labelAddres.Size = new Size(62, 21);
            labelAddres.TabIndex = 5;
            labelAddres.Text = "Addres:";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Segoe UI", 12F);
            textBoxSurname.Location = new Point(108, 149);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(291, 29);
            textBoxSurname.TabIndex = 6;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 12F);
            textBoxName.Location = new Point(108, 107);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(291, 29);
            textBoxName.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F);
            textBoxPhone.Location = new Point(108, 195);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(291, 29);
            textBoxPhone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F);
            textBoxEmail.Location = new Point(108, 245);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(291, 29);
            textBoxEmail.TabIndex = 9;
            // 
            // textBoxAddres
            // 
            textBoxAddres.Font = new Font("Segoe UI", 12F);
            textBoxAddres.Location = new Point(108, 295);
            textBoxAddres.Name = "textBoxAddres";
            textBoxAddres.Size = new Size(291, 29);
            textBoxAddres.TabIndex = 10;
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI", 12F);
            buttonAdd.Location = new Point(307, 509);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(122, 70);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 12F);
            buttonBack.Location = new Point(6, 509);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(122, 70);
            buttonBack.TabIndex = 12;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(buttonBack);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(labelSurname);
            groupBox1.Controls.Add(textBoxAddres);
            groupBox1.Controls.Add(labelPhone);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(labelAddres);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(textBoxSurname);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(435, 585);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // CustomerAddController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "CustomerAddController";
            Size = new Size(435, 585);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
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
        private GroupBox groupBox1;
    }
}
