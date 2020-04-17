import tensorflow as tf
from tensorflow import keras
from tensorflow.keras import backend as K
from tensorflow.keras.layers import Dense, Activation, Dropout
from tensorflow.keras.optimizers import Adam
from tensorflow.keras.metrics import categorical_crossentropy
from tensorflow.keras import regularizers
from tensorflow.keras.preprocessing.image import ImageDataGenerator
from tensorflow.keras.models import Model, load_model, Sequential
from tensorflow.keras.preprocessing import image
import numpy as np
import matplotlib.pyplot as plt
import time
import os
from IPython.core.display import display, HTML
display(HTML("<style>.container { width:100% !important; }</style>"))

# needs to perform this check BEFORE tf and keras are imported
import platform
if platform.architecture()[0] != '64bit':
    print('Please run on 64 bit Python')
    exit()

from PIL import Image

input_file = open(r"CV Model\INPUT_FROM_GUI.txt","r")

# =============================================
# change to CHARLES if you are running this
USER = 'FINAL'
# =============================================
# we really should have just done this through git and used relative path... whatevs

# We switch between each of our computers with no git, so this is how we are doing it
if USER == 'KIRBY':
	path_to_h5 = r'C:\Users\kirby\Desktop\BirdUp\CV Model\birds-224-224-97.64.h5' 
elif USER == 'CHARLES':
	path_to_h5 = r'C:\Users\meser\BirdOutput\birds-224-224-97.64.h5'
elif USER == 'FINAL':
    # using relative path since it will be in this directory correctly. 
    path_to_h5 = r'CV Model\birds-224-224-97.64.h5'

if USER == 'KIRBY':
	imagePath = r'C:\Users\kirby\Desktop\BirdUp\Database\One-Of-Each-Bird\Blue_Jay.jpg'
elif USER == 'CHARLES':
	imagePath = r'C:\Users\meser\Backyard-Bird-Dataset\test\American Crow\zoyojqhxjt.jpg'
elif USER == 'FINAL':
    imagePath = input_file.read()

input_file.close()

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

# # construct the argument parser and parse the arguments
# ap = argparse.ArgumentParser()
# ap.add_argument("-i", "--images", required=True,
#     help="path to out input directory of images")
# args = vars(ap.parse_args())
# print("[INFO] loading pre-trained network...")
# model = load_model(args["model"])
# imagePath = args["images"]

# resized input image to what the testing images were
# image = ""
# try:
#     image = Image.open(imagePath)
#     image.thumbnail((300, 300))
#     image.save(imagePath)
#     print('[INFO] Image resized successfully')
# except (OSError, ValueError):
#     print('ERROR: RESIZING')

# dimensions of our images
img_width, img_height = 224, 224

# load the model we saved
model = load_model(path_to_h5)
model.compile(loss='binary_crossentropy',
              optimizer='rmsprop',
              metrics=['accuracy'])

# predicting images
img = image.load_img(imagePath, target_size=(img_width, img_height))
x = image.img_to_array(img)
x = np.expand_dims(x, axis=0)

# makes a prediction based on the input image
images = np.vstack([x])
classes = model.predict(images, batch_size=10)
classes = classes[0]

# gets the sum of all the values in the class array, adds up to a little over 100%
sum = 0
for i in range(len(classes)):
    sum += classes[i]

# creates a dictionary referencing each bird with its confidence value
dickt = dict(zip(bird_species, zip(classes)))
for key in dickt:
    print("%s: %s" % (key, dickt[key]))


final_bird = max(dickt, key=dickt.get)
not_bird = min(dickt, key=dickt.get)
print("We think this bird is a {}".format(final_bird))
print("We are least confident this bird is a {}".format(not_bird))

output_file = open(r"C:\Users\kirby\Desktop\BirdUp\CV Model\OUTPUT_TO_GUI.txt","w")

output_file.write(final_bird)
output_file.close()