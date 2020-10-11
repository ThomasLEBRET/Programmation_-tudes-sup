CXX = g++
CXXFLAGS = -Wall -std=c++11 -g

foxwar: foxwar.cpp cpp/animal.o cpp/coordonnees.o cpp/deplacement.o cpp/ensemble.o cpp/grille.o cpp/tools.o -lsfml-graphics -lsfml-window -lsfml-system

animal.o: hpp/animal.hpp cpp/animal.cpp
coordonnees.o: hpp/coordonnees.hpp cpp/coordonnees.cpp
deplacement.o: hpp/deplacement.hpp cpp/deplacement.cpp
ensemble.o: hpp/ensemble.hpp cpp/ensemble.cpp
grille.o: hpp/grille.hpp cpp/grille.cpp
tools.o: hpp/tools.hpp cpp/tools.cpp

clean:
	rm -f foxwar cpp/*.o
	rm -r images anime
