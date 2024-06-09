using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.CourseData;

public class Theory
{
    public long Id { get; set; }
    public string Theory_field { get; set; }
    
    public long Course_ID { get; set; }
    
    public Course Course { get; set; }
    
    public List<Practice> PracticeList { get; set; } = [];
    

    
}

public class TheoryMap
{
    public TheoryMap(EntityTypeBuilder<Theory> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.Theory_field).IsRequired();
        //Курс и теория
        entityTypeBuilder
            .HasOne(e => e.Course)
            .WithMany(e => e.TheoryList)
            .HasForeignKey(e => e.Course_ID);
        // Теория и практика
        entityTypeBuilder
            .HasMany(e => e.PracticeList)
            .WithOne(e => e.Theory);
    }
}