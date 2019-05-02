/*1. Query to return total sale price per maker and model for the past 30 days: */
select CarMaker,CarModel,sum(TotalSaleprice)
from carSales_Table where datediff(d,SaleDate,getdate())<=30
group by carMaker,carModel








