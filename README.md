# ERregulator
Simple tool for randomization of game parameters in Elden Ring, based on JKAnderson's [Irregulator](https://github.com/JKAnderson/Irregulator) for DS3.

## Usage
The usage of this application requires .NET Framework 4.7.2 to work.
As there is no official release yet, please refer to [Building from source](#building-from-source) on how to create an executable.
1. Run the ERregulator app and make sure the game directory is correct before proceeding.
2. Pick your options, click Randomize and wait for the process to finish.
3. Your game is now using modified parameters.

## Uninstallation
1. Run the ERregulator app and make sure the game directory is correct before proceeding.
2. Click Restore and wait for the process to finish.
3. Your game is now back to using the vanilla parameters.

## Building from source
1. Clone the GitHub repository, making sure to clone submodules using ``git clone --recursive``.<br>
   Make sure that the SoulsFormats submodule is on the [Elden Ring](https://github.com/JKAnderson/SoulsFormats/tree/er) branch, not the master branch.
3. Open the ERregulator solution in Visual Studio and download the necessary NuGet packages.
4. Build the project using Visual Studio, or by using ``dotnet build``.
To use the app, please refer to [Usage](#usage).

## Credits
[Costura.Fody](https://github.com/Fody/Costura) by Simon Cropp, Cameron MacFarland

[Octokit](https://github.com/octokit/octokit.net) by GitHub

[Semver](https://github.com/maxhauser/semver) by Max Hauser

[Paramdex](https://github.com/soulsmods/Paramdex) by soulsmods

[SoulsFormats](https://github.com/JKAnderson/SoulsFormats) by JKAnderson
