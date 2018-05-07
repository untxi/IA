# Tecnologico de Costa Rica
# Escuela de Ing en Computacion
# Curso de Inteligencia Artificial
# Problema de Categorizacion, Redes Neuronales
# Samantha Arburola, Mayo 2018
from ExtractData import *
from Neuron import *

myData = ExtractData()
myMind = Neuron()
#cargar datos
myData.setFile("planeC1.tdata")
myData.readData(1)
myMind.setConjC1(myData.getConjC1())
myData.setFile("planeC2.tdata")
myData.readData(2)
myMind.setConjC2(myData.getConjC2())
myMind.setConjD(myData.getConjD())

for x in myMind.realData:
    
#entrenar neurona