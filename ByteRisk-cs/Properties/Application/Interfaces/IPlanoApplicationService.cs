using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Application.Interfaces;

public interface IPlanoApplicationService
{
    IEnumerable<PlanoEntity>? ObterTodosPlanos();
    PlanoEntity? ObterPlanoPorId(int id);
    PlanoEntity? SalvarDadosPlano(PlanoDto entity);
    PlanoEntity? EditarDadosPlano(int id, PlanoDto entity);
    PlanoEntity? DeletarDadosPlano(int id);
}
