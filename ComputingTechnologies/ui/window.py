import tkinter as tk

class PointEntry:
    def __init__(self, master, row):
        self.master = master
        self.row = row

        self.label_p = tk.Label(master, text=f"t{row}:")
        self.label_p.grid(row=row, column=0, padx=10, pady=10, sticky="w")

        self.label_t = tk.Label(master, text=f"P(t{row}):")
        self.label_t.grid(row=row, column=2, padx=10, pady=10, sticky="w")

        self.entry_p = tk.Entry(master)
        self.entry_p.grid(row=row, column=1, padx=10, pady=10)

        self.entry_t = tk.Entry(master)
        self.entry_t.grid(row=row, column=3, padx=10, pady=10)

        master.pack(fill='x')

    def set_t(self, new_t):
        self.entry_t.insert(0, new_t)

    def set_p(self, new_p):
        self.entry_p.insert(0, new_p)

class BaseWindow(tk.Toplevel):
    def __init__(self, parent, task):
        super().__init__(parent)
        self.point_entries = []
        self.create_widgets(task)


    def create_widgets(self, task):
        pass

    def create_canvas_and_frames(self):
        self.canvas = tk.Canvas(self, width=400, height=400)
        self.canvas.pack(side=tk.LEFT, fill=tk.BOTH, expand=True)

        self.scrollbar = tk.Scrollbar(self, command=self.canvas.yview)
        self.scrollbar.pack(side=tk.LEFT, fill='y')

        self.canvas.configure(yscrollcommand=self.scrollbar.set)

        self.main_frame = tk.Frame(self.canvas)

        self.button_frame = tk.Frame(self.main_frame)
        self.point_frame = tk.Frame(self.main_frame)

    def add_point(self, p, t):
        row = len(self.point_entries)
        new_point = PointEntry(self.point_frame, row+1)

        new_point.set_p(p)
        new_point.set_t(t)

        self.point_entries.append(new_point)
        self.update_canvas_scrollregion()

    def add_points(self, points):
        for point in points:
            self.add_point(point[0], point[1])

    def clear_points(self):
        for widget in self.point_frame.winfo_children():
            widget.destroy()

        self.point_entries.clear()
        self.update_canvas_scrollregion()

    def apply(self):
        global data
        data = [(float(entry.entry_p.get()), float(entry.entry_t.get())) for entry in self.point_entries]
        self.destroy()

    def update_canvas_scrollregion(self):
        self.canvas.update_idletasks()
        self.canvas.config(scrollregion=self.canvas.bbox("all"))

class OptionWindow1(BaseWindow):
    def create_widgets(self, task):
        self.point_entries = []

        self.create_canvas_and_frames()

        self.add_button = tk.Button(self.button_frame, text="Додати точку",
                                    command=lambda: self.add_point("", ""))
        self.example_button = tk.Button(self.button_frame, text="Приклад",
                                        command=lambda: self.add_points(task.getExampleData()))
        self.clear_button = tk.Button(self.button_frame, text="Очистити", command=self.clear_points)
        self.apply_button = tk.Button(self.button_frame, text="Прийняти", command=self.apply)

        self.add_button.grid(row=0, column=0, sticky=tk.W + tk.E, padx=10, pady=10)
        self.example_button.grid(row=0, column=1, sticky=tk.W + tk.E, padx=10, pady=10)
        self.clear_button.grid(row=0, column=3, sticky=tk.W + tk.E, padx=10, pady=10)
        self.apply_button.grid(row=0, column=4, sticky=tk.W + tk.E, padx=10, pady=10)

        self.button_frame.pack(fill='x', pady=20, padx=20)
        self.point_frame.pack(pady=20, padx=20)

        self.canvas.create_window((0, 0), window=self.main_frame, anchor='nw')

        self.update_idletasks()
        self.canvas.config(scrollregion=self.canvas.bbox("all"))


class OptionWindow2(BaseWindow):
    def create_widgets(self, task):
        self.point_entries = []

        self.create_canvas_and_frames()

        self.add_button = tk.Button(self.button_frame, text="Додати точку",
                                    command=lambda: self.add_point("", ""))
        self.example_button = tk.Button(self.button_frame, text="Приклад",
                                        command=lambda: self.add_points(task.getExampleData()))
        self.clear_button = tk.Button(self.button_frame, text="Очистити", command=self.clear_points)
        self.apply_button = tk.Button(self.button_frame, text="Прийняти", command=self.apply)

        self.add_button.grid(row=0, column=0, sticky=tk.W + tk.E, padx=10, pady=10)
        self.example_button.grid(row=0, column=1, sticky=tk.W + tk.E, padx=10, pady=10)
        self.clear_button.grid(row=0, column=3, sticky=tk.W + tk.E, padx=10, pady=10)
        self.apply_button.grid(row=0, column=4, sticky=tk.W + tk.E, padx=10, pady=10)

        self.button_frame.pack(fill='x', pady=20, padx=20)
        self.point_frame.pack(pady=20, padx=20)

        self.canvas.create_window((0, 0), window=self.main_frame, anchor='nw')

        self.update_idletasks()
        self.canvas.config(scrollregion=self.canvas.bbox("all"))


class OptionWindow3(BaseWindow):
    def create_widgets(self, task):
        self.point_entries = []

        self.create_canvas_and_frames()

        self.example_button = tk.Button(self.button_frame, text="Приклад",
                                        command=lambda: self.add_points(task.getExampleData()))
        self.apply_button = tk.Button(self.button_frame, text="Прийняти", command=lambda: self.applyNew(task.getExampleData()))

        self.apply_button.grid(row=0, column=4, sticky=tk.W + tk.E, padx=10, pady=10)

        self.button_frame.pack(fill='x', pady=20, padx=20)
        self.point_frame.pack(pady=20, padx=20)

        self.canvas.create_window((0, 0), window=self.main_frame, anchor='nw')

        self.update_idletasks()
        self.canvas.config(scrollregion=self.canvas.bbox("all"))

    #додати метод який після натискання на кнопку "Приклад" виводить повідомлення що данні завантажені
    #зробити так що до натискання "Приклад" кнопка прийняти не активна

    def applyNew(self, task_data):
        global data
        data = task_data
        self.destroy()

data = []

