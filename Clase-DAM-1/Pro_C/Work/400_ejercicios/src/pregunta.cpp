#include "general.h"
#include "almacenes.h"
#include "pregunta.h"
#include "contadores.h"

void intro(){
    int eleccion;

    printf("¿Que grupo de ejercicios quieres hacer?: \n"
        "1/- Almacenes de datos\n"
        "2/- Contadores\n"
         );
    scanf(" %i", &eleccion);

    switch(eleccion-1){
        case ALMACENES:
            almacenes();
            break;
        case CONTADORES:
            contador();
            break;
        case BANDERAS:
            break;
        case ACUMULADORES:
            break;
        case ARRAYS:
            break;
        case CARACTERES:
            break;
        case CADENAS_CARA:
            break;
        case ARITMETICOS:
            break;
        case BITS:
            break;
        case PRIM_E_S:
            break;
        case CONTROL_ALTER:
            break;
        case CONTROL_ITER:
            break;
        default:
            printf("No esta en la lista");
    }
}
