#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <curses.h>

#define TANQUES 10
#define DELTA .1



struct TCoordenada{
    double x;
    double y;
};

struct TMovil{
    struct TCoordenada a;
    struct TCoordenada v;
    struct TCoordenada s;
}
struct TTanque{
    struct TCoordenada p;
    struct TMovil      d;
};

double tanque(){
    struct TTanque p[TANQUES];
    int jugador = 0;

    do{
        printf("¿Cuantos jugadores?: ");
        scanf(" %i", &jugador);

        if(jugador <=10 && jugador > 0){
            printf("Dime la posicion X Y del jugador &i: ");
            scanf(" %lf , %lf", &p.x, &p.y);
        }else
            printf("Jugadores de 1 a 10");

    }while (jugador <=10 && jugador > 0);

    return p;
}

int main(int argc, char *argv[]){
    double t = 0.;
    struct TCoordenada a = { 0., -10. },
                       v = { 5.,  10. },
                       s = { 0.,   0. };
    /*struct TTanque p1 = { 20., 20. },
                   p2 = { 10., 10. };
    */
    struct TTanque p_i = tanque();

    initscr();
    curs_set(0);

    /* Pasen los años*/
    for(t=0.; s.y>=0.; t+=DELTA){
        /* Actualizar la fisica*/
        v.y += a.y * DELTA;
        s.y += v.y * DELTA;

        v.x += a.x * DELTA;
        s.x += v.x * DELTA;

        /*Representar*/
        //clear();
        mvprintw(p1.yc, p1.xc-2, "¬");
        mvprintw(p1.yc-s.y, p1.xc+s.x, "0");
        mvprintw(p2.yc, p2.xc-2, "¬");
        mvprintw(p2.yc-s.y, p2.xc+s.x, "O");
        refresh();
        usleep(30000);
    }

    usleep(2000000);
    curs_set(1);
    endwin();

    return EXIT_SUCCESS;

}
