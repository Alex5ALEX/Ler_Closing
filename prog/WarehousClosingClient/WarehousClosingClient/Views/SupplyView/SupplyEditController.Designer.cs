namespace WarehousClosingClient.Views.SupplyView;

partial class SupplyEditController
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
        labelPrice = new Label();
        labelProvider = new Label();
        textBoxProvider = new TextBox();
        textBoxDate = new TextBox();
        textBoxPrice = new TextBox();
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
        label.Size = new Size(172, 42);
        label.TabIndex = 13;
        label.Text = "Edit Supply";
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
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(labelProvider);
        groupBox1.Controls.Add(buttonEdit);
        groupBox1.Controls.Add(textBoxProvider);
        groupBox1.Controls.Add(textBoxDate);
        groupBox1.Controls.Add(textBoxPrice);
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
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(19, 225);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(58, 25);
        labelPrice.TabIndex = 31;
        labelPrice.Text = "Price:";
        // 
        // labelProvider
        // 
        labelProvider.AutoSize = true;
        labelProvider.Font = new Font("Segoe UI", 12F);
        labelProvider.Location = new Point(19, 284);
        labelProvider.Name = "labelProvider";
        labelProvider.Size = new Size(87, 25);
        labelProvider.TabIndex = 32;
        labelProvider.Text = "Provider:";
        // 
        // textBoxProvider
        // 
        textBoxProvider.Font = new Font("Segoe UI", 12F);
        textBoxProvider.Location = new Point(122, 277);
        textBoxProvider.Margin = new Padding(3, 4, 3, 4);
        textBoxProvider.Name = "textBoxProvider";
        textBoxProvider.Size = new Size(322, 32);
        textBoxProvider.TabIndex = 35;
        // 
        // textBoxDate
        // 
        textBoxDate.Font = new Font("Segoe UI", 12F);
        textBoxDate.Location = new Point(122, 165);
        textBoxDate.Margin = new Padding(3, 4, 3, 4);
        textBoxDate.Name = "textBoxDate";
        textBoxDate.Size = new Size(322, 32);
        textBoxDate.TabIndex = 34;
        // 
        // textBoxPrice
        // 
        textBoxPrice.Font = new Font("Segoe UI", 12F);
        textBoxPrice.Location = new Point(122, 218);
        textBoxPrice.Margin = new Padding(3, 4, 3, 4);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.Size = new Size(322, 32);
        textBoxPrice.TabIndex = 33;
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
        // SupplyEditController
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(flowLayoutPanel1);
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "SupplyEditController";
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
    private Label labelPrice;
    private Label labelProvider;
    private TextBox textBoxProvider;
    private TextBox textBoxDate;
    private TextBox textBoxPrice;
    private Label labelId;
    private TextBox textBoxId;
}
