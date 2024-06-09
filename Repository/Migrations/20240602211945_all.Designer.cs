﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

#nullable disable

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240602211945_all")]
    partial class all
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.CommunicationData.Appeal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("MessageId")
                        .HasColumnType("bigint");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("User_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.ToTable("Appeal");
                });

            modelBuilder.Entity("Data.CommunicationData.Forum", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MessageId")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.ToTable("Forum");
                });

            modelBuilder.Entity("Data.CommunicationData.Message", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Appeal_id")
                        .HasColumnType("bigint");

                    b.Property<long>("Forum_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Mess_text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Personal_id")
                        .HasColumnType("bigint");

                    b.Property<long>("User_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Appeal_id");

                    b.HasIndex("Forum_id");

                    b.HasIndex("Personal_id");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Data.CommunicationData.Personal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("MessageId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Read_status")
                        .HasColumnType("bit");

                    b.Property<long>("User_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("MessageId");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("Data.CourseData.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("Data.CourseData.Practice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Practice_field")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Theory_id")
                        .HasColumnType("bigint");

                    b.Property<long>("Type_of_practice_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Theory_id");

                    b.HasIndex("Type_of_practice_id");

                    b.ToTable("Practice");
                });

            modelBuilder.Entity("Data.CourseData.Theory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Course_ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Theory_field")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Course_ID");

                    b.ToTable("Theory");
                });

            modelBuilder.Entity("Data.CourseData.TypeOfPractice", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Type_of_practice_field")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfPractice");
                });

            modelBuilder.Entity("Data.CourseData.UserCourse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Course_id")
                        .HasColumnType("bigint");

                    b.Property<long>("User_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("Course_id");

                    b.ToTable("UserCourse");
                });

            modelBuilder.Entity("Data.GradeData.TestAnswer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("is_correct")
                        .HasColumnType("bit");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestAnswer");
                });

            modelBuilder.Entity("Data.NotificationData.Method", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("Method_type_id")
                        .HasColumnType("bigint");

                    b.Property<string>("Sending_Data")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Method_type_id");

                    b.HasIndex("UserId");

                    b.ToTable("Method");
                });

            modelBuilder.Entity("Data.NotificationData.Method_type", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Method_type");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Telegram"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "По номеру телефона"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "WhatsApp"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Viber"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "ВКонтакте"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "На Email"
                        });
                });

            modelBuilder.Entity("Data.NotificationData.NotificationContent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("PatternId")
                        .HasColumnType("bigint");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PatternId");

                    b.HasIndex("TypeId");

                    b.ToTable("NotificationContent");
                });

            modelBuilder.Entity("Data.NotificationData.Notification_Data", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("AdditionalText")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime>("DispatchDateTime")
                        .HasColumnType("datetime2");

                    b.Property<long>("NotificationContentId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("NotificationContentId");

                    b.HasIndex("UserId");

                    b.ToTable("Notification_Data");
                });

            modelBuilder.Entity("Data.NotificationData.Notification_type", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<byte>("Mandatory")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Notification_type");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Mandatory = (byte)1,
                            Name = "Системное уведомление"
                        },
                        new
                        {
                            Id = 2L,
                            Mandatory = (byte)0,
                            Name = "Информационное уведомление"
                        },
                        new
                        {
                            Id = 3L,
                            Mandatory = (byte)0,
                            Name = "Напоминание"
                        },
                        new
                        {
                            Id = 4L,
                            Mandatory = (byte)1,
                            Name = "Технические работы"
                        },
                        new
                        {
                            Id = 5L,
                            Mandatory = (byte)1,
                            Name = "Новый курс доступен"
                        },
                        new
                        {
                            Id = 6L,
                            Mandatory = (byte)0,
                            Name = "Изменения в расписании"
                        },
                        new
                        {
                            Id = 7L,
                            Mandatory = (byte)1,
                            Name = "Оплата курса"
                        });
                });

            modelBuilder.Entity("Data.NotificationData.Pattern", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Default_text")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pattern");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Default_text = "",
                            Name = "Пустое"
                        },
                        new
                        {
                            Id = 2L,
                            Default_text = "У вас есть непрочитанное сообщение",
                            Name = "Новое сообщение"
                        },
                        new
                        {
                            Id = 3L,
                            Default_text = "У вас есть предстоящее домашнее задание",
                            Name = "Домашнее задание"
                        },
                        new
                        {
                            Id = 4L,
                            Default_text = "Новый курс доступен для изучения",
                            Name = "Новый курс"
                        },
                        new
                        {
                            Id = 5L,
                            Default_text = "В расписании есть изменения",
                            Name = "Изменения в расписании"
                        },
                        new
                        {
                            Id = 6L,
                            Default_text = "Расписание для курса было обновлено",
                            Name = "Отмена занятия"
                        },
                        new
                        {
                            Id = 7L,
                            Default_text = "Оплата курса успешно подтверждена",
                            Name = "Оплата курса подтверждена"
                        },
                        new
                        {
                            Id = 8L,
                            Default_text = "Не забудьте оплатить курс",
                            Name = "Напоминание об оплате курса"
                        },
                        new
                        {
                            Id = 9L,
                            Default_text = "Оплата курса отклонена, проверьте данные оплаты",
                            Name = "Оплата курса отклонена"
                        });
                });

            modelBuilder.Entity("Data.NotificationData.Subscription", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<byte>("Status")
                        .HasColumnType("tinyint");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Subscription");
                });

            modelBuilder.Entity("Data.UserData.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("First_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.CommunicationData.Appeal", b =>
                {
                    b.HasOne("Data.CommunicationData.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");
                });

            modelBuilder.Entity("Data.CommunicationData.Forum", b =>
                {
                    b.HasOne("Data.CommunicationData.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");
                });

            modelBuilder.Entity("Data.CommunicationData.Message", b =>
                {
                    b.HasOne("Data.CommunicationData.Appeal", "Appeal")
                        .WithMany("MessageList")
                        .HasForeignKey("Appeal_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.CommunicationData.Forum", "Forum")
                        .WithMany("MessageList")
                        .HasForeignKey("Forum_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Data.CommunicationData.Personal", "Personal")
                        .WithMany("MessageList")
                        .HasForeignKey("Personal_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Appeal");

                    b.Navigation("Forum");

                    b.Navigation("Personal");
                });

            modelBuilder.Entity("Data.CommunicationData.Personal", b =>
                {
                    b.HasOne("Data.CommunicationData.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");
                });

            modelBuilder.Entity("Data.CourseData.Practice", b =>
                {
                    b.HasOne("Data.CourseData.Theory", "Theory")
                        .WithMany("PracticeList")
                        .HasForeignKey("Theory_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.CourseData.TypeOfPractice", "TypeOfPractice")
                        .WithMany("PracticeList")
                        .HasForeignKey("Type_of_practice_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Theory");

                    b.Navigation("TypeOfPractice");
                });

            modelBuilder.Entity("Data.CourseData.Theory", b =>
                {
                    b.HasOne("Data.CourseData.Course", "Course")
                        .WithMany("TheoryList")
                        .HasForeignKey("Course_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Data.CourseData.UserCourse", b =>
                {
                    b.HasOne("Data.CourseData.Course", "Course")
                        .WithMany("UserCourseList")
                        .HasForeignKey("Course_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Data.NotificationData.Method", b =>
                {
                    b.HasOne("Data.NotificationData.Method_type", "Method_type")
                        .WithMany("MethodList")
                        .HasForeignKey("Method_type_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.UserData.User", "User")
                        .WithMany("MethodList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Method_type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.NotificationData.NotificationContent", b =>
                {
                    b.HasOne("Data.NotificationData.Pattern", "Pattern")
                        .WithMany("ContentList")
                        .HasForeignKey("PatternId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.NotificationData.Notification_type", "Notification_type")
                        .WithMany("ContentList")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Notification_type");

                    b.Navigation("Pattern");
                });

            modelBuilder.Entity("Data.NotificationData.Notification_Data", b =>
                {
                    b.HasOne("Data.NotificationData.NotificationContent", "NotificationContent")
                        .WithMany("NotificationDataList")
                        .HasForeignKey("NotificationContentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.UserData.User", "User")
                        .WithMany("NotificationDataList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NotificationContent");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Data.NotificationData.Subscription", b =>
                {
                    b.HasOne("Data.NotificationData.Notification_type", "Notification_type")
                        .WithMany("SubscriptionList")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.UserData.User", "User")
                        .WithMany("SubscriptionList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Notification_type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Data.UserData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Data.UserData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Data.UserData.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.CommunicationData.Appeal", b =>
                {
                    b.Navigation("MessageList");
                });

            modelBuilder.Entity("Data.CommunicationData.Forum", b =>
                {
                    b.Navigation("MessageList");
                });

            modelBuilder.Entity("Data.CommunicationData.Personal", b =>
                {
                    b.Navigation("MessageList");
                });

            modelBuilder.Entity("Data.CourseData.Course", b =>
                {
                    b.Navigation("TheoryList");

                    b.Navigation("UserCourseList");
                });

            modelBuilder.Entity("Data.CourseData.Theory", b =>
                {
                    b.Navigation("PracticeList");
                });

            modelBuilder.Entity("Data.CourseData.TypeOfPractice", b =>
                {
                    b.Navigation("PracticeList");
                });

            modelBuilder.Entity("Data.NotificationData.Method_type", b =>
                {
                    b.Navigation("MethodList");
                });

            modelBuilder.Entity("Data.NotificationData.NotificationContent", b =>
                {
                    b.Navigation("NotificationDataList");
                });

            modelBuilder.Entity("Data.NotificationData.Notification_type", b =>
                {
                    b.Navigation("ContentList");

                    b.Navigation("SubscriptionList");
                });

            modelBuilder.Entity("Data.NotificationData.Pattern", b =>
                {
                    b.Navigation("ContentList");
                });

            modelBuilder.Entity("Data.UserData.User", b =>
                {
                    b.Navigation("MethodList");

                    b.Navigation("NotificationDataList");

                    b.Navigation("SubscriptionList");
                });
#pragma warning restore 612, 618
        }
    }
}
