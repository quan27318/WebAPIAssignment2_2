using System;
namespace WebAPI2.Models{
    public class PersonModel{
        public int ID {get; set;}
        public string FirstName{get; set;}
        public string LastName{get; set;}
        public DateTime DateOfBirth{get; set;}
        public string Gender{get; set;}
        public string BirthPlace{ get; set;}
    }
}