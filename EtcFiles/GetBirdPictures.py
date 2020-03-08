"""
This file just calls BBID to download 50 images of each kind of bird
"""

from subprocess import run
from shutil import move
from os import mkdir, listdir, path

num_of_images_per_search = 50

source = r'C:\Users\kirby\Desktop\BirdUp\bing'
parent_dir = r'C:\Users\kirby\Desktop\BirdUp\Bird Pictures'
try:
    mkdir(parent_dir)
except FileExistsError:
    pass

species = ["Black Capped Chickadee", "Dark Eyed Junco", "Downy Woodpecker", "Male Northern Cardinal", "Mourning Dove", "Blue Jay", "White Breasted Nuthatch", "American Robin", "Song Sparrow", "Common Grackle",
           "American Goldfinch", "Red Bellied Woodpecker", "House Finch", "Tufted Titmouse", "Hairy Woodpecker", "European Starling", "House Sparrow", "Red Winged Blackbird", "American Crow", "Brown Headed Cowbird", "Purple Finch"]

# for testing
# species = ["Northern Cardinal", "American Goldfinch"]

for i in range(len(species)):
    new_bird_folder = path.join(parent_dir, species[i])
    try:
        mkdir(new_bird_folder)
    except FileExistsError:
        pass
    run(['python', r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\BBID.py', '-s', '\"{}\"'.format(species[i]), '--limit', '{}'.format(num_of_images_per_search)]) # downloads 50(ish) images and puts them in 'bing'
    files = listdir(source)# lists all files in bing
    move(source, new_bird_folder)
  