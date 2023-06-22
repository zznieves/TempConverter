namespace TempConverter_
{
    partial class Form1
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
            lblInput = new Label();
            txtBoxInput = new TextBox();
            txtBoxOutput = new TextBox();
            lblOutput = new Label();
            btnSubmit = new Button();
            cmbInitialUnit = new ComboBox();
            cmbFinalUnit = new ComboBox();
            SuspendLayout();
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(219, 112);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(41, 15);
            lblInput.TabIndex = 0;
            lblInput.Text = "Input :";
            // 
            // txtBoxInput
            // 
            txtBoxInput.Location = new Point(266, 109);
            txtBoxInput.Name = "txtBoxInput";
            txtBoxInput.Size = new Size(100, 23);
            txtBoxInput.TabIndex = 1;
            txtBoxInput.KeyDown += txtBoxInput_KeyDown;
            // 
            // txtBoxOutput
            // 
            txtBoxOutput.Location = new Point(266, 138);
            txtBoxOutput.Name = "txtBoxOutput";
            txtBoxOutput.ReadOnly = true;
            txtBoxOutput.Size = new Size(100, 23);
            txtBoxOutput.TabIndex = 2;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(209, 141);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(51, 15);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "Output :";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(330, 167);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            // 
            // cmbInitialUnit
            // 
            cmbInitialUnit.FormattingEnabled = true;
            cmbInitialUnit.Items.AddRange(new object[] { "F°", "C°", "K" });
            cmbInitialUnit.Location = new Point(372, 109);
            cmbInitialUnit.Name = "cmbInitialUnit";
            cmbInitialUnit.Size = new Size(121, 23);
            cmbInitialUnit.TabIndex = 5;
            // 
            // cmbFinalUnit
            // 
            cmbFinalUnit.FormattingEnabled = true;
            cmbFinalUnit.Items.AddRange(new object[] { "F°", "C°", "K" });
            cmbFinalUnit.Location = new Point(372, 138);
            cmbFinalUnit.Name = "cmbFinalUnit";
            cmbFinalUnit.Size = new Size(121, 23);
            cmbFinalUnit.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbFinalUnit);
            Controls.Add(cmbInitialUnit);
            Controls.Add(btnSubmit);
            Controls.Add(lblOutput);
            Controls.Add(txtBoxOutput);
            Controls.Add(txtBoxInput);
            Controls.Add(lblInput);
            Name = "Form1";
            Text = "TempConverter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInput;
        private TextBox txtBoxInput;
        private TextBox txtBoxOutput;
        private Label lblOutput;
        private Button btnSubmit;
        private ComboBox cmbInitialUnit;
        private ComboBox cmbFinalUnit;
    }
}