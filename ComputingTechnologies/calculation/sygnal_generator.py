import numpy as np


def modulated_signal(f1, f2, duration, sampling_rate):
    """
    Генерує дві синусоїди з частотами f1 та f2, модулює їх,
    і повертає результат у вигляді одного сигналу.

    :param f1: Частота першої синусоїди (в Гц)
    :param f2: Частота другої синусоїди (в Гц)
    :param duration: Тривалість сигналу (в секундах)
    :param sampling_rate: Частота дискретизації (відліків за секунду)
    :return: Масив NumPy з модульованим сигналом
    """
    t = np.linspace(0, duration, int(sampling_rate * duration), endpoint=False)
    sine1 = np.sin(2 * np.pi * f1 * t)
    sine2 = np.sin(2 * np.pi * f2 * t)
    modulated_signal = sine1 * sine2

    points = np.column_stack((t, modulated_signal))
    return points


def digital_signal(base_points):
    result = []

    for i in range(len(base_points) - 1):
        start, value = base_points[i]
        end, _ = base_points[i + 1]

        for j in range(int(start), int(end)):
            result.append([j, value])

    return result

def add_noise(signal_points):
    errors = np.random.normal(0, 0.2, len(signal_points))

    signal_with_errors = [[point[0], point[1] + error] for point, error in zip(signal_points, errors)]

    return signal_with_errors