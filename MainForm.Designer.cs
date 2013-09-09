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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.buttonCalc = new System.Windows.Forms.Button();
      this.dataGridViewTableLogic = new System.Windows.Forms.DataGridView();
      this.listBoxProtocol = new System.Windows.Forms.ListBox();
      this.numericUpDownW2 = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownTeta = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownW1 = new System.Windows.Forms.NumericUpDown();
      this.labelTeta = new System.Windows.Forms.Label();
      this.labelW2 = new System.Windows.Forms.Label();
      this.labelW1 = new System.Windows.Forms.Label();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableLogic)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW1)).BeginInit();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(485, 431);
      this.tabControl1.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.buttonCalc);
      this.tabPage1.Controls.Add(this.dataGridViewTableLogic);
      this.tabPage1.Controls.Add(this.listBoxProtocol);
      this.tabPage1.Controls.Add(this.numericUpDownW2);
      this.tabPage1.Controls.Add(this.numericUpDownTeta);
      this.tabPage1.Controls.Add(this.numericUpDownW1);
      this.tabPage1.Controls.Add(this.labelTeta);
      this.tabPage1.Controls.Add(this.labelW2);
      this.tabPage1.Controls.Add(this.labelW1);
      this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(477, 405);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // buttonCalc
      // 
      this.buttonCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.buttonCalc.Location = new System.Drawing.Point(349, 114);
      this.buttonCalc.Name = "buttonCalc";
      this.buttonCalc.Size = new System.Drawing.Size(120, 36);
      this.buttonCalc.TabIndex = 8;
      this.buttonCalc.Text = "Решить";
      this.buttonCalc.UseVisualStyleBackColor = true;
      // 
      // dataGridViewTableLogic
      // 
      this.dataGridViewTableLogic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewTableLogic.Location = new System.Drawing.Point(0, 0);
      this.dataGridViewTableLogic.Name = "dataGridViewTableLogic";
      this.dataGridViewTableLogic.RowTemplate.Height = 24;
      this.dataGridViewTableLogic.Size = new System.Drawing.Size(283, 201);
      this.dataGridViewTableLogic.TabIndex = 7;
      // 
      // listBoxProtocol
      // 
      this.listBoxProtocol.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.listBoxProtocol.FormattingEnabled = true;
      this.listBoxProtocol.ItemHeight = 21;
      this.listBoxProtocol.Location = new System.Drawing.Point(3, 209);
      this.listBoxProtocol.Name = "listBoxProtocol";
      this.listBoxProtocol.Size = new System.Drawing.Size(471, 193);
      this.listBoxProtocol.TabIndex = 6;
      // 
      // numericUpDownW2
      // 
      this.numericUpDownW2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.numericUpDownW2.Location = new System.Drawing.Point(349, 41);
      this.numericUpDownW2.Name = "numericUpDownW2";
      this.numericUpDownW2.Size = new System.Drawing.Size(120, 29);
      this.numericUpDownW2.TabIndex = 5;
      // 
      // numericUpDownTeta
      // 
      this.numericUpDownTeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.numericUpDownTeta.Location = new System.Drawing.Point(349, 76);
      this.numericUpDownTeta.Name = "numericUpDownTeta";
      this.numericUpDownTeta.Size = new System.Drawing.Size(120, 29);
      this.numericUpDownTeta.TabIndex = 4;
      // 
      // numericUpDownW1
      // 
      this.numericUpDownW1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.numericUpDownW1.Location = new System.Drawing.Point(349, 6);
      this.numericUpDownW1.Name = "numericUpDownW1";
      this.numericUpDownW1.Size = new System.Drawing.Size(120, 29);
      this.numericUpDownW1.TabIndex = 3;
      // 
      // labelTeta
      // 
      this.labelTeta.AutoSize = true;
      this.labelTeta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelTeta.Location = new System.Drawing.Point(289, 84);
      this.labelTeta.Name = "labelTeta";
      this.labelTeta.Size = new System.Drawing.Size(54, 21);
      this.labelTeta.TabIndex = 2;
      this.labelTeta.Text = "Порог";
      // 
      // labelW2
      // 
      this.labelW2.AutoSize = true;
      this.labelW2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelW2.Location = new System.Drawing.Point(309, 49);
      this.labelW2.Name = "labelW2";
      this.labelW2.Size = new System.Drawing.Size(34, 21);
      this.labelW2.TabIndex = 1;
      this.labelW2.Text = "W2";
      // 
      // labelW1
      // 
      this.labelW1.AutoSize = true;
      this.labelW1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelW1.Location = new System.Drawing.Point(309, 14);
      this.labelW1.Name = "labelW1";
      this.labelW1.Size = new System.Drawing.Size(34, 21);
      this.labelW1.TabIndex = 0;
      this.labelW1.Text = "W1";
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(477, 405);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // tabPage3
      // 
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(477, 405);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "tabPage3";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // tabPage4
      // 
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage4.Size = new System.Drawing.Size(477, 405);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "tabPage4";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(485, 431);
      this.Controls.Add(this.tabControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Лабораторная работа №1 - Математический нерон";
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableLogic)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTeta)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownW1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.Button buttonCalc;
    private System.Windows.Forms.DataGridView dataGridViewTableLogic;
    private System.Windows.Forms.ListBox listBoxProtocol;
    private System.Windows.Forms.NumericUpDown numericUpDownW2;
    private System.Windows.Forms.NumericUpDown numericUpDownTeta;
    private System.Windows.Forms.NumericUpDown numericUpDownW1;
    private System.Windows.Forms.Label labelTeta;
    private System.Windows.Forms.Label labelW2;
    private System.Windows.Forms.Label labelW1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.TabPage tabPage4;
  }
}

