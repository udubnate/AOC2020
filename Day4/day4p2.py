# https://adventofcode.com/2020/day/4
import re

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
def check_validity(passport):

    #check for all fields besides cid (Optional field)
    fields = ['byr','iyr','eyr','hgt','hcl','ecl','pid']
    for field in fields:
        if field not in item:
            return False
    # additional requirements
    if not (int(passport['byr']) >= 1920 and int(passport['byr']) <= 2002):
        return False
    if not (int(passport['iyr']) >= 2010 and int(passport['byr']) <= 2020):
        return False
    if not (int(passport['eyr']) >= 2020 and int(passport['byr']) <= 2030):
        return False
    # Height special requirements for cm and inches
    hgt = passport['hgt']
    hgtnum = int(re.findall("\d+", hgt)[0])
    if "cm" in hgt:
        if not (hgtnum >= 150 and hgtnum <= 192):
            return False
    else:
        if not (hgtnum >= 59 and hgtnum <= 76):
            return False
     
    # Need Eye Color to match this regex
    # ^#[a-zA-Z0-9]{6}$
    
    return True

for item in passports:
    #check for all fields besides cid (Optional field)
    item['valid'] = check_validity(item)

count = 0
validcount = 0
for item in passports:
    print("passport id: " + str(count) + " : " + str(item['valid']))
    count += 1
    if item['valid'] == True:
        validcount += 1
print("Valid count " + str(validcount))