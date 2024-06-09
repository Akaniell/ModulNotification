using System.Text;
using Data;
using Data.UserData;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Repository;
using Repository.CourseRepository;
using Repository.UserRepository;
using Repository.GradeRepository;
using Repository.NotificationRepository;
using Repository.CommunicationRepository;
using Repository.JwtRepository;
using Service.GradeService; 
using Service.UserService;
using Service.CourseService;
using Service.NotificationService;
using Service.CommunicationService;
using Services.JwtService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddTransient<IUserService, UserService>();

builder.Services.AddScoped(typeof(IJwtRepository), typeof(JwtRepository));
builder.Services.AddTransient<IJwtService, JwtService>();

//Course
builder.Services.AddScoped(typeof(ICourseRepository), typeof(CourseRepository));
builder.Services.AddTransient<ICourseService, CourseService>();

builder.Services.AddScoped(typeof(ITheoryRepository), typeof(TheoryRepository));
builder.Services.AddTransient<ITheoryService, TheoryService>();

builder.Services.AddScoped(typeof(IPracticeRepository), typeof(PracticeRepository));
builder.Services.AddTransient<IPracticeService, PracticeService>();

builder.Services.AddScoped(typeof(ITypeOfPracticeRepository), typeof(TypeOfPracticeRepository));
builder.Services.AddTransient<ITypeOfPracticeService, TypeOfPracticeService>();

builder.Services.AddScoped(typeof(IUserCourseRepository), typeof(UserCourseRepository));
builder.Services.AddTransient<IUserCourseService, UserCourseService>();

builder.Services.AddScoped(typeof(ITestAnswerRepository), typeof(TestAnswerRepository));
builder.Services.AddTransient<ITestAnswerService, TestAnswerService>();

builder.Services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));
builder.Services.AddTransient<IReviewService, ReviewService>();

builder.Services.AddScoped(typeof(IForumRepository), typeof(ForumRepository));
builder.Services.AddTransient<IForumService, ForumService>();

builder.Services.AddScoped(typeof(IAppealRepository), typeof(AppealRepository));
builder.Services.AddTransient<IAppealService, AppealService>();

builder.Services.AddScoped(typeof(IPersonalRepository), typeof(PersonalRepository));
builder.Services.AddTransient<IPersonalService, PersonalService>();

builder.Services.AddScoped(typeof(IMessageRepository), typeof(MessageRepository));
builder.Services.AddTransient<IMessageService, MessageService>();

//Notification
builder.Services.AddScoped(typeof(IMethod_typeRepository), typeof(Method_typeRepository));
builder.Services.AddTransient<IMethod_typeService, Method_typeService>();

builder.Services.AddScoped(typeof(IMethodRepository), typeof(MethodRepository));
builder.Services.AddTransient<IMethodService, MethodService>();

builder.Services.AddScoped(typeof(IPatternRepository), typeof(PatternRepository));
builder.Services.AddTransient<IPatternService, PatternService>();

builder.Services.AddScoped(typeof(INotification_typeRepository), typeof(Notification_typeRepository));
builder.Services.AddTransient<INotification_typeService, Notification_typeService>();

builder.Services.AddScoped(typeof(ISubscriptionRepository), typeof(SubscriptionRepository));
builder.Services.AddTransient<ISubscriptionService, SubscriptionService>();

builder.Services.AddScoped(typeof(INotificationContentRepository), typeof(NotificationContentRepository));
builder.Services.AddTransient<INotificationContentService, NotificationContentService>();

builder.Services.AddScoped(typeof(INotification_DataRepository), typeof(Notification_DataRepository));
builder.Services.AddTransient<INotification_DataService, Notification_DataService>();

builder.Services.AddIdentityCore<User>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.User.RequireUniqueEmail = true;
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 6;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
}).AddEntityFrameworkStores<ApplicationContext>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.UseSecurityTokenValidators = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidAudience = "onlinetrainingapi.lan",
        ValidIssuer = "onlinetrainingapi.lan",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    }; 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();