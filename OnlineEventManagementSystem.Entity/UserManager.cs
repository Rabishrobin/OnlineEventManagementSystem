using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineEventManagementSystem.Entity
{

    public  class UserManager
    {
        public string UserID { get; set; }

        [Required]
        [EmailAddress]
        public string UserMailId { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
        [Required]
        public string UserFirstName { get; set; }
        [Required]
        public string UserLastName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public long UserMobileNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime UserDOB { get; set; }
        [Required]
        public string UserGender { get; set; }

        public void Signup()
        {


        }
        public void Login(string mailId, string password)
        {

        }
        //public bool VerifyMailId(string mailId)
        //{
        //    bool isExist = true;
        //    foreach (var user in userDatabase)
        //    {
        //        if (user.userMailId.Equals(mailId))
        //        {
        //            return false;
        //        }
        //    }
        //    return isExist;
        //}
        //public bool ValidateAccount(string mailId, string password)
        //{
        //    bool isMatched = false;
        //    foreach (var user in userDatabase)
        //    {
        //        if (user.userMailId.Equals(mailId) && user.userPassword.Equals(password))
        //        {
        //            isMatched = true;
        //            break;
        //        }
        //    }
        //    return isMatched;
        //}
        public string GenerateUserID(string name, long mobileNumber)
        {
            string userId = "C" + name.Substring(0, 3).ToUpper() + mobileNumber.ToString().Substring(0, 4);
            return userId;
        }
    }

}
