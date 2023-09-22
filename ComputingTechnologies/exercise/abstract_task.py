from abc import ABC, abstractmethod


class Task(ABC):
    @abstractmethod
    def resolv_task(self, args):
        pass

    @abstractmethod
    def getExampleData(self):
        pass