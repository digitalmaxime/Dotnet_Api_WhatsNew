New C# 12 features :

- TimeProvider (good for testing)
- AOT AheadOfTime Compiling available for MinimalApi
  - provides a way for going from C# code --> Native Code
  - instead of the default C# --> IL --> JIT --> Native Code
- Primary constructor :/
- Using on any type :/ `using Exists = bool?;`
- Inline arrays `int[] row0 = [1, 2, 3]`, with spread operator:  `int[] largeArray = [..array1, ..array2];` 
- Random.GenerateRandom
- Default lambda parameters
- nameof get name of variable, types and instance members
- Collection expressions
- Interceptors (experimental)
- Metrics
- Frozen Dictionary (slow init, fast get)

The `UsingTime` demo explores the TimeProvider class, helpful for testing