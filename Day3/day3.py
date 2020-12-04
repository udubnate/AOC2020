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

maxx = len(map[0])
maxy = len(map)

curx = 0
cury = 0

def move(x, y):
    return (x+3) % maxx, y+1

treecount = 0

while (cury < maxy):
    curx, cury = move(curx, cury)

    if cury >= maxy:
        break

    if map[cury][curx] == '#':
        treecount += 1

print(treecount)
