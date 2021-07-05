using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingDay.Controllers
{
    [Route("public/[controller]")]
    public class TeamsController : Controller
    {
        // private readonly TeamService teamService;
        // ...

        // Implement me: GET /public/teams
        // Expected output: list of teams, each containing fields id and name
        //                  and a field with the count of users in the team
        //    [HttpGet]
        //    public List<TeamDTO> getAllUsers() {
        //        return teamService.
        //                .getAllTeams() // use the service to get all team records
        //                .select(teams -> ...) // convert TeamRecord objects into TeamDTO objects
        //                .select(dto -> dto.set...(teamService.countUsers(dto.getId()))) // use the teamService to get the user count for a team and set it on the DTO
        //                ...
        //    }


        // Implement me: GET /public/teams/{id}
        // Expected output: a team object containing all fields in the database (id, name, description)
        //                  and a list of user objects of users in this particular team
    }
}
