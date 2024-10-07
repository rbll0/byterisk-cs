using ByteRisk_cs.Properties.Domain.Entities;
using ByteRisk_cs.Properties.Domain.Interfaces;
using ByteRisk_cs.Properties.Infrastructure.Data.AppData;

namespace ByteRisk_cs.Properties.Infrastructure.Data.Repository;

public class ConsultaRepository : IConsultaRepository
{
    private readonly ApplicationContext _context;

        public ConsultaRepository(ApplicationContext context)
        {
            _context = context;
        }

        public ConsultaEntity? DeletarDados(int id)
        {
            try
            {
                var consulta = _context.Consultas.Find(id);

                if (consulta is not null)
                {
                    _context.Consultas.Remove(consulta);
                    _context.SaveChanges();
                    return consulta;
                }

                throw new Exception("Não foi possível localizar a consulta");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public ConsultaEntity? EditarDados(ConsultaEntity entity)
        {
            try
            {
                var consulta = _context.Consultas.Find(entity.Id);

                if (consulta is not null)
                {
                    consulta.DataConsulta = entity.DataConsulta;
                    consulta.MotivoConsulta = entity.MotivoConsulta;
                    consulta.Status = entity.Status;
                    consulta.BeneficiarioId = entity.BeneficiarioId;
                    consulta.MedicoId = entity.MedicoId;

                    _context.Update(consulta);
                    _context.SaveChanges();

                    return consulta;
                }

                throw new Exception("Não foi possível localizar a consulta");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public ConsultaEntity? ObterPorId(int id)
        {
            return _context.Consultas.Find(id);
        }

        public IEnumerable<ConsultaEntity>? ObterTodos()
        {
            var consultas = _context.Consultas.ToList();

            if (consultas.Any())
                return consultas;

            return null;
        }

        public ConsultaEntity? SalvarDados(ConsultaEntity entity)
        {
            try
            {
                _context.Consultas.Add(entity);
                _context.SaveChanges();

                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Não foi possível salvar a consulta");
            }
        }
}
