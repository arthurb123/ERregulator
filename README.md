# ERregulator
<b>Supports the <i>Shadow of the Erdtree</i> DLC!</b>

Simple tool for randomization of game parameters in Elden Ring, based on JKAnderson's [Irregulator](https://github.com/JKAnderson/Irregulator) for DS3.<br>
<img alt="Interface Screenshot" src="interface.png" width=50% height=50%>

## Usage
The usage of this application requires .NET Framework 4.8 to work.<br>
Please download the latest release from the [Releases](https://github.com/arthurb123/ERregulator/releases) page, or refer to [Building from source](#building-from-source) on how to create an executable yourself.
1. Run the ERregulator app and make sure the game directory is correct before proceeding.
2. Pick your options, click Randomize and wait for the process to finish.
3. Your game is now using modified parameters.

## Uninstallation
1. Run the ERregulator app and make sure the game directory is correct before proceeding.
2. Click Restore and wait for the process to finish.
3. Your game is now back to using the vanilla parameters.

## Building from source
1. Clone the GitHub repository, making sure to clone submodules using ``git clone --recursive``.<br>
3. Open the ERregulator solution in Visual Studio and download the necessary NuGet packages.<br>
4. Build the project using Visual Studio, or by using ``dotnet build``.<br>
   If you get a targeting error for the SoulsFormats submodule, make sure SoulsFormats targeting framework is set to ``net48``.<br>

To use the app, please refer to [Usage](#usage).

## Credits
[Paramdex](https://github.com/soulsmods/Paramdex) by soulsmods<br>
[SoulsFormatsNEXT](https://github.com/soulsmods/SoulsFormatsNEXT) by soulsmods & JKAnderson
