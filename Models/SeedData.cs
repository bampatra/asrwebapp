using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using ASRWebApp.Models;

namespace ASRWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new AsrContext(serviceProvider.GetRequiredService<DbContextOptions<AsrContext>>()))
            {
                // Look for any rooms.
                if(context.Room.Any())
                    return; // DB has been seeded.

                context.Room.AddRange(
                    new Room { RoomID = "A" },
                    new Room { RoomID = "B" },
                    new Room { RoomID = "C" },
                    new Room { RoomID = "D" }
                );

                context.Staff.AddRange(
                    new Staff
                    {
                        StaffID = "e12345",
                        Name = "Matt",
                        Email = "e12345@rmit.edu.au"
                    },
                    new Staff
                    {
                        StaffID = "e56789",
                        Name = "Joe",
                        Email = "e56789@rmit.edu.au"
                    }
                );

                context.Student.AddRange(
                    new Student
                    {
                        StudentID = "s1234567",
                        Name = "Kevin",
                        Email = "s1234567@student.rmit.edu.au"
                    },
                    new Student
                    {
                        StudentID = "s4567890",
                        Name = "Olivier",
                        Email = "s4567890@student.rmit.edu.au"
                    }
                );

                context.Slot.AddRange(
                    new Slot
                    {
                        RoomID = "A",
                        StartTime = new DateTime(2019, 1, 30),
                        StaffID = "e12345"
                    },
                    new Slot
                    {
                        RoomID = "B",
                        StartTime = new DateTime(2019, 1, 30),
                        StaffID = "e56789",
                        StudentID = "s1234567"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
