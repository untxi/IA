"""
Se cree que los ninnos aprenden mediante un proceso llamado 
razonamiento por analogias, en el que intentan asociar objetos parecidos 
a otros que ya conocen, y los
intentan agrupar por categorias.

Suponga que un ninno ha visto alguna vez un leon en el zoo y que sabe 
que es peligroso, y lo ha representado internamente por el patron 
(1 1 0 1 0) 
Un dia va por la calle y se encuentra a un gato, que representaremos 
por el patron 
(1 1 1 0 1) 

Debe salir corriendo el ninno porque crea al verlo que se parece 
demasiado a un leon?
Modela esta situacion (el aprendizaje del leon y despues del gato)
mediante un perceptronmulticapa y mediante un algoritmo de aprendizaje 
no supervisado."""

# Referencias
"""
https://www.nebrija.es/~cmalagon/inco/ejercicios%20y%20practicas/Ejercicios_redes_neuronales.pdf
https://machinelearningmastery.com/implement-perceptron-algorithm-scratch-python/
"""

# Descripcion del Patron
"""
Patron de 5 bits
  Caracteristica                Porcentaje de Riesgo
       1           0                      1      0
0 presencia | siguiloso                 0.14    0.30
1 carnivoro | hervivoro                 0.35    0.10
2 venenoso  | no venenoso               0.25    0.20
3 tamanno >= |  tamanno < humano        0.10    0.30
    humano  
4 violentos | pasivo                    0.15    0.10

Problema: definir el limite de indica si es peligroso o no
"""

class Animal:
    def __init__(self, nombre, patron):
        self.nombre = nombre
        self.patron = patron
        self.peso   = 0
        self.peligro = 0

        #[0]
        if self.patron[0] == '1':
            self.peso += 0.14
        if self.patron[0] == '0':
            self.peso += 0.35
        #[1]
        if self.patron[1] == '1':
            self.peso += 0.30
        if self.patron[1] == '0':
            self.peso += 0.10
        #[2]
        if self.patron[2] == '1':
            self.peso += 0.20
        if self.patron[2] == '0':
            self.peso += 0.14
        #[3]
        if self.patron[3] == '1':
            self.peso += 0.10
        if self.patron[3] == '0':
            self.peso += 0.30
        #[0]
        if self.patron[4] == '1':
            self.peso += 0.15
        if self.patron[4] == '0':
            self.peso += 0.10
    
    def setPeligro(self, p):
        #if peligroso p=1
        #if !peligroso p =-1
        self.peligro = p 

        

# Establecer animal peligroso
leon = Animal("leon", "11010")
#leon.peligro = 1
toro = Animal("toro", "10011")
#toro.peligro = 1
rino = Animal("rinoceronte", "10011")
#rino.peligro = 1
oso  = Animal("oso", "11011")
#oso.peligro = 1
elefant = Animal("elefante", "10010")
#elefant.peligro = 1
# Establecer animal docil
gato = Animal("gato","11000")
#gato.peligro = -1
perro  = Animal("perro","11000")
#perro.peligro = -1
perico  = Animal("perico","10000")
#perico.peligro = -1
conejo  = Animal("conejo","10000")
#conejo.peligro = -1
#animales
animales  = [leon, toro, rino, oso, elefant, gato,  perro, perico, conejo]

def calculoPeligro(w, peso):
    if peso >= w:
        return -1
    if peso < w:
        return 1

class PeligroAnimal:
    def __init__(self):
        self.animales = {}
        self.animal  = None
        self.limite = 0.0
        self.promedioBuenos = 0.9
        self.promedioMalos = 1.1
        self.diferencia = 0

    def calculaDiferencia(self):
        self.promedioBuenos = 0
        self.promedioMalos  = 0
        for x in animales:
            if (x.peligro == 1):
                self.promedioMalos += x.peso
            if (x.peligro == -1):
                self.promedioBuenos += x.peso
        self.promedioBuenos = self.promedioBuenos/len(animales)
        self.promedioMalos = self.promedioMalos/len(animales)
        self.diferencia =  self.promedioBuenos - self.promedioMalos

    def train(self):        
        #w = w - (promedio de buenos - promedio de malos)
        w = 0.90
        #setea peligrosos
        for buddy in animales:
            buddy.peligro =calculoPeligro(w, buddy.peso)
            if (buddy.peligro == -1 and buddy.peso < self.promedioMalos):
                buddy.peligro = calculoPeligro(w, buddy.peso)
            if (buddy.peligro == 1 and buddy.peso > self.promedioMalos):
                self.diferencia = calculaDiferencia()
                w = (w - self.diferencia) * 0.2
            if self.diferencia == 0:
                w += 0.01
            buddy.peligro = calculoPeligro(w, buddy.peso)
        
        self.limite = w

    def printPeligro(self):
        for x in self.animales:
            print(x.nombre +": "+ str(x.peligro))



def main(p):
    myTest = PeligroAnimal()
    myTest.animales = animales
    for x in range(p):
        myTest.train()
    myTest.printPeligro()
    print("dif = " + str(myTest.diferencia))
    print(" w  = ")
    print(myTest.limite)


main(int(input("pasadas: ")))