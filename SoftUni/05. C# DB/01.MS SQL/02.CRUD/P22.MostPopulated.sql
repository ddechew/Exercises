SELECT TOP(30) CountryName, [Population]
	FROM Countries
	--INNER JOIN Continents ON Countries.ContinentCode = Continents.ContinentCode
	--WHERE ContinentName = 'Europe'
	WHERE ContinentCode = 'EU'
	ORDER BY 
	[Population] DESC,
	CountryName ASC