#include <stdio.h>
#include <stdlib.h>
bool es_perfecto(int n){

    int d = 1, divisor = 0;

    while(d<n){
        if (n % d == 0)
            divisor += d;
        if (divisor == n)
            return true;
        d++;
    }

    return false;
}
int main(int argc, char *argv[]){

    int numero;

    printf("Escribe un numero: ");
    scanf(" %i", &numero);

    printf(" %i %sperfecto.\n", numero, es_perfecto(numero)? "es ": "no es ");

    return EXIT_SUCCESS;

}
