# Oefening Dapper 1

## Voorbereiding  

Maak op je SQL Server zelf een nieuwe database aan met de naam **ScalaDapper1**  
Voeg aan deze database 1 tabel toe met de naam **Personen**  
Deze tabel krijgt volgende kolommen :   
  * **Id** , nvarchar(50), PK  
  * **Naam** , nvarchar(50)    
  * **Voornaam** , nvarchar(50)    
  * **Adres** , nvarchar(50)    
  * **Gemeente** , nvarchar(50)    
  * **Land** , nvarchar(50)    
  * **Telefoon** , nvarchar(50)    
  * **Email** , nvarchar(100)    

## Opdracht  

In het WPF project vind je al alle nodige controls om deze tabel te beheren.  
Voorzie een class library die de schakel vormt tussen jouw applicatie en jouw database.  
Gebruik Dapper/Dapper Contrib
