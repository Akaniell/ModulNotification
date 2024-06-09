using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.GradeData;

public class Test
{
    public long Id { get; set; }
    public string name { get; set; }
    public string intro { get; set; }
}

public class TestMap
{
    public TestMap(EntityTypeBuilder<Test> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
    }
}