namespace SetCustomCurrencySymbol
{
  partial class FormMain
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
      this.cboCultures = new System.Windows.Forms.ComboBox();
      this.txtSymbol = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnRegister = new System.Windows.Forms.Button();
      this.btnUnregister = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtISOCurrencySymbol = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // cboCultures
      // 
      this.cboCultures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboCultures.FormattingEnabled = true;
      this.cboCultures.Location = new System.Drawing.Point(15, 29);
      this.cboCultures.Name = "cboCultures";
      this.cboCultures.Size = new System.Drawing.Size(267, 21);
      this.cboCultures.TabIndex = 0;
      this.cboCultures.SelectedIndexChanged += new System.EventHandler(this.CboCulturesSelectedIndexChanged);
      // 
      // txtSymbol
      // 
      this.txtSymbol.Location = new System.Drawing.Point(160, 89);
      this.txtSymbol.Name = "txtSymbol";
      this.txtSymbol.Size = new System.Drawing.Size(100, 20);
      this.txtSymbol.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(15, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Culture:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(160, 70);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Currency symbol:";
      // 
      // btnRegister
      // 
      this.btnRegister.Location = new System.Drawing.Point(284, 86);
      this.btnRegister.Name = "btnRegister";
      this.btnRegister.Size = new System.Drawing.Size(75, 23);
      this.btnRegister.TabIndex = 4;
      this.btnRegister.Text = "Register";
      this.btnRegister.UseVisualStyleBackColor = true;
      this.btnRegister.Click += new System.EventHandler(this.BtnRegisterClick);
      // 
      // btnUnregister
      // 
      this.btnUnregister.Location = new System.Drawing.Point(365, 86);
      this.btnUnregister.Name = "btnUnregister";
      this.btnUnregister.Size = new System.Drawing.Size(75, 23);
      this.btnUnregister.TabIndex = 5;
      this.btnUnregister.Text = "Unregister";
      this.btnUnregister.UseVisualStyleBackColor = true;
      this.btnUnregister.Click += new System.EventHandler(this.BtnUnregisterClick);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(15, 70);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(108, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "ISO Currency symbol:";
      // 
      // txtISOCurrencySymbol
      // 
      this.txtISOCurrencySymbol.Location = new System.Drawing.Point(15, 89);
      this.txtISOCurrencySymbol.Name = "txtISOCurrencySymbol";
      this.txtISOCurrencySymbol.Size = new System.Drawing.Size(100, 20);
      this.txtISOCurrencySymbol.TabIndex = 6;
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(475, 136);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtISOCurrencySymbol);
      this.Controls.Add(this.btnUnregister);
      this.Controls.Add(this.btnRegister);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSymbol);
      this.Controls.Add(this.cboCultures);
      this.MaximizeBox = false;
      this.Name = "FormMain";
      this.Text = "Set custom currency symbol";
      this.Load += new System.EventHandler(this.Form1Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboCultures;
    private System.Windows.Forms.TextBox txtSymbol;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.Button btnUnregister;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtISOCurrencySymbol;
  }
}

