using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.GradeData;

public class Problem()
{
    public long Id { get; set; }
    public string name { get; set; }
    public string task { get; set; }
}

public class ProblemMap
{
    public ProblemMap(EntityTypeBuilder<Problem> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
    }
}