namespace DigitalInnovation_CW1.Models;

/**
    * Represents a task list record in the database.
*/
public class TaskList {
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required int BoardID { get; set; }
}