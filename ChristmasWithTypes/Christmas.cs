using System;
namespace ChristmasWithTypes
{
    public class Christmas
    {
        public string[] Presents;
        public string Santa { get; set; } //this is a property
        public int? TreeHeight { get; set; } //TODO Make the TreeHeight property nullable

        //TODO Make the property, "Day", type enum
        //this is a comment
        public enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday};

    }
}
