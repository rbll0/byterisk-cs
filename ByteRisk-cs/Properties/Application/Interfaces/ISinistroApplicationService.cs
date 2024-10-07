using ByteRisk_cs.Properties.Application.Dtos;
using ByteRisk_cs.Properties.Domain.Entities;

namespace ByteRisk_cs.Properties.Application.Interfaces;

public interface ISinistroApplicationService
{
    IEnumerable<SinistroEntity>? ObterTodosSinistros();
    SinistroEntity? ObterSinistroPorId(int id);
    SinistroEntity? SalvarDadosSinistro(SinistroDto entity);
    SinistroEntity? EditarDadosSinistro(int id, SinistroDto entity);
    SinistroEntity? DeletarDadosSinistro(int id);
}
