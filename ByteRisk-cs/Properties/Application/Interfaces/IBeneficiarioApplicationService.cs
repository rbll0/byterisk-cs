using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Application.Interfaces;

public interface IBeneficiarioApplicationService
{
    IEnumerable<BeneficiarioEntity>? ObterTodosBeneficiarios();
    BeneficiarioEntity? ObterBeneficiarioPorId(int id);
    BeneficiarioEntity? SalvarDadosBeneficiario(BeneficiarioDto entity);
    BeneficiarioEntity? EditarDadosBeneficiario(int id, BeneficiarioDto entity);
    BeneficiarioEntity? DeletarDadosBeneficiario(int id);
}
