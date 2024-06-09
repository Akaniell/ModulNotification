using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.CourseData;

public class TypeOfPractice
{
    public long Id { get; set; }
    
    public string Type_of_practice_field { get; set; }

    public List<Practice> PracticeList { get; set; } = [];
    
    
}

public class TypeOfPracticeMap
{
    public TypeOfPracticeMap(EntityTypeBuilder<TypeOfPractice> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.Type_of_practice_field).IsRequired();
        entityTypeBuilder
            .HasMany(e => e.PracticeList)
            .WithOne(e => e.TypeOfPractice);
    }
}