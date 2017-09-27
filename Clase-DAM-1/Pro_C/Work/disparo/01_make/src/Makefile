IDIR = ../include
DDIR = ../dist

CC = g++
CFLAGS = -g -I$(IDIR) 

DEPF = play.h
DEPS = $(pathsubst %,$(IDIR)/%,$(DEPF))
OBJS = jugadores.o main.o
EXEC = tanks

$(EXEC): $(OBJS)
	$(CC) -g $^ -o $(EXEC) $(CFALGS) -lncurses 

all: $(EXEC) dist

dist: clean
	mv tanks $(DDIR)
%.o: %.cpp $(DEPS)
	$(CC) -c $< $(CFLAGS) -c $<

.PHONY: clean

clean:
	$(RM) *.o

