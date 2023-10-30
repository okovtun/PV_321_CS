#include<iostream>
#include<string>
#include<map>
using std::cin;
using std::cout;
using std::endl;

void main()
{
	setlocale(LC_ALL, "");
	/*int arr[] = { 3, 5, 8, 13, 21 };
	for (int i = 0; i < sizeof(arr)/sizeof(arr[0]); i++)
	{
		cout << arr[i] << "\t";
	}
	cout << endl;
	for (int i : arr)
	{
		cout << i << "\t";
	}
	cout << endl;*/

	std::map<int, std::string> week =
	{
		{0, "Sunday"},
		{1, "Monday"},
		{2, "Tuesday"},
		{3, "Wednesday"},
		{4, "Thursday"},
		{5, "Friday"},
		{6, "Saturday"},
	};
	for (std::map<int, std::string>::iterator it = week.begin(); it != week.end(); ++it)
	{
		cout << it->first << " - " << it->second << endl;
	}
	cout << endl;
	cout << "\n-------------------------------\n";
	for (std::pair<int, std::string> i : week)
	{
		cout << i.first << " - " << i.second << endl;
	}
	cout << endl;
}