import re
    
# Day One
counter = 0
with open('day2/input.txt') as f:
    for line in f:
        mininum, maximum, char, password = re.split('-| |: ', line)
        if int(mininum) <= password.count(char) <= int(maximum):
            f = open("day2/alt-answers.txt", "a")
            f.write(line)
            f.close()
            counter += 1

print(counter)