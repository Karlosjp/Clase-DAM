#include <studio.h>
#include <stdlib.h>
#include <thread.h>

struct TPrueba{
    char letra;
    int num;
};

void * esc_char(void * escribe)
{
    struct TPrueba * p = (struct Tprueba *) escribe;
    int i;

    for(i = 0; i < p->num; i++)
        fputc (p->letra, stderr);

    return NULL;
}

int main()
{
    pthread_t thread1_id, thread2_id;
    struct TPrueba thread1_args, thread2_args;

    thread1_args.letra = 'x';
    thread1_args.num = 20000;
    thread2_args.letra = 'y';
    thread2_args.num = 10000;

    pthread_create (&thread1_id; NULL, esc_char, &thread1_id);
    pthread_create (&thread2_id; NULL, esc_char, &thread2_id);

    return EXIT_SUCCESS;
}
