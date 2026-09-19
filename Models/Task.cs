#nullable enable

namespace Digital_Innovation_CW1.Models;

/**
    * Represents a task record in the database.
*/
public class Task
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public required string? Description { get; set; }
    public required bool IsCompleted { get; set; }
    public required DateTime? DueDateTime { get; set; }
    public required int TaskListId { get; set; }
}