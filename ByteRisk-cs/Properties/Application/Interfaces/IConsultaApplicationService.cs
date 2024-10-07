using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Application.Interfaces;

public interface IConsultaApplicationService
{
    IEnumerable<ConsultaEntity>? ObterTodasConsultas();
    ConsultaEntity? ObterConsultaPorId(int id);
    ConsultaEntity? SalvarDadosConsulta(ConsultaDto entity);
    ConsultaEntity? EditarDadosConsulta(int id, ConsultaDto entity);
    ConsultaEntity? DeletarDadosConsulta(int id);
}
