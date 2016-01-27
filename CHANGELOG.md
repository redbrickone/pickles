# CHANGE LOG

All notable changes to this project will be documented in this file.

This project adheres to [Semantic Versioning](http://semver.org). We consider the following to be the API of Pickles for the purposes of Semantic Versioning:

  - The arguments of the command line runner
  - The arguments of the PowerShell runner
  - The arguments of the MSBuild configuration
  - The settings file of the GUI runner
  - The JSON output of the JSON format

This document is formatted according to the principles of [Keep A CHANGELOG](http://keepachangelog.com).

## [2.3.0] - 2016-01-27

### Added

- Support for SpecFlow v2 ([#276](https://github.com/picklesdoc/pickles/issues/276)) (by [@dirkrombauts](https://github.com/dirkrombauts)).

## [2.2.1] - 2016-01-25

### Changed

- The .nuspec files now contain a releaseNotes elements that points to this file on GitHub.

### Fixed

- xUnit1 and xUnit2: Failure when tests are included that don't have traits ([#268](https://github.com/picklesdoc/pickles/issues/268)) (by [@dirkrombauts](https://github.com/dirkrombauts)).

## [2.2.0] - 2016-01-15

### Added

- Support for xUnit 2 ([#230](https://github.com/picklesdoc/pickles/issues/230)) (by [@dirkrombauts](https://github.com/dirkrombauts)).
- Support for nUnit 3 ([#230](https://github.com/picklesdoc/pickles/issues/224)) (by [@dirkrombauts](https://github.com/dirkrombauts)).

### Changed

- The Gherkin parser was updated to version 3.2.0 ([#256](https://github.com/picklesdoc/pickles/pull/256)) (by [@dirkrombauts](https://github.com/dirkrombauts)).
- Other dependencies were updated (by [@dirkrombauts](https://github.com/dirkrombauts)).

### Fixed

- The language parameter now correctly sets the default language to use when parsing feature files ([#260](https://github.com/picklesdoc/pickles/issues/260)) (by [@dirkrombauts](https://github.com/dirkrombauts)).
- The MarkDown code in the examples was corrected ([#254](https://github.com/picklesdoc/pickles/issues/254)) (by [@dirkrombauts](https://github.com/dirkrombauts))


## [2.1.0] - 2015-12-30

### Added

- The language of the `.feature` files can now be set in the MSBuild runner as well. See MSBuild configuration should map Language too ([#236](https://github.com/picklesdoc/pickles/issues/236)).

### Fixed

- Remove potential load failure from the Command Line, GUI and MSBuild runners ([#243](https://github.com/picklesdoc/pickles/issues/243))

### Changed

- Some external components were updated.

## [2.0.4] - 2015-12-27

### Fixed

- The PowerShell runner does not load ([#239](https://github.com/picklesdoc/pickles/issues/239))


## [2.0.3] - 2015-15-23

### Fixed

- The presence of a background causes a crash when integrating test results ([#238](https://github.com/picklesdoc/pickles/issues/238))


## [2.0.2] - 2015-11-21

### Fixed

- Test results in example rows of scenario outlines that contain `$` signs were not correctly identified ([#227](https://github.com/picklesdoc/pickles/issues/227))
- Table layout in the DHTML version was sometimes unnecessarily narrow ([#225])https://github.com/picklesdoc/pickles/pull/225))


## [2.0.1] - 2015-11-20

### Fixed

- A crash was fixed that occurred when linking nUnit test results  ([#223](https://github.com/picklesdoc/pickles/issues/223))


## [2.0.0] - 2015-11-03

### Removed

- Pickles no longer supports running on .NET version prior to 4.5: Pickles now uses version 3 of the Gherkin parser, and as such requires .NET 4.5. The new parser is a lot smaller and should be faster too.


## [1.2.3] - 2015-10-06

### Fixed

- In the DHtml version, the alignment of the keywords (Given, When, Then) was fixed for non-English languages ([#219](https://github.com/picklesdoc/pickles/issues/219))


## [1.2.2] - 2015-09-24

### Fixed

- The PowerShell version now correctly traces relative paths from the current directory ([#216](https://github.com/picklesdoc/pickles/issues/216))


## [1.2.1] - 2015-08-14

### Fixed

- In the Html version, the alignment of the keywords (Given, When, Then) was fixed for non-English languages ([#209](https://github.com/picklesdoc/pickles/issues/209))
- A NullReferenceException in the MSTest provider was fixed when the test results also contain ordinary unit test results in addition to the SpecFlow results ([#212](https://github.com/picklesdoc/pickles/issues/212))


## [1.2.0] - 2015-07-28

### Added

- In the DHtml version, there are now links to hide/show the navigation, and to collapse/expand all nodes in the navigation ([#204](https://github.com/picklesdoc/pickles/issues/204))

### Fixed

- The command line version no longer silently fails when an error occurs. You will need to adapt the configuration in order to get more information from the error ([#202]((https://github.com/picklesdoc/pickles/issues/202))
- The issue of failing silently in case the full filename is too long has been fixed ([#199](https://github.com/picklesdoc/pickles/issues/199))


## [1.1.0] - 2015-05-12

### Added

- In both the DHtml and Html versions: Align scenario keywords to the right side so that step texts start from the same position ([#195](https://github.com/picklesdoc/pickles/issues/195))

### Fixed

- Abbreviations displayed incorrectly with spaces between letters ([#192](https://github.com/picklesdoc/pickles/issues/192))


## [1.0.1] - 2015-03-31

### Fixed

- In the DHtml version, feature wide tags with capitals can not be filtered on ([#194](https://github.com/picklesdoc/pickles/issues/194))
- Tables in background for Word & Excel  ([#191](https://github.com/picklesdoc/pickles/issues/191))


## [1.0.0] - 2014-12-15

### Removed

- Support for the nAnt runner has been discontinued. nAnt users can migrate by using nAnt's capabilities to call the command line runner of Pickles. ([#179](https://github.com/picklesdoc/pickles/pull/179))

### Fixed

- The checkmark/cross icon in the GUI client did not always show the cross icon when appropriate, and its state could be changed by the user. ([#177](https://github.com/picklesdoc/pickles/pull/177))


## [0.20.0] - 2014-12-10

### Added

- The command line and powershell runners now return an error code of 0 when everything went fine, and 1 if there was an error.
- The HTML and DHTML output versions no longer horizontally spread tables.
- The GUI version has an icon

### Changed

- The msbuild runner will now break the build when an error occurs. This reflects our belief that the Living Documentation is a first class output of the software development process.


## [0.19.0] - 2014-11-25

### Added

- Each runner has its own download package
- Several improvements to the DHTML version
  - A progress indicator when loading features for the first time
  - Add a toggle to show/hide folder contents (top level folders are collapsed by default)
- The Nuget package for the MSBuild runner adds an msbuild target file - see [MSBuild Task](http://www.picklesdoc.com/#!Pages/MSBuildTask.md) for documentation ([#157](https://github.com/picklesdoc/pickles/pull/157))
- The text "pickled on" was replaced with "generated on".

### Changed

- For contributors: we are now using a new assert library: [NFluent](http://n-fluent.net/).

### Removed

- DITA support has been discontinued. ([#153](https://github.com/picklesdoc/pickles/pull/153))


## [0.18.2] - 2014-09-12

### Fixed

- Fixed issue where the Html version didn't render the pass/fail icons ([#139](https://github.com/picklesdoc/pickles/issues/139))
- Fixed issue where the Html version generated an unexpected entry for a file in obj/Debug ([#140](https://github.com/picklesdoc/pickles/issues/140))
- Removed dependencies from the Nuget packages ([#142](https://github.com/picklesdoc/pickles/issues/142))
- The nuget packages Pickles.CommandLine and Pickles.MSBuild contain the files twice ([#144](https://github.com/picklesdoc/pickles/issues/144))


## [0.18.1] - 2014-09-01

### Fixed

- Fixed issue where multiline arguments of gherkin steps would not be rendered in the DHtml verion ([#134](https://github.com/picklesdoc/pickles/issues/134))


## [0.18.0] - 2014-07-07

### Changed

- The folder structure of the dependencies of the static HTML version was changed. If you override the .css files, you will need to update your workflow to account for that.

### Fixed

- Fixed issue where multiple results files for a single feature causes exceptions when processing scenario outline examples ([#123](https://github.com/picklesdoc/pickles/pull/123))
- Fixed issue where pickles would crash when a specified test results file does not exist ([#126](https://github.com/picklesdoc/pickles/issues/126))


## [0.17.4] - 2014-06-04

### Fixed

- Description blocks are rendered as code elements in DHtml version ([#118](https://github.com/picklesdoc/pickles/issues/118))


## [0.17.3] - 2014-05-28

### Fixed

- PowerShell version works again


## [0.17.2] - 2014-05-28

Some things went wrong during the publication of versions 0.17.0 and 0.17.1. Therefore 0.17.2 is the first published 0.17.x version.

### Added

- Added test status in the DHTML browsing section (left nav) (#110)

### Fixed

- Crash because of nunit result (#108)
- Avoid crash on start of GUI (#112)


## [0.17.1] - 2014-05-28 [YANKED]


## [0.17.0] - 2014-05-28 [YANKED]


## [0.16.0] - 2014-05-15

### Added

- Enable results for individual example results in a scenario outline (in the Html version) ([#105](https://github.com/picklesdoc/pickles/pull/105))

### Fixed

- Features don't render correctly when there are less than 4 spaces ([#106](https://github.com/picklesdoc/pickles/pull/106))


## [0.15.0] - 2014-04-11

### Added

- Allow multiple result files ([#83](https://github.com/picklesdoc/pickles/issues/83)): it is now possible to use multiple test result files. This will come in handy if you need to partition your test runs. Simple use a semicolon-separated list of file paths instead of the single file path as an argument


## [0.14.0] - 2014-03-27

### Added

- The (static) Html version now supports images with .png, .gif, .jpg and .bmp extensions. This partially addresses issue ([#12](https://github.com/picklesdoc/pickles/issues/12))
- Several updates of external dependencies, including the long out-of-date IKVM. Yay!
- All production code and test code now use the excellent [System.IO.Abstraction](https://github.com/tathamoddie/System.IO.Abstractions) library and its TestingHelpers classes.
- We are using build services provided by [MyGet](http://www.myget.org/)


## [0.13.1] - 2013-12-20

### Fixed

- DHTML uses the Feature's description for the Background ([#74](https://github.com/picklesdoc/pickles/issues/74))
- Nuget manifest should mention PicklesDoc instead of only Jeffrey Cameron ([#84](https://github.com/picklesdoc/pickles/issues/84))
- Crash when a feature is not present in the test result (with NUnit) ([#85](https://github.com/picklesdoc/pickles/issues/85))


## [0.13.0] - 2013-11-29

### Added

- The UI version now includes the option to generate each selected output format in its own directory ([#78](https://github.com/picklesdoc/pickles/pull/78))

### Fixed

- Left nav bug fix in DHTML format ([#73](https://github.com/picklesdoc/pickles/pull/73))
- DHTML uses the Feature's description for the Background ([#74](https://github.com/picklesdoc/pickles/issues/74))


## [0.12.1] - 2013-10-28

### Fixed

- Fixes a .NET runtime version issue caused by combining all Pickles runners in one directory. We are back to each runner in a separate directory, and will likely remain so until all assemblies use the same .NET framework version.


## [0.12.0] - 2013-10-25

### Added

- DHTML output format should render Markdown correctly (one step closer toward feature parity for all export formats) ([#60](https://github.com/picklesdoc/pickles/issues/60))

### Changed

- The .zip file contains all 5 Pickles runners in one directory, reducing the size of the download by roughly three quarters.

### Bug(s) Fixed

- When selecting multiple output formats in the UI, pickles generates the first output format multiple times ([#66](https://github.com/picklesdoc/pickles/issues/66))


## [0.11.0] - 2013-09-26

### Added

- Better Error Reporting: both the command line client and the UI show a log ([#36](https://github.com/picklesdoc/pickles/issues/36))

### Fixed

- Pickles crashes when generating excel with really long descriptions ([#62](https://github.com/picklesdoc/pickles/issues/62))
- Calling pickles.exe without any arguments in a directory without features causes a crash ([#63](https://github.com/picklesdoc/pickles/issues/63))


## [0.10.0] - 2013-08-29

### Added

- Add support for SpecRun test results ([#21](https://github.com/picklesdoc/pickles/issues/21)). Refer to the wiki page for instructions on how to configure SpecRun correctly: [Integrating Test Results From SpecRun](http://www.picklesdoc.com/#!Pages/IntegratingTestResultsFromSpecRun.md).

### Fixed

- Please implement marking ignored test cases with yellow sign rather than red for all Test Result providers (not just MSTest) ([#47](https://github.com/picklesdoc/pickles/issues/47))
- Remove duplication of example feature files ([#50](https://github.com/picklesdoc/pickles/issues/50))
- Adding background to features in word ([#58](https://github.com/picklesdoc/pickles/pull/58))
- Handle cucumber feature with no scenarios ([#59](https://github.com/picklesdoc/pickles/pull/59))


## [0.9.0] - 2013-07-23


## [0.8.0] - 2012-12-17


## [0.7.0] - 2012-08-07


## [0.6.0] [SKIPPED]


## [0.5.0] - 2012-03-13


## [0.4.0] - 2012-01-20


## [0.3.0] - 2011-12-13


## [0.2.0] - 2011-11-14


## [0.1.0] - 2011-10-22