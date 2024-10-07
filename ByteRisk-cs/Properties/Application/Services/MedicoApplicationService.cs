using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Application.Interfaces;
using ByteRisk_cs.Properties.Domain.Entities;
using ByteRisk_cs.Properties.Domain.Interfaces;

namespace ByteRisk_cs.Properties.Application.Services;

public class MedicoApplicationService : IMedicoApplicationService
{
    private readonly IMedicoRepository _medicoRepository;

    public MedicoApplicationService(IMedicoRepository medicoRepository)
    {
        _medicoRepository = medicoRepository;
    }

    public MedicoEntity? DeletarDadosMedico(int id)
    {
        return _medicoRepository.DeletarDados(id);
    }

    public MedicoEntity? EditarDadosMedico(int id, MedicoDto entity)
    {
        var medico = new MedicoEntity
        {
            Id = id,
            Nome = entity.Nome,
            Especialidade = entity.Especialidade,
            Crm = entity.Crm
        };

        return _medicoRepository.EditarDados(medico);
    }

    public MedicoEntity? ObterMedicoPorId(int id)
    {
        return _medicoRepository.ObterPorId(id);
    }

    public IEnumerable<MedicoEntity>? ObterTodosMedicos()
    {
        return _medicoRepository.ObterTodos();
    }

    public MedicoEntity? SalvarDadosMedico(MedicoDto entity)
    {
        var medico = new MedicoEntity
        {
            Nome = entity.Nome,
            Especialidade = entity.Especialidade,
            Crm = entity.Crm
        };

        return _medicoRepository.SalvarDados(medico);
    }
}

