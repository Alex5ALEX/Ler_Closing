namespace WarehousClosingClient.Views.ProviderView;

partial class ProviderRowControl
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
        labelCompany = new Label();
        labelContactPerson = new Label();
        labelContactPersonText = new Label();
        labelCompanyText = new Label();
        labelPhone = new Label();
        labelPhoneText = new Label();
        labelEmail = new Label();
        labelEmailText = new Label();
        labelAddres = new Label();
        labelAddresText = new Label();
        buttonCopy = new Button();
        groupBox1 = new GroupBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // labelId
        // 
        labelId.AutoSize = true;
        labelId.Font = new Font("Segoe UI", 12F);
        labelId.Location = new Point(16, 16);
        labelId.Name = "labelId";
        labelId.Size = new Size(26, 21);
        labelId.TabIndex = 0;
        labelId.Text = "Id:";
        // 
        // labelIdText
        // 
        labelIdText.AutoSize = true;
        labelIdText.Font = new Font("Segoe UI", 12F);
        labelIdText.Location = new Point(48, 16);
        labelIdText.Name = "labelIdText";
        labelIdText.Size = new Size(65, 21);
        labelIdText.TabIndex = 1;
        labelIdText.Text = "TEXT_ID";
        // 
        // labelCompany
        // 
        labelCompany.AutoSize = true;
        labelCompany.Font = new Font("Segoe UI", 12F);
        labelCompany.Location = new Point(15, 45);
        labelCompany.Name = "labelCompany";
        labelCompany.Size = new Size(80, 21);
        labelCompany.TabIndex = 2;
        labelCompany.Text = "Company:";
        // 
        // labelContactPerson
        // 
        labelContactPerson.AutoSize = true;
        labelContactPerson.Font = new Font("Segoe UI", 12F);
        labelContactPerson.Location = new Point(16, 70);
        labelContactPerson.Name = "labelContactPerson";
        labelContactPerson.Size = new Size(63, 42);
        labelContactPerson.TabIndex = 3;
        labelContactPerson.Text = "Contact\nPerson:";
        // 
        // labelContactPersonText
        // 
        labelContactPersonText.AutoSize = true;
        labelContactPersonText.Font = new Font("Segoe UI", 12F);
        labelContactPersonText.Location = new Point(95, 91);
        labelContactPersonText.Name = "labelContactPersonText";
        labelContactPersonText.Size = new Size(124, 21);
        labelContactPersonText.TabIndex = 5;
        labelContactPersonText.Text = "TEXT_SURNAME";
        // 
        // labelCompanyText
        // 
        labelCompanyText.AutoSize = true;
        labelCompanyText.Font = new Font("Segoe UI", 12F);
        labelCompanyText.Location = new Point(95, 45);
        labelCompanyText.Name = "labelCompanyText";
        labelCompanyText.Size = new Size(94, 21);
        labelCompanyText.TabIndex = 4;
        labelCompanyText.Text = "TEXT_NAME";
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(386, 49);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(57, 21);
        labelPhone.TabIndex = 6;
        labelPhone.Text = "Phone:";
        // 
        // labelPhoneText
        // 
        labelPhoneText.AutoSize = true;
        labelPhoneText.Font = new Font("Segoe UI", 12F);
        labelPhoneText.Location = new Point(461, 45);
        labelPhoneText.Name = "labelPhoneText";
        labelPhoneText.Size = new Size(102, 21);
        labelPhoneText.TabIndex = 7;
        labelPhoneText.Text = "TEXT_PHONE";
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(386, 70);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(51, 21);
        labelEmail.TabIndex = 8;
        labelEmail.Text = "Email:";
        // 
        // labelEmailText
        // 
        labelEmailText.AutoSize = true;
        labelEmailText.Font = new Font("Segoe UI", 12F);
        labelEmailText.Location = new Point(461, 70);
        labelEmailText.Name = "labelEmailText";
        labelEmailText.Size = new Size(94, 21);
        labelEmailText.TabIndex = 9;
        labelEmailText.Text = "TEXT_EMAIL";
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(386, 95);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(62, 21);
        labelAddres.TabIndex = 10;
        labelAddres.Text = "Addres:";
        // 
        // labelAddresText
        // 
        labelAddresText.AutoSize = true;
        labelAddresText.Font = new Font("Segoe UI", 12F);
        labelAddresText.Location = new Point(461, 95);
        labelAddresText.Name = "labelAddresText";
        labelAddresText.Size = new Size(109, 21);
        labelAddresText.TabIndex = 11;
        labelAddresText.Text = "TEXT_ADDRES";
        // 
        // buttonCopy
        // 
        buttonCopy.BackgroundImage = Properties.Resources.copy1_picture;
        buttonCopy.BackgroundImageLayout = ImageLayout.Stretch;
        buttonCopy.Font = new Font("Segoe UI", 12F);
        buttonCopy.Location = new Point(385, 10);
        buttonCopy.Name = "buttonCopy";
        buttonCopy.Size = new Size(40, 35);
        buttonCopy.TabIndex = 12;
        buttonCopy.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(labelContactPersonText);
        groupBox1.Controls.Add(labelContactPerson);
        groupBox1.Controls.Add(labelPhone);
        groupBox1.Controls.Add(labelPhoneText);
        groupBox1.Controls.Add(labelAddresText);
        groupBox1.Controls.Add(buttonCopy);
        groupBox1.Controls.Add(labelAddres);
        groupBox1.Controls.Add(labelIdText);
        groupBox1.Controls.Add(labelEmailText);
        groupBox1.Controls.Add(labelEmail);
        groupBox1.Controls.Add(labelId);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(770, 120);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // ProviderRowControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(labelCompanyText);
        Controls.Add(labelCompany);
        Controls.Add(groupBox1);
        Name = "ProviderRowControl";
        Size = new Size(770, 120);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label labelId;
    private Label labelIdText;
    private Label labelCompany;
    private Label labelContactPerson;
    private Label labelContactPersonText;
    private Label labelCompanyText;
    private Label labelPhone;
    private Label labelPhoneText;
    private Label labelEmail;
    private Label labelEmailText;
    private Label labelAddres;
    private Label labelAddresText;
    private Button buttonCopy;
    private GroupBox groupBox1;
}
