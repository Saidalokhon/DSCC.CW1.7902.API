using System;

namespace DSCC.CW1._7902.API.Models
{
    public class Employee : IModel
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int PositionId { get; set; }

        public virtual Position Position { get; set; }
    }
}