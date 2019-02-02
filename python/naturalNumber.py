Count = int(input('How many natural numbers do you want to print?'))
print('The natural numbers upto ' + str(Count) + ' are',end = '')
for Counter in range (1, (Count + 1)):
  print(' ' + str(Counter),end = '')
print('.')