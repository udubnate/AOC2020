import re

def myfunction(mystr):
    print('my_function works.')
    print('Message: ' + mystr)

def isvalid_byr(x):
    if int(x) >= 1920 and int(x) <= 2002:
        return True
    else:
        return False

def isvalid_iyr(x):
    if int(x) >= 2010 and int(x) <= 2020:
        return True
    else:
        return False

def isvalid_eyr(x):
    if int(x) >= 2020 and int(x) <= 2030:
        return True
    else:
        return False

def isvalid_hgt(x):
    hgtnum = int(re.findall("\d+", x)[0])
    if "cm" in x:
        if hgtnum >= 150 and hgtnum <= 193:
            return True
        else:
            return False
    else:
        if hgtnum >= 59 and hgtnum <= 76:
            return True
        else:
            return False


def isvalid_hcl(x):
    hgtnum = int(re.findall("\d+", x)[0])
    return True

def isvalid_ecl(x):
    ecls = ['amb','blu','gry','grn','hzl','oth']
    if x in ecls:
        return True
    return False
    
