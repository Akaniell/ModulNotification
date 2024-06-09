using DTO.CommunicationDTO;
using Data.CommunicationData;
using Microsoft.EntityFrameworkCore;
using Data.CourseData;
using DTO.CourseDTO;
using Repository.CourseRepository;

namespace Repository.CommunicationRepository;

public class AppealRepository(ApplicationContext context) : IAppealRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Appeal> _appeals = context.Set<Appeal>();

    public AppealDTO Get(long id)
    {
        var appeal = _appeals.SingleOrDefault(e => e.Id == id);
        if (appeal == null) return null;

        var AppealDTO = new AppealDTO()
        {
            Id = appeal.Id,
            User_id = appeal.User_id,
            Problem = appeal.Problem
        };
        return AppealDTO;
    }
    public List<AppealDTO> GetAll()
    {
        var appeals = _appeals.ToList();

        return appeals.Select(appeal => new AppealDTO
        {
            Id = appeal.Id,
            User_id = appeal.User_id,
            Problem = appeal.Problem
        }).ToList();
    }
    public void Insert(CreateAppealDTO dto)
    {
        var appeal = new Appeal
        {
            User_id = dto.User_id,
            Problem = dto.Problem
        };

        _appeals.Add(appeal);
        context.SaveChanges();
    }
    public void Update(UpdateAppealDTO dto)
    {
        var appeal = _appeals.SingleOrDefault(e => e.Id == dto.Id);
        if (appeal == null) return;

        appeal.User_id = dto.User_id;
        appeal.Problem = dto.Problem;

        _appeals.Update(appeal);
        context.SaveChanges();
    }
    public void Delete(long id)
    {
        var appeal = _appeals.SingleOrDefault(e => e.Id == id);
        if (appeal == null) return;

        _appeals.Remove(appeal);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}
