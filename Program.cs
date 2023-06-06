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
          using(var context = new EFCoreDataContext())
          {
                            //CREATE
           var tag = new Tag{Name = "Devops", Slug = "Linux"};
           context.Tags.Add(tag);
           context.SaveChanges();

                            //UPDATE
            var UpTag = context.Tags.FirstOrDefault(x => x.Name == "Devops");
            UpTag.Slug = "Linux / DEV";

            context.SaveChanges();

                            //DELETE
           var delTag = context.Tags.FirstOrDefault(x => x.Name == "NET");
           context.Remove(delTag);
           context.SaveChanges();

                            //ToList
          var listTags = context.Tags.AsNoTracking().ToList();

            foreach(var tagg in listTags)
            {
              System.Console.WriteLine(tagg.Name);
            }
          } 
        }
    }
  }


