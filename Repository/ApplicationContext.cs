using Data.CourseData;
using Data.UserData;
using Data.GradeData;
using Data.NotificationData;
using Data.CommunicationData;
using DTO.CourseDTO;
using Microsoft.EntityFrameworkCore;
using Data.CommunicationData;
using Data.NotificationData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Repository;

public class ApplicationContext(DbContextOptions<ApplicationContext> options) : IdentityUserContext<User>(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        /*new UserMap(modelBuilder.Entity<User>());*/
        
        //Communication
        
        /*
        new ReviewMap(modelBuilder.Entity<Review>());
        /*modelBuilder.Entity<Review>().HasData(
            new Review { Id = 1, User_id = 2, Course_id = 1, Star = 1, Review_text = "Не понравилось. Скучно" },
            new Review { Id = 2, User_id = 3, Course_id = 2, Star = 5, Review_text = "Супер" },
            new Review { Id = 3, User_id = 4, Course_id = 3, Star = 4, Review_text = "Можно и лучше" },
            new Review { Id = 4, User_id = 4, Course_id = 2, Star = 5, Review_text = "С первого раза всё понял. Спасибо!!" }
        );*/

        new ForumMap(modelBuilder.Entity<Forum>());
        /*modelBuilder.Entity<Forum>().HasData(
            new Forum { Id = 1, Name = "SQL", Description = "Почкему так сложно" },
            new Forum { Id = 2, Name = "Биполярка", Description = "Почему так легко" },
            new Forum { Id = 3, Name = "Геймдев", Description = "Я обязательно туда попаду" },
            new Forum { Id = 4, Name = "Мотивация", Description = "Слишком тяжёлая, не поднимается" },
            new Forum { Id = 5, Name = "Как стать миллионером за 5 минут", Description = "Спойлер: никак. Можно за 6" },
            new Forum { Id = 6, Name = "Программирование", Description = "Структурированное программирование подтверждает закон исключённого третьего.." }
        );*/

        new AppealMap(modelBuilder.Entity<Appeal>());
        /*modelBuilder.Entity<Appeal>().HasData(
            new Appeal { Id = 1, User_id = 3, Problem = "Проблемы с оплатой" },
            new Appeal { Id = 2, User_id = 3, Problem = "Другое" },
            new Appeal { Id = 3, User_id = 1, Problem = "Проблемы с преподавателем" },
            new Appeal { Id = 4, User_id = 4, Problem = "Проблемы с сайтом" }
        );*/

        new PersonalMap(modelBuilder.Entity<Personal>());
        /*modelBuilder.Entity<Personal>().HasData(
            new Personal { Id = 1, User_id = 2, Read_status = true },
            new Personal { Id = 2, User_id = 3, Read_status = true },
            new Personal { Id = 3, User_id = 1, Read_status = true },
            new Personal { Id = 4, User_id = 4, Read_status = false }
        );*/

        new MessageMap(modelBuilder.Entity<Message>());
        /*modelBuilder.Entity<Message>().HasData(
            new Message { Id = 1, Mess_text = "Как дела?", Forum_id = 2, User_id = 3, Personal_id = 9223372036854775807, Appeal_id = 9223372036854775807 },
            new Message { Id = 2, Mess_text = "Привет", Forum_id = 9223372036854775807, User_id = 2, Personal_id = 1, Appeal_id = 9223372036854775807 },
            new Message { Id = 3, Mess_text = "Я уеду жить в Л.. в Москву", Forum_id = 2, User_id = 1, Personal_id = 9223372036854775807, Appeal_id = 9223372036854775807 },
            new Message { Id = 4, Mess_text = "Почему так дорого", Forum_id = 9223372036854775807, User_id = 4, Personal_id = 9223372036854775807, Appeal_id = 3 },
            new Message { Id = 5, Mess_text = "Ответ - 42", Forum_id = 9223372036854775807, User_id = 1, Personal_id = 3, Appeal_id = 9223372036854775807 },
            new Message { Id = 6, Mess_text = "Не понимаю тему", Forum_id = 6, User_id = 3, Personal_id = 9223372036854775807, Appeal_id = 9223372036854775807 }
        );*/

        //Course
        new CourseMap(modelBuilder.Entity<Course>());
        /*modelBuilder.Entity<Course>().HasData(
            new Course { Id = 1, CourseName = "Программирование", Price = 20000, Author = "Анатолий" },
            new Course { Id = 2, CourseName = "Базы данных", Price = 22000, Author = "Артём" },
            new Course { Id = 3, CourseName = "Учение о жизни", Price = 15000, Author = "Елена" },
            new Course { Id = 4, CourseName = "Спецкурс для инфоцыган", Price = 3000, Author = "Даниил" }
        );*/

        new TheoryMap(modelBuilder.Entity<Theory>());
        /*modelBuilder.Entity<Theory>().HasData(
            new Theory { Id = 1, Theory_field = "Программирование — процесс создания и модификации компьютерных программ.", Course_ID = 1 },
            new Theory { Id = 2, Theory_field = "База данных — это упорядоченный набор структурированной информации или данных, которые обычно хранятся в электронном виде в компьютерной системе.", Course_ID = 2 },
            new Theory { Id = 3, Theory_field = "Учиться и не размышлять – напрасная трата времени; размышлять и не учиться – губительно. Конфуций", Course_ID = 3 },
            new Theory { Id = 4, Theory_field = "Купи мо курсы и зарабатывай 1$ каждый раз, когда моргаешь", Course_ID = 4 },
            new Theory { Id = 5, Theory_field = "Первая нормальная форма: нет повторяющихся групп Таблицы должны иметь только два измерения. ...\n    Вторая нормальная форма: устранение избыточных данных ...\n    Третья нормальная форма: устранение данных, не зависящих от ключа", Course_ID = 2 }
        );*/

        new PracticeMap(modelBuilder.Entity<Practice>());
        /*modelBuilder.Entity<Practice>().HasData(
            new Practice { Id = 1, Theory_id = 1, Type_of_practice_id = 1, Practice_field = "Мы узнали что такое программирование, а теперь перейдем к вопросу" },
            new Practice { Id = 2, Theory_id = 2, Type_of_practice_id = 1, Practice_field = "Создаём свою первую таблицу book" },
            new Practice { Id = 3, Theory_id = 3, Type_of_practice_id = 0, Practice_field = "Какое из утверждений верно?" },
            new Practice { Id = 4, Theory_id = 4, Type_of_practice_id = 1, Practice_field = "А ты уже моргнул 10 раз?" },
            new Practice { Id = 5, Theory_id = 5, Type_of_practice_id = 0, Practice_field = "Мы узнали об основных формах нормализации. Попробуйте ответить на следующие вопросы" }
        );*/

        new TypeOfPracticeMap(modelBuilder.Entity<TypeOfPractice>());
        /*modelBuilder.Entity<TypeOfPractice>().HasData(
            new TypeOfPractice { Id = 1, Type_of_practice_field = "Выбор правильного варианта ответа" },
            new TypeOfPractice { Id = 2, Type_of_practice_field = "Проверка кода" }
        );*/

        new UserCourseMap(modelBuilder.Entity<UserCourse>());
        /*modelBuilder.Entity<UserCourse>().HasData(
            new UserCourse { Id = 1, User_id = 1, Course_id = 1 },
            new UserCourse { Id = 2, User_id = 1, Course_id = 4 },
            new UserCourse { Id = 3, User_id = 3, Course_id = 3 },
            new UserCourse { Id = 4, User_id = 4, Course_id = 2 },
            new UserCourse { Id = 5, User_id = 2, Course_id = 1 },
            new UserCourse { Id = 6, User_id = 2, Course_id = 2 }
        );*/

        //Grade
        new TestAnswerMap(modelBuilder.Entity<TestAnswer>());

        //Notification
        new Method_TypeMap(modelBuilder.Entity<Method_type>());
        modelBuilder.Entity<Method_type>().HasData(
            new Method_type { Id = 1, Name = "Telegram" },
            new Method_type { Id = 2, Name = "По номеру телефона" },
            new Method_type { Id = 3, Name = "WhatsApp" },
            new Method_type { Id = 4, Name = "Viber" },
            new Method_type { Id = 5, Name = "ВКонтакте" },
            new Method_type { Id = 6, Name = "На Email" }
        );

        new PatternMap(modelBuilder.Entity<Pattern>());
        modelBuilder.Entity<Pattern>().HasData(
            new Pattern { Id = 1, Name = "Пустое", Default_text = "" },
            new Pattern { Id = 2, Name = "Новое сообщение", Default_text = "У вас есть непрочитанное сообщение" },
            new Pattern { Id = 3, Name = "Домашнее задание", Default_text = "У вас есть предстоящее домашнее задание" },
            new Pattern { Id = 4, Name = "Новый курс", Default_text = "Новый курс доступен для изучения" },
            new Pattern { Id = 5, Name = "Изменения в расписании", Default_text = "В расписании есть изменения" },
            new Pattern { Id = 6, Name = "Отмена занятия", Default_text = "Расписание для курса было обновлено" },
            new Pattern { Id = 7, Name = "Оплата курса подтверждена", Default_text = "Оплата курса успешно подтверждена" },
            new Pattern { Id = 8, Name = "Напоминание об оплате курса", Default_text = "Не забудьте оплатить курс" },
            new Pattern { Id = 9, Name = "Оплата курса отклонена", Default_text = "Оплата курса отклонена, проверьте данные оплаты" }
        );

        new MethodMap(modelBuilder.Entity<Method>());
        
        new Notification_typeMap(modelBuilder.Entity<Notification_type>());
        modelBuilder.Entity<Notification_type>().HasData(
            new Notification_type{ Id = 1, Name = "Системное уведомление", Mandatory = 1},
            new Notification_type{ Id = 2, Name = "Информационное уведомление", Mandatory = 0},
            new Notification_type{ Id = 3, Name = "Напоминание", Mandatory = 0},
            new Notification_type{ Id = 4, Name = "Технические работы", Mandatory = 1},
            new Notification_type{ Id = 5, Name = "Новый курс доступен", Mandatory = 1},
            new Notification_type{ Id = 6, Name = "Изменения в расписании", Mandatory = 0},
            new Notification_type{ Id = 7, Name = "Оплата курса", Mandatory = 1}
        );

        new SubscriptionMap(modelBuilder.Entity<Subscription>());

        new NotificationContentMap(modelBuilder.Entity<NotificationContent>());

        new Notification_DataMap(modelBuilder.Entity<Notification_Data>());
    }
}