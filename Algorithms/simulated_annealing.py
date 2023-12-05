import random


def simulated_annealing(init_function, cost_function, random_neighbour, acceptance_probability, maxsteps=2000,
                        debug=True):
    """Алгоритм відпалу

    :param init_function: функція без аргументів, яка повертає початкову точку
    :param cost_function: функція, яка приймає рішення і повертає його вартість
    :param random_neighbour: функція, яка приймає рішення і повертає одного з його сусідів
    :param acceptance_probability: функція, яка приймає різницю вартостей і температуру, і повертає ймовірність прийняття
    :param temperature: функція, яка приймає час і повертає температуру
    :param maxsteps: максимальна кількість кроків
    :param debug: чи виводити інформацію про процес
    """

    state = init_function()
    cost = cost_function(state)
    states, costs = [state], [cost]
    temperature = 100
    fraction = 0.003

    for step in range(maxsteps):
        temperature = 1 - temperature * fraction
        new_state = random_neighbour(state)
        new_cost = cost_function(new_state)

        if debug and step % 100 == 0:
            print("Step #{:>2}/{:>2} : T = {:>4.3g}, state = {}, cost = {}".format(step, maxsteps, temperature, state, cost))

        rand = random.random()
        accept = acceptance_probability(cost, new_cost, temperature)
        if accept > rand:
            state, cost = new_state, new_cost
            states.append(state)
            costs.append(cost)

    return state, cost_function(state), states, costs



