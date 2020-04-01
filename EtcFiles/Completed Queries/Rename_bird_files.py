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
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\American Crow'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\American Goldfinch'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\American Robin'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Black Capped Chickadee'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Blue Jay'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Brown Headed Cowbird'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Common Grackle'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Dark Eyed Junco'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Downy Woodpecker'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\European Starling'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Hairy Woodpecker'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\House Finch'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\House Sparrow'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Male Northern Cardinal'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Mourning Dove'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Purple Finch'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Red Bellied Woodpecker'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Red Winged Blackbird'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Song Sparrow'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\Tufted Titmouse'),
    Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries\White Breasted Nuthatch')
]

base_path = Path(r'C:\Users\kirby\Desktop\BirdUp\EtcFiles\Completed Queries')

i = 0
j = 20
# for j in range(len(bird_species)):
#     os.system('cd {}'.format(bird_species_files[j]))
for filename in os.listdir(base_path / bird_species[j]):
    new_filename = bird_species[j] + "_" + str(i) + ".jpg"
    os.rename(filename, new_filename) 
    i -= -1
    
  
