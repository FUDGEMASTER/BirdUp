"""
This file just calls BBID to download 50 images of each kind of bird
"""

from subprocess import run
from shutil import move
from os import mkdir, listdir, path
from pathlib import Path

num_of_images_per_search = 50

this_file = path.abspath(path.dirname(__file__))
parent_dir = this_file / Path(r'Completed Queries')

species = ["Black Capped Chickadee", "Dark Eyed Junco", "Downy Woodpecker", "Male Northern Cardinal", "Mourning Dove", "Blue Jay", "White Breasted Nuthatch", "American Robin", "Song Sparrow", "Common Grackle",
           "American Goldfinch", "Red Bellied Woodpecker", "House Finch", "Tufted Titmouse", "Hairy Woodpecker", "European Starling", "House Sparrow", "Red Winged Blackbird", "American Crow", "Brown Headed Cowbird", "Purple Finch"]

# for testing
# species = ["Northern Cardinal", "American Goldfinch"]

def search_and_dump(query, quantity):
    new_search_folder = parent_dir / Path('{}'.format(query))
    try:
        mkdir(new_search_folder)
    except FileExistsError:
        pass
    # not bothering making BBID a relative path since the script is not repeated
    run(['python', r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\BBID.py' , '-s',
         '\"{}\"'.format(query), '-o', r'{}'.format(new_search_folder), '--limit', '{}'.format(quantity)])


try:
    mkdir(parent_dir)
except FileExistsError:
    pass
for i in range(len(species)):
    search_and_dump(species[i], num_of_images_per_search)

  