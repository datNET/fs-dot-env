namespace datNET

module DotEnv =
    open System.IO

    // TODO: Try catch
    let private _envLines = File.ReadAllLines(".env")
