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
        return True
    else:
        return False

    
def ExtractTuple(tupleInString):
    listOfTuples = []
    tupleInString = tupleInString.split(' ')
    for x in tupleInString:
        x = x.replace(')','')
        x = x.replace('(','')
        x = x.split(',')
        new = (int(x[0]), int(x[1]))
        listOfTuples.append(new)

    return listOfTuples

class Neuron:
    def __init__(self):
        self.realDataC1 = []
        self.realDataC2 = []
        self.realData   = []
    
    def getRealData(self, fileName, setBelongs):
        """ Read a .tdata file """
        try:
            # print "File exists and is readable"
            FileExist(fileName)
        except:
            print ("Either file is missing or is not readable")
            return False

        myList = []
        myFile = open(fileName, 'r')
        myFileLines = myFile.readlines()
        for line in myFileLines:
            myList.extend(ExtractTuple(line))
                    
        myFile.close()
        if setBelongs == 1:
            self.realDataC1 = myList
        if setBelongs == 2:
            self.realDataC2 = myList

        self.realData = self.realDataC1 + self.realDataC2
        return True
    
    def showData(self):
        print (self.realData)

    def Training(self):
        return True

        
    def Classify(self):
        return True
           


myNewbie = Neuron()
res1 = myNewbie.getRealData("planeC1.tdata", 1)
res2 = myNewbie.getRealData("planeC2.tdata", 2)
print ('=== D ===')
myNewbie.showData()
print ('=== D ===')
