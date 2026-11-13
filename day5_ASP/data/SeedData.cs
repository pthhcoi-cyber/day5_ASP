namespace day5_ASP.data
{
    public class SeedData
    {
        //gia lap du lieu ban adau cho database
        public static List<Models.Category> categories = new List<Models.Category>{
            new Models.Category(){ Id=1,Name="Categori1",Description="Descition1"},
            new Models.Category(){Id=2,Name="Categori2",Description="Descition2"},
            new Models.Category(){Id=3,Name="Categori3",Description="Descition3"},
            new Models.Category(){Id=4,Name="Categori4",Description="Descition4"},
            new Models.Category(){Id=5,Name="Categori5",Description="Descition5"},
            new Models.Category(){Id=6,Name="Categori6",Description="Descition6"},
            new Models.Category(){Id=7,Name="Categori7",Description="Descition7"},
            new Models.Category(){Id=8,Name="Categori8",Description="Descition8"},
            new Models.Category(){Id=9,Name="Categori9",Description="Descition9"},
            new Models.Category(){Id=10,Name="Categori10",Description="Descition10"},
            new Models.Category(){Id=11,Name="Categori11",Description="Descition11"},
            new Models.Category(){Id=12,Name="Categori12",Description="Descition12"}
        };

        public static List<Models.Product> products = new List<Models.Product>
        {
            new Models.Product(){Id=1,Name="Anh T",Description="siêu gay số 1 thế giới",Price=100,CategoryId=1},
            new Models.Product(){Id=2,Name="Quân Béo",Description="Béo số 2 k ai nhận số 1",Price=200,CategoryId=2},
            new Models.Product(){Id=3,Name="Swon",Description="gay lọ thiên vương",Price=300,CategoryId=3}
        };
    }
}
