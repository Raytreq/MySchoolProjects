from re import I
import openpyxl
wb = openpyxl.load_workbook("uczniowie.xlsx")
sheet = wb.get_sheet_by_name("Sheet1")

ilosc = int(input("Podaj ilość uczniów: "))
zakres = ilosc + 1

for x in range(1, zakres):
    y=str(x)

    sheet["A"+y] = input ("Podaj imię: ")
    sheet["B"+y] = input ("Podaj nazwisko: ")
    sheet["C"+y] = input ("Podaj PESEL: ")

    wb.save("uczniowie.xlsx")