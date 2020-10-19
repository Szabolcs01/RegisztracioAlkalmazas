namespace RegisztracioAlkalmazas
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBetoltes = new System.Windows.Forms.Button();
            this.textBoxNev = new System.Windows.Forms.TextBox();
            this.listBoxLista = new System.Windows.Forms.ListBox();
            this.rbtnFerfi = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.Név = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHobbi = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(282, 306);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 1;
            this.btnHozzaad.Text = "Hozzáad";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(187, 358);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(75, 23);
            this.btnMentes.TabIndex = 2;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnBetoltes
            // 
            this.btnBetoltes.Location = new System.Drawing.Point(282, 358);
            this.btnBetoltes.Name = "btnBetoltes";
            this.btnBetoltes.Size = new System.Drawing.Size(75, 23);
            this.btnBetoltes.TabIndex = 3;
            this.btnBetoltes.Text = "Betöltés";
            this.btnBetoltes.UseVisualStyleBackColor = true;
            this.btnBetoltes.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // textBoxNev
            // 
            this.textBoxNev.Location = new System.Drawing.Point(133, 38);
            this.textBoxNev.Name = "textBoxNev";
            this.textBoxNev.Size = new System.Drawing.Size(100, 20);
            this.textBoxNev.TabIndex = 4;
            // 
            // listBoxLista
            // 
            this.listBoxLista.FormattingEnabled = true;
            this.listBoxLista.Location = new System.Drawing.Point(258, 73);
            this.listBoxLista.Name = "listBoxLista";
            this.listBoxLista.Size = new System.Drawing.Size(120, 95);
            this.listBoxLista.TabIndex = 5;
            // 
            // rbtnFerfi
            // 
            this.rbtnFerfi.AutoSize = true;
            this.rbtnFerfi.Location = new System.Drawing.Point(73, 203);
            this.rbtnFerfi.Name = "rbtnFerfi";
            this.rbtnFerfi.Size = new System.Drawing.Size(31, 17);
            this.rbtnFerfi.TabIndex = 6;
            this.rbtnFerfi.TabStop = true;
            this.rbtnFerfi.Text = "F";
            this.rbtnFerfi.UseVisualStyleBackColor = true;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(133, 205);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(33, 17);
            this.rbtnNo.TabIndex = 7;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "N";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // Név
            // 
            this.Név.AutoSize = true;
            this.Név.Location = new System.Drawing.Point(12, 34);
            this.Név.Name = "Név";
            this.Név.Size = new System.Drawing.Size(27, 13);
            this.Név.TabIndex = 8;
            this.Név.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Szül. dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Kedvenc hobbi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Új hobbi:";
            // 
            // textBoxHobbi
            // 
            this.textBoxHobbi.Location = new System.Drawing.Point(257, 261);
            this.textBoxHobbi.Name = "textBoxHobbi";
            this.textBoxHobbi.Size = new System.Drawing.Size(100, 20);
            this.textBoxHobbi.TabIndex = 13;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Jegyzettömb (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Szöveges dokumentumok|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 450);
            this.Controls.Add(this.textBoxHobbi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Név);
            this.Controls.Add(this.rbtnNo);
            this.Controls.Add(this.rbtnFerfi);
            this.Controls.Add(this.listBoxLista);
            this.Controls.Add(this.textBoxNev);
            this.Controls.Add(this.btnBetoltes);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBetoltes;
        private System.Windows.Forms.TextBox textBoxNev;
        private System.Windows.Forms.ListBox listBoxLista;
        private System.Windows.Forms.RadioButton rbtnFerfi;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.Label Név;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHobbi;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

