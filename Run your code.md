## You can use F# interactive to code from shell
```
dotnet fsi
```
Inside the interactive shell, code anything. `Enter` doesn't run the code. To run the code, add `;;` after the last line and hit `Enter`/`Retrun`. 
To run a file from F# interactive shell, create a `.fsx` file and run-
```
dotnet fsi `test.fsx`
```
To quit the shell, simply run
```
#q;;
```

## From editor
Create a F# project by
```
dotnet new console -lang F# -o MyFSharpApp
cd MyFShardApp
```
To run-
```
dotnet run
```
