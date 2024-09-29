module Oxpecker.Solid.Tests.Cases.NestedTags

open Oxpecker.Solid

[<SolidComponent>]
let NestedTags (id: int) =
    let hello = "Hello "
    div(id=string id, class'="testclass") {
        h1() { hello }; "world!"
    }
