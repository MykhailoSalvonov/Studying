import numpy as np
import random

def calculate(points, r=2, u=0, dots_amount=10, need_extrapolation=True):
    if len(points) < 3:
        return None

    if u < 0 or u > 3:
        raise ValueError("Параметер u мусить дорівнювати 0, 1, 2 або 3.")

    if r > 3 or r < 1:
        raise ValueError("Параметер r мусить дорівнювати 1, 2 або 3.")

    f = []
    t_step = points[1][0] - points[0][0];
    x_values_temp = split_interval(-1, 1, dots_amount)

    for index, point in enumerate(points):
        if r % 2 == 0:
            new_t_temp = split_interval((2 * point[0] - t_step) / 2, (2 * point[0] + t_step) / 2, dots_amount)
        else:
            new_t_temp = split_interval(point[0], point[0] + t_step, dots_amount)

        new_t = [x for x in new_t_temp if points[0][0] <= x <= points[len(points) - 1][0]]
        start_index = new_t_temp.index(new_t[0])
        x_values = x_values_temp[start_index:start_index + len(new_t)]

        for index_t, x in enumerate(x_values):
            if r == 2:
                if u == 0:
                    p_t = splice_20(x, points, point, index, t_step, need_extrapolation)
                if u == 1:
                    p_t = splice_21(x, points, point, index, t_step, need_extrapolation)
                if u == 2:
                    p_t = splice_22(x, points, point, index, t_step, need_extrapolation)
            elif r == 3:
                if u == 0:
                    p_t = splice_30(x, points, point, index, t_step, need_extrapolation)
                if u == 1:
                    p_t = splice_31(x, points, point, index, t_step, need_extrapolation)
                if u == 2:
                    p_t = splice_32(x, points, point, index, t_step, need_extrapolation)

            if p_t is None:
                continue
            else:
                f.append([new_t[index_t], p_t])
    return f


def get_extrapolation_point(data, x_new1, degree=2):
    x = np.array([item[0] for item in data])
    y = np.array([item[1] for item in data])

    coefficients = np.polyfit(x, y, degree)

    x_new = x_new1
    if degree == 1:
        a, b = coefficients
        y_new = a * x_new + b

    if degree == 2:
        a, b, c = coefficients
        y_new = a * x_new ** 2 + b * x_new + c

    if degree == 3:
        a, b, c, d = coefficients
        y_new = a * x_new ** 3 + b * x_new ** 2 + c * x_new + d

    return y_new


def split_interval(a, b, n):
    if n <= 1:
        return [a, b]

    step = (b - a) / (n - 1)
    points = [a + i * step for i in range(n)]
    return points


def splice_20(x, points, current_point, current_index, t_step, need_extrapolation):
    if current_index == 0 or current_index == len(points)-1:
        if need_extrapolation:
            p_1 = get_extrapolation_point(points, current_point[0] - t_step, 2) if current_index == 0 \
                else points[current_index - 1][1]
            p1 = get_extrapolation_point(points, current_point[0] + t_step, 2) if current_index == len(points)-1 \
                else points[current_index + 1][1]
        else:
            return None
    else:
        p_1 = points[current_index - 1][1]
        p1 = points[current_index + 1][1]

    p = current_point[1]

    return 1 / 8 * ((p_1 + 6 * p + p1) + 2 * (-p_1 + p1) * x + (p_1 - 2 * p + p1) * x ** 2)


def splice_21(x, points, current_point, current_index, t_step, need_extrapolation):
    if current_index <= 2 or current_index >= len(points)-2:
        if need_extrapolation:
            p_2 = get_extrapolation_point(points, current_point[0] - 2 * t_step, 2) if current_index <= 1 \
                else points[current_index - 2][1]
            p_1 = get_extrapolation_point(points, current_point[0] - t_step, 2) if current_index == 0 \
                else points[current_index - 1][1]
            p1 = get_extrapolation_point(points, current_point[0] + t_step, 2) if current_index == len(points)-1 \
                else points[current_index + 1][1]
            p2 = get_extrapolation_point(points, current_point[0] + 2 * t_step, 2) if current_index >= len(points)-2 \
                else points[current_index + 2][1]
        else:
            return None
    else:
        p_2 = points[current_index - 2][1]
        p_1 = points[current_index - 1][1]
        p1 = points[current_index + 1][1]
        p2 = points[current_index + 2][1]

    p = current_point[1]

    return 1 / 48 * (- p_2 + 10 * p_1 - 18 * p + 10 * p1 - p2) * x ** 2 + \
        1 / 24 * (p_2 - 8 * p_1 + 8 * p1 - p2) * x + \
        1 / 48 * (- p_2 + 2 * p_1 + 46 * p + 2 * p1 - p2)


def splice_22(x, points, current_point, current_index, t_step, need_extrapolation):
    if current_index <= 3 or current_index >= len(points)-3:
        if need_extrapolation:
            p_3 = get_extrapolation_point(points, current_point[0] - 3 * t_step, 2) if current_index <= 2 \
                else points[current_index - 1][1]
            p_2 = get_extrapolation_point(points, current_point[0] - 2 * t_step, 2) if current_index <= 1 \
                else points[current_index - 2][1]
            p_1 = get_extrapolation_point(points, current_point[0] - t_step, 2) if current_index == 0 \
                else points[current_index - 1][1]
            p1 = get_extrapolation_point(points, current_point[0] + t_step, 2) if current_index == len(points)-1 \
                else points[current_index + 1][1]
            p2 = get_extrapolation_point(points, current_point[0] + 2 * t_step, 2) if current_index >= len(points)-2 \
                else points[current_index + 2][1]
            p3 = get_extrapolation_point(points, current_point[0] + 3 * t_step, 2) if current_index >= len(points)-3 \
                else points[current_index + 2][1]
        else:
            return None
    else:
        p_3 = points[current_index - 3][1]
        p_2 = points[current_index - 2][1]
        p_1 = points[current_index - 1][1]
        p1 = points[current_index + 1][1]
        p2 = points[current_index + 2][1]
        p3 = points[current_index + 3][1]

    p = current_point[1]

    return 1 / 288 * (p_3 - 12 * p_2 + 75 * p_1 - 128 * p + 75 * p1 - 12 * p2 + p3) * x ** 2 + \
        1 / 144 * (- p_3 + 10 * p_2 - 53 * p_1 + 53 * p1 - 10 * p2 + p3) * x + \
        1 / 288 * (p_3 - 4 * p_2 - 5 * p_1 + 304 * p - 5 * p1 - 4 * p2 + p3)


def splice_30(x, points, current_point, current_index, t_step, need_extrapolation):
    if current_index == 0 or current_index >= len(points)-2:
        if need_extrapolation:
            p_1 = get_extrapolation_point(points, current_point[0] - t_step, 2) if current_index == 0 \
                else points[current_index - 1][1]
            p1 = get_extrapolation_point(points, current_point[0] + t_step, 2) if current_index == len(points)-1 \
                else points[current_index + 1][1]
            p2 = get_extrapolation_point(points, current_point[0] + 2 * t_step, 2) if current_index >= len(points)-2 \
                else points[current_index + 2][1]
        else:
            return None
    else:
        p_1 = points[current_index - 1][1]
        p1 = points[current_index + 1][1]
        p2 = points[current_index + 2][1]

    p = current_point[1]

    return 1 / 48 * (- p_1 + 3 * p - 3 * p1 + p2) * x ** 3 + \
        1 / 16 * (p_1 - p - p1 + p2) * x ** 2 + \
        1 / 16 * (- p_1 - 5 * p + 5 * p1 + p2) * x + \
        1 / 48 * (p_1 + 23 * p + 23 * p1 + p2)


def splice_31(x, points, current_point, current_index, t_step, need_extrapolation):
    return None


def splice_32(x, points, current_point, current_index, t_step, need_extrapolation):
    return None


def generate_random_points(t1, t2, a, b, c, num_points):
    points = []

    intervals = [(t1, t1 + 1), (t1 + 1, t2 - 1), (t2 - 1, t2)]
    interval_probs = [0.2, 0.6, 0.2]

    for _ in range(num_points):
        chosen_interval = random.choices(intervals, interval_probs)[0]
        x = random.uniform(chosen_interval[0], chosen_interval[1])

        e = random.uniform(-2, 2)
        #y = a * x ** 2 + b * x + c + e
        y = x ** 2

        points.append([x, y])

    points.sort(key=lambda point: point[0])
    return points


def get_approximate_points(base_points, intervals):
    t_min = min(base_points, key=lambda point: point[0])[0]
    t_max = max(base_points, key=lambda point: point[0])[0]

    points = []

    for k in range(intervals+1):
        previous_y = 0

        for i in range(10):
            t_begin = t_min + i * (t_max - t_min) / 2 ** k
            t_end = t_min + (1 + i) * (t_max - t_min) / 2 ** k

            if t_end>t_max:
                break

            y_points = [point[1] for point in base_points if t_begin <= point[0] <= t_end]

            if len(y_points) == 0:
                y = previous_y
            else:
                y = sum(y_points)/len(y_points)
                previous_y = y

            points.append([(t_begin+t_end)/2, y])

    points.sort(key=lambda point: point[0])
    return points

