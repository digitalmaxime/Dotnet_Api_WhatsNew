AOT stands for Ahead of time compiling

In AOT scenarios, all unnecessary parts are removed.

no support for
- https Krestrel feature
- http3
- some logging providers
- IIS

/program.cs

`var builder = WebApplication.CreateSlimBuilder(args);`

`CreateSlimBuilder` will enable a smaller set of feature only

System.Text JsonSerializer needs to be configured to be compatible with native AOT 
```
builder.Services.ConfigureHttpJsonOptions(options =>
{

    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);

});
```

/.csproj 

`<PublishAot>true</PublishAot>`

