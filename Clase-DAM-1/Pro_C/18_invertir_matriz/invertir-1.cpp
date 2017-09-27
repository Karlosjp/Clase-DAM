
#include <stdio.h>
#include <stdlib.h>

#define N 10

void imprime(int *datos, int cuantos){
    for (int i=0; i<cuantos; i++)
        printf("%6i", datos[i]);
    printf("\n");
}

int main(int argc, char *argv[]){

    int m[N]= {1,2,3,4,5,6,7,8,9,10};
    int *ini = m, *fin = m+N-1;
    int aux;

    imprime(m,N);

    for(; ini<fin; ini++, fin--){
        aux = *ini;
        *ini = *fin;
        *fin = aux;
    }

    imprime(m,N);

    return EXIT_SUCCESS;

}
