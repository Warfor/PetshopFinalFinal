using System;

namespace Entity
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime SoldDate { get; set; }
        public string Color { get; set; }
        public string PreviosOwner { get; set; }
        public double Price { get; set; }
    }
}
