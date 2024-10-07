using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Application.Interfaces;

public interface IExameApplicationService
{
    IEnumerable<ExameEntity>? ObterTodosExames();
    ExameEntity? ObterExamePorId(int id);
    ExameEntity? SalvarDadosExame(ExameDto entity);
    ExameEntity? EditarDadosExame(int id, ExameDto entity);
    ExameEntity? DeletarDadosExame(int id);
}
