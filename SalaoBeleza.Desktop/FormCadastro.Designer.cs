namespace SalaoBeleza.Desktop
{
    partial class FormCadastro
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
            barraTopo = new Panel();
            btnVoltar = new Button();
            label1 = new Label();
            pnlFormulario = new Panel();
            flowLayoutPanel4 = new FlowLayoutPanel();
            label5 = new Label();
            textBox3 = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label4 = new Label();
            textBox2 = new TextBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label3 = new Label();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            txtNome = new TextBox();
            button1 = new Button();
            barraTopo.SuspendLayout();
            pnlFormulario.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // barraTopo
            // 
            barraTopo.Controls.Add(btnVoltar);
            barraTopo.Controls.Add(label1);
            barraTopo.Dock = DockStyle.Top;
            barraTopo.Location = new Point(8, 8);
            barraTopo.Name = "barraTopo";
            barraTopo.Size = new Size(484, 48);
            barraTopo.TabIndex = 0;
            // 
            // btnVoltar
            // 
            btnVoltar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltar.Location = new Point(409, 11);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(72, 24);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += FecharCadastro;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(184, 149, 46);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 48);
            label1.TabIndex = 0;
            label1.Text = "Beauty Hair";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlFormulario
            // 
            pnlFormulario.AutoSize = true;
            pnlFormulario.Controls.Add(flowLayoutPanel4);
            pnlFormulario.Controls.Add(flowLayoutPanel3);
            pnlFormulario.Controls.Add(flowLayoutPanel2);
            pnlFormulario.Controls.Add(flowLayoutPanel1);
            pnlFormulario.Dock = DockStyle.Top;
            pnlFormulario.Location = new Point(8, 56);
            pnlFormulario.Name = "pnlFormulario";
            pnlFormulario.Size = new Size(484, 312);
            pnlFormulario.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(label5);
            flowLayoutPanel4.Controls.Add(textBox3);
            flowLayoutPanel4.Dock = DockStyle.Top;
            flowLayoutPanel4.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel4.Location = new Point(0, 234);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(484, 78);
            flowLayoutPanel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(178, 175, 182);
            label5.Location = new Point(0, 0);
            label5.Margin = new Padding(0, 0, 0, 8);
            label5.Name = "label5";
            label5.Size = new Size(162, 25);
            label5.TabIndex = 0;
            label5.Text = "Confirmar Senha";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(0, 33);
            textBox3.Margin = new Padding(0, 0, 0, 16);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(484, 29);
            textBox3.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(label4);
            flowLayoutPanel3.Controls.Add(textBox2);
            flowLayoutPanel3.Dock = DockStyle.Top;
            flowLayoutPanel3.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel3.Location = new Point(0, 156);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(484, 78);
            flowLayoutPanel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(178, 175, 182);
            label4.Location = new Point(0, 0);
            label4.Margin = new Padding(0, 0, 0, 8);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 0;
            label4.Text = "Senha";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(0, 33);
            textBox2.Margin = new Padding(0, 0, 0, 16);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(484, 29);
            textBox2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(textBox1);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 78);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(484, 78);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(178, 175, 182);
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(0, 0, 0, 8);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(0, 33);
            textBox1.Margin = new Padding(0, 0, 0, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(484, 29);
            textBox1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txtNome);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.MinimumSize = new Size(484, 78);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(484, 78);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(178, 175, 182);
            label2.Location = new Point(0, 0);
            label2.Margin = new Padding(0, 0, 0, 8);
            label2.Name = "label2";
            label2.Size = new Size(158, 25);
            label2.TabIndex = 0;
            label2.Text = "Nome Completo";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 12F);
            txtNome.Location = new Point(0, 33);
            txtNome.Margin = new Padding(0, 0, 0, 16);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(484, 29);
            txtNome.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(209, 616);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(500, 650);
            Controls.Add(pnlFormulario);
            Controls.Add(barraTopo);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastro";
            Padding = new Padding(8);
            Text = "FormCadastro";
            barraTopo.ResumeLayout(false);
            pnlFormulario.ResumeLayout(false);
            pnlFormulario.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel barraTopo;
        private Label label1;
        private Button btnVoltar;
        private Panel pnlFormulario;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox txtNome;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label5;
        private TextBox textBox3;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label4;
        private TextBox textBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private TextBox textBox1;
        private Button button1;
    }
}