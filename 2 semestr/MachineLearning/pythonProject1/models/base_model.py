import tensorflow as tf


class BaseModel:
    def __init__(self):
        self.q0 = tf.Variable(tf.random.normal([]))
        self.q1 = tf.Variable(tf.random.normal([]))
        self.train_loss = []
        self.test_loss = []

    def predict(self, x):
        pass  # Реалізувати у файлі

    def teach_model(self, x_train, y_train, x_test, y_test):
        iterations = 5000

        def loss_function():
            return self.loss_function(x_train, y_train)

        optimizer = tf.keras.optimizers.Adam(learning_rate=0.01)

        for epoch in range(iterations):
            optimizer.minimize(loss_function, var_list=self.get_variables())

            if epoch % 100 == 0 and epoch != 0:
                print(loss_function()/len(x_train))
                self.train_loss.append([epoch, loss_function()/len(x_train)])

    def loss_function(self, x, y):
        return tf.sqrt(tf.reduce_mean(tf.square(y - self.predict(x))))

    def get_variables(self):
        return [self.q0, self.q1]
