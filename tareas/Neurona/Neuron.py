# Tecnologico de Costa Rica
# Escuela de Ing en Computacion
# Curso de Inteligencia Artificial
# Neurona
# Problema de Categorizacion, Redes Neuronales
# Samantha Arburola, Mayo 2018

# Library
import random


class Neuron:
    def __init__(self):
        self.realDataC1 = []
        self.realDataC2 = []
        self.realData   = []
        self.x  = 0
        self.y  = 0
        self.b  = 1
        self.w1 = 0
        self.w2 = 0
        self.d  = 0
    

    def setConjD(self, listD):
        self.realData = listD
    

    def setConjC1(self, listC1):
        self.realDataC1 = listC1
    

    def setConjC2(self, listC2):
        self.realDataC2 = listC2

    
    def setConjuts(self, listD, listC1, listC2):
        self.realData = listD
        self.realDataC1 = listC1
        self.realDataC2 = listC2


    def showData(self):
        print (self.realData)


    def getConjD(self):
        return self.realData


    def getConjC1(self):
        return self.realDataC1

        
    def getConjC2(self):
        return self.realDataC2

    def correction(self, point):        
        if (self.realDataC2.find(point)) and self.y == -1:
                self.d = 1
        if (point in self.realDataC2) and self.y == 1:
                self.d = -1

        self.w1 = self.w1 + self.d * self.x
        self.w2 = self.w2 + self.d * self.y
        self.b  = self.b  + self.d
        
    def training(self):
        self.w1 = random.random()
        self.w2 = random.random()
        self.b  = random.random()

        for point in self.realData:
            print(point) # ToDo
        
    def classify(self, w1, w2, b):
        temp = (self.x * self.w1) + (self.y * self.w2) + self.b
        if temp >= 0:
            return 1
        if temp < 0:
            return -1

    def consultPoint(self, myX, myY):
        print('Conjunto: ')