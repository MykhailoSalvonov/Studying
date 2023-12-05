import cv2
import sys
import Filters


def apply_filter_to_image(image_path):
    image = cv2.imread(image_path)
    filter_matrix = Filters.y4

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
    if len(sys.argv) != 2:
        sys.exit(1)

    img_path = sys.argv[1]
    out_path = apply_filter_to_image(img_path)

    print(out_path)

