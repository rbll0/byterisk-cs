using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Domain.Interfaces;

public interface IConsultaRepository
{
    IEnumerable<ConsultaEntity>? ObterTodos();
    ConsultaEntity? ObterPorId(int id);
    ConsultaEntity? SalvarDados(ConsultaEntity entity);
    ConsultaEntity? EditarDados(ConsultaEntity entity);
    ConsultaEntity? DeletarDados(int id);
}
