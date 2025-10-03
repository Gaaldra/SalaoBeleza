using SalaoBeleza.Desktop.Banco_de_Dados;
using SalaoBeleza.Desktop.Servicos;
using SalaoBeleza.Desktop.Modelos;

namespace SalaoBeleza.Desktop;

public partial class FormCadastro : Form
{
    public FormCadastro()
    {
        InitializeComponent();
    }

    private void FecharCadastro(object sender, EventArgs e)
    {
        this.Close();
    }

    private void CadastrarUsuario(object sender, EventArgs e)
    {
        List<TextBox> camposParaValidar = [txtNome, txtEmail, txtSenha, txtConfirmarSenha];
        foreach (TextBox campo in camposParaValidar)
        {
            if (string.IsNullOrWhiteSpace(campo.Text))
            {
                MessageBox.Show("Ainda existem campos vazios que precisam ser preenchidos!", "Erro de validação!");
                campo.Focus();
                return;
            }
        }

        if (!txtSenha.Text.Equals(txtConfirmarSenha.Text))
        {
            MessageBox.Show("As senhas digita não são iguais.", "Erro de Validação!");
            txtConfirmarSenha.Focus();
            return;
        }

        Usuario novoUsuario = new()
        {
            NomeCompleto = txtNome.Text,
            Email = txtEmail.Text,
            Senha = txtSenha.Text
        };

        UsuarioServicos userServicos = new(new SalaoBelezaContext());
        userServicos.AdicionarUsuario(novoUsuario);
    }
}
