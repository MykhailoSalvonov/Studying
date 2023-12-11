import cv2
import sys
import ContrastFilters
import LowFilters


def apply_filter(image_path, filter_matrix):
    image = cv2.imread(image_path)

    if image is None:
        raise ValueError(f"Не вдалося завантажити зображення за шляхом {image_path}")

    blue, green, red = cv2.split(image)

    blue_filtered = cv2.filter2D(blue, -1, filter_matrix)
    green_filtered = cv2.filter2D(green, -1, filter_matrix)
    red_filtered = cv2.filter2D(red, -1, filter_matrix)

    filtered_image = cv2.merge([blue_filtered, green_filtered, red_filtered])

    if '_filtered.jpg' in image_path:
        output_path = image_path
    else:
        output_path = image_path.replace('.jpg', '_filtered.jpg')
    cv2.imwrite(output_path, filtered_image)

    return output_path


if __name__ == "__main__":
    if len(sys.argv) != 4:
        sys.exit(1)

    img_path = sys.argv[1]

    if sys.argv[2] == 'Low':
        filters = LowFilters.filters
    else:
        filters = ContrastFilters.filters

    filter_matrix = filters[sys.argv[3]]

    out_path = apply_filter(img_path, filter_matrix)

    print(out_path)

