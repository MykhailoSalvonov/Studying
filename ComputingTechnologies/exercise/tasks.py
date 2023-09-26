from calculation import funk
from ui import plot
from exercise import abstract_task, examples


class TaskOne(abstract_task.Task):
    def resolv_task(self, data):
        calculated_data = funk.calculate(data, 2, 0, 10, True)
        plot.show_plot(calculated_data, data)

    def getExampleData(self):
        return examples.task_1_example


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
