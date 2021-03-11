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
	TownNode* first;				// link to first
public:
	TownNode();                // no argument constructor
	TownNode(string name);
	void setNext(TownNode* nextNode);
	TownNode* getNext();
	string* getName();

	void setFirst(TownNode* firstNode);
	TownNode*getFirst();
	//*getName();
};


class TownList
{
private:
	TownNode  *start, *end;

public:
	TownList();
	bool isEmpty();
	void addFirstTown(string name);
	void addFirstTownConstant(string name);
	void addTownAtEnd(string name);
	void listAllNames();
	void listAllNames2();
};
#endif
