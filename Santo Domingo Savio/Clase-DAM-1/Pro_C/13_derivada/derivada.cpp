
#include <stdio.h>
#include <stdlib.h>

#define INC 0.01
double punto_y(double x){

    return x * x;
}

double derivada(double x){

    return (punto_y(x + INC) - punto_y(x)) / INC;
}
int main(int argc, char *argv[]){

    double x_num, y_num;

    printf("Escribe velocidad : ");
    scanf(" %lf", &x_num);

    printf("%.3lf.\n", derivada(x_num));

    return EXIT_SUCCESS;
}
