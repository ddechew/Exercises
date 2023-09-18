SELECT CountryName, CountryCode,
CASE
	WHEN Countries.CurrencyCode = 'EUR' THEN 'Euro'
	ELSE 'Not Euro'
END AS Currency
	FROM Countries
ORDER BY CountryName;

SELECT * FROM Countries;