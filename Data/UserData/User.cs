using Data.NotificationData;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.UserData;

public class User:IdentityUser
{
    /*public long Id { get; set; }*/
    public string First_name { get; set;  }
    public string Last_name { get; set; }
    /*public string login { get; set; }
    public string password { get; set; }
    public string email { get; set; }*/
    /*public string created_at { get; set; }*/
    //Communication
        
     //Course
        
     //Grade
        
     //Notification
    //public List<UserNotification> UserNotificationList { get; set; } = [];
    public List<Subscription> SubscriptionList { get; set; } = [];
    public List<Method> MethodList { get; set; } = [];
    public List<Notification_Data> NotificationDataList { get; set; } = [];
}

public class UserMap
{
    public UserMap(EntityTypeBuilder<User> entityTypeBuilder)
    {
        /*entityTypeBuilder.HasKey(e => e.Id);*/
        entityTypeBuilder.Property(e => e.First_name).IsRequired();
        entityTypeBuilder.Property(e => e.Last_name).IsRequired();
        /*entityTypeBuilder.Property(e => e.login).IsRequired();
        entityTypeBuilder.Property(e => e.password).IsRequired();
        entityTypeBuilder.Property(e => e.email).IsRequired();*/
        /*entityTypeBuilder.Property(e => e.created_at).IsRequired();*/
        //Communication
        
        //Course
        
        //Grade
        
        //Notification
        /*entityTypeBuilder
            .HasMany(e => e.UserNotificationList)
            .WithOne(e => e.User);*/
        entityTypeBuilder                       
            .HasMany(e => e.SubscriptionList) 
            .WithOne(e => e.User); 
        entityTypeBuilder                       
            .HasMany(e => e.MethodList) 
            .WithOne(e => e.User);
        entityTypeBuilder                       
            .HasMany(e => e.NotificationDataList) 
            .WithOne(e => e.User);
    }
}