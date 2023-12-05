import cv2
import numpy as np
import sys

y1 = np.array([
      [3.75457E-09, 8.93587E-07, 5.40282E-06, -7.38748E-05, 5.40282E-06, 8.93587E-07, 3.75457E-09],
      [8.93587E-07, 2.12674E-05, 1.285871E-03, -1.758221E-02, 1.285871E-03, 2.12674E-05, 8.93587E-07],
      [5.40282E-06, 1.285871E-03, 7.774658E-03, -1.06305883E-01, 7.774658E-03, 1.285871E-03, 5.40282E-06],
      [-7.38748E-05, -1.758221E-02, -1.06305883E-01, 1.45356119, -1.06305883E-01, -1.758221E-02, -7.38748E-05],
      [5.40282E-06, 1.285871E-03, 7.774658E-03, -1.06305883E-01, 7.774658E-03, 1.285871E-03, 5.40282E-06],
      [8.93587E-07, 2.12674E-05, 1.285871E-03, -1.758221E-02, 1.285871E-03, 2.12674E-05, 8.93587E-07],
      [3.75457E-09, 8.93587E-07, 5.40282E-06, -7.38748E-05, 5.40282E-06, 8.93587E-07, 3.75457E-09]
])

y2 =  np.array([
      [1.24562E-08, 2.96456E-06, 1.59314E-05, -0.000149424, 1.59314E-05, 2.96456E-06, 1.24562E-08],
      [2.96456E-06, 0.000705566, 0.003791678, -0.035562919, 0.003791678, 0.000705566, 2.96456E-06],
      [1.59314E-05, 0.003791678, 0.020376288, -0.191113331, 0.020376288, 0.003791678, 1.59314E-05],
      [-0.000149424, -0.035562919, -0.191113331, 1.792490633, -0.191113331, -0.035562919, -0.000149424],
      [1.59314E-05, 0.003791678, 0.020376288, -0.191113331, 0.020376288, 0.003791678, 1.59314E-05],
      [2.96456E-06, 0.000705566, 0.003791678, -0.035562919, 0.003791678, 0.000705566, 2.96456E-06],
      [1.24562E-08, 2.96456E-06, 1.59314E-05, -0.000149424, 1.59314E-05, 2.96456E-06, 1.24562E-08]
])


def apply_filter_to_image(image_path):
    image = cv2.imread(image_path)
    filter_matrix = y1

    if image is None:
        raise ValueError(f"Не вдалося завантажити зображення за шляхом {image_path}")

    blue, green, red = cv2.split(image)

    blue_filtered = cv2.filter2D(blue, -1, filter_matrix)
    green_filtered = cv2.filter2D(green, -1, filter_matrix)
    red_filtered = cv2.filter2D(red, -1, filter_matrix)

    filtered_image = cv2.merge([blue_filtered, green_filtered, red_filtered])

    output_path = image_path.replace('.jpg', '_filtered.jpg')
    cv2.imwrite(output_path, filtered_image)

    return output_path


if __name__ == "__main__":
    if len(sys.argv) != 2:
        sys.exit(1)

    print("I'M HERE!!!!")
    image_path = sys.argv[1]
    output_path = apply_filter_to_image(image_path)

    print(output_path)

