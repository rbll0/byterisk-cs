using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Domain.Interfaces;

public interface IBeneficiarioRepository
{
    IEnumerable<BeneficiarioEntity>? ObterTodos();
    BeneficiarioEntity? ObterPorId(int id);
    BeneficiarioEntity? SalvarDados(BeneficiarioEntity entity);
    BeneficiarioEntity? EditarDados(BeneficiarioEntity entity);
    BeneficiarioEntity? DeletarDados(int id);
}
