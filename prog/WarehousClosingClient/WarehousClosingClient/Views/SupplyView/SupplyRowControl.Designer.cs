namespace WarehousClosingClient.Views.SupplyView;

partial class SupplyRowControl
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplyRowControl));
        labelId = new Label();
        labelIdText = new Label();
        labelDate = new Label();
        labelPrice = new Label();
        labelPriceText = new Label();
        labelDateText = new Label();
        labelIdProvider = new Label();
        labelProviderText = new Label();
        buttonCopy = new Button();
        groupBox1 = new GroupBox();
        buttonCopyProvider = new Button();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // labelId
        // 
        labelId.AutoSize = true;
        labelId.Font = new Font("Segoe UI", 12F);
        labelId.Location = new Point(7, 24);
        labelId.Name = "labelId";
        labelId.Size = new Size(32, 25);
        labelId.TabIndex = 0;
        labelId.Text = "Id:";
        // 
        // labelIdText
        // 
        labelIdText.AutoSize = true;
        labelIdText.Font = new Font("Segoe UI", 12F);
        labelIdText.Location = new Point(7, 58);
        labelIdText.Name = "labelIdText";
        labelIdText.Size = new Size(79, 25);
        labelIdText.TabIndex = 1;
        labelIdText.Text = "TEXT_ID";
        // 
        // labelDate
        // 
        labelDate.AutoSize = true;
        labelDate.Font = new Font("Segoe UI", 12F);
        labelDate.Location = new Point(7, 85);
        labelDate.Name = "labelDate";
        labelDate.Size = new Size(55, 25);
        labelDate.TabIndex = 2;
        labelDate.Text = "Date:";
        // 
        // labelPrice
        // 
        labelPrice.AutoSize = true;
        labelPrice.Font = new Font("Segoe UI", 12F);
        labelPrice.Location = new Point(4, 110);
        labelPrice.Name = "labelPrice";
        labelPrice.Size = new Size(58, 25);
        labelPrice.TabIndex = 3;
        labelPrice.Text = "Price:";
        // 
        // labelPriceText
        // 
        labelPriceText.AutoSize = true;
        labelPriceText.Font = new Font("Segoe UI", 12F);
        labelPriceText.Location = new Point(62, 110);
        labelPriceText.Name = "labelPriceText";
        labelPriceText.Size = new Size(148, 25);
        labelPriceText.TabIndex = 5;
        labelPriceText.Text = "TEXT_SURNAME";
        // 
        // labelDateText
        // 
        labelDateText.AutoSize = true;
        labelDateText.Font = new Font("Segoe UI", 12F);
        labelDateText.Location = new Point(65, 85);
        labelDateText.Name = "labelDateText";
        labelDateText.Size = new Size(53, 25);
        labelDateText.TabIndex = 4;
        labelDateText.Text = "TEXT";
        // 
        // labelIdProvider
        // 
        labelIdProvider.AutoSize = true;
        labelIdProvider.Font = new Font("Segoe UI", 12F);
        labelIdProvider.Location = new Point(7, 146);
        labelIdProvider.Name = "labelIdProvider";
        labelIdProvider.Size = new Size(111, 25);
        labelIdProvider.TabIndex = 6;
        labelIdProvider.Text = "Id_Provider:";
        // 
        // labelProviderText
        // 
        labelProviderText.AutoSize = true;
        labelProviderText.Font = new Font("Segoe UI", 12F);
        labelProviderText.Location = new Point(8, 173);
        labelProviderText.Name = "labelProviderText";
        labelProviderText.Size = new Size(148, 25);
        labelProviderText.TabIndex = 7;
        labelProviderText.Text = "TEXT_PROVIDER";
        // 
        // buttonCopy
        // 
        buttonCopy.BackgroundImage = (Image)resources.GetObject("buttonCopy.BackgroundImage");
        buttonCopy.BackgroundImageLayout = ImageLayout.Stretch;
        buttonCopy.Font = new Font("Segoe UI", 12F);
        buttonCopy.Location = new Point(43, 15);
        buttonCopy.Margin = new Padding(3, 4, 3, 4);
        buttonCopy.Name = "buttonCopy";
        buttonCopy.Size = new Size(34, 35);
        buttonCopy.TabIndex = 12;
        buttonCopy.UseVisualStyleBackColor = true;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(buttonCopyProvider);
        groupBox1.Controls.Add(labelPrice);
        groupBox1.Controls.Add(labelDateText);
        groupBox1.Controls.Add(labelPriceText);
        groupBox1.Controls.Add(labelProviderText);
        groupBox1.Controls.Add(labelDate);
        groupBox1.Controls.Add(buttonCopy);
        groupBox1.Controls.Add(labelIdProvider);
        groupBox1.Controls.Add(labelIdText);
        groupBox1.Controls.Add(labelId);
        groupBox1.Location = new Point(0, 0);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(429, 204);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        // 
        // buttonCopyProvider
        // 
        buttonCopyProvider.BackgroundImage = (Image)resources.GetObject("buttonCopyProvider.BackgroundImage");
        buttonCopyProvider.BackgroundImageLayout = ImageLayout.Stretch;
        buttonCopyProvider.Font = new Font("Segoe UI", 12F);
        buttonCopyProvider.Location = new Point(129, 138);
        buttonCopyProvider.Margin = new Padding(3, 4, 3, 4);
        buttonCopyProvider.Name = "buttonCopyProvider";
        buttonCopyProvider.Size = new Size(34, 35);
        buttonCopyProvider.TabIndex = 14;
        buttonCopyProvider.UseVisualStyleBackColor = true;
        // 
        // SupplyRowControl
        // 
        AutoScaleDimensions = new SizeF(8F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(groupBox1);
        Margin = new Padding(3, 4, 3, 4);
        Name = "SupplyRowControl";
        Size = new Size(431, 204);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label labelId;
    private Label labelIdText;
    private Label labelDate;
    private Label labelPrice;
    private Label labelPriceText;
    private Label labelDateText;
    private Label labelIdProvider;
    private Label labelProviderText;
    private Button buttonCopy;
    private GroupBox groupBox1;
    private Button buttonCopyProvider;
}
