module Trainer

open Network
open Sample
//let private checkDimensions net cases =
//    if Array.length cases <> 0 then
//        ////////////

let TrainAllCases net samples =
    cases 
    |> Array.iter(fun sample ->
        feedForward net sample.Input |> ignore
     )
    ()

