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
    'Purle Finch',
    'Red Bellied Woodpecker',
    'Red Winged Blackbird',
    'Song Sparrow',
    'Tufted Titmouse',
    'White Breasted Nuthatch'
]

base_path = Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries')

for j in range(len(bird_species)):
    i = 0
    subprocess.call(['cd', '{}'.format(base_path / bird_species[j])])
    for filename in os.listdir(base_path / bird_species[j]):
        new_filename = bird_species[j] + "_" + str(i) + ".jpg"
        os.rename(filename, new_filename) 
        i -= -1
        
  
