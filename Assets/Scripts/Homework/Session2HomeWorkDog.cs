using System;


namespace SessionHomeworDog 
{
    public class dog
    {
        // Properties
        public string kind;
        private string colour;
        public string name;

        private int age;
        public string owner;

        // Constructor
        public dog (string _kind, string _colour, string _name, int _age, string _owner)
        {
            kind =  _kind;
            colour=  _colour;
            name =  _name;
            age =  _age;
            owner =  _owner;
        }

        // Functions
        public string GetdogKind ()
        {
            return kind;
        }

        public string GetdogColour()
        {
            return colour;
        }

        public string GetdogName()
        {
            return name;
        }

        
        public string GetdogOwner()
        {
            return owner;
        }
    }
}