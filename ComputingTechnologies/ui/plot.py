import matplotlib.pyplot as plt


def show_plot(zip_calculated_data, zip_basic_data):
    if zip_calculated_data:
        plt.plot(*zip(*zip_calculated_data), marker='o', linestyle='-')
        plt.plot(*zip(*zip_basic_data), marker='o', linestyle='--')
        plt.xlabel('t')
        plt.ylabel('P(t)')
        plt.title('Графік')
        plt.grid(True)
        plt.show()


def show_subplots(zip_data_1, zip_data_2):
    if zip_data_1:
        fig, (ax1, ax2) = plt.subplots(1, 2, figsize=(10, 5))

        # Перший графік
        ax1.plot(*zip(*zip_data_1))
        ax1.set_title('Перший графік')
        ax1.set_xlabel('t')
        ax1.set_ylabel('x')
        ax1.legend()

        # Другий графік
        ax2.plot(*zip(*zip_data_2))
        ax2.set_title('Другий графік')
        ax2.set_xlabel('t')
        ax2.set_ylabel('y')
        ax2.legend()

        # Відображення графіків
        plt.tight_layout()
        plt.show()
