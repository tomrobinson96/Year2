//constructors.cpp
#include <iostream>
#include <cstdlib>
#include <cstring>

using namespace std;

class Book
{
	int pages;
public:
	Book()
	{
		pages = 0;
	}

	void setPages(int num)
	{
		pages = num;
	}

	~Book()
	{
		cout << "deleting Object" <<endl;
	}
	int getPages()
	{
		return pages;
	}
};
int main()
{
	Book mybook1;
	Book mybook2 = Book();
	Book mybook3 = mybook1;
	mybook1.setPages(500);
	mybook2.setPages(300);
	mybook3.setPages(200);
	cout << "pages = " << mybook1.getPages() << endl;
	cout << "Pages also: " << mybook2.getPages() << endl;
	cout << "Pages also: " << mybook3.getPages() << endl;
	system("PAUSE");
	return 0;
}