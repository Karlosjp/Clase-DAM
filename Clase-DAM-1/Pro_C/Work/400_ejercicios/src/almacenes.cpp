#include "general.h"
#include "almacenes.h"

void preguntaEdad();
void preguntaLetra();
void preguntaNombre();
void intercambioNum();

struct TEjercicio almacenar = {
    &preguntaEdad,
    &preguntaLetra,
    &preguntaNombre,
    &intercambioNum,
    NULL
};

void almacenes(){
    int ejercicio;

    printf("¿Que ejercicio quieres ver?:\n"
        "1*1/- Preguntar edad"
        "1-2/- Preguntar letra"
        "1-3/- Preguntar Nombre"
        "1-4/- Incercambiar numeros");
    scanf(" %i", &ejercicio);

    switch(ejercicio-1){
        case EDAD:
            (*almacenar.apartado[EDAD])();
            break;
        case LETRA:
            (*almacenar.apartado[LETRA])();
            break;
        case NOMBRE:
            (*almacenar.apartado[NOMBRE])();
            break;
        case NUMERO:
            (*almacenar.apartado[NUMERO])();
            break;
    }
}

void preguntaEdad(){
    int edad;

    printf("¿Cual es tu edad?: ");
    scanf(" %i",&edad);

    printf("Tienes %i años\n", edad);
}

void preguntaLetra(){
    char letra;

    printf("Escribe una letra: ");
    scanf(" %c",&letra);

    printf("La letra es %c\n",letra);
}

void preguntaNombre(){
    char nombre[10];

    printf("Escribe tu nombre: ");
    scanf(" %s", nombre);

    printf("Tu nombre es %s\n", nombre);
}

void intercambioNum(){
    printf("En proceso\n");
}
