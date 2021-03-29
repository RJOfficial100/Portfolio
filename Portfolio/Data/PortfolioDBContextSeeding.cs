using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Portfolio.Data
{
    public class PortfolioDBContextSeeding: DropCreateDatabaseIfModelChanges<PortfolioDBContext>
    {
        protected override void Seed(PortfolioDBContext context)
        {
            Company company1 = new Company()
            {
                CompanyName = "TCS",
                CompanyLocation = "Noida",
                JobTitle = "System Engineer",
                Projects = new List<Project>()
                {
                    new Project()
                    {
                    ProjectName="Food Ordering System",
                    ProjectDescription="This is an Food Ordering System",
                    StartMonth="Jan",
                    StartYear=2021,
                    EndMonth="March",
                    EndYear=2021,
                    TechnologiesUsed= new List<Technology>()
                    {
                        new Technology()
                        {
                            TechnologyName="ASP.Net"
                        },
                        new Technology()
                        {
                            TechnologyName="SQL Server"
                        },
                        new Technology()
                        {
                            TechnologyName="Entity Framework"
                        }
                    },
                    Role="Team Lead"
                    }
                }
            };
            Company company2 = new Company()
            {
                CompanyName = "Infosys",
                CompanyLocation = "Gurgaon",
                JobTitle = "Senior Engineer",
                Projects = new List<Project>()
                {
                    new Project()
                    {
                    ProjectName="Banking",
                    ProjectDescription="This is an Banking App",
                    StartMonth="Jun",
                    StartYear=2021,
                    Current = true,
                    TechnologiesUsed= new List<Technology>()
                    {
                        new Technology()
                        {
                            TechnologyName="Java"
                        },
                        new Technology()
                        {
                            TechnologyName="SQL Server"
                        },
                        new Technology()
                        {
                            TechnologyName="Hibernate"
                        }
                    },
                    Role="Project Manager"
                    }
                }
            };
            Profile profile = new Profile()
            {
                FirstName = "Raman",
                LastName = "Jhamb",
                DOB = "06/09/1997",
                PhoneNo =7988065952,
                CompanyId = 1
            };

            context.Companies.Add(company1);
            context.Companies.Add(company2);
            context.SaveChanges();
            context.Profile.Add(profile);
            context.SaveChanges();
            base.Seed(context);
        }
    }
}