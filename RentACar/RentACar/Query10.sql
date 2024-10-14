Select Brand,Model,MakeYear,Category,FuelType,Rate,IsAvailable
From Car
Where Brand In('Toyota','Honda') and FuelType != 'Hybrid' and IsAvailable = 1