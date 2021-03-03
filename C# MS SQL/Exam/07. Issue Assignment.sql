SELECT i.Id, CAST(u.Username AS VARCHAR) + ' : ' + i.Title AS IssueAssignee 
FROM Issues i 
INNER JOIN Users u ON i.AssigneeId = u.Id
ORDER BY i.Id DESC, i.AssigneeId