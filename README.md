# С# native AOT

AOT - Ahead-of-Time (AOT) compilation is a kind of compilation of your C# code without using JIT — CIL (.NET Common Intermediate Language)

## Features
- launch time
- no IL
- peak performance is available immediately
- running applications without installed .NET
- memory consumption

## Minuses
- application size 
- limited reflection
## Say bye to IL reversing
![alt text](https://cdn.discordapp.com/attachments/768535544014831666/1157366876498821130/IMG_3290.png?ex=65185966&is=651707e6&hm=8a8018d57fe600567b420a15426cdcd76bda1ccd97959d47efd099c509cc05ab&)
## How to use
just copy .../aot_cs/copy_that_csproj_file.csproj into your .csproj file and enter in terminal ```dotnet publish -r win-x64 -c Release``` (for win-x64)

next, there is complited .exe application in bin\Release\netX.X\win-x64\publish\ 


## PS
.../aot_cs/debug/DTiming.cs - you can use this class instead of Stopwatch for your benchmarks (measurements at the execution flow level)

also more about native AOT .NET - https://learn.microsoft.com/en-us/dotnet/core/deploying/native-aot/
