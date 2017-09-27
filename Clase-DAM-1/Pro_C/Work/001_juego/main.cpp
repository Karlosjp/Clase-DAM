#include <stdio.h>
#include <stdlib.h>
#include <strings.h>

#define MAX_JUG 9
#define X       1
#define Y      -1

typedef struct TCoordenada {
    int x;
    int y;
};

typedef struct TMesa{
    TCoordenada datos[MAX_JUG];
    TCoordenada j1[MAX_JUG];
    TCoordenada j2[MAX_JUG];
};

int main(int argc, char *argv[]){
    int tablero [3][3];
    bzero(&tablero, sizeof(tablero));

    TMesa pos;
    bzero(&pos, sizeof(pos));

    pos.datos[0].x = 2;
    pos.datos[0].y = 2;
    pos.datos[1].x = 2;
    pos.datos[1].y = 1;
    pos.datos[2].x = 1;
    pos.datos[2].y = 2;

   for(int i=0; i<3; i++) {
        if(i%2)
            tablero[pos.datos[i].x][pos.datos[i].y] = X;
        else
            tablero[pos.datos[i].x][pos.datos[i].y] = Y;
   }
    for(int i=0; i<3; i++){
        printf("{");
    //    printf("Jugada %i, %i.\n", pos.datos[i].x, pos.datos[i].y);
        for(int j=0; j<3; j++)
            printf("\t%i", tablero[i][j]);

        printf("\t}\n");
        printf(" ");

        for(int l=0; l<31;l++)
            printf("-");

        printf(" \n");
    }

    return EXIT_SUCCESS;

}
