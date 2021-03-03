SELECT u.Username, AVG(f.Size) AS Size FROM Users u
INNER JOIN Commits c ON u.Id = c.ContributorId
INNER JOIN Files f ON f.CommitId = c.Id
GROUP BY u.Username
ORDER BY Size DESC, Username