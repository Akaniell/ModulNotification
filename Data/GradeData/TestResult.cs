using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.GradeData;

public class TestResult()
{
    public long Id { get; set; }
    public string created_at { get; set; }
    public long answer_id { get; set; }
    public long question_id{ get; set; }
    public long test_id { get; set; }
    public long user_id { get; set; }
}

public class TestResultMap
{
    public TestResultMap(EntityTypeBuilder<TestResult> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);   
    }
}