#******************************************************************
# Instituto Tecnol�gico de Costa Rica
# Escuela de Ingeniería en Computación
# IC-6200 Inteligencia Artificial
# Tarea: Algortimo Genético para las N-Reinas
#
# Integrantes:
# - Melissa Molina Corrales
# - Liza Chaves Carranza
# - Samantha Arburola Leon
#******************************************************************

import random

cant_reinas = int(input("Ingrese la cantidad de reinas: "))

def generarIndividuos():
    individuo = []
    for x in range(cant_reinas):
        individuo.append(random.randrange(cant_reinas))
        
    return individuo


def generarPoblacion(cant_individuos):
    poblacion = []
    for x in range(cant_individuos):
        poblacion.append(generarIndividuos())

    return poblacion


def calcularFitnessIndividuo(individuo):
    ##Se podria poner 1 si en un array ninguna reina se mata o 0 si en un array las reinas se matan
    ##entonces en nuestro caso el mejor fitness seria los array que tengan 1 que es donde ninguna reina se mata

    if repetido(individuo) == (True or abs(individuo)):
        return 0
    else:
        return 1
    return random.randrange(2)
        

##Calcula el fitness y le coloca a cada inviduo su respetivo fitness para saber cual es buen individuo y cual no
##Ejemplo: [[2,3,4,5],1] buen individuo tiene 1 porque ninguna reina choca
##Ejemplo: [[2,4,5,6],0] no es un buen individuo porque tiene 0, osea las reinas chocan

def calcularFitness(poblacion):
    individuoConFitness = []
    PoblacionFitness = []
    for x in range(len(poblacion)):
        individuoConFitness.append(poblacion[x][:])
        individuoConFitness.append(calcularFitnessIndividuo(poblacion[x])) 
        PoblacionFitness.append(individuoConFitness[:])
        individuoConFitness = []
        ##print(individuoConFitness)
        ##print(PoblacionFitness)

    return PoblacionFitness
        

def AlgoritmoGenetico():

    individuosPorGeneracion = 10 #En cada generacion se crean 10 individuos
    poblacion = []
    BuenIndividuo = False
    mejorIndividuo = []
    
    ##Continua buscando hasta que encuentra un fitness de 1
    while(BuenIndividuo == False):
        poblacion = generarPoblacion(individuosPorGeneracion)
        poblacion = calcularFitness(poblacion)
        poblacion.sort(key = lambda k: k[1], reverse = True) ##Que los ordene por el mejor fitness en este caso ordena los que tienen 1 
        if(poblacion[0][1] == 1): ## Si el fitness es 1 lo agrega como mejor individuo ya que cualquiera que tenga un 1 es un buen individuo a elegir
            mejorIndividuo = poblacion[0][0]
            BuenIndividuo = True
        
    return mejorIndividuo


print("El mejor individuo es: ")
print(AlgoritmoGenetico())
    

    
