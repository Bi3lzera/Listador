namespace Listador_II
{
          partial class Form1
          {
                    /// <summary>
                    /// Variável de designer necessária.
                    /// </summary>
                    private System.ComponentModel.IContainer components = null;

                    /// <summary>
                    /// Limpar os recursos que estão sendo usados.
                    /// </summary>
                    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
                    protected override void Dispose(bool disposing)
                    {
                              if (disposing && (components != null))
                              {
                                        components.Dispose();
                              }
                              base.Dispose(disposing);
                    }

                    #region Código gerado pelo Windows Form Designer

                    /// <summary>
                    /// Método necessário para suporte ao Designer - não modifique 
                    /// o conteúdo deste método com o editor de código.
                    /// </summary>
                    private void InitializeComponent()
                    {
                        this.dataGridView1 = new System.Windows.Forms.DataGridView();
                        this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Ligacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
                        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
                        this.SuspendLayout();
                        // 
                        // dataGridView1
                        // 
                        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Ligacao,
            this.Valor,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
                        this.dataGridView1.Location = new System.Drawing.Point(24, 28);
                        this.dataGridView1.Name = "dataGridView1";
                        this.dataGridView1.Size = new System.Drawing.Size(764, 399);
                        this.dataGridView1.TabIndex = 0;
                        // 
                        // Num
                        // 
                        this.Num.HeaderText = "Column1";
                        this.Num.Name = "Num";
                        // 
                        // Ligacao
                        // 
                        this.Ligacao.HeaderText = "Ligacao";
                        this.Ligacao.Name = "Ligacao";
                        // 
                        // Valor
                        // 
                        this.Valor.HeaderText = "Valor";
                        this.Valor.Name = "Valor";
                        // 
                        // Column1
                        // 
                        this.Column1.HeaderText = "Column1";
                        this.Column1.Name = "Column1";
                        // 
                        // Column2
                        // 
                        this.Column2.HeaderText = "Column2";
                        this.Column2.Name = "Column2";
                        // 
                        // Column3
                        // 
                        this.Column3.HeaderText = "Column3";
                        this.Column3.Name = "Column3";
                        // 
                        // Column4
                        // 
                        this.Column4.HeaderText = "Column4";
                        this.Column4.Name = "Column4";
                        // 
                        // Column5
                        // 
                        this.Column5.HeaderText = "Column5";
                        this.Column5.Name = "Column5";
                        // 
                        // Column6
                        // 
                        this.Column6.HeaderText = "Column6";
                        this.Column6.Name = "Column6";
                        // 
                        // Column7
                        // 
                        this.Column7.HeaderText = "Column7";
                        this.Column7.Name = "Column7";
                        // 
                        // Form1
                        // 
                        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                        this.ClientSize = new System.Drawing.Size(800, 450);
                        this.Controls.Add(this.dataGridView1);
                        this.Name = "Form1";
                        this.Text = "Form1";
                        this.Load += new System.EventHandler(this.Form1_Load);
                        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
                        this.ResumeLayout(false);

                    }

                #endregion

                private System.Windows.Forms.DataGridView dataGridView1;
                private System.Windows.Forms.DataGridViewTextBoxColumn Num;
                private System.Windows.Forms.DataGridViewTextBoxColumn Ligacao;
                private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
                private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
                private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
                private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
                private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
                private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
                private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
                private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        }
}

