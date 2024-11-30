namespace WarehousClosingClient.Views.ProductView
{
    partial class ProductRowControl
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
            labelName = new Label();
            labelNameText = new Label();
            labelId = new Label();
            labelIdText = new Label();
            buttonCopy = new Button();
            labelPrice = new Label();
            labelPriceText = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 12F);
            labelName.Location = new Point(16, 56);
            labelName.Name = "labelName";
            labelName.Size = new Size(55, 21);
            labelName.TabIndex = 2;
            labelName.Text = "Name:";
            // 
            // labelNameText
            // 
            labelNameText.AutoSize = true;
            labelNameText.Font = new Font("Segoe UI", 12F);
            labelNameText.Location = new Point(94, 56);
            labelNameText.Name = "labelNameText";
            labelNameText.Size = new Size(94, 21);
            labelNameText.TabIndex = 4;
            labelNameText.Text = "TEXT_NAME";
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
            // buttonCopy
            // 
            buttonCopy.BackgroundImage = Properties.Resources.copy1_picture;
            buttonCopy.BackgroundImageLayout = ImageLayout.Stretch;
            buttonCopy.Font = new Font("Segoe UI", 12F);
            buttonCopy.Location = new Point(386, 10);
            buttonCopy.Name = "buttonCopy";
            buttonCopy.Size = new Size(40, 35);
            buttonCopy.TabIndex = 12;
            buttonCopy.UseVisualStyleBackColor = true;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 12F);
            labelPrice.Location = new Point(385, 56);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(47, 21);
            labelPrice.TabIndex = 13;
            labelPrice.Text = "Price:";
            // 
            // labelPriceText
            // 
            labelPriceText.AutoSize = true;
            labelPriceText.Font = new Font("Segoe UI", 12F);
            labelPriceText.Location = new Point(463, 56);
            labelPriceText.Name = "labelPriceText";
            labelPriceText.Size = new Size(94, 21);
            labelPriceText.TabIndex = 14;
            labelPriceText.Text = "TEXT_EMAIL";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelNameText);
            groupBox1.Controls.Add(labelPriceText);
            groupBox1.Controls.Add(labelName);
            groupBox1.Controls.Add(labelPrice);
            groupBox1.Controls.Add(buttonCopy);
            groupBox1.Controls.Add(labelIdText);
            groupBox1.Controls.Add(labelId);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 100);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // ProductRowControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "ProductRowControl";
            Size = new Size(770, 100);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label labelName;
        private Label labelNameText;
        private Label labelId;
        private Label labelIdText;
        private Button buttonCopy;
        private Label labelPrice;
        private Label labelPriceText;
        private GroupBox groupBox1;
    }
}
