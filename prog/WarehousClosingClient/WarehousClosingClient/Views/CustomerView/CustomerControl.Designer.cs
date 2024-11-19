namespace WarehousClosingClient.Views.CustomerView
{
    partial class CustomerControl
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
            labelMenuName = new Label();
            buttonAddNew = new Button();
            flowLayoutPanel = new FlowLayoutPanel();
            buttonEdit = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // labelMenuName
            // 
            labelMenuName.AutoSize = true;
            labelMenuName.Font = new Font("Segoe UI", 16F);
            labelMenuName.Location = new Point(3, 9);
            labelMenuName.Name = "labelMenuName";
            labelMenuName.Size = new Size(133, 35);
            labelMenuName.TabIndex = 8;
            labelMenuName.Text = "Customers";
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new Point(594, 11);
            buttonAddNew.Margin = new Padding(3, 4, 3, 4);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(99, 43);
            buttonAddNew.TabIndex = 7;
            buttonAddNew.Text = "Add New";
            buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(3, 62);
            flowLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(690, 556);
            flowLayoutPanel.TabIndex = 6;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(477, 11);
            buttonEdit.Margin = new Padding(3, 4, 3, 4);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(99, 43);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 26);
            textBox1.TabIndex = 11;
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(buttonEdit);
            Controls.Add(labelMenuName);
            Controls.Add(buttonAddNew);
            Controls.Add(flowLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerControl";
            Size = new Size(697, 627);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenuName;
        private Button buttonAddNew;
        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonEdit;
        private TextBox textBox1;
    }
}
