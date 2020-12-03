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
    ncount = 0
    for n in value:
        if n == letter:
            ncount += 1
    if int(range[0]) <= ncount <= int(range[1]):
        count += 1

print(count)
