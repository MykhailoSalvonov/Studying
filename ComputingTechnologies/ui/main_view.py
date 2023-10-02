import tkinter as tk
from tkinter import Entry
from tkinter import ttk
from exercise import tasks


class PointEntry:
    def __init__(self, master, row):
        self.master = master
        self.row = row

        self.label_p = tk.Label(master, text=f"t{row}:")
        self.label_p.grid(row=row, column=0, padx=10, pady=10, sticky="w")

        self.label_t = tk.Label(master, text=f"P(t{row}):")
        self.label_t.grid(row=row, column=2, padx=10, pady=10, sticky="w")

        self.entry_p = Entry(master)
        self.entry_p.grid(row=row, column=1, padx=10, pady=10)

        self.entry_t = Entry(master)
        self.entry_t.grid(row=row, column=3, padx=10, pady=10)

        master.pack(fill='x')

    def set_t(self, new_t):
        self.entry_t.insert(0, new_t)

    def set_p(self, new_p):
        self.entry_p.insert(0, new_p)


def add_empty_point():
    row = len(point_entries)
    new_point = PointEntry(point_frame, row)
    point_entries.append(new_point)


def add_point(p, t):
    row = len(point_entries)
    new_point = PointEntry(point_frame, row)

    new_point.set_p(p)
    new_point.set_t(t)

    point_entries.append(new_point)


def add_points(points):
    for point in points:
        add_point(point[0], point[1])


def clear():
    for widget in point_frame.winfo_children():
        widget.destroy()

    point_entries.clear()


def on_combobox_select(event):
    global task
    #global show_all_splines

    selected_item = combobox.get()
    task = my_task_dict[selected_item]

    add_button["state"] = "active"
    example_button["state"] = "active"
    plot_button["state"] = "active"
    clear_button["state"] = "active"

    clear()

#    if selected_item == 'Практична робота №3':
#        show_all_splines = tk.Checkbutton(button_frame, text="Усі В-сплайни")
#        show_all_splines.grid(row=0, column=4, sticky=tk.W + tk.E, padx=10, pady=10)
#        button_frame.pack(fill='x')
#    else:
#        try:
#            show_all_splines
#        except NameError:
#            pass
#        else:
#            show_all_splines.destroy()

def show():
    root.title("Графік F(t)")
    root.geometry("600x600")

    combobox.pack(padx=10, pady=10)

    # Додати обробник події для вибору елементу зі списку
    combobox.bind("<<ComboboxSelected>>", on_combobox_select)

    button_frame.columnconfigure(0, weight=1)
    button_frame.columnconfigure(1, weight=1)
    button_frame.columnconfigure(2, weight=1)
    button_frame.columnconfigure(3, weight=1)

    point_frame.columnconfigure(0, weight=1)
    point_frame.columnconfigure(1, weight=1)
    point_frame.columnconfigure(2, weight=1)
    point_frame.columnconfigure(3, weight=1)

    add_button.grid(row=0, column=0, sticky=tk.W + tk.E, padx=10, pady=10)
    add_button["state"] = "disabled"

    example_button.grid(row=0, column=1, sticky=tk.W + tk.E, padx=10, pady=10)
    example_button["state"] = "disabled"

    plot_button.grid(row=0, column=2, sticky=tk.W + tk.E, padx=10, pady=10)
    plot_button["state"] = "disabled"

    clear_button.grid(row=0, column=3, sticky=tk.W + tk.E, padx=10, pady=10)
    clear_button["state"] = "disabled"

    button_frame.pack(fill='x')

    root.mainloop()


def get_data():
    return [(float(entry.entry_p.get()), float(entry.entry_t.get())) for entry in point_entries]


global root
global point_entries
global button_frame
global combobox
global task

root = tk.Tk()
point_entries = []
button_frame = tk.Frame(root)
point_frame = tk.Frame(root)

my_task_dict = {
    'Практична робота №1': tasks.TaskOne(),
    'Практична робота №2': tasks.TaskTwo(),
    'Практична робота №3': tasks.TaskThree(),
    'Практична робота №4': tasks.TaskFour(),
}

add_button = tk.Button(button_frame, text="Додати точку", command=add_empty_point)
example_button = tk.Button(button_frame, text="Приклад", command=lambda: add_points(task.getExampleData()))
plot_button = tk.Button(button_frame, text="Зобразити графік", command=lambda: task.resolv_task(get_data()))
clear_button = tk.Button(button_frame, text="Очистити", command=clear)
combobox = ttk.Combobox(root,
                        values=list(my_task_dict.keys()),
                        height=5,
                        width=25)
