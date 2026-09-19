namespace Digital_Innovation_CW1.Models;

/**
    * Represents a board record in the database.
    * Contains a number of task lists, which each contain a number of tasks.
*/
public class Board
{
    public required int Id { get; set; } // Primary key
    public required string Title { get; set; }
    public required int AdminId { get; set; } //Foreign key
}