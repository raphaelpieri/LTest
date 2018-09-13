SELECT cli.client_id, cli.client_name FROM [dbo].[Clients] cli
INNER JOIN [dbo].[Orders] ord ON ord.client_id = cli.client_id
WHERE ord.order_sum > 50
GROUP BY cli.client_id, cli.client_name


--I had a doubt, this select needed to return quantity or value of order_sum, if it was bigger than 100

SELECT cli.client_id, cli.client_name FROM [dbo].[Clients] cli
WHERE (SELECT SUM(1) FROM [dbo].[Orders] ord WHERE ord.client_id = cli.client_id) > 100


SELECT cli.client_id, cli.client_name FROM [dbo].[Clients] cli
WHERE (SELECT SUM(ord.order_sum) FROM [dbo].[Orders] ord WHERE ord.client_id = cli.client_id) > 100