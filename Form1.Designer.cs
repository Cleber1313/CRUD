
namespace CRUD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDeletar = new Button();
            btnSalvar = new Button();
            label7 = new Label();
            btnConsultar = new Button();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            txtId = new TextBox();
            txtLocalizar = new TextBox();
            txtListView = new ListView();
            btnAtualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(571, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 30);
            label1.TabIndex = 0;
            label1.Text = "CRUD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 1;
            label2.Text = "Dados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 182);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 2;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(76, 273);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 367);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 451);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(39, 25);
            label6.TabIndex = 5;
            label6.Text = "ID:";
            // 
            // btnDeletar
            // 
            btnDeletar.ForeColor = Color.DodgerBlue;
            btnDeletar.Location = new Point(76, 577);
            btnDeletar.Margin = new Padding(4, 4, 4, 4);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(110, 43);
            btnDeletar.TabIndex = 6;
            btnDeletar.Text = "DELETAR";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click_1;
            // 
            // btnSalvar
            // 
            btnSalvar.ForeColor = Color.DodgerBlue;
            btnSalvar.Location = new Point(292, 568);
            btnSalvar.Margin = new Padding(4, 4, 4, 4);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(134, 52);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(598, 182);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 25);
            label7.TabIndex = 9;
            label7.Text = "Localizar:";
            // 
            // btnConsultar
            // 
            btnConsultar.ForeColor = Color.DodgerBlue;
            btnConsultar.Location = new Point(1027, 173);
            btnConsultar.Margin = new Padding(4, 4, 4, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(134, 35);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "CONSULTAR";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click_1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(194, 173);
            txtNome.Margin = new Padding(4, 4, 4, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(248, 33);
            txtNome.TabIndex = 11;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(194, 263);
            txtTelefone.Margin = new Padding(4, 4, 4, 4);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(248, 33);
            txtTelefone.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(194, 357);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(248, 33);
            txtEmail.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Location = new Point(120, 442);
            txtId.Margin = new Padding(4, 4, 4, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(69, 33);
            txtId.TabIndex = 14;
            // 
            // txtLocalizar
            // 
            txtLocalizar.Location = new Point(728, 173);
            txtLocalizar.Margin = new Padding(4, 4, 4, 4);
            txtLocalizar.Name = "txtLocalizar";
            txtLocalizar.Size = new Size(260, 33);
            txtLocalizar.TabIndex = 15;
            // 
            // txtListView
            // 
            txtListView.Location = new Point(598, 235);
            txtListView.Margin = new Padding(4, 4, 4, 4);
            txtListView.Name = "txtListView";
            txtListView.Size = new Size(651, 335);
            txtListView.TabIndex = 16;
            txtListView.UseCompatibleStateImageBehavior = false;
            // 
            // btnAtualizar
            // 
            btnAtualizar.ForeColor = Color.DodgerBlue;
            btnAtualizar.Location = new Point(76, 529);
            btnAtualizar.Margin = new Padding(4, 4, 4, 4);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(107, 42);
            btnAtualizar.TabIndex = 17;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(1301, 637);
            Controls.Add(btnAtualizar);
            Controls.Add(txtListView);
            Controls.Add(txtLocalizar);
            Controls.Add(txtId);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(btnConsultar);
            Controls.Add(label7);
            Controls.Add(btnSalvar);
            Controls.Add(btnDeletar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonFace;
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDeletar;
        private Button btnSalvar;
        private Label label7;
        private Button btnConsultar;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private TextBox txtId;
        private TextBox txtLocalizar;
        private ListView txtListView;
        private Button btnAtualizar;
    }
}
