module DummyTests

open FsUnit
open Xunit

[<Fact>]
let ``1 + 1 = 2`` () = 1 + 1 |> should equal 2
