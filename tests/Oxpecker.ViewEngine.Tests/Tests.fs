module Tests

open Oxpecker.ViewEngine
open Xunit
open FsUnitTyped

[<Fact>]
let ``My test`` () =
    let result =
        html() {
            div(id = "1")
            div(id = "2") {
                let x = 2
                div(id = "3", class' = "test")
                for _ in 1..x do
                    br()
                div(id = "4")
            }
        }
    result.Render().ToString() |> shouldEqual """<html><div id="1"></div><div id="2"><div id="3" class="test"></div><br><br><div id="4"></div></div></html>"""