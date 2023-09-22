import numpy as np


def calculate(points, r, u, dots_amount):
    if len(points) < 3:
        return None
    f = []

    for index, point in enumerate(points):
#        if index == 0:
#            start_point = get_extrapolation_point(points, 2 * point[0] - points[index+1][0], u)
#        elif index >= len(points)-1:
#            start_point = get_extrapolation_point(points, x_new1, u)

        x_values = split_interval(-1, 1, dots_amount)

        if r % 2 == 0:
            new_t = split_interval((points[index-1][0] + point[0])/2, (point[0] + points[index+1][0])/2, dots_amount)
        else:
            new_t = split_interval(points[0], points[index+1][0], dots_amount)

        for index_t, x in enumerate(x_values):
            f.append([new_t[index_t],
                      splice_20(points[index-1][1], point[1], points[index+1][1], x)])

    return f


def get_extrapolation_point(data, x_new1, degree=2):
    # degree - Ступінь полінома (2 для квадратичного)
    if degree > 3 or degree < 1:
        raise ValueError("Параметер degree мусить дорівнювати 1, 2 або 3.")

    x = np.array([item[0] for item in data])
    y = np.array([item[1] for item in data])

    coefficients = np.polyfit(x, y, degree)
    a, b, c, d = coefficients

    x_new = x_new1
    if degree == 1:
        y_new = a * x_new + b

    if degree == 2:
        y_new = a * x_new ** 2 + b * x_new + c

    if degree == 3:
        y_new = a * x_new ** 3 + b * x_new ** 2 + c * x + d

    return y_new


def split_interval(a, b, n):
    if n <= 1:
        return [a, b]

    step = (b - a) / (n - 1)
    points = [a + i * step for i in range(n)]
    return points


def splice_20(p_1, p, p1, x):
    return 1 / 8 * ((p_1 + 6 * p + p1) + 2 * (-p_1 + p1) * x + (p_1 - 2 * p + p1) * x ** 2)


def splice_21(p_2, p_1, p, p1, p2, x):
    return 1 / 48 * (- p_2 + 10 * p_1 - 18 * p + 10 * p1 - p2) * x ** 2 + \
        1 / 24 * (p_2 - 8 * p_1 + 8 * p1 - p2) * x + \
        1 / 48 * (- p_2 + 2 * p_1 + 46 * p + 2 * p1 - p2)


def splice_22(p_3, p_2, p_1, p, p1, p2, p3, x):
    return 1 / 288 * (p_3 - 12 * p_2 + 75 * p_1 - 128 * p + 75 * p1 - 12 * p2 + p3) * x ** 2 + \
        1 / 144 * (- p_3 + 10 * p_2 - 53 * p_1 + 53 * p1 - 10 * p2 + p3) * x + \
        1 / 288 * (p_3 - 4 * p_2 - 5 * p_1 + 304 * p - 5 * p1 - 4 * p2 + p3)


def splice_30(p_1, p, p1, p2, x):
    return 1 / 48 * (- p_1 + 3 * p - 3 * p1 + p2) * x ** 3 + \
        1 / 16 * (p_1 - p - p1 + p2) * x ** 2 + \
        1 / 16 * (- p_1 - 5 * p + 5 * p1 + p2) * x + \
        1 / 48 * (p_1 + 23 * p + 23 * p1 + p2)
