module Library1

type Alias = Dummy.OriginalType
let myFunc = Alias.DUCase

type Class1() = 
    member this.X = "F#"
