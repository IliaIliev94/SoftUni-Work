-- Select the first 10 started projects
SELECT TOP(10) * FROM Projects
	ORDER BY StartDate, [Name]