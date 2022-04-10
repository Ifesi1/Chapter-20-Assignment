using System;

namespace Question6
{
    public class Animal
    {
        //All features for the subcategories
        public static int age;
        public static string name;
        public static string gender;

        public class Dog
        {
            public int DogsAge
            {
                get { return age; }
                set { age = 4; }
            }
            public string DogsName
            {
                get { return name; }
                set { name = "Jasper"; }
            }
            public string DogsGender
            {
                get { return gender; }
                set { gender = "Male"; }
            }
        }

        public class Frog
        {
            public int FrogsAge
            {
                get { return age; }
                set { age = 2; }
            }
            public string FrogsName
            {
                get { return name; }
                set { name = "Froggy"; }
            }
            public string FrogsGender
            {
                get { return gender; }
                set { gender = "Female"; }
            }
        }

        public class Cat
        {
            public int CatsAge
            {
                get { return age; }
                set { age = 4; }
            }
            public string CatsName
            {
                get { return name; }
                set { name = "Watz"; }
            }
            public string CatsGender
            {
                get { return gender; }
                set { gender = "Male"; }
            }
        }

        public class Kitten
        {
            public int KittenssAge
            {
                get { return age; }
                set { age = 7; }
            }
            public string KittensName
            {
                get { return name; }
                set { name = "Kitty"; }
            }
            public string KittensGender
            {
                get { return gender; }
                set { gender = "Male"; }
            }
        }

        public class TomCat
        {
            public int TomCatsAge
            {
                get { return age; }
                set { age = 4; }
            }
            public string TomCatsName
            {
                get { return name; }
                set { name = "Jasper"; }
            }
            public string TomCatssGender
            {
                get { return gender; }
                set { gender = "Male"; }
            }
        }
    }
   
    
    public class program
    {
        public static int Main()
        {

        }
    }
}
