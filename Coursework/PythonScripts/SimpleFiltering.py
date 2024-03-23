import numpy as np
import cv2
import sys
from Filters import Contrast
from Filters import LowFrequency
from Filters import HighFrequency


def apply_filter(image, filter_matrix):
    blue, green, red = cv2.split(image)
    
    blue_filtered = np.clip(cv2.filter2D(blue.astype(np.float32), -1, filter_matrix), 0, 255).astype(np.uint8)
    green_filtered = np.clip(cv2.filter2D(green.astype(np.float32), -1, filter_matrix), 0, 255).astype(np.uint8)
    red_filtered = np.clip(cv2.filter2D(red.astype(np.float32), -1, filter_matrix), 0, 255).astype(np.uint8)

    filtered_image = cv2.merge([blue_filtered, green_filtered, red_filtered])

    return filtered_image



if __name__ == "__main__":
    if len(sys.argv) != 4:
        sys.exit(1)

    img_path = sys.argv[1]
    image = cv2.imread(img_path)

    if image is None:
        raise ValueError(f"Не вдалося завантажити зображення за шляхом {img_path}")

    if sys.argv[2] == 'Low':
        filter_matrix = LowFrequency.filters[sys.argv[3]]
        filtered_image = apply_filter(image, filter_matrix)
    elif sys.argv[2] == 'High':
        filter_matrix = HighFrequency.filters[sys.argv[3]]
        filtered_image = apply_filter(image, filter_matrix)
    elif sys.argv[2] == 'Contrast':
        filter_matrix = Contrast.filters[sys.argv[3]]
        filtered_image = apply_filter(image, filter_matrix)
    else:
        raise ValueError(f"Невідомий тип фільтру {sys.argv[3]}")

    

    cv2.imwrite(img_path, filtered_image)
    print("1")