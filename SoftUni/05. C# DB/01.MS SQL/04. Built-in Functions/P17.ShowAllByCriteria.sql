SELECT [Name] AS [Game], 
	CASE 
		WHEN (DATEPART(HOUR, [Start]) BETWEEN 0 AND 11) THEN 'Morning'
		WHEN (DATEPART(HOUR, [Start]) BETWEEN 12 AND 17) THEN 'Afternoon'
		WHEN (DATEPART(HOUR, [Start]) BETWEEN 18 AND 23) THEN 'Evening'
		ELSE 'Invalid Hour'
	END AS [Part of the Day],

	CASE 
		WHEN Duration IS NULL THEN 'Extra Long'
		WHEN Duration > 6 THEN 'Long'
		WHEN Duration > 3 THEN 'Short'
		ELSE 'Extra Short'
	END AS Duration
FROM Games
	ORDER BY [Game], Duration, [Part of the Day];
