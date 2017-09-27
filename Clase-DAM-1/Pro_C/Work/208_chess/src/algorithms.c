#include "algorithms.h"

#define UP         direction[0]
#define UP_RIGHT   direction[1]
#define RIGHT      direction[2]
#define RIGHT_DOWN direction[3]
#define DOWN       direction[4]
#define DOWN_LEFT  direction[5]
#define LEFT       direction[6]
#define LEFT_UP    direction[7]

#define K_UP_RIGHT   k_mv[0]
#define K_RIGHT_DOWN k_mv[1]
#define K_DOWN_LEFT  k_mv[2]
#define K_LEFT_UP    k_mv[3]
#define K_UP_LEFT    k_mv[4]
#define K_LEFT_DOWN  k_mv[5]
#define K_DOWN_RIGHT k_mv[6]
#define K_RIGHT_UP   k_mv[7]


int check_direction (int row, int col, struct TVector dir, char board[SIZE][SIZE]);
int check_position (int row, int col, struct TVector dir, char board[SIZE][SIZE]);

struct TVector direction[] = {
    {0, -1}, {1, -1}, {1, 0}, {1, 1}, {0, 1}, {-1, 1}, {-1, 0}, {-1, -1}
};

struct TVector k_mv[] = {
    {1, -2}, {2, 1}, {-1, 2}, {-2, -1},
    {-1, -2}, {2, -1}, {1, 2}, {-2, 1}
};

struct TVector *pawn_mv[] = { &DOWN, NULL };
struct TVector *rook_mv[] = { &RIGHT, &LEFT, &UP, &DOWN, NULL };
struct TVector *knight_mv[] = {
        &K_UP_RIGHT, &K_RIGHT_DOWN, &K_DOWN_LEFT, &K_LEFT_UP,
        &K_UP_LEFT, &K_LEFT_DOWN, &K_DOWN_RIGHT, &K_RIGHT_UP, NULL  };
struct TVector *bishop_mv[] = { &UP_RIGHT, &LEFT_UP, &RIGHT_DOWN, &DOWN_LEFT, NULL };
struct TVector *king_mv[] = { &UP, &UP_RIGHT, &RIGHT, &RIGHT_DOWN, &DOWN, &DOWN_LEFT, &LEFT, &LEFT_UP, NULL};
struct TVector *queen_mv[] = { &UP, &UP_RIGHT, &RIGHT, &RIGHT_DOWN, &DOWN, &DOWN_LEFT, &LEFT, &LEFT_UP, NULL};

struct TVector **movements[] = {
    pawn_mv, rook_mv, knight_mv, bishop_mv, king_mv, queen_mv
    };

struct Piece set[] = {
   {pawn,   'P', {"♙", "♟"}, "Peón"   , &check_position  },
   {rook,   'T', {"♖", "♜"}, "Torre"  , &check_direction },
   {knight, 'C', {"♘", "♞"}, "Caballo", &check_position  },
   {bishop, 'A', {"♗", "♝"}, "Alfil"  , &check_direction },
   {queen,  'Q', {"♕", "♛"}, "Reina"  , &check_direction },
   {king,   'K', {"♔", "♚"}, "Rey"    , &check_position  },
   {nop,    ' ', {" ", " "}, "Espacio", NULL }
};


int
is_empty (int row, int col, char board[SIZE][SIZE])
{
  return board[row][col] == ' ';
}

int
check_direction (int row, int col, struct TVector dir, char board[SIZE][SIZE])
{
  int offs;
  struct TVector cell = { col, row };
  ADD (cell, dir);

  for (offs = 0; IN_LIMITS (cell.x) && IN_LIMITS (cell.y); ADD (cell, dir))
    if (!is_empty (cell.y, cell.x, board))
      {
	print_possibility (cell.y, cell.x, board);
	return 1;
      }
  return 0;
}

int
check_position (int row, int col, struct TVector dir, char board[SIZE][SIZE])
{
  struct TVector cell = { col, row };
  ADD (cell, dir);

  if (    IN_LIMITS (cell.x) && IN_LIMITS (cell.y) &&
          !is_empty (cell.y, cell.x, board))
  {
      print_possibility (cell.y, cell.x, board);
      return 1;
  }
  return 0;
}

    int
check (int row, int col, char board[SIZE][SIZE], enum TPiece piece)
{
    int i;

    prepare_win (OUT_LIN);
    printf (BOLD_ON
            "\tCOMPROBANDO EL %s\n" "\t====================\n\n" BOLD_OFF, set[piece].name);

    for (i=0; movements[piece][i] != NULL; i++)
        (*set[piece].my_check)(row, col, *movements[piece][i], board);
}

