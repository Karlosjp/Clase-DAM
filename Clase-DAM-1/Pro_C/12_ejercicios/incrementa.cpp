#include <stdio.h>
#include <stdlib.h>

void incrementa(int *num, int inc ){

    *num += inc;
}

int main(int argc, char *argv[]){

    int a = 2, b = 5;

    incrementa(&a, 5);
    printf("a= %i\n", a);

    incrementa(&b, 5);
    printf("b= %i\n", b);

    incrementa(&a, -2);
    printf("a= %i\n", a);

    return EXIT_SUCCESS;

}
