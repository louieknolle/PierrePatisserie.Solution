# Pierre's Patisserie

#### By: Louie Knolle

#### Allows user to order loaves of bread and pastries.

## Technologies Used

* C#
* dotnet5 
* MSTest
* Command Line Interface
* Colorful.Console

## Description 

This simple C# application run in the terminal allows the user to order bread and pastries from Pierre's Patisserie and find out the total cost of the order. Pricing for bread is $5 per loaf with every 3rd loaf being free.  Pastry prices are: 1 or 2 pastries for $2 each, 3 pastries for $5, 4 pastries for $7, 5 pastries for $9, 6 pastries for $10. After entering in the desired quantities for each, the total cost for the order is displayed to the user. 

## Setup/Installation Requirements

* _On your computer, install .NET 5 if you do not already have it_
  * _Direct link for Mac download here: ```https://download.visualstudio.microsoft.com/download/pr/846d5680-b804-4903-8d8d-255804bcfaeb/436101afc96998f75efb452f5ded3c1a/dotnet-sdk-5.0.401-osx-x64.pkg```_
  * _Direct link for Windows download here: ```https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer```_
  * _Open the file that downloads and follow instructions in the installer that opens_
  * _Confirm that install was successful by opening your command terminal and run the command ```$ dotnet --version``` (```5.0.401``` should display)_ 
  
* _Use the terminal to clone the repository from Github by inputting ```git clone https://github.com/louieknolle/PierrePatisserie.Solution```_
* _Download ```Colorful.Console``` from NuGet by issuing command ```dotnet add package Colorful.  Console --version 1.2.15```_
* _run command in terminal ```cd Bakery``` to move into the main project directory_
* _run command ```dotnet run``` to build the project and launch the Program.cs file in the terminal_
* _Have fun following the program's prompts!_

## Known Bugs

* _There's error handling for numbers that do not work with the methods for instance constructors and their methods, but as of now the program just exits with a built in dotnet error message if the user inputs letters or characters are instead of integers_


## License

_Email knollelw@gmail.com with any comments or contributions. This software is licensed under the Microsoft license_

Copyright (c) _2022_ _Louie Knolle_