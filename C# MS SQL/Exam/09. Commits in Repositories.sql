SELECT TOP(5) rc.RepositoryId, r.[Name], COUNT(*) AS Commits FROM RepositoriesContributors rc
LEFT JOIN Repositories r ON rc.RepositoryId = r.Id
LEFT JOIN Commits c ON c.RepositoryId = r.Id
GROUP BY rc.RepositoryId, r.[Name]
ORDER BY Commits DESC, rc.RepositoryId, r.[Name]
