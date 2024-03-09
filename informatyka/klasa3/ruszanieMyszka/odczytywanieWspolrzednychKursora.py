#Zaimportowanie modułu potrzebnego do prawidłowego zafunkcjonowania programu
import pyautogui

#Instrukcja dla użytkownika
print('Naciśnij klawisze Ctrl+C, aby zakończyć działanie programu.')

#Linia try mająca na celu przeprowadzić dane operacje, jeżeli określony wyjątkowy warunek nie zostanie spełniony
try:
    #Pętla obliczająca obecną pozycję myszki cały czas
    while True:
        #Określenie specjalnej funkcji pobierającą naszą pozycję myszki poprzez moduł PyAutoGUI dla naszych zmiennych X i Y
        x, y = pyautogui.position()
        #Przemienienie zmiennych na czteropozycyjny tekst
        positionStr = 'X: ' + str(x).rjust(4) + ' Y: ' + str(y).rjust(4)
        #Komunikat pokazujący obecne zmienne, a co za tym idzie obecną pozycję myszki
        print(positionStr, end='')
        #Polecenie ma na celu wycczysczenie poprzednich zmiennych i zaaktulizowanie ich nowymi pozycjami
        print('\b' * len(positionStr), end='', flush=True)

#Manualne zatrzymanie programu poprzez naciśnięcie Ctrl+C, wyjątkowy warunek kończący polecenie try
except KeyboardInterrupt:
    #Komunikat
    print('\nGotowe!')