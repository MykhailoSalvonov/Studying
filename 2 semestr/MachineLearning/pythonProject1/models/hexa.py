import tensorflow as tf

"""
Функція для мінімізації квадратичної функції f(X) = Q0 + Q1 * X + Q2 * X^2 + Q3 * X^4 + Q4 * X^6
"""

q0 = tf.Variable(tf.random.normal([]))
q1 = tf.Variable(tf.random.normal([]))
q2 = tf.Variable(tf.random.normal([]))

loss = []


def minimize_hexa_function(x, y):
    iterations = 1000

    def loss_function():
        return tf.reduce_mean(tf.square(y - function_hexa(x)))

    optimizer = tf.keras.optimizers.Adam(learning_rate=0.01)

    for epoch in range(iterations):
        optimizer.minimize(loss_function, var_list=[q0, q1, q2])

        if epoch % 50:
            loss.append(loss_function()/iterations)


def function_hexa(x):
    return q0 + q1 * x ** 2 + q2 * x ** 6
