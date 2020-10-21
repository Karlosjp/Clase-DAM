#include <stdio.h>
#include <stdlib.h>

#include "general.h"
#include "comp.h"
int
good_coordinates(int row, int col)
{
  return row >= 0 && col >= 0 &&
         row < SIZE && col < SIZE;
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

  for(int offs=1; col+offs < SIZE; offs++)
  {
    if(!is_empty(row, col+offs,board))
      printf("1. Te puedes comer la ficha %c de la posición %i, %i\n",
             board[row][col+offs], row, col+offs);
      break;
  }

   for(int offs=1; col-offs>=0; offs++)
  {
    if(!is_empty(row, col-offs,board))
      printf("1. Te puedes comer la ficha %c de la posición %i, %i\n",
             board[row][col-offs], row, col-offs);
      break;
  }

   for(int offs=1; row-offs>=0; offs++)
  {
    if(!is_empty(row-offs, col,board))
      printf("1. Te puedes comer la ficha %c de la posición %i, %i\n",
             board[row-offs][col], row-offs, col);
      break;
  }
}
