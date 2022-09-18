//// For more information see ///////////////
////https://aka.ms/fsharp-console-apps///////

open System
open System.IO

//// Calc ///////////////////////////////////
module Calc =

  let calcCtoF current_temperature =
    (current_temperature * 1.8) + 32.
  
  (*
  printf Debug
  let resultCtoF = calcCtoF 100
  printfn "%e" resultCtoF
  *)

  let calcFtoC current_temperature =
    (current_temperature - 32.) / 1.8

  (*
  printf Debug 
  let resultFtoC = calcFtoC 100
  printfn "%e" resultFtoC
  *)

//// firstCall /////////////////////////////////
module firstCall =

  let dispInfo = Console.WriteLine(
    "\n
    +------------------------------------------+\n
    |摂氏（°C）から華氏（°F）に変換-> 1　を入力|\n
    +------------------------------------------+\n
    |華氏（°F）から摂氏（°C）に変換-> 2　を入力|\n
    +------------------------------------------+\n
    |終了（exit）　　　　　　　　　-> 0　を入力|\n
    +------------------------------------------+\n
    ")

  let firstCall() =
    Console.WriteLine("\n  摂氏を華氏、または華氏を摂氏に変換します。\n")
    Console.WriteLine(dispInfo)

//// Main //////////////////////////////////////

[<EntryPoint>] 
let main argv =
  firstCall.firstCall() 
  let line = Console.ReadLine()
  let addLine2 = line + line 
  
  Console.WriteLine(addLine2)

  0



