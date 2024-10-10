using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkCore.Domain;

public class Team : BaseDomainModel
{
    public string? Name { get; set; }

    public virtual Coach? Coach { get; set; }
    public int? CoachId { get; set; }

    public virtual League? League { get; set; }
    public int? LeagueId { get; set; }

    // For SQL Server Only
    //[Timestamp]
    //public byte[] Version { get; set; }


    public virtual IList<Match> HomeMatches { get; set; } = new List<Match>() { };
    public virtual IList<Match> AwayMatches { get; set; } = new List<Match>() { };
}
