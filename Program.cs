using System;
using EFCore.Data;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore {
    internal class Program
    {
        static void Main(string[] args)
        {
          using(var context = new EFCoreDataContext())
          {
                            //CREATE
            // var tag = new Tag{Name = "Front", Slug = "End"};
            // context.Tags.Add(tag);
            // context.SaveChanges();

                            //UPDATE
            // var upTag = context.Tags.FirstOrDefault(x => x.Name == "Front");
            // upTag.Slug = "Angular";

            // context.Update(upTag);
            // context.SaveChanges();

                                //REMOVE
            // var DelTag = context.Tags.FirstOrDefault(x => x.Name == "Front");

            // context.Remove(DelTag);
            // context.SaveChanges();

            var listTags = context
                          .Tags
                          .AsNoTracking()// Só leitura, não rastreia(nao usa para alterações)
                          .ToList();

            foreach(var tag in listTags){
              System.Console.WriteLine(tag.Name);
            } 
          }
        }
    }
}

