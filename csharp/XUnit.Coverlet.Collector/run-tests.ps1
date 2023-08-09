rm -r TestResults

dotnet test --collect:"XPlat Code Coverage"

reportgenerator                                 `
-reports:"TestResults\*\coverage.cobertura.xml" `
-targetdir:"coveragereport"                     `
-reporttypes:Html

Start-Process "chrome.exe" "file:///$pwd/coveragereport/GildedRoseKata_GildedRose.html"