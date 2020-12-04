with open('Day3/day3.txt','r') as file:
    data = file.readlines()

# create 2D array (list)
map = []
for line in data:
    column = []
    for j in range(len(line)):
        if line[j] == '\n':
            break
        column.append(line[j])
    map.append(column)

#slopes
slopes = [[1,1],[3,1],[5,1],[7,1],[1,2]]
finalvalue = 1
for slope in slopes:

    maxx = len(map[0])
    maxy = len(map)

    curx = 0
    cury = 0

    def move(x, y, s1, s2):
        return (x+s1) % maxx, y+s2

    treecount = 0

    while (cury < maxy):
        curx, cury = move(curx, cury, slope[0], slope[1])

        if cury >= maxy:
            break

        if map[cury][curx] == '#':
            treecount += 1

    finalvalue *= treecount
    print(treecount)
print(f"The Final Value is {finalvalue}")
