namespace BRTS
{
    partial class FIRST
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "                             Ahmedabad BRTS is a highly ambitious rapid transport" +
                " system",
            " developed by Gujarat Infrastructure Development Board (GIDB) for the city of ",
            "Ahmedabad, recognizing that no single mode would cater to the mobility needs of  " +
                "city ",
            "and that ‘Bus’ forms the most critical segment of the public transport system in",
            " the Ahmedabad city.GIDB has thereby entrusted the system design task to CEPT",
            " University.A part of first corridor connecting Pirana to R.T.O. was opened to",
            " public on October 14, 2009 by Chief Minister of Gujarat Narendra Modi.",
            "Ahmedabad is a city with present population of 72 lakhs (7.2 million).[2],",
            " which is likely to be 11 million by the year 2035. This would lead to agglomerat" +
                "ion",
            " of surrounding settlements like Naroda and other smaller villages, which ultimat" +
                "ely ",
            "increases the area of the city, which may become 1,000 km2 in the year 2035. More" +
                "over, ",
            "about 1/3 of total as well as student population reside within walking distance f" +
                "rom the",
            " proposed BRTS network. Thus, there is a growing need for greater accessibility t" +
                "o basic ",
            "amenities and opportunities for mobility in the city. In such a state of rapid ur" +
                "banization,",
            " it is very essential to have an efficient and rapid transit system, which will s" +
                "ustain and",
            " accelerate the growth of the city. In order to cater this future demand, the cit" +
                "y and State",
            " Government has initiated a Plan for Integrated Public Transit System, in which B" +
                "us Rapid",
            " Transit System (BRTS) is one of the components. This will facilitate the major m" +
                "obility",
            " need of the people. In future, this system will get integrated with Ahmedabad Me" +
                "tro by",
            " the addition of two lines running through east to west and north to south."});
            this.listBox1.Location = new System.Drawing.Point(20, 151);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(400, 169);
            this.listBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BRTS.Properties.Resources.Transforming_Ahmedabad1;
            this.pictureBox1.Location = new System.Drawing.Point(421, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Location = new System.Drawing.Point(140, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "ENTER IN BRTS FROM HERE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)
                            | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "BRTS AHMEDABAD";
            // 
            // FIRST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(432, 404);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "FIRST";
            this.Text = "FIRST";
            this.Load += new System.EventHandler(this.FIRST_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}