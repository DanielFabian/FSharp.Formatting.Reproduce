module Library1

type Marker = class end

[<EntryPoint>]
let main args =
    printfn "%A" args
//    failwith "omg"
    let rec killMyself x = killMyself x
    killMyself 1
    0