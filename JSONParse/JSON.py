import json
import re

file = open(r"D:\Programming\ZeldaChecker\bin\Games\albw\new\maiamai.txt", "r")


itemsFound = []
itemConstruction = ""
itemNumber = 1

for line in file:
    if "Requirements" in line:
        strip = re.sub("Requirements: ", "", line)
        itemConstruction = itemConstruction + '"conditions": ["' + strip.strip("\n") + '"],'
    if "- " in line:
        strip = re.sub("- ", '"guide": "', line)
        itemConstruction = itemConstruction + strip.strip("\n") + '", "status": false}'
        itemsFound.append(itemConstruction)
        itemConstruction = ""


toWriteFile = open("newfile.txt", "w")

for item in itemsFound:
    item.strip("\n")
    toWriteFile.write(item + "\n")





