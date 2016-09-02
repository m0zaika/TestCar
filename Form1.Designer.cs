namespace TestCar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCars = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddOption = new System.Windows.Forms.Button();
            this.tbOptionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.numOptionPrice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numOptionPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCars
            // 
            this.lbCars.FormattingEnabled = true;
            this.lbCars.Location = new System.Drawing.Point(12, 27);
            this.lbCars.Name = "lbCars";
            this.lbCars.Size = new System.Drawing.Size(157, 316);
            this.lbCars.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список машин:";
            // 
            // btnAddOption
            // 
            this.btnAddOption.Location = new System.Drawing.Point(205, 27);
            this.btnAddOption.Name = "btnAddOption";
            this.btnAddOption.Size = new System.Drawing.Size(252, 23);
            this.btnAddOption.TabIndex = 3;
            this.btnAddOption.Text = "Добавить опцию";
            this.btnAddOption.UseVisualStyleBackColor = true;
            this.btnAddOption.Click += new System.EventHandler(this.btnAddOption_Click);
            // 
            // tbOptionName
            // 
            this.tbOptionName.Location = new System.Drawing.Point(479, 27);
            this.tbOptionName.Name = "tbOptionName";
            this.tbOptionName.Size = new System.Drawing.Size(191, 20);
            this.tbOptionName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название опции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Стоимость опции";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(205, 85);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(252, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Запустить движение автомобилей";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(205, 149);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(252, 23);
            this.btnReport.TabIndex = 9;
            this.btnReport.Text = "Вывести полный отчет по автомобилю";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // numOptionPrice
            // 
            this.numOptionPrice.DecimalPlaces = 2;
            this.numOptionPrice.Location = new System.Drawing.Point(479, 85);
            this.numOptionPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOptionPrice.Name = "numOptionPrice";
            this.numOptionPrice.Size = new System.Drawing.Size(191, 20);
            this.numOptionPrice.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.Controls.Add(this.numOptionPrice);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOptionName);
            this.Controls.Add(this.btnAddOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCars);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.numOptionPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddOption;
        private System.Windows.Forms.TextBox tbOptionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.NumericUpDown numOptionPrice;
    }
}

