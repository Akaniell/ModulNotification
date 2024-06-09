using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.CourseData;

public class Practice
{
    public long Id { get; set; }
    
    public long Theory_id { get; set; }
    
    public long Type_of_practice_id { get; set; }
    
    public string Practice_field { get; set; }

    public Theory Theory { get; set; }

    public TypeOfPractice TypeOfPractice { get; set; }
    
}

public class PracticeMap
{
    public PracticeMap(EntityTypeBuilder<Practice> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.Practice_field).IsRequired();
        //Теория и практика
        entityTypeBuilder
            .HasOne(e => e.Theory)
            .WithMany(e => e.PracticeList)
            .HasForeignKey(e => e.Theory_id);
        //Практика и тип практики
        entityTypeBuilder
            .HasOne(e => e.TypeOfPractice)
            .WithMany(e => e.PracticeList)
            .HasForeignKey(e => e.Type_of_practice_id);



    }
}