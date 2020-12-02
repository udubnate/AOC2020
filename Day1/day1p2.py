
with open('day1.txt','r') as file:
    data = file.readlines()

#print(data)
found = False
for num1 in data:
    for num2 in data:
        for num3 in data:
            val = int(num1) + int(num2) + int(num3)
            if (val == 2020):
                print("found one at " + num1 + " and " + num2 + " and " + num3 )
                mult1 = int(num1)  * int(num2) * int(num3)
                print("Multiplier is " + str(mult1))
                found = True
                break
        if found:
            break