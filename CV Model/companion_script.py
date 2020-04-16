# import the necessary packages
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

model = load_model(r'C:\Users\kirby\Desktop\BirdUp\CV Model\birds-224-224-97.64.h5')

f= open(r"C:\Users\kirby\Desktop\BirdUp\CV Model\INPUT_FROM_GUI.txt","r")

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
