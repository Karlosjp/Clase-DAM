#include <stdio.h>
#include <stdlib.h>
#include <strings.h>

#define MAX_JUG 9
#define X       1
#define O      -1

struct TCoordenada {
    int x;
    int y;
};

struct TMesa{
    int localizacion;
    struct TCoordenada datos[MAX_JUG];
    struct TCoordenada j1[MAX_JUG];
    struct TCoordenada j2[MAX_JUG];
};

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
//    system("clear");

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

int main(int argc, char *argv[]){
    struct TMesa pos;
    bzero(&pos, sizeof(pos));

    jugadas(0, 2, &pos);
    jugadas(1, 2, &pos);
    jugadas(2, 1, &pos);
    jugadas(0, 0, &pos);

    return EXIT_SUCCESS;

}
