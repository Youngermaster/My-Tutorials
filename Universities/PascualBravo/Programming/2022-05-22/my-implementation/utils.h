#pragma once
#include <math.h>

#include <iostream>
#include <limits>
#include <vector>

using namespace std;

#define LOG(x) std::cout << x << std::endl

void printMainMenu();

// First Point
void menuOne();
void printMenuOne();
void getSumeBinomeOperations();
void getMinusBinomeOperations();
void inverseOperations();
float invertANumber(float& a);

// Second point
void menuTwo();
void printMenuTwo();
bool isPrime(int& a);
void getPrimesInRange();
void getMultiplesInRange();
void getMultiplesInRangeOfSeven();
// Third point
void menuThree();
void printMenuThree();

// Fourth point
void factorialOfANumber();