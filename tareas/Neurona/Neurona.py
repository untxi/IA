# Tecnologico de Costa Rica
# Escuela de Ing en Computacion
# Curso de Inteligencia Artificial
# Neurona
# Problema de Categorizacion, Redes Neuronales
# Samantha Arburola, Mayo 2018

#Library
import os
import os.path

# Auxiliar Function
def FileExist(filePath):
    if os.path.isfile(filePath) and os.access(filePath, os.R_OK) and (filePath[len(filePath)-6 :] == ".tdata"):
        print ":)"
        return True
    else:
        print ":("
        return False


class Neuron:
    def __init__(self):
        self.realDataC1 = []
        self.realDataC2 = []
        self.realData = self.realDataC1 + self.realDataC2
    
    def getRealData(self, fileName, setBelongs):
        """ Read a .tdata file """
        try:
            # print "File exists and is readable"
            FileExist(fileName)
        except:
            print "Either file is missing or is not readable"
            return False
        
        myFile = open(fileName, 'r')
        myFile.readlines()

        for line in myFile:
            line = line.replace('\n', ' ')
            line.split(' ')
            for point in line:
                setBelongs.append(point)

        return True
    

    def Training(self):
        return True

        
    def Classify(self):
        return True
           


