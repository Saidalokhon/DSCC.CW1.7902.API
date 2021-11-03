using System;

namespace DSCC.CW1._7902.API.Models
{
    // Create model for Employee, that implements IModel.
    public class Employee : IModel
    {
        #region Variables
        // Implement the interface member 'Id'.
        public int Id { get; set; }

        // Create the rest of the required variables.
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Position Position { get; set; }
        #endregion
    }
}
