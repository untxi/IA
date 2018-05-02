# Tecnologico de Costa Rica
# Escuela de Ing en Computacion
# Curso de Inteligencia Artificial
# GenerarTuplas
# Generar archivo .tdata
# Contenido de tuplas de la forma (x,y) estrictamente y 
# usando como separador " "
# Samantha Arburola, Mayo 2018

class GenTuples():
    def __init__(self):
        self.fileName = ""  

    
    def createFile(self, nameToSave):
        self.file = open((nameToSave + ".tdata"), "w")
    
    def writeFile(self, words):
        self.file.write(words)
    
    def finish(self):
        self.file.close()

    def addTuple(self, x, y):
        self.file.write('('+str(x)+','+str(y)+') ')

    def addMultiTuple(self):
        print("Write tuple: 'x,y', if job is done write 'end'")
        run = True
        while run:
            opt = str(input(">> "))
            print(opt)
            if opt != "end":
                self.file.write(opt + ' ')
            else:
                run = False