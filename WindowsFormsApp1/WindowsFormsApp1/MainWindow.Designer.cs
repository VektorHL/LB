
namespace WindowsFormsApp1
{
    partial class MainWindow
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
            this.MainWindow_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MW_tLP_getMoves_textBox = new System.Windows.Forms.TextBox();
            this.MW_tLP_setMoves_textBox = new System.Windows.Forms.TextBox();
            this.MainWindow_tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindow_tableLayoutPanel
            // 
            this.MainWindow_tableLayoutPanel.ColumnCount = 2;
            this.MainWindow_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainWindow_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainWindow_tableLayoutPanel.Controls.Add(this.MW_tLP_getMoves_textBox, 1, 0);
            this.MainWindow_tableLayoutPanel.Controls.Add(this.MW_tLP_setMoves_textBox, 0, 0);
            this.MainWindow_tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindow_tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainWindow_tableLayoutPanel.Name = "MainWindow_tableLayoutPanel";
            this.MainWindow_tableLayoutPanel.RowCount = 1;
            this.MainWindow_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainWindow_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainWindow_tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
            this.MainWindow_tableLayoutPanel.TabIndex = 1;
            this.MainWindow_tableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_tableLayoutPanel_Paint);
            // 
            // MW_tLP_getMoves_textBox
            // 
            this.MW_tLP_getMoves_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MW_tLP_getMoves_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MW_tLP_getMoves_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MW_tLP_getMoves_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MW_tLP_getMoves_textBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MW_tLP_getMoves_textBox.Location = new System.Drawing.Point(403, 3);
            this.MW_tLP_getMoves_textBox.Multiline = true;
            this.MW_tLP_getMoves_textBox.Name = "MW_tLP_getMoves_textBox";
            this.MW_tLP_getMoves_textBox.ReadOnly = true;
            this.MW_tLP_getMoves_textBox.Size = new System.Drawing.Size(394, 40);
            this.MW_tLP_getMoves_textBox.TabIndex = 1;
            this.MW_tLP_getMoves_textBox.TabStop = false;
            this.MW_tLP_getMoves_textBox.Text = "СВОДКА О ПЕРЕМЕЩЕНИЯХ";
            this.MW_tLP_getMoves_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MW_tLP_getMoves_textBox.WordWrap = false;
            this.MW_tLP_getMoves_textBox.TextChanged += new System.EventHandler(this.MW_tLP_getMoves_textBox_TextChanged);
            // 
            // MW_tLP_setMoves_textBox
            // 
            this.MW_tLP_setMoves_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MW_tLP_setMoves_textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MW_tLP_setMoves_textBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MW_tLP_setMoves_textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MW_tLP_setMoves_textBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MW_tLP_setMoves_textBox.Location = new System.Drawing.Point(3, 3);
            this.MW_tLP_setMoves_textBox.Multiline = true;
            this.MW_tLP_setMoves_textBox.Name = "MW_tLP_setMoves_textBox";
            this.MW_tLP_setMoves_textBox.ReadOnly = true;
            this.MW_tLP_setMoves_textBox.Size = new System.Drawing.Size(394, 40);
            this.MW_tLP_setMoves_textBox.TabIndex = 0;
            this.MW_tLP_setMoves_textBox.TabStop = false;
            this.MW_tLP_setMoves_textBox.Text = "ДОБАВЛЕНИЕ ПЕРЕМЕЩЕНИЯ";
            this.MW_tLP_setMoves_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MW_tLP_setMoves_textBox.WordWrap = false;
            this.MW_tLP_setMoves_textBox.TextChanged += new System.EventHandler(this.MW_tLP_setMoves_textBox_TextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainWindow_tableLayoutPanel);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.MainWindow_tableLayoutPanel.ResumeLayout(false);
            this.MainWindow_tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainWindow_tableLayoutPanel;
        private System.Windows.Forms.TextBox MW_tLP_getMoves_textBox;
        private System.Windows.Forms.TextBox MW_tLP_setMoves_textBox;
    }
}