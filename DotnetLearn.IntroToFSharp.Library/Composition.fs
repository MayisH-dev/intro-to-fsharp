module Composition

open Coffee

let roast coffeeBerries =
    // simple pattern matching
    let (CoffeeBerry count) = coffeeBerries
    // function call
    CoffeeBean count

let grind (CoffeeBean count) =
    let beanWeight = 0.1325
    count
    |> float
    |> (*) beanWeight
    |> CoffeeGroundGram

let boil (CoffeeGroundGram grams) =
    let gramsInSpoon = 10.
    grams
    |> (/) gramsInSpoon
    |> CoffeeCupWithSpoonfuls

// not as readable 
let makeCoffeeFromBerries berries = boil (grind (roast berries))

// define it as a pipeline of operations over an initial value
let makeCoffeeFromBerries' berries = berries |> roast |> grind |> boil

// naturally readable, intuitive way to define high level operations by combining (composing) lower level operations
let makeCoffeeFromBerries'' = roast >> grind >> boil

// compose low level functions to create service functions
// compose service functions to create use cases
// compose use cases to create applications