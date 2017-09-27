#include <string.h>

#include "tres.h"

int main(int argc, char *argv[]){
    struct TMesa pos;
    bzero(&pos, sizeof(pos));

    jugadas(0, 2, &pos);
    jugadas(1, 2, &pos);
    jugadas(2, 1, &pos);
    jugadas(0, 0, &pos);

    return EXIT_SUCCESS;

}
