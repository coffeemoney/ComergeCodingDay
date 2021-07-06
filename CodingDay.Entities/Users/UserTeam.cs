using CodingDay.Entities.Teams;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDay.Entities.Users
{
    public class UserTeam
    {
        public int UserId { get; set; }
        public int TeamId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }

        [ForeignKey(nameof(TeamId))]
        public Team Team { get; set; }
    }
}
