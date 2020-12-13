# https://adventofcode.com/2020/day/4
import re
from validation import *

with open('day4.txt','r') as file:
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
        passport[entry[0]] = entry[1].replace('\n','')

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
    if not isvalid_byr(passport['byr']):
        return False
    if not isvalid_iyr(passport['iyr']):
        return False
    if not isvalid_eyr(passport['eyr']): 
        return False
    if not isvalid_hgt(passport['hgt']): 
        return False
    if not isvalid_hcl(passport['hcl']): 
        return False
    if not isvalid_ecl(passport['ecl']): 
        return False
    if not isvalid_pid(passport['pid']): 
        return False

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