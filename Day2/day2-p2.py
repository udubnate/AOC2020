# Regular Expressions
import re

with open('Day2/input.txt','r') as file:
    data = file.readlines()

count = 0

for line in data:
    arr = line.split(' ')
    range = arr[0].split('-')
    letter = arr[1].replace(':','')
    value = arr[2].replace('\n','')
    #ncount count of matches

    first = value[int(range[0])-1] == letter
    last = value[int(range[1])-1] == letter

    #bitwise XOR
    if (first ^ last):
        count += 1

print(count)
