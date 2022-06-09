
namespace starsInfo
{
    partial class AddStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStart));
            this.addButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.cancButton = new System.Windows.Forms.Button();
            this.photoPath = new System.Windows.Forms.ComboBox();
            this.distance = new System.Windows.Forms.TextBox();
            this.blind = new System.Windows.Forms.TextBox();
            this.radius = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classChar = new System.Windows.Forms.ComboBox();
            this.spectrumclassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.starsDataSet2 = new starsInfo.starsDataSet2();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.spectrum_classTableAdapter = new starsInfo.starsDataSet2TableAdapters.spectrum_classTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumclassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.Location = new System.Drawing.Point(297, 239);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(97, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Location = new System.Drawing.Point(163, 26);
            this.title.MaxLength = 20;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(136, 20);
            this.title.TabIndex = 2;
            // 
            // cancButton
            // 
            this.cancButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancButton.Location = new System.Drawing.Point(421, 239);
            this.cancButton.Name = "cancButton";
            this.cancButton.Size = new System.Drawing.Size(97, 23);
            this.cancButton.TabIndex = 6;
            this.cancButton.Text = "Отменить";
            this.cancButton.UseVisualStyleBackColor = true;
            this.cancButton.Click += new System.EventHandler(this.cancButton_Click);
            // 
            // photoPath
            // 
            this.photoPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.photoPath.FormattingEnabled = true;
            this.photoPath.Location = new System.Drawing.Point(9, 198);
            this.photoPath.Name = "photoPath";
            this.photoPath.Size = new System.Drawing.Size(180, 21);
            this.photoPath.TabIndex = 7;
            this.photoPath.SelectedIndexChanged += new System.EventHandler(this.photoPath_SelectedIndexChanged);
            // 
            // distance
            // 
            this.distance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distance.Location = new System.Drawing.Point(163, 63);
            this.distance.MaxLength = 14;
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(136, 20);
            this.distance.TabIndex = 8;
            // 
            // blind
            // 
            this.blind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.blind.Location = new System.Drawing.Point(163, 138);
            this.blind.MaxLength = 5;
            this.blind.Name = "blind";
            this.blind.Size = new System.Drawing.Size(136, 20);
            this.blind.TabIndex = 5;
            // 
            // radius
            // 
            this.radius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radius.Location = new System.Drawing.Point(163, 102);
            this.radius.MaxLength = 20;
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(136, 20);
            this.radius.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.classChar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.title);
            this.groupBox1.Controls.Add(this.blind);
            this.groupBox1.Controls.Add(this.radius);
            this.groupBox1.Controls.Add(this.distance);
            this.groupBox1.Location = new System.Drawing.Point(206, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 210);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о светиле";
            // 
            // classChar
            // 
            this.classChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.classChar.DataSource = this.spectrumclassBindingSource;
            this.classChar.DisplayMember = "class";
            this.classChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classChar.FormattingEnabled = true;
            this.classChar.Location = new System.Drawing.Point(257, 177);
            this.classChar.MaxLength = 1;
            this.classChar.Name = "classChar";
            this.classChar.Size = new System.Drawing.Size(42, 21);
            this.classChar.TabIndex = 15;
            this.classChar.ValueMember = "id";
            // 
            // spectrumclassBindingSource
            // 
            this.spectrumclassBindingSource.DataMember = "spectrum_class";
            this.spectrumclassBindingSource.DataSource = this.starsDataSet2;
            // 
            // starsDataSet2
            // 
            this.starsDataSet2.DataSetName = "starsDataSet2";
            this.starsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Класс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Видиммый блеск";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(16, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Радиус";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Расстояние";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::starsInfo.Properties.Resources.white_dwaft;
            this.pictureBox1.Location = new System.Drawing.Point(9, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // spectrum_classTableAdapter
            // 
            this.spectrum_classTableAdapter.ClearBeforeFill = true;
            // 
            // AddStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 280);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.photoPath);
            this.Controls.Add(this.cancButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumclassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.ComboBox @class;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancButton;
        private System.Windows.Forms.ComboBox photoPath;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.TextBox blind;
        private System.Windows.Forms.TextBox radius;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox classChar;
        private starsDataSet2 starsDataSet2;
        private System.Windows.Forms.BindingSource spectrumclassBindingSource;
        private starsDataSet2TableAdapters.spectrum_classTableAdapter spectrum_classTableAdapter;
    }
}