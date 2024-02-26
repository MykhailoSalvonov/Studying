import tensorflow as tf

"""
Функція для мінімізації квадратичної функції f(X) = Q0 + Q1 * X + Q2 * X^2 + Q3 * X^4 + Q4 * X^6
"""

q0 = tf.Variable(tf.random.normal([]))
q1 = tf.Variable(tf.random.normal([]))
q2 = tf.Variable(tf.random.normal([]))


def minimize_hexa_function(x, y):
    def loss_function():
        return tf.reduce_mean(tf.square(function_hexa(x) - y))

    optimizer = tf.keras.optimizers.Adam(learning_rate=0.01)

    for epoch in range(500):
        optimizer.minimize(loss_function, var_list=[q0, q1, q2])
        if epoch%100:
            print(loss_function())


def function_hexa(x):
    return q0 + q1 * x ** 2 + q2 * x ** 6
