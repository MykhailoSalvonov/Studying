import os
import generator
import plot
import numpy as np

from models.linear_model import LinearModel
from models.quadratic_model import QuadraticModel
from models.hexa_model import HexaModel

os.environ["KMP_DUPLICATE_LIB_OK"] = "TRUE"

data_set_len = 400
train_set_len = int(data_set_len * 0.7)

data = generator.generate_quadratic_points(-5, 15, 2, -3, 2, data_set_len)
data = generator.add_noise(data)

shuffled_data = data.copy()
np.random.shuffle(shuffled_data)

x_full_set = np.array([pair[0] for pair in shuffled_data])
y_full_set = np.array([pair[1] for pair in shuffled_data])

x_train_set = x_full_set[:train_set_len]
x_test_set = x_full_set[train_set_len:]

y_train_set = y_full_set[:train_set_len]
y_test_set = y_full_set[train_set_len:]

quadratic_model_instance = QuadraticModel()
quadratic_model_instance.teach_model(x_train_set, y_train_set, x_test_set, y_test_set)

linear_model_instance = LinearModel()
linear_model_instance.teach_model(x_train_set, y_train_set, x_test_set, y_test_set)

hexa_model_instance = HexaModel()
hexa_model_instance.teach_model(x_train_set, y_train_set, x_test_set, y_test_set)

train_loss_by_model = [[1, linear_model_instance.loss_function(x_train_set, y_train_set)/len(y_train_set)],
                       [2, quadratic_model_instance.loss_function(x_train_set, y_train_set)/len(y_train_set)],
                       [3, hexa_model_instance.loss_function(x_train_set, y_train_set)/len(y_train_set)]]

test_loss_by_model = [[1, linear_model_instance.loss_function(x_test_set, y_test_set)/len(y_test_set)],
                      [2, quadratic_model_instance.loss_function(x_test_set, y_test_set)/len(y_test_set)],
                      [3, hexa_model_instance.loss_function(x_test_set, y_test_set)/len(y_test_set)]]
plot.show_plot(train_loss_by_model, test_loss_by_model)
