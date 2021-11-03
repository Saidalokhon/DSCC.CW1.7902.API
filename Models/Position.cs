namespace DSCC.CW1._7902.API.Models
{
    // Create model for Position, that implements IModel.
    public class Position : IModel
    {
        #region Variables
        // Implement the interface member 'Id'.
        public int Id { get; set; }

        // Create the rest of the required variables.
        public string Name { get; set; }
        #endregion
    }
}
