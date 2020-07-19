using halkhata.Context;
using halkhata.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace halkhata.Services
{
    public class TeamService
    {
        HalkhataDbContext halkhataDbContext = new HalkhataDbContext();

        public Team Create(Team team)
        {
            halkhataDbContext.Teams.Add(team);
            halkhataDbContext.SaveChanges();
            return team;
        }
    }
}