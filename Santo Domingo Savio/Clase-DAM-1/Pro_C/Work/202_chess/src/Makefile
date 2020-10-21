CC = cc

IDIR = include
DDIR = ../dist

CFLAGS = -g -I$(IDIR)
LDLIBS = 

DEPS = $(wildcard $(IDIR)/*.h)
OBJS = $(patsubst %.o, %.c, $(wildcard *.c))

EXE  = chess

all: $(EXE) dist

$(EXE): $(OBJS) $(DEPS)
		$(CC) $(CFLAGS) -o $@ $(OBJS) $(LDLIBS)

%.o: %.c $(DEPS)
		$(CC) $(CFLAGS) -c $<

.PHONY: clean

clean:
	$(RM) *.o

dist: $(EXE) clean
	mv $(EXE) $(DDIR)
