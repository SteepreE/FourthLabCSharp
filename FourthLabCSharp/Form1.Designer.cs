namespace FourthLabCSharp
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GadgedImg = new System.Windows.Forms.PictureBox();
            this.GetGadgetButton = new System.Windows.Forms.Button();
            this.LastGadgetsList = new System.Windows.Forms.ListView();
            this.GadgetsImgs = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GadgetInfo = new System.Windows.Forms.Label();
            this.GadgetsInfo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GadgedImg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GadgedImg
            // 
            this.GadgedImg.Location = new System.Drawing.Point(248, 12);
            this.GadgedImg.Name = "GadgedImg";
            this.GadgedImg.Size = new System.Drawing.Size(394, 300);
            this.GadgedImg.TabIndex = 0;
            this.GadgedImg.TabStop = false;
            // 
            // GetGadgetButton
            // 
            this.GetGadgetButton.Location = new System.Drawing.Point(5, 318);
            this.GetGadgetButton.Name = "GetGadgetButton";
            this.GetGadgetButton.Size = new System.Drawing.Size(637, 65);
            this.GetGadgetButton.TabIndex = 1;
            this.GetGadgetButton.Text = "Выдать гаджет!";
            this.GetGadgetButton.UseVisualStyleBackColor = true;
            this.GetGadgetButton.Click += new System.EventHandler(this.GetGadgetButton_Click);
            // 
            // LastGadgetsList
            // 
            this.LastGadgetsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.LastGadgetsList.HideSelection = false;
            this.LastGadgetsList.LargeImageList = this.GadgetsImgs;
            this.LastGadgetsList.Location = new System.Drawing.Point(648, 12);
            this.LastGadgetsList.Name = "LastGadgetsList";
            this.LastGadgetsList.Size = new System.Drawing.Size(232, 371);
            this.LastGadgetsList.TabIndex = 3;
            this.LastGadgetsList.UseCompatibleStateImageBehavior = false;
            // 
            // GadgetsImgs
            // 
            this.GadgetsImgs.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.GadgetsImgs.ImageSize = new System.Drawing.Size(160, 120);
            this.GadgetsImgs.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GadgetInfo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox1.Location = new System.Drawing.Point(5, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 201);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Гаджет";
            // 
            // GadgetInfo
            // 
            this.GadgetInfo.AutoSize = true;
            this.GadgetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GadgetInfo.Location = new System.Drawing.Point(5, 22);
            this.GadgetInfo.Name = "GadgetInfo";
            this.GadgetInfo.Size = new System.Drawing.Size(0, 17);
            this.GadgetInfo.TabIndex = 0;
            // 
            // GadgetsInfo
            // 
            this.GadgetsInfo.AutoSize = true;
            this.GadgetsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.GadgetsInfo.Location = new System.Drawing.Point(6, 22);
            this.GadgetsInfo.Name = "GadgetsInfo";
            this.GadgetsInfo.Size = new System.Drawing.Size(0, 17);
            this.GadgetsInfo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GadgetsInfo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.groupBox2.Location = new System.Drawing.Point(5, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 93);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "В автомате остались:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LastGadgetsList);
            this.Controls.Add(this.GetGadgetButton);
            this.Controls.Add(this.GadgedImg);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GadgedImg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GadgedImg;
        private System.Windows.Forms.Button GetGadgetButton;
        private System.Windows.Forms.ListView LastGadgetsList;
        private System.Windows.Forms.ImageList GadgetsImgs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label GadgetsInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label GadgetInfo;
    }
}

