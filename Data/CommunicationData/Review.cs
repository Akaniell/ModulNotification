using Data.CourseData;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.CommunicationData;

public class Review
{
    public long Id { get; set; }
    public long User_id { get; set; }
    public long Course_id { get; set; }
    public long Star { get; set; }
    public string Review_text { get; set; }
    
    public Course Course { get; set; }
}

public class ReviewMap
{
    public ReviewMap(EntityTypeBuilder<Review> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        entityTypeBuilder.Property(e => e.Star).IsRequired();
        entityTypeBuilder.Property(e => e.Review_text).IsRequired();
        entityTypeBuilder.Property(e => e.User_id).IsRequired();
        //entityTypeBuilder.Property(e => e.Course_id).IsRequired();
        
        // Курс и отзыв
        /*entityTypeBuilder
            .HasOne(e => e.Course)
            .WithMany(e => e.ReviewList)
            .HasForeignKey(e => e.Course_id);*/
    }
}