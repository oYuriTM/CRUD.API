using System;

namespace CRUD.Domain.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Cpf { get; set; }
        public int Age { get; set; }
    }
}
