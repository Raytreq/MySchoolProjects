import openpyxl
wb = openpyxl.load_workbook("lotto.xlsx")
sheet = wb["dl"]

a = int(input("Podaj pierwszą liczbę: "))
b = int(input("Podaj drugą liczbę: "))
h = 0

for i in range(2,6644):
    x = str(i)

    m = sheet["A"+x].value
    n = sheet["B"+x].value
    o = sheet["C"+x].value
    p = sheet["D"+x].value
    r = sheet["E"+x].value
    s = sheet["F"+x].value
    t = sheet["G"+x].value

    if (n==a or o==a or p==a or r==a or s==a or t==a) and (n==b or o==b or p==b or r==b or s==b or t==b):
        h=h+1
        print(m,n,o,p,r,s,t)

print("Znaleziono", h, "wyników")