namespace WarehousClosingClient.Views.ProviderView;

partial class ProviderEditController
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
        buttonBack = new Button();
        buttonEdit = new Button();
        textBoxAddres = new TextBox();
        textBoxEmail = new TextBox();
        textBoxPhone = new TextBox();
        textBoxCompany = new TextBox();
        textBoxContactPerson = new TextBox();
        labelAddres = new Label();
        labelEmail = new Label();
        labelPhone = new Label();
        labelContactPerson = new Label();
        labelCompany = new Label();
        label = new Label();
        labelId = new Label();
        buttonDelete = new Button();
        groupBox1 = new GroupBox();
        richTextBoxId = new RichTextBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // buttonBack
        // 
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(7, 643);
        buttonBack.Margin = new Padding(3, 4, 3, 4);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(99, 90);
        buttonBack.TabIndex = 25;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.Location = new Point(376, 643);
        buttonEdit.Margin = new Padding(3, 4, 3, 4);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(99, 90);
        buttonEdit.TabIndex = 24;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        // 
        // textBoxAddres
        // 
        textBoxAddres.Font = new Font("Segoe UI", 12F);
        textBoxAddres.Location = new Point(143, 493);
        textBoxAddres.Margin = new Padding(3, 4, 3, 4);
        textBoxAddres.Name = "textBoxAddres";
        textBoxAddres.Size = new Size(332, 32);
        textBoxAddres.TabIndex = 23;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Font = new Font("Segoe UI", 12F);
        textBoxEmail.Location = new Point(143, 429);
        textBoxEmail.Margin = new Padding(3, 4, 3, 4);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(332, 32);
        textBoxEmail.TabIndex = 22;
        // 
        // textBoxPhone
        // 
        textBoxPhone.Font = new Font("Segoe UI", 12F);
        textBoxPhone.Location = new Point(143, 361);
        textBoxPhone.Margin = new Padding(3, 4, 3, 4);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(332, 32);
        textBoxPhone.TabIndex = 21;
        // 
        // textBoxCompany
        // 
        textBoxCompany.Font = new Font("Segoe UI", 12F);
        textBoxCompany.Location = new Point(143, 219);
        textBoxCompany.Margin = new Padding(3, 4, 3, 4);
        textBoxCompany.Name = "textBoxCompany";
        textBoxCompany.Size = new Size(332, 32);
        textBoxCompany.TabIndex = 20;
        // 
        // textBoxContactPerson
        // 
        textBoxContactPerson.Font = new Font("Segoe UI", 12F);
        textBoxContactPerson.Location = new Point(143, 296);
        textBoxContactPerson.Margin = new Padding(3, 4, 3, 4);
        textBoxContactPerson.Name = "textBoxContactPerson";
        textBoxContactPerson.Size = new Size(332, 32);
        textBoxContactPerson.TabIndex = 19;
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(42, 503);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(75, 25);
        labelAddres.TabIndex = 18;
        labelAddres.Text = "Addres:";
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(42, 440);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(62, 25);
        labelEmail.TabIndex = 17;
        labelEmail.Text = "Email:";
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(41, 371);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(70, 25);
        labelPhone.TabIndex = 16;
        labelPhone.Text = "Phone:";
        // 
        // labelContactPerson
        // 
        labelContactPerson.AutoSize = true;
        labelContactPerson.Font = new Font("Segoe UI", 12F);
        labelContactPerson.Location = new Point(42, 280);
        labelContactPerson.Name = "labelContactPerson";
        labelContactPerson.Size = new Size(77, 50);
        labelContactPerson.TabIndex = 15;
        labelContactPerson.Text = "Contact\nPerson:";
        // 
        // labelCompany
        // 
        labelCompany.AutoSize = true;
        labelCompany.Font = new Font("Segoe UI", 12F);
        labelCompany.Location = new Point(41, 229);
        labelCompany.Name = "labelCompany";
        labelCompany.Size = new Size(96, 25);
        labelCompany.TabIndex = 14;
        labelCompany.Text = "Company:";
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(7, 24);
        label.Name = "label";
        label.Size = new Size(193, 42);
        label.TabIndex = 13;
        label.Text = "Edit Provider";
        // 
        // labelId
        // 
        labelId.AutoSize = true;
        labelId.Font = new Font("Segoe UI", 12F);
        labelId.Location = new Point(41, 152);
        labelId.Name = "labelId";
        labelId.Size = new Size(32, 25);
        labelId.TabIndex = 26;
        labelId.Text = "Id:";
        // 
        // buttonDelete
        // 
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.Location = new Point(191, 643);
        buttonDelete.Margin = new Padding(3, 4, 3, 4);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(99, 90);
        buttonDelete.TabIndex = 28;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(richTextBoxId);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(buttonDelete);
        groupBox1.Controls.Add(labelCompany);
        groupBox1.Controls.Add(labelContactPerson);
        groupBox1.Controls.Add(labelId);
        groupBox1.Controls.Add(labelPhone);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(labelEmail);
        groupBox1.Controls.Add(buttonEdit);
        groupBox1.Controls.Add(labelAddres);
        groupBox1.Controls.Add(textBoxAddres);
        groupBox1.Controls.Add(textBoxContactPerson);
        groupBox1.Controls.Add(textBoxEmail);
        groupBox1.Controls.Add(textBoxCompany);
        groupBox1.Controls.Add(textBoxPhone);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(497, 741);
        groupBox1.TabIndex = 29;
        groupBox1.TabStop = false;
        // 
        // richTextBoxId
        // 
        richTextBoxId.Font = new Font("Segoe UI", 12F);
        richTextBoxId.Location = new Point(143, 89);
        richTextBoxId.Margin = new Padding(3, 4, 3, 4);
        richTextBoxId.Name = "richTextBoxId";
        richTextBoxId.Size = new Size(332, 89);
        richTextBoxId.TabIndex = 29;
        richTextBoxId.Text = "";
        // 
        // ProviderEditController
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "ProviderEditController";
        Size = new Size(497, 741);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonBack;
    private Button buttonEdit;
    private TextBox textBoxAddres;
    private TextBox textBoxEmail;
    private TextBox textBoxPhone;
    private TextBox textBoxCompany;
    private TextBox textBoxContactPerson;
    private Label labelAddres;
    private Label labelEmail;
    private Label labelPhone;
    private Label labelContactPerson;
    private Label labelCompany;
    private Label label;
    private Label labelId;
    private Button buttonDelete;
    private GroupBox groupBox1;
    private RichTextBox richTextBoxId;
}
