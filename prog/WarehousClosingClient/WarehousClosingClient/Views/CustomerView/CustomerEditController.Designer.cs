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
        buttonEdit = new Button();
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
        buttonDelete = new Button();
        SuspendLayout();
        // 
        // buttonBack
        // 
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(19, 464);
        buttonBack.Margin = new Padding(3, 4, 3, 4);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(149, 51);
        buttonBack.TabIndex = 25;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.Location = new Point(486, 464);
        buttonEdit.Margin = new Padding(3, 4, 3, 4);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(149, 51);
        buttonEdit.TabIndex = 24;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        // 
        // textBoxAddres
        // 
        textBoxAddres.Font = new Font("Segoe UI", 12F);
        textBoxAddres.Location = new Point(125, 400);
        textBoxAddres.Margin = new Padding(3, 4, 3, 4);
        textBoxAddres.Name = "textBoxAddres";
        textBoxAddres.Size = new Size(332, 32);
        textBoxAddres.TabIndex = 23;
        // 
        // textBoxEmail
        // 
        textBoxEmail.Font = new Font("Segoe UI", 12F);
        textBoxEmail.Location = new Point(125, 337);
        textBoxEmail.Margin = new Padding(3, 4, 3, 4);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(332, 32);
        textBoxEmail.TabIndex = 22;
        // 
        // textBoxPhone
        // 
        textBoxPhone.Font = new Font("Segoe UI", 12F);
        textBoxPhone.Location = new Point(125, 269);
        textBoxPhone.Margin = new Padding(3, 4, 3, 4);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(332, 32);
        textBoxPhone.TabIndex = 21;
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(125, 147);
        textBoxName.Margin = new Padding(3, 4, 3, 4);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(332, 32);
        textBoxName.TabIndex = 20;
        // 
        // textBoxSurname
        // 
        textBoxSurname.Font = new Font("Segoe UI", 12F);
        textBoxSurname.Location = new Point(125, 208);
        textBoxSurname.Margin = new Padding(3, 4, 3, 4);
        textBoxSurname.Name = "textBoxSurname";
        textBoxSurname.Size = new Size(332, 32);
        textBoxSurname.TabIndex = 19;
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(23, 410);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(75, 25);
        labelAddres.TabIndex = 18;
        labelAddres.Text = "Addres:";
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(23, 347);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(62, 25);
        labelEmail.TabIndex = 17;
        labelEmail.Text = "Email:";
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(23, 279);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(70, 25);
        labelPhone.TabIndex = 16;
        labelPhone.Text = "Phone:";
        // 
        // labelSurname
        // 
        labelSurname.AutoSize = true;
        labelSurname.Font = new Font("Segoe UI", 12F);
        labelSurname.Location = new Point(23, 218);
        labelSurname.Name = "labelSurname";
        labelSurname.Size = new Size(91, 25);
        labelSurname.TabIndex = 15;
        labelSurname.Text = "Surname:";
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(23, 157);
        labelName.Name = "labelName";
        labelName.Size = new Size(66, 25);
        labelName.TabIndex = 14;
        labelName.Text = "Name:";
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 14F);
        label.Location = new Point(23, 15);
        label.Name = "label";
        label.Size = new Size(149, 30);
        label.TabIndex = 13;
        label.Text = "Edit Customer";
        // 
        // labelId
        // 
        labelId.AutoSize = true;
        labelId.Font = new Font("Segoe UI", 12F);
        labelId.Location = new Point(23, 95);
        labelId.Name = "labelId";
        labelId.Size = new Size(32, 25);
        labelId.TabIndex = 26;
        labelId.Text = "Id:";
        // 
        // labelIdText
        // 
        labelIdText.AutoSize = true;
        labelIdText.Font = new Font("Segoe UI", 12F);
        labelIdText.Location = new Point(125, 95);
        labelIdText.Name = "labelIdText";
        labelIdText.Size = new Size(79, 25);
        labelIdText.TabIndex = 27;
        labelIdText.Text = "ID_TEXT";
        // 
        // buttonDelete
        // 
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.Location = new Point(250, 464);
        buttonDelete.Margin = new Padding(3, 4, 3, 4);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(149, 51);
        buttonDelete.TabIndex = 28;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        // 
        // CustomerEditController
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(buttonDelete);
        Controls.Add(labelIdText);
        Controls.Add(labelId);
        Controls.Add(buttonBack);
        Controls.Add(buttonEdit);
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
        Margin = new Padding(3, 4, 3, 4);
        Name = "CustomerEditController";
        Size = new Size(674, 532);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonBack;
    private Button buttonEdit;
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
    private Button buttonDelete;
}
