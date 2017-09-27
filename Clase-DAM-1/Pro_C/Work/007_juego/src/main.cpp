#include <string.h>

#include "tres.h"

#define X    1
#define O   -1

int main(int argc, char *argv[]){
    struct TMesa pos;
    bzero(&pos, sizeof(pos));

    int tablero[3][3];
    bzero(&tablero, sizeof(tablero));

    struct TDato contador;
    bzero(&contador, sizeof(contador));

    while(conteoh(tablero, &contador) &&
          conteov(tablero, &contador) &&
          conteod(tablero, &contador)){
        dibujar(tablero);

        jugadas(pregunta(), &pos);

        for(int i=0; i<pos.localizacion; i++){
            if(i%2)
                tablero[pos.datos[i].x][pos.datos[i].y] = X;
            else
                tablero[pos.datos[i].x][pos.datos[i].y] = O;
        }
    }

    return EXIT_SUCCESS;

}
