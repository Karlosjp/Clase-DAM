#ifndef __COMP_H__
#define __COMP_H__

#include "general.h"


#ifdef __cplusplus
extern "C"
{
#endif

  int is_empty (int row, int col, char board[SIZE][SIZE]);
  int tower_check (int row, int col, char board[SIZE][SIZE]);
  int good_coordinates (int row, int col);

#ifdef __cplusplus
}
#endif

#endif
