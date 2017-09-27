IDIR = ../include
DDIR = ../dist

CC = g++
CFLAGS = -g -I$(IDIR)

DEPS = imprime.h
OBJS = imprime.o main.o
EXEC = el2

$(EXEC): $(OBJS)
	$(CC) $^ -o I$(EXEC) $(CFALGS)

%.0: %.cpp $(DEPS)
 	$(CC) -c $< $(CFLAGS)

.PHONY: clean dist

clean:
 	$(RM) *.o
