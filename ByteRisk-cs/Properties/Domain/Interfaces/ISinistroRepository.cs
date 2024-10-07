using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Domain.Interfaces;

public interface ISinistroRepository
{
    IEnumerable<SinistroEntity>? ObterTodos();
    SinistroEntity? ObterPorId(int id);
    SinistroEntity? SalvarDados(SinistroEntity entity);
    SinistroEntity? EditarDados(SinistroEntity entity);
    SinistroEntity? DeletarDados(int id);
}