namespace WarehousClosingClient.Views.CustomerView;

partial class CustomerEditController
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
        buttonAdd = new Button();
        textBoxAddres = new TextBox();
        textBoxEmail = new TextBox();
        textBoxPhone = new TextBox();
        textBoxName = new TextBox();
        textBoxSurname = new TextBox();
        labelAddres = new Label();
        labelEmail = new Label();
        labelPhone = new Label();
        labelSurname = new Label();
        labelName = new Label();
        label = new Label();
        labelId = new Label();
        labelIdText = new Label();
        SuspendLayout();
        // 
        // buttonBack
        // 
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(17, 366);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(130, 40);
        buttonBack.TabIndex = 25;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // buttonAdd
        // 
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(425, 366);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(130, 40);
        buttonAdd.TabIndex = 24;
        buttonAdd.Text = "Edit";
        buttonAdd.UseVisualStyleBackColor = true;
        // 
        // textBoxAddres
        // 
        textBoxAddres.Font = new Font("Segoe UI", 12F);
        textBoxAddres.Location = new Point(109, 316);
        textBoxAddres.Name = "textBoxAddres";
        textBoxAddres.Size = new Size(291, 29);
        textBoxAddres.TabIndex = 23;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Font = new Font("Segoe UI", 12F);
        textBoxEmail.Location = new Point(109, 266);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(291, 29);
        textBoxEmail.TabIndex = 22;
        // 
        // textBoxPhone
        // 
        textBoxPhone.Font = new Font("Segoe UI", 12F);
        textBoxPhone.Location = new Point(109, 212);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(291, 29);
        textBoxPhone.TabIndex = 21;
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(109, 116);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(291, 29);
        textBoxName.TabIndex = 20;
        // 
        // textBoxSurname
        // 
        textBoxSurname.Font = new Font("Segoe UI", 12F);
        textBoxSurname.Location = new Point(109, 164);
        textBoxSurname.Name = "textBoxSurname";
        textBoxSurname.Size = new Size(291, 29);
        textBoxSurname.TabIndex = 19;
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(20, 324);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(62, 21);
        labelAddres.TabIndex = 18;
        labelAddres.Text = "Addres:";
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(20, 274);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(51, 21);
        labelEmail.TabIndex = 17;
        labelEmail.Text = "Email:";
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(20, 220);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(57, 21);
        labelPhone.TabIndex = 16;
        labelPhone.Text = "Phone:";
        // 
        // labelSurname
        // 
        labelSurname.AutoSize = true;
        labelSurname.Font = new Font("Segoe UI", 12F);
        labelSurname.Location = new Point(20, 172);
        labelSurname.Name = "labelSurname";
        labelSurname.Size = new Size(76, 21);
        labelSurname.TabIndex = 15;
        labelSurname.Text = "Surname:";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(20, 124);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 14;
        labelName.Text = "Name:";
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 14F);
        label.Location = new Point(20, 12);
        label.Name = "label";
        label.Size = new Size(130, 25);
        label.TabIndex = 13;
        label.Text = "Edit Customer";
        // 
        // labelId
        // 
        labelId.AutoSize = true;
        labelId.Font = new Font("Segoe UI", 12F);
        labelId.Location = new Point(20, 75);
        labelId.Name = "labelId";
        labelId.Size = new Size(26, 21);
        labelId.TabIndex = 26;
        labelId.Text = "Id:";
        // 
        // labelIdText
        // 
        labelIdText.AutoSize = true;
        labelIdText.Font = new Font("Segoe UI", 12F);
        labelIdText.Location = new Point(109, 75);
        labelIdText.Name = "labelIdText";
        labelIdText.Size = new Size(65, 21);
        labelIdText.TabIndex = 27;
        labelIdText.Text = "ID_TEXT";
        // 
        // CustomerEditController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(labelIdText);
        Controls.Add(labelId);
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
        Name = "CustomerEditController";
        Size = new Size(590, 420);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonBack;
    private Button buttonAdd;
    private TextBox textBoxAddres;
    private TextBox textBoxEmail;
    private TextBox textBoxPhone;
    private TextBox textBoxName;
    private TextBox textBoxSurname;
    private Label labelAddres;
    private Label labelEmail;
    private Label labelPhone;
    private Label labelSurname;
    private Label labelName;
    private Label label;
    private Label labelId;
    private Label labelIdText;
}
