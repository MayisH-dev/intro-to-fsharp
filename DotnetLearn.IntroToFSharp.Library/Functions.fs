module Functions

// Functions are things!
// Functions are not attached to classes

let one = 1

let add x y = x + y

// declarations similar to mathematical functions f(x) = x * x
let square x = x * x

// take functions as parameters
let call f x = f x

// return functions
let add' x = fun y -> x + y