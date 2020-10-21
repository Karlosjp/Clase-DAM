#include <pthread.h>
#include <stdio.h>

void* print_xs(void* unesed)
{
    while(1)
        fputc('x',stderr);

    return NULL;
}

int main(int argc, char *argv[])
{
    pthread_t thread_id;
    pthread_create(&thread_id, NULL, &print_xs, NULL);

    while(1)
        fputc('o',stderr);

    return 0;
}
