using Models.DTO;
namespace Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO> {
                new VillaDTO{Id= 1 , Name ="Pool View",Sqft = 100,Occupany = 9},
                new VillaDTO{Id = 2 , Name="Beach View",Sqft = 200,Occupany = 7},
                new VillaDTO{Id = 3 , Name="Karki View",Sqft = 800,Occupany = 89},
                new VillaDTO{Id = 4 , Name="Shankar View",Sqft = 90,Occupany = 19}
             };

        }
    }
