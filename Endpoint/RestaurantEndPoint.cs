using Microsoft.AspNetCore.Http.HttpResults;
using Restaurant.Api.Dto;

namespace Restaurant.Api.Endpoint;
//static means run once
public static class RestaurantEndPoint
{
    //readonly means read only
    private static readonly List<OrderDto> orders = [ //this is a manmade list of orders
        new (
            1,
            "Jojo",
            69.99,
            "Fries"
        ),
        new (
            2,
            "Jaja",
            49.99,
            "Fries"
        ),
        new (
            3,
            "Jiji",
            29.99,
            "Fries"
        )
    ];
    
    //RouteGroupBuilder means Routing basically
    public static RouteGroupBuilder MapOrderEndpoint(this WebApplication app){

        
        var OrderEndpoint = app.MapGroup("order");

        OrderEndpoint.MapGet("/", () => { //Get basically for sending data 
        //NOTE WALA PANG ASYNC AND AWAIT SINCE WALA PANG DATABASE
            return orders;
        });
        
        OrderEndpoint.MapGet("/get/{id}", (int id) => { //Get basically for sending data 
        //this get is for getting specific data
            var existingId = orders.Find(order => order.Id == id);

            if(!existingId){
                return NoContent;
                }

            return existingId;
        });

        //Post needs payload usually used in creating object or data
        OrderEndpoint.MapPost("/post", () => { //Get basically for sending data 
            return orders;
        });

        //PUT needs payload used for updating existing object or data
        OrderEndpoint.MapPut("/put/{id}", (int id) => { //Get basically for sending data 
            return orders;
        });

        //DELETE needs id payload to delete existing object or data
        OrderEndpoint.MapDelete("/delete/{id}", (int id) => { //Get basically for sending data 
            return orders;
        });

        return OrderEndpoint;
    }

}
