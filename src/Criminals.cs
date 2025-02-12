using System;

namespace PoliceDatabaseProgram.Models
{
    public class Criminal
    {
        // Private fields
        private int id;
        private string category;
        private string name;
        private int year;
        private int age;
        private string height;
        private decimal weight;
        private bool isSolved;
        private string description;
        private string location;
        private string imageUrl;

        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Category
        {
            get { return category; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Category cannot be empty.");
                category = value;
            }
        }

    
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                name = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentOutOfRangeException("Year must be a valid year.");
                year = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Age must be a positive number.");
                age = value;
            }
        }

        public string Height
        {
            get { return height; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Height cannot be empty.");
                height = value;
            }
        }

        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Weight must be a positive number.");
                weight = value;
            }
        }

        public bool IsSolved
        {
            get { return isSolved; }
            set { isSolved = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value ?? string.Empty; }
        }

        public string Location
        {
            get { return location; }
            set { location = value ?? string.Empty; }
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value ?? string.Empty; }
        }

        // Constructor to initialize Criminal
        public Criminal(string category, string name, int year, int age, string height, decimal weight, bool isSolved, string description, string location, string imageUrl)
        {
            Category = category;
            Name = name;
            Year = year;
            Age = age;
            Height = height;
            Weight = weight;
            IsSolved = isSolved;
            Description = description;
            Location = location;
            ImageUrl = imageUrl;
        }

        // Override the ToString method to display summary info about the criminal
        public override string ToString()
        {
            return $"{Name} ({Category}) - Age: {Age} - {(IsSolved ? "Case Solved" : "Case Unsolved")}";
        }
    }
}
