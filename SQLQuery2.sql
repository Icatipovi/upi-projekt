select t.NameOfTeam,s.ScalePosition,s.Points,ci.NameOfCity,c.CoachName,c.CoachLastName from Teams t
inner join Scales s on s.Scale_ID=t.Scale_ID
inner join Coaches c on c.Coach_ID=t.Coach_ID
inner join Cities ci on ci.City_ID=t.City_ID


select pl.Name,pl.LastName,pl.PlayerNumber,pl.AverageMark,t.NameOfTeam,p.NameOfPosition from Players pl
inner join Teams t on t.Team_ID=pl.Team_ID
inner join Positions p on p.Position_ID=pl.Position_ID

select t.NameOfTeam,g.HomeScore,g.GuestScore,te.NameOfTeam,g.date from Games g
inner join Teams t on t.Team_ID=g.HomeTeam_ID
inner join Teams te on te.Team_ID=g.GuestTeam_ID
