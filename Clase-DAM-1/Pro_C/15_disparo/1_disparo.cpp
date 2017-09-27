
#include <stdio.h>
#include <stdlib.h>

#define X 0
#define Y 1
#define AX 0
#define AY -9.8
#define DELTA 0.01

double pregunta(){
    double num;

    scanf(" %lf", &num);

    return num;
}

int main(int argc, char *argv[]){

    double v[2];

    printf("Escribe X ");
    v[0] = pregunta();

    printf("Escribe Y ");
    v[1] = pregunta();

    for(int i = 0; v[Y]>0; i++){
        v[X] += AX * DELTA;
        v[Y] += AY * DELTA;

        printf("%.2lf, %.2lf | ", v[X], v[Y]);
    }

    printf("\n");

    return EXIT_SUCCESS;

}
