SELECT pf.Id, pf.[Name], CAST(pf.Size AS VARCHAR) + 'KB' AS Size FROM Files cf
RIGHT JOIN Files pf ON cf.ParentId = pf.Id
WHERE cf.Id IS NULL
ORDER BY pf.Id, pf.[Name], pf.Size