namespace Todoapi.Dtos;

public record TodoGetDto(
    int Id,
    string Title,
    bool IsCompleted
);