namespace gregsharp.Models;

    public class House
    {
        public int Id { get; set; }
        public string address { get; set; } 
        public int price { get; set; }  
        public string imgUrl { get; set; }  
        public int levels { get; set; } 
        public int beds { get; set; }   
        public int baths { get; set; }  
        public bool garage { get; set; }    
    }
