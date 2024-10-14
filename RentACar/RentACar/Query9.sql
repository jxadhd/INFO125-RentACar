Select Brand,Model,MakeYear,Category,FuelType,Rate
From Car
Where Rate < 55 and FuelType = 'Hybrid' or Category = 'Economy'