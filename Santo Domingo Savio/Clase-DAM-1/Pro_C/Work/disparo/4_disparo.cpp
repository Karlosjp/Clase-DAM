#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <curses.h>
#include <strings.h>

#define G 9.80665
#define TANK 10
#define DELTA .1

struct TCoordinate{
    double x;
    double y;
};

struct TShot{
    struct TCoordinate ac;
    struct TCoordinate sp;
    struct TCoordinate  s;
};

struct TTank{
    struct TCoordinate pos;
    struct TShot        sh;
};

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

int main(int argc, char *argv[]){

    int players, turn;
    struct TCoordinate g = {0., -G};

    struct TTank tank[TANK];
    bzero(tank, 10 * sizeof(struct TTank));

    initscr();
    curs_set(1);

    players =  play();

    while(1){
       /* Posicion de los juadores*/
        for (int i = 0; i < players; i++){
            clear();
            mvprintw(1,1,"Posicion del tanque %i: ", i+1);
            scanw(" %lf , %lf", &tank[i].pos.x, &tank[i].pos.y);
        }

        clear();

        curs_set(0);

        /*Pasen los años*/
        for(turn = 0; turn<=players; turn++){

            for(double t = 0.; tank[turn].sh.s.y >=0.; t+= DELTA){
                /*Actualizar fisica*/
                tank[turn].sh.sp.y += (tank[turn].sh.ac.y + g.y) * DELTA;
                tank[turn].sh.s.y += tank[turn].sh.sp.y * DELTA;

                tank[turn].sh.sp.x += (tank[turn].sh.ac.x + g.x) * DELTA;
                tank[turn].sh.s.x += tank[turn].sh.sp.x * DELTA;

                /*Representar*/

                mvprintw(tank[turn].pos.y - tank[turn].sh.s.y, tank[turn].pos.x - tank[turn].sh.s.x, "0");

                refresh();
                usleep(100000);
            }

        curs_set(1);
        usleep(2000000);
        }
    }

    endwin();

    return EXIT_SUCCESS;

}
