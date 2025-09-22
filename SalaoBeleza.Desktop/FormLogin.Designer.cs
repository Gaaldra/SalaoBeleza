using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;
using Button = System.Windows.Forms.Button;

namespace SalaoBeleza.Desktop;

partial class FormLogin
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
        txtEmail = new TextBox();
        topBar = new Panel();
        btnFechar = new Button();
        lblTitulo = new Label();
        pnlFormulario = new Panel();
        btnEntrar = new Button();
        chkLembrar = new CheckBox();
        txtSenha = new TextBox();
        label2 = new Label();
        topBar.SuspendLayout();
        pnlFormulario.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F);
        label1.Location = new Point(7, 111);
        label1.Margin = new Padding(0, 0, 0, 8);
        label1.Name = "label1";
        label1.Size = new Size(48, 21);
        label1.TabIndex = 3;
        label1.Text = "Email";
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(7, 137);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(390, 23);
        txtEmail.TabIndex = 4;
        // 
        // topBar
        // 
        topBar.BackColor = Color.Transparent;
        topBar.Controls.Add(btnFechar);
        topBar.Controls.Add(lblTitulo);
        topBar.Dock = DockStyle.Top;
        topBar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        topBar.Location = new Point(8, 8);
        topBar.Name = "topBar";
        topBar.Size = new Size(404, 48);
        topBar.TabIndex = 5;
        // 
        // btnFechar
        // 
        btnFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnFechar.BackColor = Color.FromArgb(220, 53, 69);
        btnFechar.FlatAppearance.BorderSize = 0;
        btnFechar.FlatStyle = FlatStyle.Flat;
        btnFechar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnFechar.ForeColor = Color.White;
        btnFechar.Location = new Point(359, 9);
        btnFechar.Name = "btnFechar";
        btnFechar.Size = new Size(42, 30);
        btnFechar.TabIndex = 1;
        btnFechar.Text = "X";
        btnFechar.UseVisualStyleBackColor = false;
        btnFechar.Click += FecharPrograma;
        // 
        // lblTitulo
        // 
        lblTitulo.BackColor = Color.Transparent;
        lblTitulo.Dock = DockStyle.Left;
        lblTitulo.Font = new Font("Segoe Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lblTitulo.ForeColor = Color.FromArgb(240, 185, 179);
        lblTitulo.Location = new Point(0, 0);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Padding = new Padding(12, 0, 0, 0);
        lblTitulo.Size = new Size(300, 48);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Beauty Hair";
        lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // pnlFormulario
        // 
        pnlFormulario.Controls.Add(btnEntrar);
        pnlFormulario.Controls.Add(chkLembrar);
        pnlFormulario.Controls.Add(txtSenha);
        pnlFormulario.Controls.Add(label2);
        pnlFormulario.Controls.Add(txtEmail);
        pnlFormulario.Controls.Add(label1);
        pnlFormulario.Dock = DockStyle.Fill;
        pnlFormulario.Location = new Point(8, 56);
        pnlFormulario.Name = "pnlFormulario";
        pnlFormulario.Padding = new Padding(4);
        pnlFormulario.Size = new Size(404, 456);
        pnlFormulario.TabIndex = 6;
        // 
        // btnEntrar
        // 
        btnEntrar.Anchor = AnchorStyles.None;
        btnEntrar.Location = new Point(170, 417);
        btnEntrar.Name = "btnEntrar";
        btnEntrar.Size = new Size(80, 32);
        btnEntrar.TabIndex = 8;
        btnEntrar.Text = "Entrar";
        btnEntrar.UseVisualStyleBackColor = true;
        // 
        // chkLembrar
        // 
        chkLembrar.AutoSize = true;
        chkLembrar.Location = new Point(7, 270);
        chkLembrar.Name = "chkLembrar";
        chkLembrar.Size = new Size(97, 19);
        chkLembrar.TabIndex = 7;
        chkLembrar.Text = "Lembrar-me?";
        chkLembrar.UseVisualStyleBackColor = true;
        // 
        // txtSenha
        // 
        txtSenha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtSenha.Font = new Font("Segoe UI", 12F);
        txtSenha.Location = new Point(7, 235);
        txtSenha.Name = "txtSenha";
        txtSenha.PasswordChar = '*';
        txtSenha.Size = new Size(390, 29);
        txtSenha.TabIndex = 6;
        // 
        // label2
        // 
        label2.Font = new Font("Segoe UI", 12F);
        label2.Location = new Point(7, 204);
        label2.Margin = new Padding(0, 0, 0, 8);
        label2.Name = "label2";
        label2.Size = new Size(53, 20);
        label2.TabIndex = 5;
        label2.Text = "Senha";
        // 
        // FormLogin
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(420, 520);
        Controls.Add(pnlFormulario);
        Controls.Add(topBar);
        DoubleBuffered = true;
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FormLogin";
        Padding = new Padding(8);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login do Sistema";
        topBar.ResumeLayout(false);
        pnlFormulario.ResumeLayout(false);
        pnlFormulario.PerformLayout();
        ResumeLayout(false);
    }

    #endregion
    private Label label1;
    private TextBox txtEmail;
    private Panel topBar;
    private Button btnFechar;
    private Label lblTitulo;
    private Panel pnlFormulario;
    private CheckBox chkLembrar;
    private TextBox txtSenha;
    private Label label2;
    private Button btnEntrar;
}
