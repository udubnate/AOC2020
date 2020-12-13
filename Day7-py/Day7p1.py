# Struggled with this one. used help from Dylan Codes - https://www.youtube.com/watch?v=7IOd7wvxDX0

with open ('day7.txt') as file:
    data = file.readlines()
    data = [ line.strip() for line in data ]


def get_num_bags(color):
    # Doesn't start with 'shiny gold' and search all bags that contain shiny gold
    lines = [ line for line in data if color in line and line.index(color) != 0]
    allColors = []

    if len(lines) == 0:
        return []
    else:
        colors = [ line[:line.index(' bags')] for line in lines ]
        #recursive part
        colors = [ color for color in colors if color not in allColors]

        for color in colors:
            allColors.append(color)
            bags = get_num_bags(color)

            allColors += bags

        #get unique
        uniqueColors = []
        for color in allColors:
            if color not in uniqueColors:
                uniqueColors.append(color)
    
        return uniqueColors


colors = get_num_bags('shiny gold')
print(len(colors))

#part 2
def get_bag_count(color):
    rule = ''
    for line in data:
        if line[:line.index(' bags')] == color:
            rule = line

    if 'no' in rule:
        return 1

    rule = rule[rule.index('contain')+8:].split()

    i = 0
    total = 0
    while i < len(rule):
        count = int(rule[i])
        color = rule[i+1] + ' ' + rule[i+2]
        i += 4

        total += count * get_bag_count(color)
    
    return total+1

count = get_bag_count('shiny gold')
print(str(count-1))