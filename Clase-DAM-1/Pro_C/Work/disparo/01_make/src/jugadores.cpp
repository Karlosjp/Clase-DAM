#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <curses.h>
#include <strings.h>

#include "play.h"

/*Numero jugadores*/
int play(){

    int players = 0;


    do{
        mvprintw(1, 1,"Introduce el numero de jugadores. (minimo 1, maximo 10) ");
        scanw(" %i", &players);

            if (players <= 10)
                return players;
            else{
                        clear();
                        mvprintw(1,1,"Mas jugadores de lo permitido");
                    }
        }while(1);

}
