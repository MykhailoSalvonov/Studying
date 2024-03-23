from models.base_model import BaseModel


class LinearModel(BaseModel):
    def predict(self, x):
        return self.q0 + self.q1 * x