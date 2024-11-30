namespace WarehousClosingClient.Views.OrderView;

partial class OrderRowControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderRowControl));
        labelId = new Label();
        labelIdText = new Label();
        labelDate = new Label();
        labelIdCustomer = new Label();
        labelCustomerText = new Label();
        labelDateText = new Label();
        labelIdEmployee = new Label();
        labelEmployeeText = new Label();
        buttonCopy = new Button();
        groupBox1 = new GroupBox();
        buttonCopyEmployee = new Button();
        buttonCopyCustomer = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // labelId
        // 
        labelId.AutoSize = true;
        labelId.Font = new Font("Segoe UI", 12F);
        labelId.Location = new Point(6, 19);
        labelId.Name = "labelId";
        labelId.Size = new Size(26, 21);
        labelId.TabIndex = 0;
        labelId.Text = "Id:";
        // 
        // labelIdText
        // 
        labelIdText.AutoSize = true;
        labelIdText.Font = new Font("Segoe UI", 12F);
        labelIdText.Location = new Point(6, 46);
        labelIdText.Name = "labelIdText";
        labelIdText.Size = new Size(65, 21);
        labelIdText.TabIndex = 1;
        labelIdText.Text = "TEXT_ID";
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(6, 67);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(45, 21);
        labelDate.TabIndex = 2;
        labelDate.Text = "Date:";
        // 
        // labelIdCustomer
        // 
        labelIdCustomer.AutoSize = true;
        labelIdCustomer.Font = new Font("Segoe UI", 12F);
        labelIdCustomer.Location = new Point(6, 99);
        labelIdCustomer.Name = "labelIdCustomer";
        labelIdCustomer.Size = new Size(98, 21);
        labelIdCustomer.TabIndex = 3;
        labelIdCustomer.Text = "Id Customer:";
        // 
        // labelCustomerText
        // 
        labelCustomerText.AutoSize = true;
        labelCustomerText.Font = new Font("Segoe UI", 12F);
        labelCustomerText.Location = new Point(6, 120);
        labelCustomerText.Name = "labelCustomerText";
        labelCustomerText.Size = new Size(124, 21);
        labelCustomerText.TabIndex = 5;
        labelCustomerText.Text = "TEXT_SURNAME";
        // 
        // labelDateText
        // 
        labelDateText.AutoSize = true;
        labelDateText.Font = new Font("Segoe UI", 12F);
        labelDateText.Location = new Point(57, 67);
        labelDateText.Name = "labelDateText";
        labelDateText.Size = new Size(43, 21);
        labelDateText.TabIndex = 4;
        labelDateText.Text = "TEXT";
        // 
        // labelIdEmployee
        // 
        labelIdEmployee.AutoSize = true;
        labelIdEmployee.Font = new Font("Segoe UI", 12F);
        labelIdEmployee.Location = new Point(5, 148);
        labelIdEmployee.Name = "labelIdEmployee";
        labelIdEmployee.Size = new Size(101, 21);
        labelIdEmployee.TabIndex = 6;
        labelIdEmployee.Text = "Id_Employee:";
        // 
        // labelEmployeeText
        // 
        labelEmployeeText.AutoSize = true;
        labelEmployeeText.Font = new Font("Segoe UI", 12F);
        labelEmployeeText.Location = new Point(6, 169);
        labelEmployeeText.Name = "labelEmployeeText";
        labelEmployeeText.Size = new Size(102, 21);
        labelEmployeeText.TabIndex = 7;
        labelEmployeeText.Text = "TEXT_PHONE";
        // 
        // buttonCopy
        // 
        buttonCopy.BackgroundImage = (Image)resources.GetObject("buttonCopy.BackgroundImage");
        buttonCopy.BackgroundImageLayout = ImageLayout.Stretch;
        buttonCopy.Font = new Font("Segoe UI", 12F);
        buttonCopy.Location = new Point(38, 12);
        buttonCopy.Name = "buttonCopy";
        buttonCopy.Size = new Size(30, 28);
        buttonCopy.TabIndex = 12;
        buttonCopy.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(buttonCopyEmployee);
        groupBox1.Controls.Add(buttonCopyCustomer);
        groupBox1.Controls.Add(labelIdCustomer);
        groupBox1.Controls.Add(labelDateText);
        groupBox1.Controls.Add(labelCustomerText);
        groupBox1.Controls.Add(labelEmployeeText);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Controls.Add(buttonCopy);
        groupBox1.Controls.Add(labelIdEmployee);
        groupBox1.Controls.Add(labelIdText);
        groupBox1.Controls.Add(labelId);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(375, 200);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // buttonCopyEmployee
        // 
        buttonCopyEmployee.BackgroundImage = (Image)resources.GetObject("buttonCopyEmployee.BackgroundImage");
        buttonCopyEmployee.BackgroundImageLayout = ImageLayout.Stretch;
        buttonCopyEmployee.Font = new Font("Segoe UI", 12F);
        buttonCopyEmployee.Location = new Point(112, 141);
        buttonCopyEmployee.Name = "buttonCopyEmployee";
        buttonCopyEmployee.Size = new Size(30, 28);
        buttonCopyEmployee.TabIndex = 14;
        buttonCopyEmployee.UseVisualStyleBackColor = true;
        // 
        // buttonCopyCustomer
        // 
        buttonCopyCustomer.BackgroundImage = (Image)resources.GetObject("buttonCopyCustomer.BackgroundImage");
        buttonCopyCustomer.BackgroundImageLayout = ImageLayout.Stretch;
        buttonCopyCustomer.Font = new Font("Segoe UI", 12F);
        buttonCopyCustomer.Location = new Point(112, 92);
        buttonCopyCustomer.Name = "buttonCopyCustomer";
        buttonCopyCustomer.Size = new Size(30, 28);
        buttonCopyCustomer.TabIndex = 13;
        buttonCopyCustomer.UseVisualStyleBackColor = true;
        // 
        // OrderRowControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Name = "OrderRowControl";
        Size = new Size(377, 200);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label labelId;
    private Label labelIdText;
    private Label labelDate;
    private Label labelIdCustomer;
    private Label labelCustomerText;
    private Label labelDateText;
    private Label labelIdEmployee;
    private Label labelEmployeeText;
    private Button buttonCopy;
    private GroupBox groupBox1;
    private Button buttonCopyEmployee;
    private Button buttonCopyCustomer;
}
