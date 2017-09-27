
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define N 3
#define K 2
#define M 4

void print(int matriz_c[M][N]){

    for(int f=0; f<N; f++){
        printf("(\t");

        for(int c=0; c<N; c++){
            printf("%i\t", matriz_c[f][c]);
        }

        printf(")\n");
    }
}

int main(int argc, char *argv[]){

    /*Recorrer todas las filas
        Recorrer cada columna
            Para cada valor de k
                cij += aik * bkj;
    */

    int matriz_a [M][K] = { {1, 2}, {2, -3}, {-4, 3}, {5, 4}},
        matriz_b [K][N] = { {7, 2, 5}, {1,  2, 4}},
        matriz_c [M][N];

    bzero(matriz_c, sizeof(matriz_c));

    for(int m=0; m<M; m++){
        for(int n=0; n<N; n++){
            for(int k=0; k<K; k++){
                matriz_c[m][n] += matriz_a[m][k] * matriz_b[k][n];
            }
        }
    }

    print(matriz_c);

    return EXIT_SUCCESS;

}
