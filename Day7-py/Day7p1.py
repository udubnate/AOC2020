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
        colors = [ lines[:line.index(' bags')]]

    for line in lines:
        print(line)


get_num_bags('shiny gold')