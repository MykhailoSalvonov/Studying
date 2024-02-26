import numpy as np

def generate_quadratic_points(x0, x1, a, b, c, num_points):
    x_values = np.random.uniform(x0, x1, num_points)
    y_values = a * x_values ** 2 + b * x_values + c

    points = sorted(zip(x_values, y_values), key=lambda point: point[0])
    return points

def add_noise(signal_points):
    errors = np.random.normal(0, 10, len(signal_points))

    signal_with_errors = [[point[0], point[1] + error] for point, error in zip(signal_points, errors)]

    return signal_with_errors