#include "ListOfTowns.h"

TownNode::TownNode()
{
	townName = NULL;  // default 
	next = NULL;		 // initialise next
}

TownNode::TownNode(string name)
{
	townName = new string(name);  // store name
	next = NULL;                  // initialise next
}

void TownNode::setNext(TownNode* nextNode)
{
	next = nextNode;  // change next node
}

TownNode* TownNode::getNext()
{
	return next;
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

void TownList::addTownAtEnd(string name)
{
	cout << "Adding town " << name << " at end" << endl << endl;

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

int main()
{
	TownList townList1;
	townList1.addFirstTown("Brighton");
	townList1.addTownAtEnd("Cambridge");
	townList1.addTownAtEnd("Hove");
	townList1.addTownAtEnd("Arbury");
	townList1.listAllNames();
}