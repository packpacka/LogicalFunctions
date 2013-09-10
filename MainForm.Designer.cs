namespace LogicalFunctions
{
  partial class MainForm
  {
    /// <summary>
    /// Требуется переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Обязательный метод для поддержки конструктора - не изменяйте
    /// содержимое данного метода при помощи редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.buttonCalc = new System.Windows.Forms.Button();
      this.dataGridViewTableLogic = new System.Windows.Forms.DataGridView();
      this.listBoxProtocol = new System.Windows.Forms.ListBox();
      this.numericUpDownW2 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownTeta = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownW1 = new System.Windows.Forms.NumericUpDown();
      this.labelTeta = new System.Windows.Forms.Label();
      this.labelW2 = new System.Windows.Forms.Label();
      this.labelW1 = new System.Windows.Forms.Label();
      this.radioButtonOR = new System.Windows.Forms.RadioButton();
      this.radioButtonAND = new System.Windows.Forms.RadioButton();
      this.radioButtonXOR = new System.Windows.Forms.RadioButton();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableLogic)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW1)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonCalc
      // 
      this.buttonCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.buttonCalc.Location = new System.Drawing.Point(349, 114);
      this.buttonCalc.Name = "buttonCalc";
      this.buttonCalc.Size = new System.Drawing.Size(120, 36);
      this.buttonCalc.TabIndex = 17;
      this.buttonCalc.Text = "Решить";
      this.buttonCalc.UseVisualStyleBackColor = true;
      this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
      // 
      // dataGridViewTableLogic
      // 
      this.dataGridViewTableLogic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTableLogic.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewTableLogic.Name = "dataGridViewTableLogic";
      this.dataGridViewTableLogic.RowTemplate.Height = 24;
      this.dataGridViewTableLogic.Size = new System.Drawing.Size(283, 85);
      this.dataGridViewTableLogic.TabIndex = 16;
      // 
      // listBoxProtocol
      // 
      this.listBoxProtocol.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.listBoxProtocol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.listBoxProtocol.FormattingEnabled = true;
      this.listBoxProtocol.ItemHeight = 17;
      this.listBoxProtocol.Location = new System.Drawing.Point(0, 198);
      this.listBoxProtocol.Name = "listBoxProtocol";
      this.listBoxProtocol.Size = new System.Drawing.Size(485, 191);
      this.listBoxProtocol.TabIndex = 15;
      // 
      // numericUpDownW2
      // 
      this.numericUpDownW2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.numericUpDownW2.Location = new System.Drawing.Point(349, 41);
      this.numericUpDownW2.Name = "numericUpDownW2";
      this.numericUpDownW2.Size = new System.Drawing.Size(120, 29);
      this.numericUpDownW2.TabIndex = 14;
      // 
      // numericUpDownTeta
      // 
      this.numericUpDownTeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.numericUpDownTeta.Location = new System.Drawing.Point(349, 76);
      this.numericUpDownTeta.Name = "numericUpDownTeta";
      this.numericUpDownTeta.Size = new System.Drawing.Size(120, 29);
      this.numericUpDownTeta.TabIndex = 13;
      // 
      // numericUpDownW1
      // 
      this.numericUpDownW1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.numericUpDownW1.Location = new System.Drawing.Point(349, 6);
      this.numericUpDownW1.Name = "numericUpDownW1";
      this.numericUpDownW1.Size = new System.Drawing.Size(120, 29);
      this.numericUpDownW1.TabIndex = 12;
      // 
      // labelTeta
      // 
      this.labelTeta.AutoSize = true;
      this.labelTeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelTeta.Location = new System.Drawing.Point(289, 84);
      this.labelTeta.Name = "labelTeta";
      this.labelTeta.Size = new System.Drawing.Size(54, 21);
      this.labelTeta.TabIndex = 11;
      this.labelTeta.Text = "Порог";
      // 
      // labelW2
      // 
      this.labelW2.AutoSize = true;
      this.labelW2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelW2.Location = new System.Drawing.Point(309, 49);
      this.labelW2.Name = "labelW2";
      this.labelW2.Size = new System.Drawing.Size(34, 21);
      this.labelW2.TabIndex = 10;
      this.labelW2.Text = "W2";
      // 
      // labelW1
      // 
      this.labelW1.AutoSize = true;
      this.labelW1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelW1.Location = new System.Drawing.Point(309, 14);
      this.labelW1.Name = "labelW1";
      this.labelW1.Size = new System.Drawing.Size(34, 21);
      this.labelW1.TabIndex = 9;
      this.labelW1.Text = "W1";
      // 
      // radioButtonOR
      // 
      this.radioButtonOR.AutoSize = true;
      this.radioButtonOR.Location = new System.Drawing.Point(375, 168);
      this.radioButtonOR.Name = "radioButtonOR";
      this.radioButtonOR.Size = new System.Drawing.Size(41, 17);
      this.radioButtonOR.TabIndex = 18;
      this.radioButtonOR.Text = "OR";
      this.radioButtonOR.UseVisualStyleBackColor = true;
      this.radioButtonOR.CheckedChanged += new System.EventHandler(this.radioButtonOR_CheckedChanged);
      // 
      // radioButtonAND
      // 
      this.radioButtonAND.AutoSize = true;
      this.radioButtonAND.Checked = true;
      this.radioButtonAND.Location = new System.Drawing.Point(321, 168);
      this.radioButtonAND.Name = "radioButtonAND";
      this.radioButtonAND.Size = new System.Drawing.Size(48, 17);
      this.radioButtonAND.TabIndex = 19;
      this.radioButtonAND.TabStop = true;
      this.radioButtonAND.Text = "AND";
      this.radioButtonAND.UseVisualStyleBackColor = true;
      this.radioButtonAND.CheckedChanged += new System.EventHandler(this.radioButtonAND_CheckedChanged);
      // 
      // radioButtonXOR
      // 
      this.radioButtonXOR.AutoSize = true;
      this.radioButtonXOR.Location = new System.Drawing.Point(422, 168);
      this.radioButtonXOR.Name = "radioButtonXOR";
      this.radioButtonXOR.Size = new System.Drawing.Size(47, 17);
      this.radioButtonXOR.TabIndex = 20;
      this.radioButtonXOR.Text = "XOR";
      this.radioButtonXOR.UseVisualStyleBackColor = true;
      this.radioButtonXOR.CheckedChanged += new System.EventHandler(this.radioButtonXOR_CheckedChanged);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(485, 389);
      this.Controls.Add(this.radioButtonXOR);
      this.Controls.Add(this.radioButtonAND);
      this.Controls.Add(this.radioButtonOR);
      this.Controls.Add(this.buttonCalc);
      this.Controls.Add(this.dataGridViewTableLogic);
      this.Controls.Add(this.listBoxProtocol);
      this.Controls.Add(this.numericUpDownW2);
      this.Controls.Add(this.numericUpDownTeta);
      this.Controls.Add(this.numericUpDownW1);
      this.Controls.Add(this.labelTeta);
      this.Controls.Add(this.labelW2);
      this.Controls.Add(this.labelW1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Лабораторная работа №1 - Математический нерон";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableLogic)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonCalc;
    private System.Windows.Forms.DataGridView dataGridViewTableLogic;
    private System.Windows.Forms.ListBox listBoxProtocol;
    private System.Windows.Forms.NumericUpDown numericUpDownW2;
    private System.Windows.Forms.NumericUpDown numericUpDownTeta;
    private System.Windows.Forms.NumericUpDown numericUpDownW1;
    private System.Windows.Forms.Label labelTeta;
    private System.Windows.Forms.Label labelW2;
    private System.Windows.Forms.Label labelW1;
    private System.Windows.Forms.RadioButton radioButtonOR;
    private System.Windows.Forms.RadioButton radioButtonAND;
    private System.Windows.Forms.RadioButton radioButtonXOR;

  }
}

