using System;
using System.Collections.Generic;

namespace ViewModel_Fun.Models
{
    // public class ErrorViewModel
    // {
    //     public string RequestId { get; set; }

    //     public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    // }

    public class messages
    {
        public string message { get; set; }
    }

    public class numbers
    {
        public int [] number;
    }


    public class user
    {
        public string firstName;
        public string lastName;
    }


    public class users
    {
        public List <user> theListofUsers; 
    }





public class allThem
{
    public messages NewOne = new messages();
    public numbers newNumbers = new numbers();
    public user thisUser = new user();
    public users allTheUsers = new users();

}
}