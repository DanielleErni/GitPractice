namespace Restaurant.Api.Dto;

public record class OrderDto
(
    int Id,
    string CustomerName,
    double Price,
    string OrderName
);
