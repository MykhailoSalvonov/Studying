import generator
import plot
import numpy as np
from models import quadratic
from models import linear
from models import hexa
import os
os.environ["KMP_DUPLICATE_LIB_OK"] = "TRUE"

data = generator.generate_quadratic_points(-5, 15, 2, -3, 2, 10)
data = generator.add_noise(data)

shuffled_data = data.copy()
np.random.shuffle(shuffled_data)

x_input = np.array([pair[0] for pair in shuffled_data])
y_input = np.array([pair[1] for pair in shuffled_data])

quadratic.minimize_quadratic_function(x_input, y_input)
data2 = []
for i in range(-15, 15):
    x = i
    y = quadratic.function_quadratic(i).numpy().item()
    data2.append([x, y])

data3 = []
linear.minimize_linear_function(x_input, y_input)
for i in range(-5, 15):
    x = i
    y = linear.function_linear(i).numpy().item()
    data3.append([x, y])

data4 = []
hexa.minimize_hexa_function(x_input, y_input)
for i in range(-5, 15):
    x = i
    y = hexa.function_hexa(i).numpy().item()
    data4.append([x, y])

plot.show_plot(data, data2)
plot.show_plot(data, data3)
plot.show_plot(data, data4)
