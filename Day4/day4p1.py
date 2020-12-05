# https://adventofcode.com/2020/day/4

with open('Day4/day4.txt','r') as file:
    data = file.readlines()

# 2D array of passports
passports = []
passport = {}

# create an list of hashtable passports
for line in data:
    passportinfos = line.split(' ')

    if line == '\n':
        passports.append(passport)
        passport = {}
        continue

    for info in passportinfos:
        entry = info.split(':')
        passport[entry[0]] = entry[1]

# add last entry
passports.append(passport)
passport = {}

# check for passport validity
for item in passports:
    #check for all fields besides cid (Optional field)
    fields = ['byr','iyr','eyr','hgt','hcl','ecl','pid']
    for field in fields:
        if field in item:
            item['valid'] = "True"
        else:
            item['valid'] = "False"
            break

count = 0
validcount = 0
for item in passports:
    print("passport id: " + str(count) + " : " + item['valid'])
    count += 1
    if item['valid'] == 'True':
        validcount += 1
print("Valid count " + str(validcount))