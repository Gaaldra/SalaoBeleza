using Microsoft.EntityFrameworkCore;
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
        try
        {
            _contexto.Usuarios.Add(usuario);
            _contexto.SaveChanges();
        }
        catch (DbUpdateConcurrencyException)
        {
            MessageBox.Show("Usuário não pode ser salvo no banco de dados");
        }
        catch (DbUpdateException)
        {
            MessageBox.Show("Erro ao salvar informações no banco de dados");
        }
    }
}
