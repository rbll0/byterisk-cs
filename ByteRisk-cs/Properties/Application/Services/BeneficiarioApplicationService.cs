using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Application.Interfaces;
using ByteRisk_cs.Properties.Domain.Entities;
using ByteRisk_cs.Properties.Domain.Interfaces;

namespace ByteRisk_cs.Properties.Application.Services;

public class BeneficiarioApplicationService : IBeneficiarioApplicationService
{
    private readonly IBeneficiarioRepository _beneficiarioRepository;

    public BeneficiarioApplicationService(IBeneficiarioRepository beneficiarioRepository)
    {
        _beneficiarioRepository = beneficiarioRepository;
    }

    public BeneficiarioEntity? DeletarDadosBeneficiario(int id)
    {
        return _beneficiarioRepository.DeletarDados(id);
    }

    public BeneficiarioEntity? EditarDadosBeneficiario(int id, BeneficiarioDto entity)
    {
        var beneficiario = new BeneficiarioEntity
        {
            Id = id,
            Nome = entity.Nome,
            DataNascimento = entity.DataNascimento,
            Cpf = entity.Cpf,
            Telefone = entity.Telefone,
            Email = entity.Email,
            Endereco = entity.Endereco,
            PlanoId = entity.PlanoId
        };

        return _beneficiarioRepository.EditarDados(beneficiario);
    }

    public BeneficiarioEntity? ObterBeneficiarioPorId(int id)
    {
        return _beneficiarioRepository.ObterPorId(id);
    }

    public IEnumerable<BeneficiarioEntity>? ObterTodosBeneficiarios()
    {
        return _beneficiarioRepository.ObterTodos();
    }

    public BeneficiarioEntity? SalvarDadosBeneficiario(BeneficiarioDto entity)
    {
        var beneficiario = new BeneficiarioEntity
        {
            Nome = entity.Nome,
            DataNascimento = entity.DataNascimento,
            Cpf = entity.Cpf,
            Telefone = entity.Telefone,
            Email = entity.Email,
            Endereco = entity.Endereco,
            PlanoId = entity.PlanoId
        };

        return _beneficiarioRepository.SalvarDados(beneficiario);
    }
}
