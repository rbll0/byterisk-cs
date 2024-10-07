using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Domain.Interfaces;

public interface IExameRepository
{
    IEnumerable<ExameEntity>? ObterTodos();
    ExameEntity? ObterPorId(int id);
    ExameEntity? SalvarDados(ExameEntity entity);
    ExameEntity? EditarDados(ExameEntity entity);
    ExameEntity? DeletarDados(int id);
}
