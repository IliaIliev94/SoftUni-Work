using Microsoft.EntityFrameworkCore;
using P03_FootballBetting.Data;
using System;

namespace P03_FootballBetting
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new FootballBettingContext();
            dbContext.Database.Migrate();
        }
    }
}
