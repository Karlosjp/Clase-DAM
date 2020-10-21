#include <stdio.h>
#include <stdlib.h>

// guarda base y exponente en el puntero
void leer(double *base, double *exp){

    printf("Escribe la 'base, exponente': ");
    scanf(" %lf , %lf", base, exp);

}

int main(int argc, char *argv[]){

    double base, exponente;

    leer(&base, &exponente);

    printf("Base %.1lf\n", base);
    printf("Exponente %.1lf\n", exponente);

    return EXIT_SUCCESS;

}
