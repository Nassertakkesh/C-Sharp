using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModel_Fun.Models;

namespace ViewModel_Fun.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            messages messagesInController =  new messages()
            {
            message = "lorem hasj kfsabbgasdfasdkjas hfkajshfkjsadhfkjashdfksakjh kj kjast fshtgthe noet aihi need ti inpeor ds as lkaj sgiashklvja sfgl afdgbdflkjgbsdlkfglksdfg"
            };


            numbers numberInController =  new numbers()
            {
               number = new int [] {5,6,3,245,435,43,234,5}
            };

            user thisOne = new user()
            {
                firstName = "nate",
                lastName = "T"
            };
            user theOther = new user()
            {
                firstName = "tarik",
                lastName = "Tjsbvkajsn"
            };


            users allOfTheUsers = new users()
            {
                theListofUsers = new List<user> {thisOne,theOther}
            };



             allThem ViewModel = new allThem()
            {
                NewOne = messagesInController,
                newNumbers = numberInController,
                thisUser = thisOne,
                allTheUsers = allOfTheUsers,
            };  

            return View(ViewModel);
        }


        public IActionResult Privacy()
        {
            return View();
        }


        [HttpGet("numbers")]
            public IActionResult numbers()
        {
            
            messages messagesInController =  new messages()
            {
            message = "lorem hasj kfsabbgasdfasdkjas hfkajshfkjsadhfkjashdfksakjh kj kjast fshtgthe noet aihi need ti inpeor ds as lkaj sgiashklvja sfgl afdgbdflkjgbsdlkfglksdfg"
            };


            numbers numberInController =  new numbers()
            {
               number = new int [] {5,6,3,245,435,43,234,5}
            };

            user thisOne = new user()
            {
                firstName = "nate",
                lastName = "T"
            };
            user theOther = new user()
            {
                firstName = "tarik",
                lastName = "Tjsbvkajsn"
            };


            users allOfTheUsers = new users()
            {
                theListofUsers = new List<user> {thisOne,theOther}
            };



             allThem ViewModel = new allThem()
            {
                NewOne = messagesInController,
                newNumbers = numberInController,
                thisUser = thisOne,
                allTheUsers = allOfTheUsers,
            };  

            return View(ViewModel);
        }
        [HttpGet("message")]
        public IActionResult message()
        {
            
            messages messagesInController =  new messages()
            {
            message = "lorem hasj kfsabbgasdfasdkjas hfkajshfkjsadhfkjashdfksakjh kj kjast fshtgthe noet aihi need ti inpeor ds as lkaj sgiashklvja sfgl afdgbdflkjgbsdlkfglksdfg"
            };


            numbers numberInController =  new numbers()
            {
               number = new int [] {5,6,3,245,435,43,234,5}
            };

            user thisOne = new user()
            {
                firstName = "nate",
                lastName = "T"
            };
            user theOther = new user()
            {
                firstName = "tarik",
                lastName = "Tjsbvkajsn"
            };


            users allOfTheUsers = new users()
            {
                theListofUsers = new List<user> {thisOne,theOther}
            };



             allThem ViewModel = new allThem()
            {
                NewOne = messagesInController,
                newNumbers = numberInController,
                thisUser = thisOne,
                allTheUsers = allOfTheUsers,
            };  

            return View(ViewModel);
        }
        [HttpGet("user")]  
        public IActionResult user()
        {
            
            messages messagesInController =  new messages()
            {
            message = "lorem hasj kfsabbgasdfasdkjas hfkajshfkjsadhfkjashdfksakjh kj kjast fshtgthe noet aihi need ti inpeor ds as lkaj sgiashklvja sfgl afdgbdflkjgbsdlkfglksdfg"
            };


            numbers numberInController =  new numbers()
            {
               number = new int [] {5,6,3,245,435,43,234,5}
            };

            user thisOne = new user()
            {
                firstName = "nate",
                lastName = "T"
            };
            user theOther = new user()
            {
                firstName = "tarik",
                lastName = "Tjsbvkajsn"
            };


            users allOfTheUsers = new users()
            {
                theListofUsers = new List<user> {thisOne,theOther}
            };



             allThem ViewModel = new allThem()
            {
                NewOne = messagesInController,
                newNumbers = numberInController,
                thisUser = thisOne,
                allTheUsers = allOfTheUsers,
            };  

            return View(ViewModel);
        }
         [HttpGet("users")]
        public IActionResult users()
        {
            
            messages messagesInController =  new messages()
            {
            message = "lorem hasj kfsabbgasdfasdkjas hfkajshfkjsadhfkjashdfksakjh kj kjast fshtgthe noet aihi need ti inpeor ds as lkaj sgiashklvja sfgl afdgbdflkjgbsdlkfglksdfg"
            };


            numbers numberInController =  new numbers()
            {
               number = new int [] {5,6,3,245,435,43,234,5}
            };

            user thisOne = new user()
            {
                firstName = "nate",
                lastName = "T"
            };
            user theOther = new user()
            {
                firstName = "tarik",
                lastName = "Tjsbvkajsn"
            };


            users allOfTheUsers = new users()
            {
                theListofUsers = new List<user> {thisOne,theOther}
            };



             allThem ViewModel = new allThem()
            {
                NewOne = messagesInController,
                newNumbers = numberInController,
                thisUser = thisOne,
                allTheUsers = allOfTheUsers,
            };  

            return View(ViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }









    }
}
