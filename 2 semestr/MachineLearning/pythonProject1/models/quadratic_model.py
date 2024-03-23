from models.base_model import BaseModel
import tensorflow as tf


class QuadraticModel(BaseModel):
    def __init__(self):
        super().__init__()  # Викликаємо конструктор базового класу
        self.q2 = tf.Variable(tf.random.normal([]))

    def predict(self, x):
        return self.q0 + self.q1 * x + self.q2 * x ** 2

    def get_variables(self):
        return [self.q0, self.q1, self.q2]