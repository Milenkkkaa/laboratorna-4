namespace laboratorna4
{
    partial class fHouse
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbRoom = new System.Windows.Forms.TextBox();
            this.tbFloor = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasForniture = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbWidth);
            this.groupBox1.Controls.Add(this.tbLength);
            this.groupBox1.Controls.Add(this.tbHeight);
            this.groupBox1.Controls.Add(this.tbRoom);
            this.groupBox1.Controls.Add(this.tbFloor);
            this.groupBox1.Controls.Add(this.tbValue);
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(250, 28);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(196, 22);
            this.tbWidth.TabIndex = 1;
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(250, 71);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(196, 22);
            this.tbLength.TabIndex = 2;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(250, 116);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(196, 22);
            this.tbHeight.TabIndex = 3;
            // 
            // tbRoom
            // 
            this.tbRoom.Location = new System.Drawing.Point(250, 160);
            this.tbRoom.Name = "tbRoom";
            this.tbRoom.Size = new System.Drawing.Size(196, 22);
            this.tbRoom.TabIndex = 4;
            // 
            // tbFloor
            // 
            this.tbFloor.Location = new System.Drawing.Point(250, 200);
            this.tbFloor.Name = "tbFloor";
            this.tbFloor.Size = new System.Drawing.Size(196, 22);
            this.tbFloor.TabIndex = 5;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(250, 244);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(196, 22);
            this.tbValue.TabIndex = 6;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(250, 283);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(196, 22);
            this.tbPrice.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Довжина";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Висота";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Кількість кімнат";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Кількість поверхів";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ціна за кв м";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ціна за опалення";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasForniture);
            this.groupBox2.Location = new System.Drawing.Point(12, 338);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Меблі";
            // 
            // chbHasForniture
            // 
            this.chbHasForniture.AutoSize = true;
            this.chbHasForniture.Location = new System.Drawing.Point(15, 45);
            this.chbHasForniture.Name = "chbHasForniture";
            this.chbHasForniture.Size = new System.Drawing.Size(171, 20);
            this.chbHasForniture.TabIndex = 8;
            this.chbHasForniture.Text = "Чи є меблі та техніка?";
            this.chbHasForniture.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(501, 82);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(501, 39);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 23);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // fHouse
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fHouse";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про новий будинок";
            this.Load += new System.EventHandler(this.fHouse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbRoom;
        private System.Windows.Forms.TextBox tbFloor;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.CheckBox chbHasForniture;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}