using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Application.Interfaces;
using ByteRisk_cs.Properties.Domain.Entities;
using ByteRisk_cs.Properties.Domain.Interfaces;

namespace ByteRisk_cs.Properties.Application.Services;

public class PlanoApplicationService : IPlanoApplicationService 
{
    private readonly IPlanoRepository _planoRepository;

    public PlanoApplicationService(IPlanoRepository planoRepository)
    {
        _planoRepository = planoRepository;
    }

    public PlanoEntity? DeletarDadosPlano(int id)
    {
        return _planoRepository.DeletarDados(id);
    }

    public PlanoEntity? EditarDadosPlano(int id, PlanoDto entity)
    {
        var plano = new PlanoEntity
        {
            Id = id,
            NomePlano = entity.NomePlano,
            TipoPlano = entity.TipoPlano,
            ValorMensal = entity.ValorMensal
        };

        return _planoRepository.EditarDados(plano);
    }

    public PlanoEntity? ObterPlanoPorId(int id)
    {
        return _planoRepository.ObterPorId(id);
    }

    public IEnumerable<PlanoEntity>? ObterTodosPlanos()
    {
        return _planoRepository.ObterTodos();
    }

    public PlanoEntity? SalvarDadosPlano(PlanoDto entity)
    {
        var plano = new PlanoEntity
        {
            NomePlano = entity.NomePlano,
            TipoPlano = entity.TipoPlano,
            ValorMensal = entity.ValorMensal
        };

        return _planoRepository.SalvarDados(plano);
    }
}
