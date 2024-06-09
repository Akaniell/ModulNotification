using DTO.CommunicationDTO;
using Data.CommunicationData;
using Microsoft.EntityFrameworkCore;

namespace Repository.CommunicationRepository;

public class PersonalRepository(ApplicationContext context) : IPersonalRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Personal> _personals = context.Set<Personal>();
    public PersonalDTO Get(long id)
    {
        var personal = _personals.SingleOrDefault(e => e.Id == id);
        if (personal == null) return null;

        var PersonalDTO = new PersonalDTO()
        {
            Id = personal.Id,
            User_id = personal.User_id,
            Read_status = personal.Read_status
        };
        return PersonalDTO;
    }

    public List<PersonalDTO> GetAll()
    {
        var personals = _personals.ToList();

        return personals.Select(personal => new PersonalDTO
        {
            Id = personal.Id,
            User_id = personal.User_id,
            Read_status = personal.Read_status
        }).ToList();
    }

    public void Insert(CreatePersonalDTO dto)
    {
        var personal = new Personal
        {
            User_id = dto.User_id,
            Read_status = dto.Read_status
        };

        _personals.Add(personal);
        context.SaveChanges();
    }

    public void Update(UpdatePersonalDTO dto)
    {
        var personal = _personals.SingleOrDefault(e => e.Id == dto.Id);
        if (personal == null) return;

        personal.User_id = dto.User_id;
        personal.Read_status = dto.Read_status;

        _personals.Update(personal);
        context.SaveChanges();
    }

    public void Delete(long id)
    {
        var personal = _personals.SingleOrDefault(e => e.Id == id);
        if (personal == null) return;

        _personals.Remove(personal);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}
