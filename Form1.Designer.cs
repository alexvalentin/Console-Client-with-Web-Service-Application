
namespace ConsoleClientForWSA
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
            this.listBox_Lista = new System.Windows.Forms.ListBox();
            this.buttonAddList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.temperatura1 = new System.Windows.Forms.Label();
            this.temperatura2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.temperaturaC = new System.Windows.Forms.TextBox();
            this.temperaturaF = new System.Windows.Forms.TextBox();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.buttonFtoC = new System.Windows.Forms.Button();
            this.buttonCtoF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_Lista
            // 
            this.listBox_Lista.FormattingEnabled = true;
            this.listBox_Lista.ItemHeight = 16;
            this.listBox_Lista.Location = new System.Drawing.Point(72, 56);
            this.listBox_Lista.Name = "listBox_Lista";
            this.listBox_Lista.Size = new System.Drawing.Size(107, 148);
            this.listBox_Lista.TabIndex = 0;
            // 
            // buttonAddList
            // 
            this.buttonAddList.Location = new System.Drawing.Point(72, 220);
            this.buttonAddList.Name = "buttonAddList";
            this.buttonAddList.Size = new System.Drawing.Size(94, 27);
            this.buttonAddList.TabIndex = 1;
            this.buttonAddList.Text = "Add List";
            this.buttonAddList.UseVisualStyleBackColor = true;
            this.buttonAddList.Click += new System.EventHandler(this.buttonAddList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista";
            // 
            // temperatura1
            // 
            this.temperatura1.AutoSize = true;
            this.temperatura1.Location = new System.Drawing.Point(465, 56);
            this.temperatura1.Name = "temperatura1";
            this.temperatura1.Size = new System.Drawing.Size(103, 17);
            this.temperatura1.TabIndex = 3;
            this.temperatura1.Text = "Temperatura C";
            // 
            // temperatura2
            // 
            this.temperatura2.AutoSize = true;
            this.temperatura2.Location = new System.Drawing.Point(465, 111);
            this.temperatura2.Name = "temperatura2";
            this.temperatura2.Size = new System.Drawing.Size(102, 17);
            this.temperatura2.TabIndex = 4;
            this.temperatura2.Text = "Temperatura F";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rezultat";
            // 
            // temperaturaC
            // 
            this.temperaturaC.Location = new System.Drawing.Point(592, 56);
            this.temperaturaC.Name = "temperaturaC";
            this.temperaturaC.Size = new System.Drawing.Size(100, 22);
            this.temperaturaC.TabIndex = 6;
            // 
            // temperaturaF
            // 
            this.temperaturaF.Location = new System.Drawing.Point(592, 106);
            this.temperaturaF.Name = "temperaturaF";
            this.temperaturaF.Size = new System.Drawing.Size(100, 22);
            this.temperaturaF.TabIndex = 7;
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(592, 155);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(100, 22);
            this.rezultat.TabIndex = 8;
            // 
            // buttonFtoC
            // 
            this.buttonFtoC.Location = new System.Drawing.Point(592, 213);
            this.buttonFtoC.Name = "buttonFtoC";
            this.buttonFtoC.Size = new System.Drawing.Size(100, 34);
            this.buttonFtoC.TabIndex = 9;
            this.buttonFtoC.Text = "F to C";
            this.buttonFtoC.UseVisualStyleBackColor = true;
            this.buttonFtoC.Click += new System.EventHandler(this.buttonFtoC_Click);
            // 
            // buttonCtoF
            // 
            this.buttonCtoF.Location = new System.Drawing.Point(592, 269);
            this.buttonCtoF.Name = "buttonCtoF";
            this.buttonCtoF.Size = new System.Drawing.Size(100, 32);
            this.buttonCtoF.TabIndex = 10;
            this.buttonCtoF.Text = "C to F";
            this.buttonCtoF.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data actuala";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCtoF);
            this.Controls.Add(this.buttonFtoC);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.temperaturaF);
            this.Controls.Add(this.temperaturaC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.temperatura2);
            this.Controls.Add(this.temperatura1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddList);
            this.Controls.Add(this.listBox_Lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Lista;
        private System.Windows.Forms.Button buttonAddList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label temperatura1;
        private System.Windows.Forms.Label temperatura2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox temperaturaC;
        private System.Windows.Forms.TextBox temperaturaF;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.Button buttonFtoC;
        private System.Windows.Forms.Button buttonCtoF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}