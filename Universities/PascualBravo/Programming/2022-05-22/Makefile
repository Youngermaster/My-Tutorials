CXXFLAGS=

mathproject: main.cpp utils.o
	$(CXX) -o $@ $^

utils.o: utils.cpp utils.h

clean:
	rm -f *.o
	rm -f mathproject