using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Application.Interfaces;
using ByteRisk_cs.Properties.Domain.Entities;
using ByteRisk_cs.Properties.Domain.Interfaces;

namespace ByteRisk_cs.Properties.Application.Services;

public class SinistroApplicationService : ISinistroApplicationService
{
    private readonly ISinistroRepository _sinistroRepository;

    public SinistroApplicationService(ISinistroRepository sinistroRepository)
    {
        _sinistroRepository = sinistroRepository;
    }

    public SinistroEntity? DeletarDadosSinistro(int id)
    {
        return _sinistroRepository.DeletarDados(id);
    }

    public SinistroEntity? EditarDadosSinistro(int id, SinistroDto entity)
    {
        var sinistro = new SinistroEntity
        {
            Id = id,
            DataSinistro = entity.DataSinistro,
            TipoSinistro = entity.TipoSinistro,
            ValorSinistro = entity.ValorSinistro,
            BeneficiarioId = entity.BeneficiarioId
        };

        return _sinistroRepository.EditarDados(sinistro);
    }

    public SinistroEntity? ObterSinistroPorId(int id)
    {
        return _sinistroRepository.ObterPorId(id);
    }

    public IEnumerable<SinistroEntity>? ObterTodosSinistros()
    {
        return _sinistroRepository.ObterTodos();
    }

    public SinistroEntity? SalvarDadosSinistro(SinistroDto entity)
    {
        var sinistro = new SinistroEntity
        {
            DataSinistro = entity.DataSinistro,
            TipoSinistro = entity.TipoSinistro,
            ValorSinistro = entity.ValorSinistro,
            BeneficiarioId = entity.BeneficiarioId
        };

        return _sinistroRepository.SalvarDados(sinistro);
    }
}
