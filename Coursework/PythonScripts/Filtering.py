import cv2
import sys
import ContrastFilters
import LowFilters
import HighFilters


def apply_filter(image_path, filter_matrix):
    blue, green, red = cv2.split(image)

    blue_filtered = cv2.filter2D(blue, -1, filter_matrix)
    green_filtered = cv2.filter2D(green, -1, filter_matrix)
    red_filtered = cv2.filter2D(red, -1, filter_matrix)

    filtered_image = cv2.merge([blue_filtered, green_filtered, red_filtered])

    return filtered_image


if __name__ == "__main__":
    if len(sys.argv) != 4:
        sys.exit(1)

    img_path = sys.argv[1]

    if sys.argv[2] == 'Low':
        filters = LowFilters.filters
    elif sys.argv[2] == 'High':
        filters = HighFilters.filters
    elif sys.argv[2] == 'Contrast':
        filters = ContrastFilters.filters
    else
        raise ValueError(f"Невідомий тип фільтру {sys.argv[2]}")

    filter_matrix = filters[sys.argv[3]]

    image = cv2.imread(img_path)

    if image is None:
        raise ValueError(f"Не вдалося завантажити зображення за шляхом {img_path}")

    filtered_image = apply_filter(image, filter_matrix)

    if '_filtered.jpg' in img_path:
        output_path = img_path
    else:
        output_path = img_path.replace('.jpg', '_filtered.jpg')
    cv2.imwrite(output_path, filtered_image)

    print(out_path)

