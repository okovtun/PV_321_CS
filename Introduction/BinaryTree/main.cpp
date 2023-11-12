#include<iostream>
#include<ctime>
#include<algorithm>
using namespace std;
using std::cin;
using std::cout;
using std::endl;

class Tree
{
protected:
	class Element
	{
		int Data;
		Element* pLeft;
		Element* pRight;
	public:
		Element(int Data, Element* pLeft = nullptr, Element* pRight = nullptr) :Data(Data), pLeft(pLeft), pRight(pRight)
		{
#ifdef DEBUG
			cout << "EConstructor:\t" << this << endl;
#endif // DEBUG
		}
		~Element()
		{
#ifdef DEBUG
			cout << "EDestructor:\t" << this << endl;
#endif // DEBUG
		}
		friend class Tree;
		friend class UniqueTree;
	}*Root;
public:
	Element* getRoot()
	{
		return Root;
	}
	Tree()
	{
		Root = nullptr;
		cout << "TConstructor:\t" << this << endl;
	}
	//			type		  name
	Tree(initializer_list<int> il) :Tree()
	{
		//begin() - возвращает итератор на начало контейнера;
		//end()   - возвращает итератор на конец контейнера;
		for (int const* it = il.begin(); it != il.end(); ++it)
			insert(*it, Root);
	}
	~Tree()
	{
		clear(Root);
		cout << "TDestructor:\t" << this << endl;
	}
	void insert(int Data)
	{
		insert(Data, Root);
	}
	void erase(int Data)
	{
		erase(Data, Root);
	}
	int minValue()const
	{
		return minValue(Root);
	}
	int maxValue()const
	{
		return maxValue(Root);
	}
	int sum()const
	{
		return sum(Root);
	}
	int count()const
	{
		return count(Root);
	}
	double avg()const
	{
		return (double)sum(Root) / count(Root);
	}
	int depth()const
	{
		return depth(this->Root);
	}
	void depth_print(int depth, int width = 8)const
	{
		depth_print(this->Root, depth, width);
		cout << endl;
	}
	void tree_print()const
	{
		tree_print(depth(Root), depth(Root) * 8);
	}
	void print()const
	{
		print(Root);
		cout << endl;
	}
private:
	void insert(int Data, Element* Root)
	{
		if (this->Root == nullptr)this->Root = new Element(Data);
		if (Root == nullptr)return;
		if (Data < Root->Data)
		{
			if (Root->pLeft == nullptr)Root->pLeft = new Element(Data);
			else insert(Data, Root->pLeft);
		}
		else
		{
			if (Root->pRight == nullptr)Root->pRight = new Element(Data);
			else insert(Data, Root->pRight);
		}
	}
	void erase(int Data, Element*& Root)
	{
		if (Root == nullptr)return;
		if (Data == Root->Data)
		{
			if (Root->pLeft == Root->pRight)
			{
				delete Root;
				Root = nullptr;
			}
			else
			{
				if (count(Root->pLeft) > count(Root->pRight))
				{
					Root->Data = maxValue(Root->pLeft);
					erase(maxValue(Root->pLeft), Root->pLeft);
				}
				else
				{
					Root->Data = minValue(Root->pRight);
					erase(minValue(Root->pRight), Root->pRight);
				}
			}
		}
		if (Root)erase(Data, Root->pLeft);
		if (Root)erase(Data, Root->pRight);
	}
	void clear(Element* Root)
	{
		if (Root == nullptr)return;
		clear(Root->pLeft);
		clear(Root->pRight);
		delete Root;
		Root = nullptr;
	}
	int minValue(Element* Root)const
	{
		if (Root == nullptr)return 0;
		/*if (Root->pLeft == nullptr)return Root->Data;
		else return minValue(Root->pLeft);*/
		return Root->pLeft == nullptr ? Root->Data : minValue(Root->pLeft);
	}
	int maxValue(Element* Root)const
	{
		if (Root == nullptr)return 0;
		/*if (Root->pRight == nullptr)return Root->Data;
		else return maxValue(Root->pRight);*/
		return Root->pRight == nullptr ? Root->Data : maxValue(Root->pRight);
		//return Root->pRight ? maxValue(Root->pRight) : Root->Data;
	}
	int sum(Element* Root)const
	{
		if (Root == nullptr)
			return 0;
		else
			return sum(Root->pLeft) + sum(Root->pRight) + Root->Data;
		//return Root == nullptr ? 0 : sum(Root->pLeft) + sum(Root->pRight) + Root->Data;
	}
	int count(Element* Root)const
	{
		return Root == nullptr ? 0 : count(Root->pLeft) + count(Root->pRight) + 1;
	}
	int depth(Element* Root) const
	{
		//if (Root == nullptr)return 0;
		/*else return
			depth(Root->pLeft)  + 1 >
			depth(Root->pRight) + 1 ?
			depth(Root->pLeft)  + 1 :
			depth(Root->pRight) + 1 ;*/
			/*int l_depth = depth(Root->pLeft) + 1;
			int r_depth = depth(Root->pRight) + 1;
			return l_depth > r_depth ? l_depth : r_depth;*/
		return Root == nullptr ? 0 : std::max(depth(Root->pLeft), depth(Root->pRight)) + 1;
	}
	void depth_print(Element* Root, int depth, int width = 8)const
	{
		if (Root == nullptr)return;
		if (depth == 0)
		{
			cout.width(width);
			cout << Root->Data;
			cout.width(width);
			cout << "";
		}
		depth_print(Root->pLeft, depth - 1, width);
		depth_print(Root->pRight, depth - 1, width);
	}
	void tree_print(int depth, int width)const
	{
		if (depth == -1)return;
		depth_print(this->depth(this->Root) - depth, width);
		cout << endl;
		cout << endl;
		cout << endl;
		cout << endl;
		tree_print(depth - 1, width / 2);
	}
	void print(Element* Root)const
	{
		if (Root == nullptr)return;
		print(Root->pLeft);
		cout << Root->Data << "\t";
		print(Root->pRight);
	}
};
class UniqueTree :public Tree
{
	void insert(int Data, Element* Root)
	{
		if (this->Root == nullptr)this->Root = new Element(Data);
		if (Root == nullptr)return;
		if (Data < Root->Data)
		{
			if (Root->pLeft == nullptr)Root->pLeft = new Element(Data);
			else insert(Data, Root->pLeft);
		}
		else if (Data > Root->Data)
		{
			if (Root->pRight == nullptr)Root->pRight = new Element(Data);
			else insert(Data, Root->pRight);
		}
	}
public:
	void insert(int Data)
	{
		insert(Data, Root);
	}
};

template<typename T>void measure(const char msg[], const Tree& tree, T(Tree::*member_function)()const)
{
	cout << msg << ": ";
	clock_t start = clock();
	T value = (tree.*member_function)();
	clock_t end = clock();
	cout << value << ", выполнено за " << double(end - start) / CLOCKS_PER_SEC << " секунд.\n";
}

//#define BASE_CHECK
//#define PREFORMANCE_CHECK_1
//#define ERASE_CHECK
#define BALANCE_CHECK

void main()
{
	setlocale(LC_ALL, "");

#ifdef BASE_CHECK
	int n;
	cout << "Введите расмер дерева: "; cin >> n;
	Tree tree;
	clock_t start = clock();
	for (int i = 0; i < n; i++)
	{
		tree.insert(rand() % 100);
	}
	clock_t end = clock();
	cout << "Дерево заполнено за " << double(end - start) / CLOCKS_PER_SEC << " секунд.\n";
	//tree.print();
	cout << endl;
#ifdef PREFORMANCE_CHECK_1
	cout << "Минимальное значение в дереве: ";
	start = clock();
	cout << tree.minValue() << "\t";
	end = clock();
	cout << "выполнено за " << double(end - start) / CLOCKS_PER_SEC << " секунд.\n";
	/////////////////////////////////////////////////////////////
	start = clock();
	cout << "Максимальное значение в дереве: " << tree.maxValue() << "\t";
	end = clock();
	cout << "выполнено за " << double(end - start) / CLOCKS_PER_SEC << " секунд.\n";
	/////////////////////////////////////////////////////////////
	start = clock();
	cout << "Сумма элементов дерева: " << tree.sum() << "\t";
	end = clock();
	cout << "выполнено за " << double(end - start) / CLOCKS_PER_SEC << " секунд.\n";
	/////////////////////////////////////////////////////////////
	start = clock();
	cout << "Количество элементов дерева: " << tree.count() << "\t";
	end = clock();
	cout << "выполнено за " << double(end - start) / CLOCKS_PER_SEC << " секунд.\n";
	/////////////////////////////////////////////////////////////
	start = clock();
	cout << "Среднее-арифметическое элементов дерева: " << tree.avg() << "\t";
	end = clock();
	cout << "выполнено за " << double(end - start) / CLOCKS_PER_SEC << " секунд.\n";
	/////////////////////////////////////////////////////////////
	cout << "Глубина дерева: ";
	start = clock();
	cout << tree.depth() << "\t";
	end = clock();
	cout << "выполнено за " << double(end - start) / CLOCKS_PER_SEC << " секунд.\n";
	/////////////////////////////////////////////////////////////  
#endif // PREFORMANCE_CHECK_1

	measure("Минимальное значение в дереве", tree, &Tree::minValue);
	measure("Максимальное значение в дереве", tree, &Tree::maxValue);
	measure("Сумма элементов дерева", tree, &Tree::sum);
	measure("Количество элементов дерева", tree, &Tree::count);
	measure("Среднее-арифметическое элементов дерева", tree, &Tree::avg);
	measure("Глубина дерева", tree, &Tree::depth);

	UniqueTree u_tree;
	for (int i = 0; i < n; i++)
	{
		u_tree.insert(rand() % 100);
	}
	u_tree.print();
	cout << endl;
	cout << "Минимальное значение в дереве: " << u_tree.minValue() << endl;
	cout << "Максимальное значение в дереве: " << u_tree.maxValue() << endl;
	cout << "Сумма элементов дерева: " << u_tree.sum() << endl;
	cout << "Количество элементов дерева: " << u_tree.count() << endl;
	cout << "Среднее-арифметическое элементов дерева: " << u_tree.avg() << endl;
	cout << "Глубина дерева: " << u_tree.depth() << endl;
#endif // BASE_CHECK

#ifdef ERASE_CHECK
	Tree tree =
	{
						50,

			25,						75,

		16,		32,				64,		80,
			17,
			 18
	};
	tree.print();
	cout << "Минимальное значение в дереве: " << tree.minValue() << endl;
	cout << "Максимальное значение в дереве: " << tree.maxValue() << endl;
	cout << "Сумма элементов дерева: " << tree.sum() << endl;
	cout << "Количество элементов дерева: " << tree.count() << endl;
	cout << "Среднее-арифметическое элементов дерева: " << tree.avg() << endl;
	//int value;
	//cout << "Введите удаляемое значение: "; cin >> value;
	//tree.erase(value);
	//tree.print();
	cout << "Глубина дерева: " << tree.depth() << endl;
	int depth;
	cout << "Введите желаемую глубину: "; cin >> depth;
	tree.depth_print(depth);
	tree.tree_print();
#endif // ERASE_CHECK

#ifdef BALANCE_CHECK
	Tree tree = { 55, 34, 21, 13, 8, 5, 3 };
	tree.tree_print();
#endif // BALANCE_CHECK

}