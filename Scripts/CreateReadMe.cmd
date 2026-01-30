:: CreateReadMe.cmd
:: Create the ReadMe.md file from Docs/ReadMe.docx.
:: This command is meant to be run from within the Scripts folder.
SET FAR=C:\Files\Dropbox\Develop\Shared\FindAndReplace\Source\FindAndReplace\bin\Debug\net6.0\FindAndReplace.exe
SET SOURCE=..\Docs\ReadMe.odt
SET TARGET=..\README.md


:: When the image has a URL assigned it isn't placed in the output. Use 'Image' or 'Banner' blocks.
PANDOC -t markdown_strict --embed-resources=false --wrap=none "%SOURCE%" -o "%TARGET%"
"%FAR%" "/workingpath:..\Docs" "/files:%TARGET%" "/patternfile:..\Scripts\ReadmePostProcessing.json"
"%FAR%" /wait /workingpath:../ "/infile:Docs\NuGetUpdates.md" "/outfile:Source\NuGet\README.md" "/patternfile:Scripts\NuGetReadMeProcessing.json"
