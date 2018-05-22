open System
let n = Console.ReadLine() |> int

let last n xs = xs |> Seq.skip (Seq.length xs - n)

let rotate n s = Seq.append (last (Seq.length s - n) s) (Seq.take n s) |> Seq.map string |> String.concat "" 

let read_and_rotate_string () =
    let s = Console.ReadLine()
    [1..s.Length] |> List.map (fun n -> rotate n s)

[1..n] 
    |> List.map (fun _ -> read_and_rotate_string ()) 
    |> List.map (fun a -> String.concat " " a) 
    |> List.iter (fun s -> printfn "%s" s)
