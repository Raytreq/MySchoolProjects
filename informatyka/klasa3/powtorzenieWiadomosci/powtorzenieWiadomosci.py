g = int(input("Podaj czas rozpoczęcia wydarzenia(godziny)"))
m = int(input("Podaj czas rozpoczęcia wydarzenia(minuty)"))
d = int(input("Podaj czas trwania wydarzenia(minuty)"))

print("Czas zakończenia wydarzenia: ",((((g*60)+m+d))//60)%24,":",(((g*60)+m+d))%60)