namespace WarehousClosingClient.Views.SupplyView;

partial class SupplyAddController
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
        labelPrice = new Label();
        textBoxPrice = new TextBox();
        groupBox1 = new GroupBox();
        buttonBack = new Button();
        buttonAdd = new Button();
        dateTimePicker = new DateTimePicker();
        labelDate = new Label();
        groupBox2 = new GroupBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        tabPageProvider = new TabPage();
        flowLayoutPanelProviders = new FlowLayoutPanel();
        tabPageProducts = new TabPage();
        flowLayoutPanelProducts = new FlowLayoutPanel();
        tabControl = new TabControl();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        tabPageProvider.SuspendLayout();
        tabPageProducts.SuspendLayout();
        tabControl.SuspendLayout();
        SuspendLayout();
        // 
        // label
        // 
        label.AutoSize = true;
        label.Font = new Font("Segoe UI", 20F);
        label.Location = new Point(6, 19);
        label.Name = "label";
        label.Size = new Size(154, 37);
        label.TabIndex = 0;
        label.Text = "Add Supply";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(17, 123);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(47, 21);
        labelPrice.TabIndex = 2;
        labelPrice.Text = "Price:";
        // 
        // textBoxPrice
        // 
        textBoxPrice.Font = new Font("Segoe UI", 12F);
        textBoxPrice.Location = new Point(17, 146);
        textBoxPrice.Name = "textBoxPrice";
        textBoxPrice.Size = new Size(282, 29);
        textBoxPrice.TabIndex = 6;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(tabControl);
        groupBox1.Controls.Add(groupBox2);
        groupBox1.Controls.Add(dateTimePicker);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Controls.Add(buttonBack);
        groupBox1.Controls.Add(buttonAdd);
        groupBox1.Controls.Add(label);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(textBoxPrice);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(680, 585);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // buttonBack
        // 
        buttonBack.BackColor = SystemColors.ControlLightLight;
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.Font = new Font("Segoe UI", 12F);
        buttonBack.Location = new Point(6, 529);
        buttonBack.Name = "buttonBack";
        buttonBack.Size = new Size(100, 50);
        buttonBack.TabIndex = 19;
        buttonBack.Text = "Back";
        buttonBack.UseVisualStyleBackColor = false;
        // 
        // buttonAdd
        // 
        buttonAdd.BackColor = Color.SpringGreen;
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.Font = new Font("Segoe UI", 12F);
        buttonAdd.Location = new Point(197, 529);
        buttonAdd.Name = "buttonAdd";
        buttonAdd.Size = new Size(100, 50);
        buttonAdd.TabIndex = 18;
        buttonAdd.Text = "Add";
        buttonAdd.UseVisualStyleBackColor = false;
        // 
        // dateTimePicker
        // 
        dateTimePicker.CalendarFont = new Font("Segoe UI", 12F);
        dateTimePicker.Font = new Font("Segoe UI", 12F);
        dateTimePicker.Location = new Point(17, 91);
        dateTimePicker.Name = "dateTimePicker";
        dateTimePicker.Size = new Size(282, 29);
        dateTimePicker.TabIndex = 21;
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(17, 67);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(45, 21);
        labelDate.TabIndex = 20;
        labelDate.Text = "Date:";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(label2);
        groupBox2.Controls.Add(label1);
        groupBox2.Font = new Font("Segoe UI", 12F);
        groupBox2.Location = new Point(17, 200);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(282, 130);
        groupBox2.TabIndex = 22;
        groupBox2.TabStop = false;
        groupBox2.Text = "Provider";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(18, 91);
        label4.Name = "label4";
        label4.Size = new Size(0, 21);
        label4.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(18, 57);
        label3.Name = "label3";
        label3.Size = new Size(0, 21);
        label3.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(148, 25);
        label2.Name = "label2";
        label2.Size = new Size(0, 21);
        label2.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(18, 25);
        label1.Name = "label1";
        label1.Size = new Size(0, 21);
        label1.TabIndex = 0;
        // 
        // tabPageProvider
        // 
        tabPageProvider.Controls.Add(flowLayoutPanelProviders);
        tabPageProvider.Location = new Point(4, 30);
        tabPageProvider.Name = "tabPageProvider";
        tabPageProvider.Padding = new Padding(3);
        tabPageProvider.Size = new Size(354, 529);
        tabPageProvider.TabIndex = 1;
        tabPageProvider.Text = "Provider";
        tabPageProvider.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelProviders
        // 
        flowLayoutPanelProviders.AutoScroll = true;
        flowLayoutPanelProviders.Location = new Point(0, 0);
        flowLayoutPanelProviders.Name = "flowLayoutPanelProviders";
        flowLayoutPanelProviders.Size = new Size(354, 529);
        flowLayoutPanelProviders.TabIndex = 0;
        // 
        // tabPageProducts
        // 
        tabPageProducts.Controls.Add(flowLayoutPanelProducts);
        tabPageProducts.Location = new Point(4, 30);
        tabPageProducts.Name = "tabPageProducts";
        tabPageProducts.Padding = new Padding(3);
        tabPageProducts.Size = new Size(354, 529);
        tabPageProducts.TabIndex = 0;
        tabPageProducts.Text = "Products";
        tabPageProducts.UseVisualStyleBackColor = true;
        // 
        // flowLayoutPanelProducts
        // 
        flowLayoutPanelProducts.AutoScroll = true;
        flowLayoutPanelProducts.Location = new Point(0, 0);
        flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
        flowLayoutPanelProducts.Size = new Size(354, 529);
        flowLayoutPanelProducts.TabIndex = 0;
        // 
        // tabControl
        // 
        tabControl.Controls.Add(tabPageProducts);
        tabControl.Controls.Add(tabPageProvider);
        tabControl.Font = new Font("Segoe UI", 12F);
        tabControl.Location = new Point(312, 16);
        tabControl.Name = "tabControl";
        tabControl.SelectedIndex = 0;
        tabControl.Size = new Size(362, 563);
        tabControl.TabIndex = 23;
        // 
        // SupplyAddController
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlLightLight;
        Controls.Add(groupBox1);
        Name = "SupplyAddController";
        Size = new Size(680, 585);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        tabPageProvider.ResumeLayout(false);
        tabPageProducts.ResumeLayout(false);
        tabControl.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private Label label;
    private Label labelPrice;
    private TextBox textBoxPrice;
    private GroupBox groupBox1;
    private Button buttonBack;
    private Button buttonAdd;
    private DateTimePicker dateTimePicker;
    private Label labelDate;
    private GroupBox groupBox2;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TabControl tabControl;
    private TabPage tabPageProducts;
    private FlowLayoutPanel flowLayoutPanelProducts;
    private TabPage tabPageProvider;
    private FlowLayoutPanel flowLayoutPanelProviders;
}
