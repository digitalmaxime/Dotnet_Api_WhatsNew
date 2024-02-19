INotificationService is injected in the ShoppingCartSErvice

Many Instances implement the INotificationService (mail, phone, push)

Keyed service allows to bind a key

This `builder.Services.AddScoped<INotificationService, MailNotificationService>()`

becomes this

`builder.Services.AddKeyedScoped<INotificationService, MailNotificationService>("mail");`


and use it by DI in ShoppingCartService constructor

`ctor([FromKeyedServices("mail")]INotificationService notifService) {...}`

in order to get the precise instance of Notification Service that you want
