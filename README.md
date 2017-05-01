#fs-bookmarker

## What it is

fs-bookmarker is a command line program for bookmarking
websites.

It's written as an exercise for me to familiarise
myself with the F# toolchain, namely VSCode, Paket and the fsproj
format.

## Usage

Example of how to add a bookmark

```
fs-bookmarker.exe add <url> [tag1] [tag2] ...
.\build\fs-bookmarker.exe add http://www.priceintelligently.com/blog/david-cancel-saas-companies-customer-first-business-growth marketing saas
```

Bookmarks are written to `bookmarks.txt` like this

    ("David Cancel: Why Half of All SaaS Companies Will Go Out of Business",
    "http://www.priceintelligently.com/blog/david-cancel-saas-companies-customer-first-business-growth",
    [|"marketing"; "saas"|])


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


