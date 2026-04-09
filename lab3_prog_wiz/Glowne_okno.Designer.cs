namespace lab3_prog_wiz
{
    partial class Glowne_okno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            btnXML = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(21, 430);
            button1.Name = "button1";
            button1.Size = new Size(200, 32);
            button1.TabIndex = 0;
            button1.Text = "Zapis do .csv";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(263, 430);
            button2.Name = "button2";
            button2.Size = new Size(200, 32);
            button2.TabIndex = 1;
            button2.Text = "Odczyt z .csv";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(718, 24);
            button3.Name = "button3";
            button3.Size = new Size(116, 42);
            button3.TabIndex = 2;
            button3.Text = "Dodaj";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(718, 83);
            button4.Name = "button4";
            button4.Size = new Size(116, 42);
            button4.TabIndex = 3;
            button4.Text = "Usuń";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(21, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(677, 380);
            dataGridView1.TabIndex = 4;
            // 
            // btnXML
            // 
            btnXML.Location = new Point(498, 430);
            btnXML.Name = "btnXML";
            btnXML.Size = new Size(200, 32);
            btnXML.TabIndex = 5;
            btnXML.Text = "Serializacja do XML";
            btnXML.UseVisualStyleBackColor = true;
            // 
            // Glowne_okno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 474);
            Controls.Add(btnXML);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Glowne_okno";
            Text = "Informacje o pracownikach";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Button btnXML;
    }
}
