using Data.GradeData;
using DTO.GradeDTO;
using Microsoft.EntityFrameworkCore;

namespace Repository.GradeRepository;

public class TestAnswerRepository(ApplicationContext context) : ITestAnswerRepository
{
    private readonly ApplicationContext _context = context;
    private DbSet<TestAnswer> _testAnswer = context.Set<TestAnswer>();

    public TestAnswerDTO Get(long id)
    {
        var testAnswer = _testAnswer.SingleOrDefault(e => e.Id == id);
        if (testAnswer == null) return null;

        var testAnswerDto = new TestAnswerDTO
        {
            Id = testAnswer.Id,
            value = testAnswer.value,
            is_correct = testAnswer.is_correct
        };

        return testAnswerDto;
    }

    public List<TestAnswerDTO> GetAll()
    {
        var testAnswer = _testAnswer.ToList();

        return testAnswer.Select(testAnswer => new TestAnswerDTO
        {
            Id = testAnswer.Id,
            value = testAnswer.value,
            is_correct = testAnswer.is_correct
        }).ToList();
    }

    public void Update(UpdateTestAnswerDTO dto)
    {
        var testAnswer = _testAnswer.SingleOrDefault(e => e.Id == dto.Id);
        if (testAnswer == null) return;

        testAnswer.value = dto.value;
        testAnswer.is_correct = dto.is_correct;

        _testAnswer.Update(testAnswer);
        context.SaveChanges();
    }

    public void Insert(CreateTestAnswerDTO dto)
    {
        var course = new TestAnswer
        {
            value = dto.value,
            is_correct = dto.is_corect
        };
        
        _testAnswer.Add(course);
        context.SaveChanges();
    }

    public void Delete(long id)
    {
        var testAnswer = _testAnswer.SingleOrDefault(e => e.Id == id);
        if (testAnswer == null) return;

        _testAnswer.Remove(testAnswer);
        context.SaveChanges();
    }

    public void SaveChanges()
    {
        context.SaveChanges();
    }

}


