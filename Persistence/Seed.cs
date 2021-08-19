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
                var works = new List<Work>
                {
                    new Work
                    {
                        Title="Making Webapp",
                        Category = "Project",
                        Description = "Making webapp using Asp.NetCore and React",
                    },
                    new Work
                    {
                        Title="Compilers",
                        Category = "GTCourse",
                        Description="Learn how compilers work",
                    },
                    new Work
                    {
                        Title="Intro to Information Security",
                        Category = "GTCourse",
                        Description="Learn information security"
                    },
                    new Work
                    {
                        Title="Algorithm",
                        Category="Programming",
                        Description="Learn algorithm"
                    },
                    new Work
                    {
                        Title = "Computer Network",
                        Category="CSAlone",
                        Description="Learn computer network"
                    }
                };

                var schedules = new List<Schedule>
                {
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-2),
                        Works = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Work = works[0],
                                Finish = true,
                                Score = 90
                            },
                            new ScheduleWork
                            {
                                Work = works[1],
                                Finish = true,
                                Score=80
                            },
                        }
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-1),
                        Works = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Work = works[2],
                                Finish = true,
                                Score = 50
                            },
                            new ScheduleWork
                            {
                                Work = works[3],
                                Finish = true,
                                Score=80
                            },
                        }
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-3),
                        Works = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Work = works[3],
                                Finish = true,
                                Score = 70
                            },
                            new ScheduleWork
                            {
                                Work = works[4],
                                Finish = true,
                                Score=30
                            },
                        }
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-4),
                        Works = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Work = works[0],
                                Finish = true,
                                Score = 50
                            },
                            new ScheduleWork
                            {
                                Work = works[4],
                                Finish = true,
                                Score=80
                            },
                        }
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-5),
                        Works = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Work = works[2],
                                Finish = true,
                                Score = 40
                            },
                            new ScheduleWork
                            {
                                Work = works[1],
                                Finish = true,
                                Score=100
                            },
                        }
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-6),
                        Works = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Work = works[1],
                                Finish = true,
                                Score = 50
                            },
                            new ScheduleWork
                            {
                                Work = works[2],
                                Finish = true,
                                Score=70
                            },
                        }
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-7),
                        Works = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Work = works[3],
                                Finish = true,
                                Score = 90
                            },
                            new ScheduleWork
                            {
                                Work = works[0],
                                Finish = true,
                                Score=90
                            },
                        }
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-8),
                        Works = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Work = works[4],
                                Finish = true,
                                Score = 40
                            },
                            new ScheduleWork
                            {
                                Work = works[2],
                                Finish = true,
                                Score=100
                            },
                        }
                    },
                    new Schedule
                    {
                        Date = DateTime.Now.AddMonths(-9),
                        Works = new List<ScheduleWork>
                        {
                            new ScheduleWork
                            {
                                Work = works[2],
                                Finish = true,
                                Score = 100
                            },
                            new ScheduleWork
                            {
                                Work = works[3],
                                Finish = true,
                                Score=30
                            },
                        }
                    },
                };

                await context.Works.AddRangeAsync(works);
                await context.Schedules.AddRangeAsync(schedules);
                await context.SaveChangesAsync();
            }
        }
    }
}