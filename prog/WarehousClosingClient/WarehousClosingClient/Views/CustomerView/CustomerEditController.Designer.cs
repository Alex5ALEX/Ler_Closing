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
        label = new Label();
        buttonDelete = new Button();
        groupBox1 = new GroupBox();
        labelName = new Label();
        labelSurname = new Label();
        textBoxAddres = new TextBox();
        labelPhone = new Label();
        textBoxEmail = new TextBox();
        labelEmail = new Label();
        textBoxPhone = new TextBox();
        labelAddres = new Label();
        textBoxName = new TextBox();
        textBoxSurname = new TextBox();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // buttonBack
        // 
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.ForeColor = SystemColors.ControlText;
        buttonBack.Location = new Point(3, 559);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 25;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = true;
        // 
        // buttonEdit
        // 
        buttonEdit.BackColor = Color.Aqua;
        buttonEdit.FlatStyle = FlatStyle.Flat;
        buttonEdit.Font = new Font("Segoe UI", 12F);
        buttonEdit.ForeColor = SystemColors.ControlText;
        buttonEdit.Location = new Point(237, 559);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(100, 50);
        buttonEdit.TabIndex = 24;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = false;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(184, 37);
        label.TabIndex = 13;
        label.Text = "Edit Customer";
        // 
        // buttonDelete
        // 
        buttonDelete.BackColor = Color.Red;
        buttonDelete.FlatStyle = FlatStyle.Flat;
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.ForeColor = SystemColors.ControlText;
        buttonDelete.Location = new Point(120, 559);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(100, 50);
        buttonDelete.TabIndex = 28;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = false;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(labelName);
        groupBox1.Controls.Add(labelSurname);
        groupBox1.Controls.Add(textBoxAddres);
        groupBox1.Controls.Add(labelPhone);
        groupBox1.Controls.Add(textBoxEmail);
        groupBox1.Controls.Add(labelEmail);
        groupBox1.Controls.Add(textBoxPhone);
        groupBox1.Controls.Add(labelAddres);
        groupBox1.Controls.Add(textBoxName);
        groupBox1.Controls.Add(textBoxSurname);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(buttonDelete);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonEdit);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(340, 615);
        groupBox1.TabIndex = 29;
        groupBox1.TabStop = false;
        // 
        // labelName
        // 
        labelName.AutoSize = true;
        labelName.Font = new Font("Segoe UI", 12F);
        labelName.Location = new Point(22, 75);
        labelName.Name = "labelName";
        labelName.Size = new Size(55, 21);
        labelName.TabIndex = 29;
        labelName.Text = "Name:";
        // 
        // labelSurname
        // 
        labelSurname.AutoSize = true;
        labelSurname.Font = new Font("Segoe UI", 12F);
        labelSurname.Location = new Point(22, 131);
        labelSurname.Name = "labelSurname";
        labelSurname.Size = new Size(76, 21);
        labelSurname.TabIndex = 30;
        labelSurname.Text = "Surname:";
        // 
        // textBoxAddres
        // 
        textBoxAddres.Font = new Font("Segoe UI", 12F);
        textBoxAddres.Location = new Point(22, 323);
        textBoxAddres.Name = "textBoxAddres";
        textBoxAddres.Size = new Size(291, 29);
        textBoxAddres.TabIndex = 38;
        // 
        // labelPhone
        // 
        labelPhone.AutoSize = true;
        labelPhone.Font = new Font("Segoe UI", 12F);
        labelPhone.Location = new Point(22, 187);
        labelPhone.Name = "labelPhone";
        labelPhone.Size = new Size(57, 21);
        labelPhone.TabIndex = 31;
        labelPhone.Text = "Phone:";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Font = new Font("Segoe UI", 12F);
        textBoxEmail.Location = new Point(22, 267);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(291, 29);
        textBoxEmail.TabIndex = 37;
        // 
        // labelEmail
        // 
        labelEmail.AutoSize = true;
        labelEmail.Font = new Font("Segoe UI", 12F);
        labelEmail.Location = new Point(22, 243);
        labelEmail.Name = "labelEmail";
        labelEmail.Size = new Size(51, 21);
        labelEmail.TabIndex = 32;
        labelEmail.Text = "Email:";
        // 
        // textBoxPhone
        // 
        textBoxPhone.Font = new Font("Segoe UI", 12F);
        textBoxPhone.Location = new Point(22, 211);
        textBoxPhone.Name = "textBoxPhone";
        textBoxPhone.Size = new Size(291, 29);
        textBoxPhone.TabIndex = 36;
        // 
        // labelAddres
        // 
        labelAddres.AutoSize = true;
        labelAddres.Font = new Font("Segoe UI", 12F);
        labelAddres.Location = new Point(22, 299);
        labelAddres.Name = "labelAddres";
        labelAddres.Size = new Size(62, 21);
        labelAddres.TabIndex = 33;
        labelAddres.Text = "Addres:";
        // 
        // textBoxName
        // 
        textBoxName.Font = new Font("Segoe UI", 12F);
        textBoxName.Location = new Point(22, 99);
        textBoxName.Name = "textBoxName";
        textBoxName.Size = new Size(291, 29);
        textBoxName.TabIndex = 35;
        // 
        // textBoxSurname
        // 
        textBoxSurname.Font = new Font("Segoe UI", 12F);
        textBoxSurname.Location = new Point(22, 155);
        textBoxSurname.Name = "textBoxSurname";
        textBoxSurname.Size = new Size(291, 29);
        textBoxSurname.TabIndex = 34;
        // 
        // CustomerEditController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "CustomerEditController";
        Size = new Size(340, 615);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button buttonBack;
    private Button buttonEdit;
    private Label label;
    private Button buttonDelete;
    private GroupBox groupBox1;
    private Label labelName;
    private Label labelSurname;
    private TextBox textBoxAddres;
    private Label labelPhone;
    private TextBox textBoxEmail;
    private Label labelEmail;
    private TextBox textBoxPhone;
    private Label labelAddres;
    private TextBox textBoxName;
    private TextBox textBoxSurname;
}
