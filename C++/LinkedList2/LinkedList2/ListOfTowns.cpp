#include "ListOfTowns.h"

TownNode::TownNode()
{
	townName = NULL;  // default 
	next = NULL;		 // initialise next
	first = NULL;		//initialise First
}

TownNode::TownNode(string name)
{
	townName = new string(name);  // store name
	next = NULL;                  // initialise next
	first = NULL;		//initialise First
}

void TownNode::setNext(TownNode* nextNode)
{
	next = nextNode;  // change next node
}

TownNode* TownNode::getNext()
{
	return next;
}

void TownNode::setFirst(TownNode* firstNode)
{
	first = firstNode;  // change first node
}

TownNode* TownNode::getFirst()
{
	return first;
}

string* TownNode::getName()
{
	return townName;
}

TownList::TownList()
{
	start = NULL;   // both set to NULL
	end = NULL;
}

bool TownList::isEmpty()
{
	return start == NULL;
}

void TownList::addFirstTown(string name)
{
	cout << "Adding town " << name << " at start" << endl << endl;
	TownNode* current;
	current = new TownNode(name);  // allocate memory
	start = current;               // change start 
	end = current;				  // and end
}

void TownList::addFirstTownConstant(string name)
{
	cout << "Adding town " << name << " at start" << endl << endl;
	TownNode* current;

	if (end == NULL)       // if list is empty
		addFirstTown(name);
	else
	{
		current = new TownNode(name);   // allocate memory		          
		start->setFirst(current);
		start = current;
	}
}

void TownList::addTownAtEnd(string name)
{
	//cout << "Adding town " << name << " at end" << endl << endl;

	TownNode* current;

	if (end == NULL)       // if list is empty
		addFirstTown(name);
	else
	{
		current = new TownNode(name);   // allocate memory
		end->setNext(current);          // change end's next
		end = current;                  // change end
	}
}

void TownList::listAllNames()
{
	TownNode* current;

	if (!isEmpty())
	{
		cout << "Start of List" << endl;
		current = start;
		while (current != NULL)
		{
			// Funny syntax here as we have to de-reference a pointer to a pointer
			cout << "Next town is: " << *(current->getName()) << endl;
			current = current->getNext();
		}
		cout << "End of List" << endl << endl;
	}
	else
		cout << "List empty" << endl << endl;
}

void TownList::listAllNames2()
{
	TownNode* current;

	if (!isEmpty())
	{
		cout << "Start of List" << endl;
		current = start;
		while (current != NULL)
		{
			// Funny syntax here as we have to de-reference a pointer to a pointer
			cout << "Next town is: " << *(current->getName()) << endl;
			current = current->getFirst();
		}
		cout << "End of List" << endl << endl;
	}
	else
		cout << "List empty" << endl << endl;
}

int main()
{
	TownList townList1;
	townList1.addFirstTown("Brighton");
	townList1.addTownAtEnd("Cambridge");
	townList1.addTownAtEnd("Hove");
	townList1.addTownAtEnd("Arbury");
	townList1.listAllNames();


	TownList townlist2;
	townlist2.addFirstTownConstant("Brighton");
	townlist2.addFirstTownConstant("Cambridge");
	townlist2.addFirstTownConstant("Hove");
	townlist2.addFirstTownConstant("Arbury");
	townlist2.listAllNames2();
	system("PAUSE");
	return 0;
}