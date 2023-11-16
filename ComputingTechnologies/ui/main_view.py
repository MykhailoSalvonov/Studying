import tkinter as tk
from ui import window
from tkinter import ttk
from exercise import tasks


def open_options_window(task):
    if task.getTaskName() == 'Практична робота №1':
        window.OptionWindow1(root, task)
    elif task.getTaskName() == 'Практична робота №2':
        window.OptionWindow2(root, task)
    elif task.getTaskName() == 'Практична робота №3':
        window.OptionWindow2(root, task)
    elif task.getTaskName() == 'Практична робота №4':
        window.OptionWindow2(root, task)
    elif task.getTaskName() == 'Практична робота №5':
        window.OptionWindow2(root, task)
    elif task.getTaskName() == 'Практична робота №6':
        window.OptionWindow3(root, task)


def on_combobox_select(event):
    global task

    selected_item = combobox.get()
    task = my_task_dict[selected_item]

    option_button["state"] = "active"
    plot_button["state"] = "active"


def show():
    root.title("Графік F(t)")
    root.geometry("500x100")

    combobox.pack(padx=10, pady=10)

    combobox.bind("<<ComboboxSelected>>", on_combobox_select)

    button_frame.columnconfigure(0, weight=1)
    button_frame.columnconfigure(1, weight=1)

    option_button.grid(row=0, column=0, sticky=tk.W + tk.E, padx=10, pady=10)
    option_button["state"] = "disabled"

    plot_button.grid(row=0, column=1, sticky=tk.W + tk.E, padx=10, pady=10)
    plot_button["state"] = "disabled"

    button_frame.pack(fill='x')

    root.mainloop()


global root
global combobox
global task

root = tk.Tk()
point_entries = []
button_frame = tk.Frame(root)

my_task_dict = {
    'Практична робота №1': tasks.TaskOne(),
    'Практична робота №2': tasks.TaskTwo(),
    'Практична робота №3': tasks.TaskThree(),
    'Практична робота №4': tasks.TaskFour(),
    'Практична робота №5': tasks.TaskFive(),
    'Практична робота №6': tasks.TaskSix(),
}

option_button = tk.Button(button_frame, text="Опції", command=lambda: open_options_window(task))
plot_button = tk.Button(button_frame, text="Зобразити графік", command=lambda: task.resolv_task(window.data))
combobox = ttk.Combobox(root,
                        values=list(my_task_dict.keys()),
                        height=5,
                        width=25)
