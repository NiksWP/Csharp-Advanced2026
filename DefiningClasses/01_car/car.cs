namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("invalid input");
                }

                make = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value == "")
                {
                    throw new Exception("invalid input");
                }

                model = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("invalid input");
                }

                year = value;
            }
        }
    }
}