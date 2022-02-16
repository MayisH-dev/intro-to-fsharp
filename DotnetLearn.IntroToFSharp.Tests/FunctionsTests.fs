module FunctionsTests

open FsUnit
open Xunit

[<Fact>]
let ``call returns the same value as invoking directly`` () = Functions.call id 1 |> should equal 1
