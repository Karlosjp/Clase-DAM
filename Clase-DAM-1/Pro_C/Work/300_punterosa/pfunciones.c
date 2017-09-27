#include <stdio.h>
#include <stdlib.h>

void saluda(){
    printf("Hola\n");
}

int suma(int x, int y){
    return x+y;
}

int main(int argc, char *argv[]){
    int x = 2;
    int y = 3;
    int (*p_sum)(int x, int y) = &suma;

    saluda();

    printf("El numero es %i\n", p_sum(x, y));

    return EXIT_SUCCESS;

}
