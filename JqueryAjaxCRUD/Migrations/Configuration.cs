namespace JqueryAjaxCRUD.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<JqueryAjaxCRUD.Models.SchoolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(JqueryAjaxCRUD.Models.SchoolDbContext context)
        {
            var listStudent = new List<Student>()
            {
                new Student { Name=@"Nguyễn Văn A", Email="nva@gmail.com",Status=true,DateOfBirth=DateTime.Now.AddYears(-24)},
                new Student { Name=@"Nguyễn Văn B", Email="nvb@gmail.com",Status=true,DateOfBirth=DateTime.Now.AddYears(-24)},
                new Student { Name=@"Nguyễn Văn C", Email="nvc@gmail.com",Status=false,DateOfBirth=DateTime.Now.AddYears(-24)},
                new Student { Name=@"Nguyễn Văn D", Email="nvd@gmail.com",Status=true,DateOfBirth=DateTime.Now.AddYears(-24)},
                new Student { Name=@"Nguyễn Văn E", Email="nve@gmail.com",Status=false,DateOfBirth=DateTime.Now.AddYears(-24)},
                new Student { Name=@"Nguyễn Văn K", Email="nvk@gmail.com",Status=true,DateOfBirth=DateTime.Now.AddYears(-24)},
                new Student { Name=@"Nguyễn Văn F", Email="nvf@gmail.com",Status=true,DateOfBirth=DateTime.Now.AddYears(-24)},
                new Student { Name=@"Nguyễn Văn G", Email="nvg@gmail.com",Status=false,DateOfBirth=DateTime.Now.AddYears(-24)},
                new Student { Name=@"Nguyễn Văn H", Email="nvh@gmail.com",Status=true,DateOfBirth=DateTime.Now.AddYears(-24)},

            };
            foreach(var item in listStudent)
            {
                context.Students.Add(item);
            }
            context.SaveChanges();
        }
    }
}