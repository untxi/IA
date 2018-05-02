# Tecnologico de Costa Rica
# Escuela de Ing en Computacion
# Curso de Inteligencia Artificial
# Neurona
# Problema de Categorizacion, Redes Neuronales
# Samantha Arburola, Mayo 2018



class Neuron:
    def __init__(self):
        self.realDataC1 = []
        self.realDataC2 = []
        self.realData   = []
    

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

    def Training(self):
        return True

        
    def Classify(self):
        return True