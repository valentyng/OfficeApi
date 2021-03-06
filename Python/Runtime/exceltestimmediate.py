﻿import excel

def simpleRangeTest():
    context = excel.createInstantContext()
    sheet = context.workbook.worksheets.getItem("Sheet1")
    sheet.getUsedRange().clear()
    r = sheet.getRange("A1:B2")
    r.values = [["Hello", "World"], [1234, "=A2 + 1000"]]
    print(r.values)
    t = sheet.tables.add(r, True)

if __name__ == "__main__":
    simpleRangeTest()
