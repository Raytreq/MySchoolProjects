import pyautogui
from time import sleep

sleep(2)
nameField = (375, 450)

formData = {
  'name': 'Krzysztof',
  'fear': 'Writing this program', 
  'source': 'Wand', 
  'robocop': 3, 
  'comments': 'Comment'
}

pyautogui.click(nameField[0], nameField[1])
sleep(0.3)
pyautogui.typewrite(formData['name'])
sleep(0.3)
pyautogui.keyDown('tab')
sleep(0.3)
pyautogui.typewrite(formData['fear'])
sleep(0.3)
pyautogui.keyDown('tab')
sleep(0.3)
pyautogui.keyDown('down')
sleep(0.3)
pyautogui.keyDown('enter')
sleep(0.3)
pyautogui.keyDown('tab')
sleep(0.3)
pyautogui.keyDown('tab')
sleep(0.3)

for i in range(2):
  pyautogui.keyDown('right')

  i+=1
  
sleep(0.3)
pyautogui.keyDown('tab')
sleep(0.3)
pyautogui.keyDown('tab')
sleep(0.3)
pyautogui.typewrite(formData['comments'])
pyautogui.keyDown('tab')
sleep(0.3)
pyautogui.keyDown('enter')
sleep(0.3)