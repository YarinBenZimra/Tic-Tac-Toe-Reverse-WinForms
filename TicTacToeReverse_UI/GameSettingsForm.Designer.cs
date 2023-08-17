using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeReverse_UI
{
    partial class GameSettingsForm
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
        private void InitializeComponentGameSettingsForm()
        {
            InitializeLabelsProperties();
            InitializeTextBoxesProperties();
            InitializeNumericUpDownProperties();
            InitializeCheckBoxProperties();
            InitializeButtonStartProperties();
            InitializeFormProperties();
        }
        public void InitializeFormProperties()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettingsForm));
            SuspendLayout();
            AcceptButton = this.buttonStart;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(300, 247);
            Controls.Add(this.buttonStart);
            Controls.Add(this.label5);
            Controls.Add(this.numericUpDownCols);
            Controls.Add(this.numericUpDownRows);
            Controls.Add(this.label4);
            Controls.Add(this.label3);
            Controls.Add(this.checkBoxPlayer2);
            Controls.Add(this.textBoxPlayer2);
            Controls.Add(this.textBoxPlayer1);
            Controls.Add(this.label2);
            Controls.Add(this.label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            MaximizeBox = false;
            Name = "GameSettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        public void InitializeLabelsProperties()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label1.Location = new System.Drawing.Point(25, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 25);
            label1.TabIndex = 0;
            label1.Text = "Players:";
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(42, 45);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(56, 16);
            label2.TabIndex = 1;
            label2.Text = "Player1:";
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(25, 125);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 16);
            label3.TabIndex = 5;
            label3.Text = "Board Size:";
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(42, 154);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 16);
            label4.TabIndex = 6;
            label4.Text = "Rows:";
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(170, 154);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 16);
            label5.TabIndex = 9;
            label5.Text = "Cols:";
        }
        public void InitializeTextBoxesProperties()
        {
            textBoxPlayer1 = new System.Windows.Forms.TextBox();
            textBoxPlayer2 = new System.Windows.Forms.TextBox();
            textBoxPlayer1.Location = new System.Drawing.Point(138, 45);
            textBoxPlayer1.Name = "textBoxPlayer1";
            textBoxPlayer1.Size = new System.Drawing.Size(100, 22);
            textBoxPlayer1.TabIndex = 10;
            textBoxPlayer2.BackColor = System.Drawing.SystemColors.ControlLight;
            textBoxPlayer2.Enabled = false;
            textBoxPlayer2.ForeColor = System.Drawing.SystemColors.GrayText;
            textBoxPlayer2.Location = new System.Drawing.Point(138, 71);
            textBoxPlayer2.Name = "textBoxPlayer2";
            textBoxPlayer2.Size = new System.Drawing.Size(100, 22);
            textBoxPlayer2.TabIndex = 30;
            textBoxPlayer2.Text = "[Computer]";
        }
        public void InitializeNumericUpDownProperties()
        {
            numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCols)).BeginInit();
            numericUpDownRows.Location = new System.Drawing.Point(92, 152);
            numericUpDownRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            numericUpDownRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            numericUpDownRows.Name = "numericUpDownRows";
            numericUpDownRows.Size = new System.Drawing.Size(45, 22);
            numericUpDownRows.TabIndex = 40;
            numericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownRows.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            numericUpDownCols.Location = new System.Drawing.Point(213, 152);
            numericUpDownCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            numericUpDownCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            numericUpDownCols.Name = "numericUpDownCols";
            numericUpDownCols.Size = new System.Drawing.Size(45, 22);
            numericUpDownCols.TabIndex = 50;
            numericUpDownCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            numericUpDownCols.ValueChanged += new System.EventHandler(this.numericUpDownCols_ValueChanged);
        }
        private void InitializeButtonStartProperties()
        {
            buttonStart = new System.Windows.Forms.Button();
            buttonStart.Location = new System.Drawing.Point(19, 203);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new System.Drawing.Size(240, 23);
            buttonStart.TabIndex = 60;
            buttonStart.Text = "Start!";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
        }
        private void InitializeCheckBoxProperties()
        {
            checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            checkBoxPlayer2.AutoSize = true;
            checkBoxPlayer2.Location = new System.Drawing.Point(45, 73);
            checkBoxPlayer2.Name = "checkBoxPlayer2";
            checkBoxPlayer2.Size = new System.Drawing.Size(78, 20);
            checkBoxPlayer2.TabIndex = 20;
            checkBoxPlayer2.Text = "Player2:";
            checkBoxPlayer2.UseVisualStyleBackColor = true;
            checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxPlayer2_CheckedChanged);
        }
        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlayer1;
        private System.Windows.Forms.TextBox textBoxPlayer2;
        private System.Windows.Forms.CheckBox checkBoxPlayer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownRows;
        private System.Windows.Forms.NumericUpDown numericUpDownCols;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonStart;
    }
}

