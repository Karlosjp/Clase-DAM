#include <stdio.h>
#include <stdlib.h>

#include "general.h"
#include "io.h"
#include "comp.h"

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
      while (!good_coordinates(row, col) ||
             !is_empty (row, col, chess_board));
      tower_check (row, col, chess_board);
  }
  while (repeat ());


  return EXIT_SUCCESS;
}
