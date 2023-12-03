import math
import random
import simulated_annealing
import matplotlib.pyplot as plt

distances = {
    'AB': 11, 'AC': 17, 'AD': 21, 'AE': 32, 'AF': 22,
    'BC': 24, 'BD': 9, 'BE': 35, 'BF': 45,
    'CD': 42, 'CE': 19, 'CF': 12,
    'DE': 8, 'DF': 27,
    'EF': 28
}


def get_distance(a, b):
    return distances.get(a + b) or distances.get(b + a)


def init():
    nodes = ['A', 'B', 'C', 'D', 'E', 'F']
    random.shuffle(nodes)
    return nodes


def cost(route):
    return sum(get_distance(route[i], route[i+1]) for i in range(len(route)-1)) + get_distance(route[-1], route[0])


def random_neighbour(route):
    new_route = route[:]
    a, b = random.sample(range(len(route)), 2)
    new_route[a], new_route[b] = new_route[b], new_route[a]
    return new_route


def acceptance_probability(cost, new_cost, temperature):
        return math.exp(- (new_cost - cost) / temperature)



# Виклик алгоритму
state, c, states, costs = simulated_annealing.simulated_annealing(init, cost, random_neighbour, acceptance_probability,
                                            maxsteps=2000, debug=False)

print("Final route:", "->".join(state) + "->" + state[0], " cost:", c)
plt.plot(costs)
plt.ylabel('Cost')
plt.xlabel('Step')
plt.title('Simulated Annealing Training')
plt.show()