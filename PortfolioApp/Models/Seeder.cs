using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class Seeder
    {
        private PortfolioContext db;
        public Seeder(PortfolioContext db)
        {
            this.db = db;
            SeedData();
        }

        // This could be modularized more nicely with a repository but here
        // is a basic version of how to seed data.
        public void SeedData()
        {
            // Exit if data exists.
            if (db.Technologies.Count() != 0)
            {
                return;
            }

            //Create a collection of Objects to add to the database.
            Technology[] seedTechnologies = new Technology[]
            {
                new Technology { Name = "HTML" },
                new Technology { Name = "CSS" },
                new Technology { Name = "Javascript" },
                new Technology { Name = "SQL" },
                new Technology { Name = ".NET Core MVC" }
            };

            //AddRange() to add multiple values.
            db.Technologies.AddRange(seedTechnologies);

            //Create a single Object to add to the database.
            //Project seedProject = new Project
            //{
            //    Title = "Tasnuva Haque Portfolio",
            //    Description = "A portfolio site for displaying my development skills."
            //};

            ////Add() to add values one at a time.
            //db.Projects.Add(seedProject);
            // Commit parent table additions to the database.
            //db.SaveChanges();

            Project[] seedProjects = new Project[]
            {
                new Project{ Title = "Tasnuva Haque Portfolio", Description = "A portfolio site for displaying my development skills."},
                new Project { Title = "Project A", Description = "A second project" },
                new Project { Title = "Project B", Description = "A third project" },
                new Project { Title = "Project 1", Description = "A fourth project" },
                new Project { Title = "Project 2", Description = "A fifth project" }
            };
            db.Projects.AddRange(seedProjects);
            db.SaveChanges();

            /* Add items to the bridge table.
             * Logic used is dependant on the desired seeding values
             * I am adding one record for each seed Technology.
             */
            //foreach (Technology seedTechnology in seedTechnologies)
            //{
            //    TechnologyProject tp = new TechnologyProject
            //    {
            //        Project = seedProject,
            //        Technology = seedTechnology
            //    };
            //    db.TechnologyProjects.Add(tp);
            //}

            foreach (Project seedProject in seedProjects)
            {
                foreach (Technology seedTechnology in seedTechnologies)
                {
                    TechnologyProject tp = new TechnologyProject
                    {
                        Project = seedProject,
                        Technology = seedTechnology
                    };
                    db.TechnologyProjects.Add(tp);
                }
            }

            // Commit child table additions to the database.
            db.SaveChanges();
        }

    }
 }
