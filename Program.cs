using System;
using EFCore.Data;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new EFCoreDataContext())
            {
                // var user = new User
                // {
                //     Name = "John Doe",
                //     Email = "johndoe@example.com",
                //     PasswordHash = "hashedpassword",
                //     Bio = "I'm a software developer",
                //     Image = "profile-image.jpg",
                //     Slug = "john-doe"
                // };

                // var categoria = new Category
                // {
                //   Name = "Devops",
                //   Slug = "Consertar Rede"
                // };

                // var post = new Post
                // {
                //   Category = categoria, 
                //   Author = user, 
                //   Title = "Sample Post",
                //   Summary = "This is a sample post summary",
                //   Body = "This is the body of the sample post",
                //   Slug = "sample-post",
                //   CreateDate = DateTime.Now,
                //   LastUpdateDate = DateTime.Now,

                // };
                // context.Posts.Add(post);
                // context.SaveChanges();

                                        //INCLUDE
                // var posts = context.
                //             Posts.
                //             AsNoTracking().
                //             Include(x => x.Author). //tipo innerjoin
                //             Include(x => x.Category).
                //             OrderByDescending(x => x.LastUpdateDate).
                //             ToList();

                // foreach (var post in posts)
                // {
                //            System.Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category.Name}"); //Usar ? caso haja possibilidade de nulo


                var posts = context.
                            Posts.
                            //AsNoTracking().
                            Include(x => x.Author). 
                            Include(x => x.Category).
                            OrderByDescending(x => x.LastUpdateDate).
                            FirstOrDefault(); //PEGANDO PRIMEIRO ITEM


                            posts.Author.Name = "Taislaine";

                            context.Posts.Update(posts);
                            context.SaveChanges();
                }
            }
        }
    }



