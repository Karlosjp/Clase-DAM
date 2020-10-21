#include "contadores.h"
#include "general.h"

void unoACien();

struct TEjercicio contadores = {
    &unoACien,
    NULL
};

void contador(){
    int ejercicio;

    printf("¿Que ejercicio quieres ver?:\n"
        "1-1/- Contar de 1 a 100");
    scanf(" %i", &ejercicio);

    switch(ejercicio-1){
        case CONTAR:
            (*contadores.apartado[CONTAR])();
            break;
    }
}

void unoACien(){
    for (int k = 1; k <= 100; k++){
        printf("Numero %i\n",k);
    }
}
