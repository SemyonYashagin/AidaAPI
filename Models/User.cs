using System;
using System.ComponentModel.DataAnnotations;

namespace AIDA_API.Models
{
    public class User
    {
        [Key]
        public int user_id { get; set; }
        public string user_name { get; set; }
        public string user_surname { get; set; }
        public string user_email { get; set; }
        public string user_password { get; set; }
        public bool user_isConfirmed { get; set; }
        public byte[] user_avatarPhoto { get; set; }
        public string user_currentCity { get; set; }
        public string user_rootCity { get; set; }
        public string user_phoneNumber { get; set; }
        public double user_level { get; set; }

    }
}
