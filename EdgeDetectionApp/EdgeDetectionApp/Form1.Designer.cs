using System.Drawing;
using System.Windows.Forms;

namespace EdgeDetectionApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            labelExecutionTime = new Label();
            buttonUpload = new Button();
            buttonSave = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();

            // Upload Button (Tile Style)
            buttonUpload.Text = "📂 Upload";
            buttonUpload.Location = new Point(50, 50);
            buttonUpload.Size = new Size(200, 100);
            buttonUpload.BackColor = Color.FromArgb(0, 120, 215);
            buttonUpload.ForeColor = Color.White;
            buttonUpload.FlatStyle = FlatStyle.Flat;
            buttonUpload.FlatAppearance.BorderSize = 0;
            buttonUpload.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonUpload.Click += UploadToolStripMenuItem_Click;
            Controls.Add(buttonUpload);

            // Save Button (Tile Style)
            buttonSave.Text = "💾 Save";
            buttonSave.Location = new Point(300, 50);
            buttonSave.Size = new Size(200, 100);
            buttonSave.BackColor = Color.FromArgb(0, 120, 215);
            buttonSave.ForeColor = Color.White;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            buttonSave.Click += SaveToolStripMenuItem_Click;
            Controls.Add(buttonSave);

            // PictureBox1 (Before Processing, Tile Style)
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(550, 50);
            pictureBox1.Size = new Size(500, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox1.TabStop = false;
            Controls.Add(pictureBox1);

            // PictureBox2 (After Processing, Tile Style)
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(550, 400);
            pictureBox2.Size = new Size(500, 300);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.BackColor = Color.FromArgb(40, 40, 40);
            pictureBox2.TabStop = false;
            Controls.Add(pictureBox2);

            // Start Button (Tile Style)
            button1.BackColor = Color.FromArgb(0, 120, 215);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(50, 200);
            button1.Size = new Size(450, 100);
            button1.Text = "▶ Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            Controls.Add(button1);

            // Execution Time Label
            labelExecutionTime.AutoSize = true;
            labelExecutionTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelExecutionTime.ForeColor = Color.White;
            labelExecutionTime.Location = new Point(50, 350);
            labelExecutionTime.Text = "Execution time: 0 ms";
            Controls.Add(labelExecutionTime);

            // Library Selection ComboBox
            comboBox1.BackColor = Color.FromArgb(30, 30, 30);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.White;
            comboBox1.Items.AddRange(new object[] { "C++", "Assembly" });
            comboBox1.Location = new Point(200, 500);
            comboBox1.Size = new Size(200, 35);
            Controls.Add(comboBox1);

            // Library Label
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(50, 500);
            label2.Text = "Library:";
            Controls.Add(label2);

            // Before Processing Label
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(550, 20);
            label3.Text = "Before Processing";
            label3.ForeColor = Color.White;
            Controls.Add(label3);

            // After Processing Label
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(550, 370);
            label4.Text = "After Processing";
            label4.ForeColor = Color.White;
            Controls.Add(label4);

            // Form Properties (Restored Default Border)
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(1100, 750);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🔍 Edge Detection App";

            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label labelExecutionTime;
        private Button buttonUpload;
        private Button buttonSave;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
