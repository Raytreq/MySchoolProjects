import pyautogui, time

time.sleep(2)
pyautogui.click()
distance = 250

while distance > 0:
    pyautogui.dragRel(distance, 0, duration=0.1)
    distance = distance - 5
    pyautogui.dragRel(0, distance, duration=0.1)
    distance = distance - 5
    pyautogui.dragRel(-distance, 0, duration=0.1)
    distance = distance - 5
    pyautogui.dragRel(0, -distance, duration=0.1)
    distance = distance - 5