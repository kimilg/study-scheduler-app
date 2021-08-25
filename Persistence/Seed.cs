using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context) {
            
            if(!context.Works.Any() && !context.Schedules.Any()) 
            {
                var schedules = new List<Schedule>
                {
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-2),
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-1),
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-3),
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-4),
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-5),
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-6),
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-7),
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-8),
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-9),
                    },
                };
                
                await context.Schedules.AddRangeAsync(schedules);


                var works = new List<Work>
                {
                    new Work
                    {
                        Title="Making Webapp",
                        Category = "Project",
                        Description = "Making webapp using Asp.NetCore and React",
                        Schedules = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Schedule = schedules[0],
                                Finish = true,
                                Score = 80
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[1],
                                Finish = true,
                                Score = 70
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[3],
                                Finish = true,
                                Score = 80
                            },
                        }
                    },
                    new Work
                    {
                        Title="Compilers",
                        Category = "GTCourse",
                        Description="Learn how compilers work",
                        Schedules = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Schedule = schedules[8],
                                Finish = true,
                                Score = 10
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[0],
                                Finish = true,
                                Score = 60
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[2],
                                Finish = true,
                                Score = 50
                            },
                        }
                    },
                    new Work
                    {
                        Title="Intro to Information Security",
                        Category = "GTCourse",
                        Description="Learn information security",
                        Schedules = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Schedule = schedules[0],
                                Finish = true,
                                Score = 80
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[1],
                                Finish = true,
                                Score = 70
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[3],
                                Finish = true,
                                Score = 80
                            },
                        }
                    },
                    new Work
                    {
                        Title="Algorithm",
                        Category="Programming",
                        Description="Learn algorithm",
                        Schedules = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Schedule = schedules[0],
                                Finish = true,
                                Score = 60
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[4],
                                Finish = true,
                                Score = 40
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[7],
                                Finish = true,
                                Score = 60
                            },
                        }
                    },
                    new Work
                    {
                        Title = "Computer Network",
                        Category="CSAlone",
                        Description="Learn computer network",
                        Schedules = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Schedule = schedules[4],
                                Finish = true,
                                Score = 80
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[1],
                                Finish = true,
                                Score = 40
                            },
                            new ScheduleWork
                            {
                                Schedule = schedules[2],
                                Finish = true,
                                Score = 80
                            },
                        }
                    }
                };

                
                await context.Works.AddRangeAsync(works);
                await context.SaveChangesAsync();
            }
        }
    }
}