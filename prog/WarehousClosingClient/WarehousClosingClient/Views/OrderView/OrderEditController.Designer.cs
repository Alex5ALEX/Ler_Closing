namespace WarehousClosingClient.Views.OrderView;

partial class OrderEditController
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
        labelId = new Label();
        textBoxId = new TextBox();
        labelDate = new Label();
        labelCustomer = new Label();
        labelEmployee = new Label();
        textBoxEmployee = new TextBox();
        textBoxDate = new TextBox();
        textBoxCustomer = new TextBox();
        flowLayoutPanel1 = new FlowLayoutPanel();
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
        buttonEdit.Location = new Point(345, 643);
        buttonEdit.Margin = new Padding(3, 4, 3, 4);
        buttonEdit.Name = "buttonEdit";
        buttonEdit.Size = new Size(99, 90);
        buttonEdit.TabIndex = 24;
        buttonEdit.Text = "Edit";
        buttonEdit.UseVisualStyleBackColor = true;
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(7, 24);
        label.Name = "label";
        label.Size = new Size(158, 42);
        label.TabIndex = 13;
        label.Text = "Edit Order";
        // 
        // buttonDelete
        // 
        buttonDelete.Font = new Font("Segoe UI", 12F);
        buttonDelete.Location = new Point(173, 643);
        buttonDelete.Margin = new Padding(3, 4, 3, 4);
        buttonDelete.Name = "buttonDelete";
        buttonDelete.Size = new Size(99, 90);
        buttonDelete.TabIndex = 28;
        buttonDelete.Text = "Delete";
        buttonDelete.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(labelId);
        groupBox1.Controls.Add(textBoxId);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Controls.Add(buttonDelete);
        groupBox1.Controls.Add(labelCustomer);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(labelEmployee);
        groupBox1.Controls.Add(buttonEdit);
        groupBox1.Controls.Add(textBoxEmployee);
        groupBox1.Controls.Add(textBoxDate);
        groupBox1.Controls.Add(textBoxCustomer);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(949, 741);
        groupBox1.TabIndex = 29;
        groupBox1.TabStop = false;
        // 
        // labelId
        // 
        labelId.AutoSize = true;
        labelId.Font = new Font("Segoe UI", 12F);
        labelId.Location = new Point(19, 113);
        labelId.Name = "labelId";
        labelId.Size = new Size(32, 25);
        labelId.TabIndex = 36;
        labelId.Text = "Id:";
        // 
        // textBoxId
        // 
        textBoxId.Font = new Font("Segoe UI", 12F);
        textBoxId.Location = new Point(122, 103);
        textBoxId.Margin = new Padding(3, 4, 3, 4);
        textBoxId.Name = "textBoxId";
        textBoxId.Size = new Size(322, 32);
        textBoxId.TabIndex = 37;
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(19, 172);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(55, 25);
        labelDate.TabIndex = 30;
        labelDate.Text = "Date:";
        // 
        // labelCustomer
        // 
        labelCustomer.AutoSize = true;
        labelCustomer.Font = new Font("Segoe UI", 12F);
        labelCustomer.Location = new Point(19, 225);
        labelCustomer.Name = "labelCustomer";
        labelCustomer.Size = new Size(97, 25);
        labelCustomer.TabIndex = 31;
        labelCustomer.Text = "Customer:";
        // 
        // labelEmployee
        // 
        labelEmployee.AutoSize = true;
        labelEmployee.Font = new Font("Segoe UI", 12F);
        labelEmployee.Location = new Point(19, 284);
        labelEmployee.Name = "labelEmployee";
        labelEmployee.Size = new Size(98, 25);
        labelEmployee.TabIndex = 32;
        labelEmployee.Text = "Employee:";
        // 
        // textBoxEmployee
        // 
        textBoxEmployee.Font = new Font("Segoe UI", 12F);
        textBoxEmployee.Location = new Point(122, 274);
        textBoxEmployee.Margin = new Padding(3, 4, 3, 4);
        textBoxEmployee.Name = "textBoxEmployee";
        textBoxEmployee.Size = new Size(322, 32);
        textBoxEmployee.TabIndex = 35;
        // 
        // textBoxDate
        // 
        textBoxDate.Font = new Font("Segoe UI", 12F);
        textBoxDate.Location = new Point(122, 162);
        textBoxDate.Margin = new Padding(3, 4, 3, 4);
        textBoxDate.Name = "textBoxDate";
        textBoxDate.Size = new Size(322, 32);
        textBoxDate.TabIndex = 34;
        // 
        // textBoxCustomer
        // 
        textBoxCustomer.Font = new Font("Segoe UI", 12F);
        textBoxCustomer.Location = new Point(122, 215);
        textBoxCustomer.Margin = new Padding(3, 4, 3, 4);
        textBoxCustomer.Name = "textBoxCustomer";
        textBoxCustomer.Size = new Size(322, 32);
        textBoxCustomer.TabIndex = 33;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.Location = new Point(451, 18);
        flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(486, 716);
        flowLayoutPanel1.TabIndex = 36;
        // 
        // OrderEditController
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(flowLayoutPanel1);
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "OrderEditController";
        Size = new Size(949, 741);
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
    private FlowLayoutPanel flowLayoutPanel1;
    private Label labelDate;
    private Label labelCustomer;
    private Label labelEmployee;
    private TextBox textBoxEmployee;
    private TextBox textBoxDate;
    private TextBox textBoxCustomer;
    private Label labelId;
    private TextBox textBoxId;
}
