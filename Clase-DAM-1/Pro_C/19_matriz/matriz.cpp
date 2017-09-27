
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define N 3

void print(int matriz_c[N][N]){

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

    int matriz_a [N][N] = { {1, 2, 3}, {2, -3, 1}, {-4, 3, 2} },
        matriz_b [N][N] = { {7, 2, 5}, {1,  2, 4}, {-3, 2, 1} },
        matriz_c [N][N];

    bzero(matriz_c, sizeof(matriz_c));

    for(int f=0; f<N; f++){
        for(int c=0; c<N; c++){
            for(int k=0; k<N; k++){
                matriz_c[f][c] += matriz_a[f][k] * matriz_b[k][c];
            }
        }
    }

    print(matriz_c);
    return EXIT_SUCCESS;

}
