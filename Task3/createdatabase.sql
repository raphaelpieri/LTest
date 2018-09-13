USE Task3;
GO;

CREATE TABLE Clients
(
    client_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	client_name NVARCHAR(51) NOT NULL
);
CREATE TABLE Orders
(
    order_id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	client_id INT NOT NULL,
	order_sum DECIMAL(14,2) NOT NULL,
	order_date DATETIME NOT NULL
);

ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_dbo.orders_dbo.clients_clients_ids] FOREIGN KEY([client_id])
REFERENCES [dbo].[Clients] (client_id)
ON DELETE CASCADE