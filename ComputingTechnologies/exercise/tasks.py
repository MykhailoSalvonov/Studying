from calculation import funk
from calculation import sygnal_generator
from ui import plot
from exercise import abstract_task, examples


class TaskOne(abstract_task.Task):
    def resolv_task(self, data):
        calculated_data = funk.calculate(data, 2, 0, 10, True)
        plot.show_plot(calculated_data, data)

    def getExampleData(self):
        return examples.task_1_example

    def getTaskName(self):
        return "Практична робота №1"


class TaskTwo(abstract_task.Task):
    def resolv_task(self, data):
        index_x_array_base = [[i, item[0]] for i, item in enumerate(data)]
        index_y_array_base = [[i, item[1]] for i, item in enumerate(data)]

        index_x_array_new = funk.calculate(index_x_array_base, 2, 0, 100, False)
        index_y_array_new = funk.calculate(index_y_array_base, 2, 0, 100, False)

        output_array = [[index_x[1], index_y[1]] for index_x, index_y in zip(index_x_array_new, index_y_array_new)]
        output_array.append(output_array[0])

        plot.show_subplots(index_x_array_new, index_y_array_new)
        plot.show_plot(output_array, data)

    def getExampleData(self):
        return examples.task_2_example

    def getTaskName(self):
        return "Практична робота №2"


class TaskThree(abstract_task.Task):
    def resolv_task(self, data):
        calculated_data_20 = funk.calculate(data, 2, 0, 5, True)
        calculated_data_21 = funk.calculate(data, 2, 1, 5, True)
        calculated_data_22 = funk.calculate(data, 2, 2, 5, True)
        calculated_data_30 = funk.calculate(data, 3, 0, 5, True)
        plot.plot_multiple_data(data, calculated_data_20, calculated_data_21, calculated_data_22, calculated_data_30,
                                x_label='t', y_label='P_t')

    def getExampleData(self):
        return examples.task_1_example

    def getTaskName(self):
        return "Практична робота №3"


class TaskFour(abstract_task.Task):
    def resolv_task(self, data):
        t1 = -3
        t2 = 12
        a = 1
        b = -10
        c = -6
        num_points = 30

        random_points = funk.generate_random_points(t1, t2, a, b, c, num_points)

        approximated_points = funk.get_approximate_points(random_points)
        calculated_data_20 = funk.calculate(approximated_points, 2, 0, 5, True)
        plot.plot_multiple_data(random_points, approximated_points, calculated_data_20)

    def getExampleData(self):
        return examples.task_1_example

    def getTaskName(self):
        return "Практична робота №4"


class TaskFive(abstract_task.Task):
    def resolv_task(self, data):
        pure_signal = sygnal_generator.digital_signal(data)
        signal_with_noise = sygnal_generator.add_noise(pure_signal)
        low_component = funk.calculate(signal_with_noise, 5, 0, 1, True)

        for i in range(5):
            low_component = funk.calculate(low_component, 5, 0, 1, True)

        high_component = [[point[0], point[1] - noise[1]] for point, noise in zip(low_component, signal_with_noise)]

        plot.show_subplots(low_component, high_component)
        plot.plot_multiple_data(pure_signal, signal_with_noise, low_component)

    def getExampleData(self):
        return examples.task_5_example

    def getTaskName(self):
        return "Практична робота №5"


class TaskSix(abstract_task.Task):
    def resolv_task(self, data):
        calculated_data_21 = funk.subdivision(data, 1)

        plot.plot_multiple_data(data, calculated_data_21)


    def getExampleData(self):
        return sygnal_generator.modulated_signal(1, 10, 1, 80)

    def getTaskName(self):
        return "Практична робота №6"
