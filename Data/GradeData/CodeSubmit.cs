using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.GradeData;

public class CodeSubmit()
{
    public long Id { get; set; }
    public string created_at { get; set; }
    public long problem_id { get; set; }
    public long user_id { get; set; }
    public string code { get; set; }
    public bool is_false { get; set; }
    public long language_id { get; set; }
}

public class CodeSubmitMap
{
    public CodeSubmitMap(EntityTypeBuilder<CodeSubmit> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
    }
}