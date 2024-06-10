namespace ToysLib
{
    public class Toy
    {
        //? means that the property can be null

        //Properties
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public decimal Price { get; set; }

        //Constructor: en constructor er en metode, der kører, når et objekt af en klasse oprettes
        //public Toy(int id, string brand, string model, decimal price)
        //{
        //    Id = id;
        //    Brand = brand;
        //    Model = model;
        //    Price = price;
        //}

        //ToString() bruges til at hente informationer fra properties til validering metoden
        public override string ToString()
        {
            return $"Id: {Id}, Brand: {Brand}, Model: {Model}, Price: {Price}";
        }

        //Validation method
        //at validere tester om en værdi er gyldig og kaster en exception hvis den ikke er
        public void ValidateBrand()
        {
            //hvis Brand er null eller tom, så kaster den en exception
            if (string.IsNullOrEmpty(Brand))
                throw new ArgumentException("Brand is required");
            //hvis Brand er mindre end 2 tegn, så kaster den en exception
            if (Brand.Length < 2)
                throw new ArgumentException("Brand must be at least 2 characters long");
        }

        //at validere en model betyder at den ikke må være tom
        public void ValidateModel()
        {
            if (string.IsNullOrEmpty(Model))
                throw new ArgumentException("Model is required");
        }

        //at validere en pris betyder at den skal være større end 0
        public void ValidatePrice()
        {
            if (Price <= 0)
                throw new ArgumentException("Price must be greater than 0");
        }

        //det gør at de alle køre på en gang
        public void ValidateToy()
        {
            ValidateBrand();
            ValidateModel();
            ValidatePrice();
        }
    }
}
