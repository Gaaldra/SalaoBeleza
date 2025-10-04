using SalaoBeleza.Desktop.Banco_de_Dados;
using SalaoBeleza.Desktop.Modelos;

namespace SalaoBeleza.Desktop.Servicos;

internal class UsuarioServicos
{
    private SalaoBelezaContext _contexto;

    public UsuarioServicos(SalaoBelezaContext contexto)
    {
        _contexto = contexto;
    }

    public void AdicionarUsuario(Usuario usuario)
    {
        _contexto.Usuarios.Add(usuario);
        _contexto.SaveChanges();
        MessageBox.Show($"{usuario.NomeCompleto} foi adicionado com sucesso");
    }

    public void ObterUsuario()
    {
        _contexto.Usuarios.FirstOrDefault();
    }
}
