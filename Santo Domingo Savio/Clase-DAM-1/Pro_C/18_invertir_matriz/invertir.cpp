
#include <stdio.h>
#include <stdlib.h>

#define N 10

int main(int argc, char *argv[]){

    int data[N]= {1,2,3,4,5,6,7,8,9,10};
    int u = N-1;

    const int *pi;
    const int *pf;

    // Muestra el array
    for( int c=0; c<=u; c++){
        pi = &data[c];
        pf = &data[u--];

        printf("%i , %i : datos.\n", *pi , *pf);
    }

    return EXIT_SUCCESS;

}
