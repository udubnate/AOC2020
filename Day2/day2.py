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
    #sort to make sure you count all
    valuearr = sorted(value)
    value = "".join(valuearr)
    regexp = '[' + letter + ']' + '{' + range[0] + ',' + range[1] + '}'
    p = re.compile(regexp)
    ptest = p.search(value)
    if ptest:
        count += 1
print(count)
