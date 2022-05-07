using System.Collections.Generic;

namespace Hotel_Listing_App.Data
{
    public class country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }   


        //Added while the DTO

        public virtual IList<hotel> Hotels { get; set; }
    }
}
