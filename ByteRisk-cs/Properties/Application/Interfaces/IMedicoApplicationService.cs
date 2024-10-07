using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Application.Interfaces;

public interface IMedicoApplicationService
{
    IEnumerable<MedicoEntity>? ObterTodosMedicos();
    MedicoEntity? ObterMedicoPorId(int id);
    MedicoEntity? SalvarDadosMedico(MedicoDto entity);
    MedicoEntity? EditarDadosMedico(int id, MedicoDto entity);
    MedicoEntity? DeletarDadosMedico(int id);
}
