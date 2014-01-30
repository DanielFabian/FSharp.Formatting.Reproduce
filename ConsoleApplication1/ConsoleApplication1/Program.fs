module AppDomainCrash
open System
open System.Reflection

let runDomain i =
    let domain = AppDomain.CreateDomain(i.ToString())
    let assembly = typeof<Library1.Marker>.Assembly  
      
    domain.ExecuteAssemblyByName(assembly.FullName, i.ToString())

[|1..100000|] |> Array.map runDomain