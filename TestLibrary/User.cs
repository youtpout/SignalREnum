using System;

namespace TestLibrary
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public UserEnum Status { get; set; }
    }

    public enum UserEnum
    {
        None,
        Student,
        Worker
    }
}
