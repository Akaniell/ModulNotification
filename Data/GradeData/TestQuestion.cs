using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.GradeData;

public class TestQuestion
{
    public long Id { get; set; }
    public int question_num { get; set; }
    public string value { get; set; }
    public string tag { get; set; }
    public long answer_id { get; set; }
    public long test_id { get; set; }
}

public class TestQuestionMap
{
    public TestQuestionMap(EntityTypeBuilder<TestQuestion> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id); 
    }
}