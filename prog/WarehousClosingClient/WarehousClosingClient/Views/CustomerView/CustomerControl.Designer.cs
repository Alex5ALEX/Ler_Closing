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
            SuspendLayout();
            // 
            // labelMenuName
            // 
            labelMenuName.AutoSize = true;
            labelMenuName.Font = new Font("Segoe UI", 16F);
            labelMenuName.Location = new Point(3, 7);
            labelMenuName.Name = "labelMenuName";
            labelMenuName.Size = new Size(116, 30);
            labelMenuName.TabIndex = 8;
            labelMenuName.Text = "Customers";
            // 
            // buttonAddNew
            // 
            buttonAddNew.Location = new Point(520, 9);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(87, 34);
            buttonAddNew.TabIndex = 7;
            buttonAddNew.Text = "Add New";
            buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(3, 49);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(604, 439);
            flowLayoutPanel.TabIndex = 6;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(417, 9);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(87, 34);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // CustomerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonEdit);
            Controls.Add(labelMenuName);
            Controls.Add(buttonAddNew);
            Controls.Add(flowLayoutPanel);
            Name = "CustomerControl";
            Size = new Size(610, 495);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMenuName;
        private Button buttonAddNew;
        private FlowLayoutPanel flowLayoutPanel;
        private Button buttonEdit;
    }
}
