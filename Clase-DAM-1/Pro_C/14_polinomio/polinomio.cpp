
#include <stdio.h>
#include <stdlib.h>

#define N 20

struct TPolinomio{
    double coeficiente[N];
    int grado;
};

struct TDatos{
    double x, potencia, resultado;
};

int main(int argc, char *argv[]){
    struct TPolinomio polinomio;
    struct TDatos dato = {0, 1, 0};

    printf("Indicar el grado: ");
    scanf( " %i", &polinomio.grado);

    for(int i=0; i <polinomio.grado; i++){
        printf("Introducir los coeficientes: ");
        scanf(" %lf", &polinomio.coeficiente[i]);
    }

    printf("Dime el valor de x: ");
    scanf(" %lf", &dato.x);

    for(int j=0; j<polinomio.grado; j++, dato.potencia*=dato.x)
        dato.resultado += polinomio.coeficiente[j] * dato.potencia;

    printf("Resultado es %.2lf \n", dato.resultado);

    return EXIT_SUCCESS;

}
