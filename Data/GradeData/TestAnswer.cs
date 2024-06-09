using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.GradeData;

public class TestAnswer
{
    public long Id { get; set; }
    public string value { get; set; }
    public bool is_correct { get; set; }
}

public class TestAnswerMap
{
    public TestAnswerMap(EntityTypeBuilder<TestAnswer> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
    }
}