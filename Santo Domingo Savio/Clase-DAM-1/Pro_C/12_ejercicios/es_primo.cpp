#include <stdio.h>
#include <stdlib.h>
bool es_primo(int n){

    int divisor = 0;

    for (int d=2; d<n; d++)
        if (n % d == 0)
            return false;

    return true;
}
int main(int argc, char *argv[]){

    int numero;

    printf("Escribe un numero: ");
    scanf(" %i", &numero);

    printf(" %i %sprimo.\n", numero, es_primo(numero)? "es ": "no es ");

    return EXIT_SUCCESS;

}
