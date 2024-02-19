## Undestanding Server-side rendering
- existed before with MVC and Razor Pages
- Blazor allows reusable components (like Angular/React) unlike Razor Pages
- HTML sent as response
    - No WASM or web sockets
- Not the same as Blazor Server (which is a stateful model)
    - Stateless like MVC
- Code is same as "old" components

## Blazor Server hosting model 

the application runs on the server

and a connection between the app on the browser and the app running on the client's machine
is made using SignalR

## Blazor WebAssembly hosting model (recommended)

- Application is loaded to the client (SPA)
- Offline capabilities
- No .Net required on server
- Application download can take a while
- Code is exposed
- 

## VS template "Blazor Web App (recommended)"

**Blazor Full Stack Web UI**
Is gonna be the standard with .NET 8

Blazor Full Stack Web UI is a container for 
- Blazor WebAssembly (client side)
- Blazor Server


