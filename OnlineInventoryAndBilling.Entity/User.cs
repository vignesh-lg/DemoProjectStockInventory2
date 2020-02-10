using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineInventoryAndBilling.Entity
{
    public class User
    {
        public string CustomerFirstName { get; set; }
        public string CustomerSecondName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string CellNumber { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string RegistrationNumber { get; set; }
        public string PinCode { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string UserName { get; set; }
        public string gender { get; set; }
        public string Search { get; set; }
        public int UserId { get; set; }

        public User(string UserName, string CustomerFirstName, string CustomerSecondName, string gender, string State, string City, string Address, string PinCode, string CellNumber, string Email, string DateOfBirth,  string Password,int UserId)
        {
            this.UserName = UserName;
            this.CustomerFirstName = CustomerFirstName;
            this.CustomerSecondName = CustomerSecondName;
            this.gender = gender;
            this.State = State;
            this.City = City;
            this.Address = Address;
            this.PinCode = PinCode;
            this.CellNumber = CellNumber;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.Password = Password;
            this.UserId = UserId;
          
        }
        public User(string CustomerFirstName, string CustomerSecondName, string gender, string State, string City, string Address, string PinCode, string CellNumber, string Email, string DateOfBirth ,string Password)
        {
            this.CustomerFirstName = CustomerFirstName;
            this.CustomerSecondName = CustomerSecondName;
            this.State = State;
            this.City = City;
            this.Address = Address;
            this.PinCode = PinCode;
            this.CellNumber = CellNumber;
            this.Email = Email;
            this.DateOfBirth = DateOfBirth;
            this.Password = Password;
            this.gender = gender;
        }
        public User(string UserName,string Password )
        {
            this.UserName = UserName;
            this.Password = Password;
        }
        public User(string Search)
        {
            this.Search = Search;
        }
        public User(int UserId)
        {
            this.UserId = UserId;
        }
        public User() { }
    }
}
