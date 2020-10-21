
#include <stdio.h>
#include <stdlib.h>

#define N 20

struct TPolinomio{
    double coeficiente[N];
    int grado;
};

struct TDatos{
    double potencia, resultado, x;
};

double elev(struct TPolinomio polinomio, struct TDatos dato){
    for (int j=0; j<=polinomio.grado; j++, dato.potencia*=dato.x)
        dato.resultado += polinomio.coeficiente[j] * dato.potencia;

    return dato.resultado;
}

void imprime(double resultado){
    printf("El resultado es: %.2lf \n", resultado);
}

int main(int argc, char *argv[]){
    struct TPolinomio polinomio;
    struct TDatos dato = {1, 0, 0};

    printf("Indicar el grado: ");
    scanf( " %i", &polinomio.grado);

    for(int i=0; i <polinomio.grado; i++){
        printf("Introducir los coeficientes: ");
        scanf(" %lf", &polinomio.coeficiente[i]);
    }

    printf("Dime el valor de x: ");
    scanf(" %lf", &dato.x);

    imprime(elev(polinomio, dato));
/*    for(int j=0; j<polinomio.grado; j++, dato.potencia*=dato.x)
        dato.resultado += polinomio.coeficiente[j] * dato.potencia;

    printf("Resultado es %.2lf \n", dato.resultado);
*/
    return EXIT_SUCCESS;

}
