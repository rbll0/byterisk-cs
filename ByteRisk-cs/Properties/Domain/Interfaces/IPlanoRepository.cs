using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Domain.Interfaces;

public interface IPlanoRepository
{
    IEnumerable<PlanoEntity>? ObterTodos();
    PlanoEntity? ObterPorId(int id);
    PlanoEntity? SalvarDados(PlanoEntity entity);
    PlanoEntity? EditarDados(PlanoEntity entity);
    PlanoEntity? DeletarDados(int id);
}
