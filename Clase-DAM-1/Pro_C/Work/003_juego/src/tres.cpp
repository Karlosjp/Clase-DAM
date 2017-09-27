#include <string.h>

#include "tres.h"

#define X       1
#define O      -1

void mesa(struct TMesa *pos){
    int tablero[3][3];
    bzero(&tablero, sizeof(tablero));

    //Mete datos al tablero
    for(int i=0; i<pos->localizacion; i++) {
        if(i%2)
            tablero[pos->datos[i].x][pos->datos[i].y] = X;
        else
            tablero[pos->datos[i].x][pos->datos[i].y] = O;
    }

    //Dibuja el tablero
    system("clear");

    for(int i=0; i<3; i++){
        printf("{");

        for(int j=0; j<3; j++)
            if(tablero[i][j]== X)
                printf("\tX");
            else if(tablero[i][j]== O)
                printf("\tO");
            else
                printf("\t_");

        printf("\t}\n");
        printf(" ");

        for(int l=0; l<31;l++)
            printf("-");

        printf(" \n");
    }

    printf(" \n");
    printf(" \n");
}

//Guarda las jugadas
void jugadas(int x, int y, struct TMesa *pos){

    pos->datos[pos->localizacion].x = x;
    pos->datos[pos->localizacion].y = y;

    pos->localizacion++;

    mesa(pos);
}
