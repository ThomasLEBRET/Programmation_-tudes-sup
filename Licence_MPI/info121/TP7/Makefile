CFLAGS = -Wall -g -std=c++11 #definition de variable

all : main

PolyAbstr.o: PolyAbstr.hpp PolyAbstr.cpp
	g++ $(CFLAGS) -c PolyAbstr.cpp

main: main.cpp PolyAbstr.o
	g++ $(CFLAGS) main.cpp PolyAbstr.o -o main

clean:
	rm -f main PolyAbstr.o
