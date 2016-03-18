namespace Sprint1Test.Migrations
{
    using Sprint1Test.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Sprint1Test.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Sprint1Test.Models.ApplicationDbContext";
            //AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Sprint1Test.Models.ApplicationDbContext context)
        {

            var applicationUsers = new List<ApplicationUser>
            {
                new ApplicationUser{Id="079d1ab1-5e66-4d39-997c-91368a174622",Email="Alex@symbiosis.com", EmailConfirmed=false, PasswordHash="APzChjKCUYs8GLKoQQqMl4OiGHqT39ZXpOl+TiqGVF8dvcJSETaCcbcnu6JcDhdWNA==", SecurityStamp="ca140b68-0d8d-4994-9248-0d54eecbad49", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Alex@symbiosis.com"},
                new ApplicationUser{Id="2026a52f-3b08-4b8e-af2d-44cfbce0847c",Email="Hammock@symbiosis.com", EmailConfirmed=false, PasswordHash="ACV8dnGzQ8mbVNI7xtPLnYD3owEFIWiIj6jA1lsDObNlh1sbMPxxdV8BH456HtJ23Q==", SecurityStamp="7e613e4b-416c-412c-8481-1ff238a36c21", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Hammock@symbiosis.com"},
                new ApplicationUser{Id="21ed460f-885d-4833-b421-1dc302de2a29",Email="Couch@symbiosis.com", EmailConfirmed=false, PasswordHash="AAtMeobnrtZUxVZtv4wClXwkR3BtUTYgRsiLv3GsEYjKOTbX01gGYSSSjw0S4vWD+w==", SecurityStamp="db02903a-ef41-47cb-80c0-2fd491a91e0e", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Couch@symbiosis.com"},
                new ApplicationUser{Id="3378f0d5-304b-4032-9d61-4f4fdd98c75c",Email="pillow@symbiosis.com", EmailConfirmed=false, PasswordHash="AJ3u2IuUmrmY+nnxdUf7F1qBnNkq60CvbK70L88HSbmqaQBvLKLxUP2R+/aIcG6dYw==", SecurityStamp="09357a25-046f-47a4-8586-c470d6fc1096", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="pillow@symbiosis.com"},
                new ApplicationUser{Id="35b85510-049c-415f-ad08-0ec1ea684318",Email="Bunny@symbiosis.com", EmailConfirmed=false, PasswordHash="AE+749B1cM3+kIs78MlAMaXsZTzVwPmyxaC6oc250usMuzdg+aax4SxcEdsHYkHYWA==", SecurityStamp="9eb42163-4949-4d30-835d-9d9e974c5d5c", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Bunny@symbiosis.com"},
                new ApplicationUser{Id="374733a7-25e4-4605-8176-74fc404ca879",Email="Burger@symbiosis.com", EmailConfirmed=false, PasswordHash="AFsPVbtl9WQRl4rYoaHCk25INyYGBEW314bdu786jfjTy8H5d17tx0IxSVLuK/pv5w==", SecurityStamp="b20e3a75-e143-43c8-9ea0-f58d8d2472a2", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Burger@symbiosis.com"},
                new ApplicationUser{Id="46d67da9-f8fc-4c9e-b779-05ec59fb3ed2",Email="Eli@symbiosis.com", EmailConfirmed=false, PasswordHash="AENllxjOTSCaY5yn+ufXvHhwI3JqQLHxuJVY7yhvTAREQ4y6kd0/n7q5eQBRQ4FV+g==", SecurityStamp="03e839ed-336e-434f-8cf6-dde5a088855e", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Eli@symbiosis.com"},
                new ApplicationUser{Id="4c16fa63-4459-4376-9062-20fb78395244",Email="Ben@gmail.com", EmailConfirmed=false, PasswordHash="AMXymGbWXYbrE6+a6y17yW7+LOT2/5RwmgOSn+iOpHhphwOUtWTDUBjh5qt012UJfQ==", SecurityStamp="ab6053dd-0ff1-4462-919f-d2974f89acef", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Ben@gmail.com"},
                new ApplicationUser{Id="5cefb4c2-bf86-4508-a15a-79942973e3c0",Email="Noodles@symbiosis.com", EmailConfirmed=false, PasswordHash="APJ10PR/r4w844k04nheMzwN1RTpT39dbjemjk9+aBFVC8Qlu4ic79KW2ZeOrqyx/g==", SecurityStamp="9645a6a1-b460-49f2-9331-df26839bdd4d", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Noodles@symbiosis.com"},
                new ApplicationUser{Id="60036a2c-86f0-44a8-9be2-68d815ab9f91",Email="test@test.com", EmailConfirmed=false, PasswordHash="AKQSxMJ7QBGwX8FKTTnGkYABtD5bFb/WshIAsryzU5eekAmftPO1gZDjfNUrKHNgWg==", SecurityStamp="bc634777-41a4-4ddb-a0c3-5f50db12b0e9", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="test@test.com"},
                new ApplicationUser{Id="6007d315-a393-4036-93d6-0824a6cad956",Email="Doggy@symbiosis.com", EmailConfirmed=false, PasswordHash="ADPzEt4C1oEFx/q3tJ1Lm4u1aw9WIDcMi7PBEYF9SiRgD6vC1zEKeCfbqBMnGqdVrA==", SecurityStamp="bb713252-f68b-4dfe-adc3-5de81c301ca9", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Doggy@symbiosis.com"},
                new ApplicationUser{Id="73e27684-a438-44ac-8f57-d0ed02c2e9a5",Email="Kitty@symbiosis.com", EmailConfirmed=false, PasswordHash="AIKwWSWMkFIFEcTl7EsNj1LAUt5YRO4H9NrbWiSwUJhuy78xmltLSHHSEP/Tc/yj6w==", SecurityStamp="6226db32-a245-4b30-a1e0-3b1d64c72e8f", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Kitty@symbiosis.com"},
                new ApplicationUser{Id="7b078875-9c36-46c9-a6c5-82434230289f",Email="Lawn@symbiosis.com", EmailConfirmed=false, PasswordHash="AIMhaifYC4rfRQm56veCoGdItHVzColF2VyTdBu1BLh3rdw7XsLltfB44bdQL6Vedw==", SecurityStamp="e09c6f66-7dd6-47ab-a7bc-c27e372ca044", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Lawn@symbiosis.com"},
                new ApplicationUser{Id="e5d2c1fc-6736-4d20-8e13-cea3429ddf71",Email="Cupcake@symbiosis.com", EmailConfirmed=false, PasswordHash="AFbCTv3Pg8HUzFFMP+uzb3nm0lRaAsoF63LrE/AAocVzwhhwXx8GKlbnDenLGjJe3Q==", SecurityStamp="15a6198c-1b63-4262-a2b0-3a6740083252", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Cupcake@symbiosis.com"},
                new ApplicationUser{Id="f2fddc40-798c-44c7-bb3e-18545ca314e7",Email="Amanda@symbiosis.com", EmailConfirmed=false, PasswordHash="AM/XzoW8Nda1zBqodWhybcogRQq064FA07zAA4bc902HCywbFgGSSRqsmhKdlhAOiA==", SecurityStamp="d2e1fa37-1085-448d-99e1-21ac8ab43bab", PhoneNumber=null, PhoneNumberConfirmed=false, TwoFactorEnabled=false, LockoutEndDateUtc=null, LockoutEnabled=true,AccessFailedCount=0, UserName="Amanda@symbiosis.com"},
            };
            applicationUsers.ForEach(s => context.Users.AddOrUpdate(x => x.Id, s));
            context.SaveChanges();


            var profiles = new List<Profile>
            {
                new Profile{ID=15,userName="Tester",firstName="Test",lastName="Test",businessName="Symbiosis",email="Test@test.com",city="Portland",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="testing",certs="testing101",imagePath="60036a2c-86f0-44a8-9be2-68d815ab9f91test.jpg",UserID="60036a2c-86f0-44a8-9be2-68d815ab9f91"},
                new Profile{ID=16,userName="BenJamin",firstName="Ben",lastName="Smith",businessName="Symbiosis",email="Ben@gmail.com",city="Dallas",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="automotive repair",certs="Ford Senior Master",imagePath="4c16fa63-4459-4376-9062-20fb78395244P1010405.JPG",UserID="4c16fa63-4459-4376-9062-20fb78395244"},
                new Profile{ID=17,userName="SkateMaster",firstName="Eli",lastName="Gasiorowski",businessName="Symbiosis",email="Eli@symbiosis.com",city="",state="",dateJoined="Sunday, May 10, 2015",skillsOffered="software design",certs="Bachelors",imagePath="46d67da9-f8fc-4c9e-b779-05ec59fb3ed2EliPic.png",UserID="46d67da9-f8fc-4c9e-b779-05ec59fb3ed2"},
                new Profile{ID=18,userName="StarCraft Master",firstName="Alexander",lastName="Carlson",businessName="Starcraft Master",email="Alex@symbiosis.com",city="Salem",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="software design",certs="Bachelors",imagePath="079d1ab1-5e66-4d39-997c-91368a174622AlexPic.png",UserID="079d1ab1-5e66-4d39-997c-91368a174622"},
                new Profile{ID=19,userName="DB Master",firstName="Amanda",lastName="Hatch",businessName="Symbiosis",email="Amanda@symbiosis.com",city="Monmouth",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="software design",certs="Bachelors",imagePath="f2fddc40-798c-44c7-bb3e-18545ca314e7AmandaPic.png",UserID="f2fddc40-798c-44c7-bb3e-18545ca314e7"},
                new Profile{ID=20,userName="EatMe",firstName="Noodles",lastName="Delicous",businessName="Symbiosis",email="Noodles@symbiosis.com",city="Portland",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="cooking",certs="none",imagePath="5cefb4c2-bf86-4508-a15a-79942973e3c0ramen.jpg",UserID="5cefb4c2-bf86-4508-a15a-79942973e3c0"},
                new Profile{ID=21,userName="OhSoSoft",firstName="Couch",lastName="Cusion",businessName="Symbiosis",email="Couch@symbiosis.com",city="Dallas",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="relaxation",certs="none",imagePath="21ed460f-885d-4833-b421-1dc302de2a29couch.jpg",UserID="21ed460f-885d-4833-b421-1dc302de2a29"},
                new Profile{ID=22,userName="RestMyHead",firstName="Pillow",lastName="Fight",businessName="Symbiosis",email="Pillow@symbiosis.com",city="Monmouth",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="relaxation",certs="none",imagePath="3378f0d5-304b-4032-9d61-4f4fdd98c75cpillow.jpg",UserID="3378f0d5-304b-4032-9d61-4f4fdd98c75c"},
                new Profile{ID=23,userName="QuarterPounder",firstName="Burger",lastName="Buns",businessName="Symbiosis",email="Burger@symbiosis.com",city="Salem",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="cooking",certs="none",imagePath="374733a7-25e4-4605-8176-74fc404ca879burger.jpg",UserID="374733a7-25e4-4605-8176-74fc404ca879"},
                new Profile{ID=24,userName="Sprinkles",firstName="Cupcake",lastName="Frosting",businessName="Symbiosis",email="Cupcake@symbiosis.com",city="Portland",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="cooking",certs="none",imagePath="e5d2c1fc-6736-4d20-8e13-cea3429ddf71cupcake.jpg",UserID="e5d2c1fc-6736-4d20-8e13-cea3429ddf71"},
                new Profile{ID=25,userName="Meow",firstName="Kitty",lastName="Cat",businessName="Symbiosis",email="Kitty@symbiosis.com",city="Independance",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="companionship",certs="9 lives",imagePath="73e27684-a438-44ac-8f57-d0ed02c2e9a5cat.jpg",UserID="73e27684-a438-44ac-8f57-d0ed02c2e9a5"},
                new Profile{ID=26,userName="Ruff",firstName="Doggy",lastName="Dog",businessName="Symbiosis",email="Doggy@symbiosis.com",city="Independance",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="companionship",certs="papered",imagePath="6007d315-a393-4036-93d6-0824a6cad956dog.jpg",UserID="6007d315-a393-4036-93d6-0824a6cad956"},
                new Profile{ID=27,userName="Hop",firstName="Bunny",lastName="Rabbit",businessName="Symbiosis",email="Bunny@gmail.com",city="Independance",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="companionship",certs="none",imagePath="35b85510-049c-415f-ad08-0ec1ea684318rabbit.jpg",UserID="35b85510-049c-415f-ad08-0ec1ea684318"},
                new Profile{ID=28,userName="Lazy",firstName="Hammock",lastName="ForTwo",businessName="Symbiosis",email="Hammock@symbiosis.com",city="Portland",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="relaxation",certs="Lounging 101",imagePath="2026a52f-3b08-4b8e-af2d-44cfbce0847chammock.jpg",UserID="2026a52f-3b08-4b8e-af2d-44cfbce0847c"},
                new Profile{ID=29,userName="CloseCut",firstName="Lawn",lastName="Mower",businessName="Symbiosis",email="Lawn@symbiosis.com",city="Salem",state="OR",dateJoined="Sunday, May 10, 2015",skillsOffered="lawn care",certs="John Deere Certified",imagePath="7b078875-9c36-46c9-a6c5-82434230289flawn mower.jpg",UserID="7b078875-9c36-46c9-a6c5-82434230289f"},
            };
            profiles.ForEach(s => context.Profiles.AddOrUpdate(x => x.ID, s));
            context.SaveChanges();


            var skills = new List<Skill>
            {
                new Skill{SkillID=1,SubCategoryID=2,SkillName="Companionship",Link="symbiosisforum.azurewebsites.net"},
                new Skill{SkillID=2,SubCategoryID=3,SkillName="Relaxation",Link="symbiosisforum.azurewebsites.net"},
                new Skill{SkillID=3,SubCategoryID=4,SkillName="Reapir",Link="symbiosisforum.azurewebsites.net"},
                new Skill{SkillID=4,SubCategoryID=5,SkillName="Cooking",Link="symbiosisforum.azurewebsites.net"},
                new Skill{SkillID=5,SubCategoryID=6,SkillName="Performance",Link="symbiosisforum.azurewebsites.net"},
                new Skill{SkillID=6,SubCategoryID=7,SkillName="Relaxation",Link="symbiosisforum.azurewebsites.net"},
                new Skill{SkillID=7,SubCategoryID=8,SkillName="Design",Link="symbiosisforum.azurewebsites.net"},
            };
            skills.ForEach(s => context.Skills.AddOrUpdate(x => x.SkillID, s));
            context.SaveChanges();


            var subCategories = new List<SubCategory>
            {
                new SubCategory{SubCategoryID=2,CategoryID=1,SubCategoryName="Relational"},
                new SubCategory{SubCategoryID=3,CategoryID=2,SubCategoryName="Indoors"},
                new SubCategory{SubCategoryID=4,CategoryID=3,SubCategoryName="Automotive"},
                new SubCategory{SubCategoryID=5,CategoryID=4,SubCategoryName="Preparation"},
                new SubCategory{SubCategoryID=6,CategoryID=5,SubCategoryName="Music"},
                new SubCategory{SubCategoryID=7,CategoryID=2,SubCategoryName="Outdoors"},
                new SubCategory{SubCategoryID=8,CategoryID=6,SubCategoryName="Software"},
            };
            subCategories.ForEach(s => context.SubCategories.AddOrUpdate(x => x.SubCategoryID, s));
            context.SaveChanges();


            var categories = new List<Category>
            {
                new Category{CategoryID=1,CategoryName="Social"},
                new Category{CategoryID=2,CategoryName="R and R"},
                new Category{CategoryID=3,CategoryName="Transportation"},
                new Category{CategoryID=4,CategoryName="Food"},
                new Category{CategoryID=5,CategoryName="Entertainment"},
                new Category{CategoryID=6,CategoryName="Computing"},
            };
            categories.ForEach(s => context.Categories.AddOrUpdate(x => x.CategoryID, s));
            context.SaveChanges();



            var userJobs = new List<UserJob>
            {
                new UserJob{UserJobID=0,JobID=0,UserID=0},
                new UserJob{UserJobID=0,JobID=0,UserID=0},
                new UserJob{UserJobID=0,JobID=0,UserID=0},
                new UserJob{UserJobID=0,JobID=0,UserID=0},
                new UserJob{UserJobID=0,JobID=0,UserID=0},
                new UserJob{UserJobID=0,JobID=0,UserID=0},
                new UserJob{UserJobID=0,JobID=0,UserID=0},
                new UserJob{UserJobID=0,JobID=0,UserID=0},
                new UserJob{UserJobID=0,JobID=0,UserID=0},
                new UserJob{UserJobID=0,JobID=0,UserID=0},
            };
            userJobs.ForEach(s => context.UserJobs.AddOrUpdate(x => x.UserJobID, s));
            context.SaveChanges();


            var jobs = new List<Job>
            {
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
                new Job{JobID=0,City="",State="",skillID=0,JobDate= DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),JobDetails="",JobRating=0,UserId=0},
            };
            jobs.ForEach(s => context.Jobs.AddOrUpdate(x => x.JobID, s));
            context.SaveChanges();


            var posts = new List<Post>
            {
                new Post{PostId=0,PostTitle="", PostDate=DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),PostText=""},
                new Post{PostId=0,PostTitle="", PostDate=DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),PostText=""},
                new Post{PostId=0,PostTitle="", PostDate=DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),PostText=""},
                new Post{PostId=0,PostTitle="", PostDate=DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),PostText=""},
                new Post{PostId=0,PostTitle="", PostDate=DateTime.ParseExact("12/12/2014, 13:45:00", "dd/MM/yyyy HH:mm:ss",null),PostText=""},
            };
            posts.ForEach(s => context.Posts.AddOrUpdate(x => x.PostId, s));
            context.SaveChanges();
        }
    }
}
