using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.GradeData;

public class Language()
{
    public long Id { get; set; }
    public string name { get; set; }
}

public class LanguageMap
{
    public LanguageMap(EntityTypeBuilder<Language> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
    }
}