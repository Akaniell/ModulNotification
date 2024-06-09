using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.CourseData;

public class UserCourse
{
    public long Id { get; set; }
    
    public long User_id { get; set; }
    
    public long Course_id { get; set; }
    
    public Course Course { get; set; }
}

public class UserCourseMap
{
    public UserCourseMap(EntityTypeBuilder<UserCourse> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(e => e.Id);
        //курс юзер-курс
        entityTypeBuilder
            .HasOne(e => e.Course)
            .WithMany(e => e.UserCourseList)
            .HasForeignKey(e => e.Course_id);
        //юзер юзер-курс
        //entityTypeBuilder
            
    }
}