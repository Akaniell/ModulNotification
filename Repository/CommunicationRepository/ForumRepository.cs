using Data.CommunicationData;
using DTO.CommunicationDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.CommunicationRepository;

public class ForumRepository(ApplicationContext context) : IForumRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<Forum> _forums = context.Set<Forum>();

    public ForumDTO Get(long id)
    {
        var forum = _forums.SingleOrDefault(e => e.Id == id);
        if (forum == null) return null;

        var ForumDTO = new ForumDTO()
        {
            Id = forum.Id,
            Name = forum.Name,
            Description = forum.Description
        };
        return ForumDTO;
    }
    public List<ForumDTO> GetAll()
    {
        var forums = _forums.ToList();

        return forums.Select(forum => new ForumDTO
        {
            Id = forum.Id,
            Name = forum.Name,
            Description = forum.Description
        }).ToList();
    }
    public void Insert(CreateForumDTO dto)
    {
        var forum = new Forum
        {
            Name = dto.Name,
            Description = dto.Description
        };

        _forums.Add(forum);
        context.SaveChanges();
    }
    public void Update(UpdateForumDTO dto)
    {
        var forum = _forums.SingleOrDefault(e => e.Id == dto.Id);
        if (forum == null) return;

        forum.Name = dto.Name;
        forum.Description = dto.Description;

        _forums.Update(forum);
        context.SaveChanges();
    }
    public void Delete(long id)
    {
        var forum = _forums.SingleOrDefault(e => e.Id == id);
        if (forum == null) return;

        _forums.Remove(forum);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }
}
