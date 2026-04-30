using System;

namespace c_
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
            this.lstWindows = new System.Windows.Forms.ListBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtBg = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTextCol = new System.Windows.Forms.TextBox();
            this.btnFocus = new System.Windows.Forms.Button();
            this.btnChangeStyle = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtNewColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnCombine = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstWindows
            // 
            this.lstWindows.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstWindows.FormattingEnabled = true;
            this.lstWindows.Location = new System.Drawing.Point(0, 0);
            this.lstWindows.Name = "lstWindows";
            this.lstWindows.Size = new System.Drawing.Size(580, 251);
            this.lstWindows.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(6, 38);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(40, 20);
            this.txtX1.TabIndex = 1;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(6, 77);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(40, 20);
            this.txtX2.TabIndex = 2;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(77, 38);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(40, 20);
            this.txtY1.TabIndex = 3;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(77, 77);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(40, 20);
            this.txtY2.TabIndex = 4;
            // 
            // txtBg
            // 
            this.txtBg.Location = new System.Drawing.Point(6, 75);
            this.txtBg.Name = "txtBg";
            this.txtBg.Size = new System.Drawing.Size(115, 20);
            this.txtBg.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(6, 36);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(115, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // txtTextCol
            // 
            this.txtTextCol.Location = new System.Drawing.Point(6, 114);
            this.txtTextCol.Name = "txtTextCol";
            this.txtTextCol.Size = new System.Drawing.Size(115, 20);
            this.txtTextCol.TabIndex = 7;
            // 
            // btnFocus
            // 
            this.btnFocus.Location = new System.Drawing.Point(6, 54);
            this.btnFocus.Name = "btnFocus";
            this.btnFocus.Size = new System.Drawing.Size(148, 29);
            this.btnFocus.TabIndex = 9;
            this.btnFocus.Text = "Змінити фокус";
            this.btnFocus.UseVisualStyleBackColor = true;
            this.btnFocus.Click += new System.EventHandler(this.btnFocus_Click);
            // 
            // btnChangeStyle
            // 
            this.btnChangeStyle.Location = new System.Drawing.Point(6, 131);
            this.btnChangeStyle.Name = "btnChangeStyle";
            this.btnChangeStyle.Size = new System.Drawing.Size(148, 29);
            this.btnChangeStyle.TabIndex = 11;
            this.btnChangeStyle.Text = "Змінити стиль";
            this.btnChangeStyle.UseVisualStyleBackColor = true;
            this.btnChangeStyle.Click += new System.EventHandler(this.btnChangeStyle_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 29);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Зберегти у файл";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(160, 54);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(148, 29);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Завантажити з файлу";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtNewColor
            // 
            this.txtNewColor.Location = new System.Drawing.Point(6, 105);
            this.txtNewColor.Multiline = true;
            this.txtNewColor.Name = "txtNewColor";
            this.txtNewColor.Size = new System.Drawing.Size(148, 20);
            this.txtNewColor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Y2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Колір фону";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Заголовок";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Колір тексту";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Новий колір";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtY1);
            this.groupBox1.Controls.Add(this.txtX1);
            this.groupBox1.Controls.Add(this.txtX2);
            this.groupBox1.Controls.Add(this.txtY2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(0, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 109);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Координати вікна";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBg);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTextCol);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(133, 257);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 192);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Початкові значення";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Відкрити вікно";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCombine);
            this.groupBox3.Controls.Add(this.btnShift);
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.btnFocus);
            this.groupBox3.Controls.Add(this.btnChangeStyle);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnLoad);
            this.groupBox3.Controls.Add(this.txtNewColor);
            this.groupBox3.Location = new System.Drawing.Point(266, 257);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 192);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Налаштування";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Закрити вікно";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShift
            // 
            this.btnShift.Location = new System.Drawing.Point(160, 89);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(148, 29);
            this.btnShift.TabIndex = 21;
            this.btnShift.Text = "Посунути вікно";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnCombine
            // 
            this.btnCombine.Location = new System.Drawing.Point(160, 124);
            this.btnCombine.Name = "btnCombine";
            this.btnCombine.Size = new System.Drawing.Size(148, 29);
            this.btnCombine.TabIndex = 22;
            this.btnCombine.Text = "Накладання вікон";
            this.btnCombine.UseVisualStyleBackColor = true;
            this.btnCombine.Click += new System.EventHandler(this.btnCombine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstWindows);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void BtnChangeStyle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ListBox lstWindows;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtBg;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtTextCol;
        private System.Windows.Forms.Button btnFocus;
        private System.Windows.Forms.Button btnChangeStyle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtNewColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCombine;
        private System.Windows.Forms.Button btnShift;
    }
}

