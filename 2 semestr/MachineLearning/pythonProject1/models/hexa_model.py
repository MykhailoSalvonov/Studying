from models.base_model import BaseModel
import tensorflow as tf


class HexaModel(BaseModel):
    def __init__(self):
        super().__init__()
        self.q2 = tf.Variable(tf.random.normal([]))
        self.q3 = tf.Variable(tf.random.normal([]))

    def predict(self, x):
        return self.q0 + self.q1 * x ** 2 + self.q2 * x ** 4 + self.q3 * x ** 6

    def get_variables(self):
        return [self.q0, self.q1, self.q2, self.q3]
