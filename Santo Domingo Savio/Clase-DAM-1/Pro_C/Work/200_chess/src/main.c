#include <stdio.h>
#include <stdlib.h>

#include "general.h"
#include "io.h"


int is_empty (int row, int col, char board[SIZE][SIZE]);
int tower_check (int row, int col, char board[SIZE][SIZE]);

int
main (int argc, char *argv[])
{
  char chess_board[SIZE][SIZE];
  int row, col;

  do
  {
      load (BOARD_FN, chess_board);
      dump (chess_board);
      do
      {
        ask_coordinates (&row, &col, "torre");
      }
      while (!is_empty (row, col, chess_board));
      tower_check (row, col, chess_board);
  }
  while (repeat ());


  return EXIT_SUCCESS;
}

int
is_empty (int row, int col, char board[SIZE][SIZE])
{
  if(board[row][col] == ' ')
    return 1;
  return 0;
}

int
tower_check (int row, int col, char board[SIZE][SIZE])
{
  printf("row %i, col %i\n", row, col);

  for(int p=row-1; p>=0; p--)
  {
    if(board[p][col] != ' ')
    {
      printf("1. Te puedes comer la ficha %c de la posición %i, %i\n", board[p][col], p, col);
      p = -1;
    }
  }

  for(int p=row+1; p<SIZE; p++)
  {
    if(board[p][col] != ' ')
    {
      printf("2. Te puedes comer la ficha %c de la posición %i, %i\n", board[p][col], p, col);
      p = SIZE;
    }
  }

  for(int p=col+1; p<SIZE; p++)
  {
    if(board[row][p] != ' ')
    {
      printf("3. Te puedes comer la ficha %c de la posición %i, %i\n", board[row][p], row, p);
      p = SIZE;
    }
  }

  for(int p=col-1; p>=0; p--)
  {
    if(board[row][p] != ' ')
    {
      printf("4. Te puedes comer la ficha %c de la posición %i, %i\n", board[row][p], row, p);
      p = -1;
    }
  }
}
