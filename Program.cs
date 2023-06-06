using System;
using EFCore.Data;
using EFCore.Models;

namespace EFCore
 {
    internal class Program
    {
        static void Main(string[] args)
        {
          using(var context = new EFCoreDataContext())
          {
              var user = new User
              {
                  Name = "John Doe",
                  Email = "johndoe@example.com",
                  PasswordHash = "hashedpassword",
                  Bio = "I'm a software developer",
                  Image = "profile-image.jpg",
                  Slug = "john-doe"
              };

              var categoria = new Category
              {
                Name = "Devops",
                Slug = "Consertar Rede"
              };

              var post = new Post
              {
                Category = categoria, 
                Author = user, 
                Title = "Sample Post",
                Summary = "This is a sample post summary",
                Body = "This is the body of the sample post",
                Slug = "sample-post",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
             
              };
              context.Posts.Add(post);
              context.SaveChanges();
          } 
        }
    }
  }


