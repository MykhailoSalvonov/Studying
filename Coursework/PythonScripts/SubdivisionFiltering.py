import numpy as np
import cv2
import sys
import SimpleFiltering
from Filters import Subdivision
from Filters import BSpline

def apply_subdivision(image, filter_matrix):
    a = SimpleFiltering.apply_filter(image, filter_matrix['A'])
    b = SimpleFiltering.apply_filter(image, filter_matrix['B'])
    c = SimpleFiltering.apply_filter(image, filter_matrix['C'])
    d = SimpleFiltering.apply_filter(image, filter_matrix['D'])

    n, m, r = a.shape
    scaled_image = np.zeros((2*n, 2*m, r)) 
    
    scaled_image[0::2, 0::2, :] = a
    scaled_image[0::2, 1::2, :] = b
    scaled_image[1::2, 0::2, :] = c
    scaled_image[1::2, 1::2, :] = d
    
    scaled_image = SimpleFiltering.apply_filter(scaled_image, BSpline.y40)

    return scaled_image

if __name__ == "__main__":
    if len(sys.argv) != 3:
        sys.exit(1)

    img_path = sys.argv[1]
    image = cv2.imread(img_path)

    if image is None:
        raise ValueError(f"Не вдалося завантажити зображення за шляхом {img_path}")

    filter_matrix = Subdivision.gamma[sys.argv[2]]
    filtered_image = apply_subdivision(image, filter_matrix)

    cv2.imwrite(img_path, filtered_image)
    print("1")