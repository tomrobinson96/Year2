#ifndef LISTOFTOWNS_H
#define LISTOFTOWNS_H

#include <string>
#include <iostream>

using namespace std;

class TownNode
{
private:
	string* townName;          // town's name    
	TownNode* next;            // link to next
public:
	TownNode();                // no argument constructor
	TownNode(string name);
	void setNext(TownNode* nextNode);
	TownNode* getNext();
	string* getName();
};


class TownList
{
private:
	TownNode  *start, *end;

public:
	TownList();
	bool isEmpty();
	void addFirstTown(string name);
	void addTownAtEnd(string name);
	void listAllNames();
};
#endif

