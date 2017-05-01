module ``fs-bookmarker``

open System
open HtmlAgilityPack
open Hopac
open HttpFs.Client

let filename = "bookmarks.txt"

let getTitle = fun (url : string) ->
    let body =
        Request.createUrl Get url
        |> Request.responseAsString
        |> run

    let doc = HtmlDocument()
    doc.LoadHtml body
    (doc.DocumentNode.SelectSingleNode "//title/text()").InnerText

let add url tags =
    let title = getTitle url
    let output = sprintf "%A" (title, url, tags)
    IO.File.AppendAllLines( filename, [| output |])

[<EntryPoint>]
let main argv =
    printfn "%A" argv
    let command = argv.[0]
    match command with
    | "add" ->
        let url, tags = argv.[1], argv.[2..]
        add url tags
        printfn "Added %A %A" url tags
    | _ ->
        printfn "fs-bookmarker add url tag1 tags"
    0 // return an integer exit code
