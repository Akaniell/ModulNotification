using Data.CommunicationData;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.CourseData;

public class Course
{
     public long Id { get; set; }

     public string CourseName { get; set; }
     
     public int Price { get; set; }
     
     public string Author { get; set; }

     public List<Theory> TheoryList { get; set; } = [];
     
     public List<UserCourse> UserCourseList { get; set; } = [];
     
     //public List<Review> ReviewList { get; set; } = [];
    
     //public Review Review { get; set; }
}

public class CourseMap
{
     public CourseMap(EntityTypeBuilder<Course> entityTypeBuilder)
     {
          entityTypeBuilder.HasKey(e => e.Id);
          entityTypeBuilder.Property(e => e.CourseName).IsRequired();
          entityTypeBuilder
               .HasMany(e => e.TheoryList)
               .WithOne(e => e.Course);
          entityTypeBuilder
               .HasMany(e => e.UserCourseList)
               .WithOne(e => e.Course);
          
          // Курс и отзыв
          /*entityTypeBuilder
               .HasMany(e => e.ReviewList)
               .WithOne(e => e.Course);*/
     }
}
