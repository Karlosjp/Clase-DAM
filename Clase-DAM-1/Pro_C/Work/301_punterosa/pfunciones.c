#include <stdio.h>
#include <stdlib.h>

void saluda(){
    printf("Hola\n");
}

int suma(int x, int y){
    return x + y;
}

int resta(int x, int y){
    return x - y;
}

int main(int argc, char *argv[]){
    int x = 2;
    int y = 3;
    int (*p_sum[2])(int x, int y) = {
        &suma,
        &resta
    };

    saluda();

    printf("El numero es %i\n", p_sum[0](x, y));
    printf("El numero es %i\n", p_sum[1](x, y));

    return EXIT_SUCCESS;

}
