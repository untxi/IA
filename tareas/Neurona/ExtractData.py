# Tecnologico de Costa Rica
# Escuela de Ing en Computacion
# Curso de Inteligencia Artificial
# Extraer Tuplas
# Extraer Tuplas de un archivo .tdata en una lista 
# para los conjuntos C, C2 y D
# Samantha Arburola, Mayo 2018

#Library
import os
import os.path

#aux

def extractTuple(tupleInString):
    listOfTuples = []
    tupleInString = tupleInString.split(' ')
    for x in tupleInString:
        x = x.replace(')','')
        x = x.replace('(','')
        x = x.split(',')
        new = (int(x[0]), int(x[1]))
        listOfTuples.append(new)

    return listOfTuples

def fileExist(filePath):
    if os.path.isfile(filePath) and os.access(filePath, os.R_OK) \
        and (filePath[len(filePath)-6 :] == ".tdata"):
        return True
    else:
        return False


class ExtractData():
    def __init__(self):
        self.filePath = ""
        self.realData = [] 
        self.realDataC1 = []
        self.realDataC2 = []


    def setFile(self, pFile):
        self.filePath = pFile

    def getConjD(self):
        return self.realData


    def getConjC1(self):
        return self.realDataC1


    def getConjC2(self):
        return self.realDataC2

    def showData(self):
        print(self.realData)

    
    def readData(self, setBelongs):
        if (fileExist(self.filePath)):
            myList = []
            myFile = open(self.filePath, 'r')
            myFileLines = myFile.readlines()
            for line in myFileLines:
                temp = extractTuple(line)
                myList.extend(temp)
                        
            myFile.close()
            
            if setBelongs == 1:
                self.realDataC1 = myList
            if setBelongs == 2:
                self.realDataC2 = myList

            self.realData = self.realDataC1 + self.realDataC2
        else:
            print ("Either file is missing or is not readable")

        

myData = ExtractData()
myData.setFile("planeC1.tdata")
myData.readData(1)
myData.showData()
