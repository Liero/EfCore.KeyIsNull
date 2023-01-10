// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sylex.ISYS.Domain.Manufacture;
using Sylex.ISYS.Domain.Manufacture.Models;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Reflection.Emit;

using var context = new ManufactureDbContext();
//context.Database.EnsureDeleted(); //not needed
//if (context.Database.EnsureCreated())
//{
//    Console.WriteLine("Database created");
//}

context.ČíselníkMateriál.Add(new ČíselníkMateriál { KódMateriálu = "ABC", Popis = "Product 1" });
try
{
    context.SaveChanges();
}
catch (Exception? ex)
{
    while (ex != null)
    {
        Console.WriteLine(ex);
        ex = ex.InnerException;
    }
}
