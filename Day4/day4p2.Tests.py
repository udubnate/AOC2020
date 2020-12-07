from validation import *

byr_tests = {'2002': True, '2003': False, '1920': True, '1919': False}

print("BYR Tests")
for kvp in byr_tests:
    testresults = isvalid_byr(kvp) == byr_tests[kvp]
    print(kvp + " test results are " + str(testresults))

iyr_tests = {'2009': False, '2010': True, '2020': True, '2021': False}

print("IYR Tests")
for kvp in iyr_tests:
    testresults = isvalid_iyr(kvp) == iyr_tests[kvp]
    print(kvp + " test results are " + str(testresults))

eyr_tests = {'2019': False, '2020': True, '2030': True, '2031': False}

print("EYR Tests")
for kvp in eyr_tests:
    testresults = isvalid_eyr(kvp) == eyr_tests[kvp]
    print(kvp + " test results are " + str(testresults))

hgt_tests = {'60in': True, '190cm': True, '190in': False, '190': False}

print("HGT Tests")
for kvp in hgt_tests:
    testresults = isvalid_hgt(kvp) == hgt_tests[kvp]
    print(kvp + " test results are " + str(testresults))

hcl_tests = {'#123abc': True, '#123abz': False, '123abc': False}

print("HCL Tests")
for kvp in hgt_tests:
    testresults = isvalid_hcl(kvp) == hcl_tests[kvp]
    print(kvp + " test results are " + str(testresults))



