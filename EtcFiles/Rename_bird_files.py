import os 
from pathlib import Path
import subprocess

bird_species = [
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


bird_species_files = [
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\American Crow"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\American Goldfinch"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\American Robin"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Black Capped Chickadee"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Blue Jay"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Brown Headed Cowbird"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Common Grackle"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Dark Eyed Junco"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Downy Woodpecker"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\European Starling"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Hairy Woodpecker"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\House Finch"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\House Sparrow"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Male Northern Cardinal"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Mourning Dove"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Purple Finch"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Red Bellied Woodpecker"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Red Winged Blackbird"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Song Sparrow"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Tufted Titmouse"
    "C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\White Breasted Nuthatch"
]

base_path = Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\One_Of_Each_Bird')

i = 0
j=4
# for j in range(len(bird_species)):
#     os.system('cd {}'.format(bird_species_files[j]))
for filename in os.listdir(base_path / bird_species[j]):
    new_filename = bird_species[j] + "__" + str(i) + ".jpg"
    os.rename(filename, new_filename) 
    i -= -1
    
  
