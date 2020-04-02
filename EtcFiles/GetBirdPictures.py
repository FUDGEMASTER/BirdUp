"""
This file just calls BBID to download 50 images of each kind of bird
"""

from subprocess import run
from shutil import move
from os import mkdir, listdir, path
from pathlib import Path

# =============================
num_of_images_per_search = 99
# =============================

this_file = path.abspath(path.dirname(__file__))
parent_dir = this_file / Path(r'Completed Queries')

species = [
    'American Crow',
    'American Goldfinch',
    'American Robin',
    'Black Capped Chickadee',
    'Blue Jay',
    'Brown Headed Cowbird',
    'Common Grackle',
    'Dark Eyed Junco',
    'Downy Woodpecker',
    'European Starling',
    'Hairy Woodpecker',
    'House Finch',
    'House Sparrow',
    'Male Northern Cardinal',
    'Mourning Dove',
    'Purple Finch',
    'Red Bellied Woodpecker',
    'Red Winged Blackbird',
    'Song Sparrow',
    'Tufted Titmouse',
    'White Breasted Nuthatch'
]

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
