# Makes sure 64 bit Python is running, or tf won't work.
import platform
if platform.architecture()[0] != '64bit':
    print('Please run on 64 bit Python')
    exit()

import tensorflow as tf
from tensorflow import keras
from tensorflow.keras import backend as K
from tensorflow.keras.layers import Dense, Activation, Dropout
from tensorflow.keras.optimizers import Adam
from tensorflow.keras.metrics import categorical_crossentropy
from tensorflow.keras import regularizers
from tensorflow.keras.preprocessing.image import ImageDataGenerator
from tensorflow.keras.models import Model, load_model, Sequential
import numpy as np
import time
import os
from PIL import Image


# =============================================
# change to CHARLES if you are running this
USER = 'KIRBY'
# =============================================
if USER == 'KIRBY':
	path_to_h5 = r'C:\Users\kirby\Desktop\BirdUp\CV Model\birds-224-224-97.64.h5' 
elif USER == 'CHARLES':
	path_to_h5 = r'C:\Users\meser\BirdOutput\birds-224-224-97.64.h5'

if USER == 'KIRBY':
	imagePath = r'C:\Users\kirby\Desktop\BirdUp\Database\One-Of-Each-Bird\American_Crow.jpg'
elif USER == 'CHARLES':
	imagePath = r'C:\Users\meser\Backyard-Bird-Dataset\test\American Crow\zoyojqhxjt.jpg'


input_file = open(r"C:\Users\kirby\Desktop\BirdUp\CV Model\INPUT_FROM_GUI.txt","r")

# # construct the argument parser and parse the arguments
# ap = argparse.ArgumentParser()
# ap.add_argument("-i", "--images", required=True,
#     help="path to out input directory of images")
# args = vars(ap.parse_args())
# print("[INFO] loading pre-trained network...")
# model = load_model(args["model"])
# imagePath = args["images"]

# resized input image to what the testing images were
try:
    image = Image.open(imagePath)
    image.thumbnail((300, 300))
    image.save(imagePath)
    print('[INFO] Image resized successfully')
except (OSError, ValueError):
    print('ERROR: RESIZING')

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

images = np.vstack([x])
classes = model.predict(images, batch_size=10)
print (classes)

# ==============================================================================
output_file = open(r"C:\Users\kirby\Desktop\BirdUp\CV Model\OUTPUT_TO_GUI.txt","w")