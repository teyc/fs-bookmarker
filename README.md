#fs-bookmarker

## What it is

fs-bookmarker is a command line program for bookmarking
websites.

It's written as an exercise for me to familiarise
myself with the F# toolchain, namely VSCode, Paket and the fsproj
format.

## Key learnings

1. Add nuget packages using Paket instead of using VS Code

     paket add nuget Hopac project fs-bookmarker\fs-bookmarker.fsproj

   otherwise, you will have to manually add them to the fsproj
   yourself. Using paket has the added benefit of having the correct
   version of the lib added to each TFM (target framework moniker.)

2. This version of `Paket.exe` doesn't seem to have the `CopyRuntimeDependencies`
   task defined. I had to manually delete it from the `fsproj` file before it
   would build.

3. It was difficult to get the `build.cmd` to run at first. I
   kept getting `Target "" not found`. In the end retyping the
   last line one build.fsx resolved the problem.

4. Set up `tasks.json` with a task name called `Build`. VS Code
   likes it that way.


