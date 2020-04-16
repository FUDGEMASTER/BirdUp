from PIL import Image
from pathlib import Path
import os
import PIL
import string
import random
import pyautogui

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
    Path(r'EtcFiles\One-Of-Each-Bird\American_Crow.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\American_Goldfinch.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\American_Robin.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Black_Capped_Chickadee.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Blue_Jay.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Brown_Headed_Cowbird.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Common_Grackle.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Dark_Eyed_Junco.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Downy_Woodpecker.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\European_Starling.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Hairy_Woodpecker.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\House_Finch.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\House_Sparrow.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Male_Northern_Cardinal.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Mourning_Dove.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Purple_Finch.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Red_Bellied_Woodpecker.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Red_Winged_Blackbird.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Song_Sparrow.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\Tufted_Titmouse.jpg'),
    Path(r'EtcFiles\One-Of-Each-Bird\White_Breasted_Nuthatch.jpg')
]

# =============================================
# this loops through all pictures in a subdir

j = 20

# =============================================

def randomString(stringLength=10):
    """Generate a random string of fixed length """
    letters = string.ascii_lowercase
    return ''.join(random.choice(letters) for i in range(stringLength))

# for j in range(len(bird_species)):
base_path = str(bird_species_files[j])
for filename in os.listdir(base_path):
    try:
        if ('.jpg') not in filename:
            os.rename(filename, randomString() + '.jpg')
        if ('%') in filename:
            print('BAD FILE NAME\t:' + filename)
            new_filename = os.rename(filename, randomString() + '.jpg')
            print('NEW FILE NAME\t:' + str(new_filename))
    except FileNotFoundError:
        print('ERROR: CANNOT RENAME FILE')
        continue

for filename in os.listdir(base_path):
    try:
        image = Image.open(filename)
        image_rot_90 = image.rotate(90)
        image_rot_90.save('{}_rot_90.jpg'.format(filename[:-4]))
        print('Image rotated 90 degrees')
        image = Image.open(filename)
        image_flip = image.transpose(Image.FLIP_LEFT_RIGHT)
        image_flip.save('{}_flip.jpg'.format(filename[:-4]))
        print('Image flipped successfully')
    except (OSError, ValueError):
        print('ERROR: ROTATE OR FLIP')
        continue

for filename in os.listdir(base_path):
    try:
        image = Image.open(filename)
        greyscale_image = image.convert('L')
        greyscale_image.save('{}_greyscale.jpg'.format(filename[:-4]))
        print('Image greyscaled sucessfully')
    except (OSError, ValueError):
        print('ERROR: GREYSCALE')
        continue

# value error raised if .apsx file
for filename in os.listdir(base_path):
    try:
        image = Image.open(filename)
        image.thumbnail((300, 300))
        image.save(filename)
        print('Image resized successfully')
    except (OSError, ValueError):
        print('ERROR: RESIZING')
        continue

i = 0
## renames all files to gibberish. Its useful, I swear
for filename in os.listdir(base_path):
    try:
        new_filename = randomString() + ".jpg"
        os.rename(filename, new_filename) 
        i -= -1
        print('Image renamed sucessfully')
    except PermissionError:
        print('ERROR: NAMING')
        continue

# for filename in os.listdir(base_path):
#     try:
#         new_filename = bird_species[j] + '_train_' + "__" + str(i) + ".jpg"
#         os.rename(filename, new_filename) 
#         i -= -1
#         print('Image renamed sucessfully')
#     except PermissionError:
#         print('ERROR: NAMING')
#         continue

print("=============================================")
print('Please do {} next'.format(bird_species[j+1]))
print("Change j to {}".format(j+1))
print('=============================================')

pyautogui.moveTo(414, 1125)
pyautogui.click()
pyautogui.write("cd " + '"' + str(bird_species_files[j+1]) + '"')

