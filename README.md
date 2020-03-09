# R6 Siege Team MMR Tracker

This tool takes the usernames of up to 10 players and displays a variety of stats from R6 siege for those players.
This tool shows the MMR, rank, KD and Win/Loss ratios for any PSN username provided for Rainbow Six Siege
This tool currently only supports PSN R6 stats


## Preliminary
THIS IS A WIP
This is a proof of concept. There are many many updates planned and this project should only been seen as something to use once it has hit version 2

## Getting Started
These instructions will get you a copy of the project up and running on your local machine for development and testing purposes. See deployment for notes on how to deploy the project on a live system.

### Prerequisites
This project was made in VS2019 but should work all the way back to VS2015

You will need to have the following:
* Visual Studio 2015 or newer
* NewtonSoft .Net library

### Installing
You can use this software with two different methods, one for installation, one for editing

#### Method 1
Download (and extract .zip) or clone this git to your HDD\
Navigate to the *Installers* directory\
Run *Setup-V1.1.0-MMRTracker.exe*

**OR**

#### Method 2
Download (and extract .zip) or clone this git to your HDD\
Open the .SLN file in the root directory and edit/use this in Visual Studio (2015 onwards)\
You will need to accept the prompt referencing a untrustworthy source\
Once it has loaded double click on any of the files in solution explorer to start editing\
Press Run or F5 to start the program

## Versioning

#### Private
* Version 1.0.0 - 06/03/20

#### Public
* Version 1.1.0 - 08/03/20

## TO-DO
* Version 1.2 - Async!
  * Version 1.2.1 - (F-1) Top left player uses Async to fetch stats
  * Version 1.2.2 - (F-2) All players uses Async to fetch stats
* Version 1.3 - Details pane revamp
  * Version 1.3.1 - (F-4) Details work for all players
  * Version 1.3.2 - (F-8) Detials are larger, easier to read
  * Version 1.3.3 - (F-10) Details are easier to navigate
* Version 1.4 - Graphics re-design
  * Version 1.4.1 - (F-20) Indicators for Async player request progress
* Version 1.5 - User customisability
  * Version 1.5.1 - (F-40) Users can swap team colours
  * Version 1.5.2 - (F-80) Users can set defaults names loaded at startup
  * Version 1.5.3 - (F-100) Users can setup teams and quickly change which team stats are loaded
  * Version 1.5.4 (?) - (F-200) Users can setup and store premade enemy teams
  * Version 1.5.5 (?) - (F-400) Users can swap players between teams
  * Version 1.5.6 - (F-800) Users can change which stats are shown
  * Version 1.5.7 - (F-1000) Users can choose to ommit certain details in "more details" pane
* Version 1.6 - Complete graphics overhaul
  * Version 1.6.1 - (F-2000) Graphics for players and teams redone
* Version 1.7 - Support all platforms
  * Version 1.7.1 - (F-4000) Support players on Xbox
  * Version 1.7.2 - (F-8000) Supoort players on PC
  * Version 1.7.3 - (F-10000) Support players in NA
  * Version 1.7.4 - (F-20000) Support players in AS
  
(F-####) indicates the level of features the released program has.\
A value of (F-3FFF) indicates Version 1.6.1 with all previous versions features
A value of (F-2D77) indicates Version 1.6.1 with all previous features except: 1.3.2, 1.5.2, 1.5.4, 1.5.7
A value of (F-DDC) indicates Version 1.5.6 with all previous features except: 1.2.1, 1.2.2, 1.4.1

Generally, a version will only be released with all previous features, if new features are implemented that make old features redundant then this feature specifier should help convey that.

It is likely that features from V1.7 will be implemented before v1.4, 1.5 and 1.6. For this reason most versions (passed 1.4) will be released with a feature specifier of ~(F-3C000) 

## Authors

* **Jake Bailey-Saltmarsh** - *All development* - [JakeR27](https://github.com/JakeR27)
* **Luke Williams** - *BETA tester*

Note: Contributers is not set up\
See also the list of [contributors](https://github.com/JakeR27) who participated in this project.

## License

Currently I have not considered any licence as I have not researched which would be best.
Until I find an appropriate licence. The following applies:
* You **can** use this program for personal use
* You **can** use this program for non-professional use (few mates hanging out together)
* You **cannot** use this program for professional use
* You **cannot** use this program for commercial use\
* You **can** view the source code
* You **can** edit the source code for personal use
* You **cannot** edit the source code for professional use
* You **cannot** edit the source code for commercial use
* You **cannot** edit the source code and then redistrobute it
* You **cannot** redistrobute any source code (with or without edits)

## Contributing

I'm not currently looking for anyone to help contribute, if you want to expand on my work or take it to places I've not even considered then feel free to contact me

## Acknowledgments

* Microsoft Documentation :) for all errors, spelling mistakes and other pains of development

## Built With

* [Visual Studio 2019](https://visualstudio.microsoft.com/vs/)
* [R6Tab](https://r6tab.com/) API - for collecting player stats

