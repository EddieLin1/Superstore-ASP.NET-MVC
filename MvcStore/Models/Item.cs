using System.ComponentModel.DataAnnotations.Schema;

namespace MvcStore.Models
{
    public class Item
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public double Price {get; set;}
        public int QuantitySold {get; set;}
        [NotMapped]
      public string ImageURL {
            get{return "~/images/" + Id +".jpg";}
        } 
   
        
    }

    
}