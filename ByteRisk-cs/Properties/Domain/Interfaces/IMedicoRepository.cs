using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Domain.Interfaces;

public interface IMedicoRepository
{
    IEnumerable<MedicoEntity>? ObterTodos();
    MedicoEntity? ObterPorId(int id);
    MedicoEntity? SalvarDados(MedicoEntity entity);
    MedicoEntity? EditarDados(MedicoEntity entity);
    MedicoEntity? DeletarDados(int id);
}
