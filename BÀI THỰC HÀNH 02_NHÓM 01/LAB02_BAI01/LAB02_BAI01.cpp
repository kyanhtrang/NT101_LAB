#include <iostream>
#include <string>
#include <math.h>
#include <stdlib.h>
#include <ctime>
#include <vector>
#include <iomanip> 
#include <random>

using std::vector;
using std::string;

vector<long long int> Reminder;
long long reminder;
bool greater_equal(const vector<long long int>& v1, const vector<long long int>& v2)
{
	if (v1.size() > v2.size()) return true;
	else if (v1.size() < v2.size()) return false;
	else
		for (int i = 0; i < v1.size(); ++i)
		{
			if (v1[i] > v2[i]) return true;
			if (v1[i] < v2[i]) return false;
		}
	return true;
}
bool greater(const vector<long long int>& v1, const vector<long long int>& v2)
{
	if (v1.size() > v2.size()) return true;
	else if (v1.size() < v2.size()) return false;
	else
		for (int i = 0; i < v1.size(); ++i)
		{
			if (v1[i] > v2[i]) return true;
			if (v1[i] < v2[i]) return false;
		}
}
bool equalvec(const vector<long long int>& x, const vector<long long int>& y)
{
	if (x.size() != y.size()) return false;
	else
	{
		for (int i = 0; i < x.size(); i++)
		{
			if (x[i] != y[i]) return false;
		}
		return true;
	}
}
vector<long long int> convertNumber(const string p, int l = 9)
{
	vector<long long int> P;
	string a;
	// inserting the input in vectors
	//P
	int x = p.length() % l;
	if (x != 0)
	{
		a = p.substr(0, x);
		P.push_back(atoll(a.c_str()));
	}
	for (int i = x; i < p.length(); i += l)
	{
		a = p.substr(i, l);
		P.push_back(atoll(a.c_str()));
	}
	return P;
}
vector<long long int> add(const vector<long long int>& x1, const vector<long long int>& y1, const int l = 9)
{
	long long int carry = 0;
	long long int k;
	long long int p;
	vector<long long int> temp;
	vector<long long int> x = x1;
	vector<long long int>y = y1;
	int diff = abs((int)(x.size() - y.size()));
	if (x.size() > y.size()) { y.insert(y.begin(), diff, 0); }
	else if (x.size() < y.size()) { x.insert(x.begin(), diff, 0); }
	for (int i = x.size() - 1; i >= 0; --i)
	{
		k = x[i] + y[i] + carry;
		p = pow(10, l);
		temp.insert(temp.begin(), k % p);
		carry = k / p;
	}
	if (carry != 0) { temp.insert(temp.begin(), carry); }
	return temp;
}
vector<long long int> sub(const vector<long long int>& x1, const vector<long long int>& y1)
{
	vector<long long int> temp;
	vector<long long int> x = x1;
	vector<long long int>y = y1;
	int diff = abs((int)(x.size() - y.size()));
	if (x.size() > y.size()) { y.insert(y.begin(), diff, 0); }
	for (int i = x.size() - 1; i >= 0; --i)
	{
		if (x[i] < y[i])
		{
			x[i] += 1000000000;
			x[i - 1]--;
		}
		temp.insert(temp.begin(), x[i] - y[i]);
	}

	return temp;
}

//sub with mod
vector<long long int> sub(const vector<long long int>& x1, const vector<long long int>& y1, const vector<long long int>& n)
{
	vector<long long int> temp;
	vector<long long int> x = x1;
	vector<long long int> y = y1;
	bool flag = false;
	int diff = abs((int)(x.size() - y.size()));
	if (x.size() > y.size()) { y.insert(y.begin(), diff, 0); }
	else if (x.size() < y.size()) { x.insert(x.begin(), diff, 0); flag = true; }
	else //x and y have the same size
	{
		if (greater(y, x))  flag = true;
	}
	if (flag == false)
	{
		for (int i = x.size() - 1; i >= 0; --i)
		{
			if (x[i] < y[i])
			{
				x[i] += 1000000000;
				x[i - 1]--;
			}
			temp.insert(temp.begin(), x[i] - y[i]);
		}
		return temp;
	}
	else
	{
		for (int i = y.size() - 1; i >= 0; --i)
		{
			if (y[i] < x[i])
			{
				y[i] += 1000000000;
				y[i - 1]--;
			}
			temp.insert(temp.begin(), y[i] - x[i]);
		}
		temp[0] = -temp[0];
	}
	return temp;
}
vector<long long int> multiply(const vector<long long int>& x1, const vector<long long int>& y1)
{
	vector<long long int> result;
	vector<long long int> x;
	vector<long long int> y;
	long long int carry;
	long long int k;
	x = x1; y = y1;
	int counter = 0;
	if (x.size() > y.size()) { x.swap(y); } // for time optimization
	result.insert(result.begin(), x.size() + y.size(), 0);

	for (int i = x.size() - 1; i >= 0; --i)
	{
		int len = result.size() - 1 - counter;
		carry = 0;

		for (int j = y.size() - 1; j >= 0; --j)
		{
			k = x[i] * y[j] + carry + result[len];
			result[len] = k % 1000000000;
			carry = k / 1000000000;
			--len;
		}
		//j=0 , may be there is a carry
		if (carry != 0) { result[len] = carry; }
		++counter;
	}

	while ((result[0] == 0) && (result.size() != 1)) // erase leading zeros
		result.erase(result.begin());

	return result;
}
vector<long long int>parsevector(const vector<long long int>& v, int l)
{
	vector<long long int> result;
	for (int i = 0; i < l; i++)
	{
		result.push_back(v[i]);
	}
	return result;
}
vector<long long int>doubledivision(const vector<long long int>& dividend1, const vector<long long int>& divisor)
{
	vector<long long int> quotient;
	vector<long long int> dividend = dividend1;
	vector<vector<long long int>> multiplies;
	vector<long long int> vec;
	vector<long long int> c;
	long long int c1 = 1;
	multiplies.push_back(vec = divisor);
	c.push_back(c1);
	vector<long long int> div;
	while (greater_equal(dividend, divisor))
	{
		vector<long long int> find;
		vector<long long int> value; value.push_back(0);
		div = parsevector(dividend, divisor.size());
		if (!greater_equal(div, divisor))
		{
			div.push_back(dividend[div.size()]);
		}
		//div=parsevector(dividend,divisor.size()+1);
		while (greater(div, multiplies[multiplies.size() - 1]))
		{
			find = multiplies[multiplies.size() - 1];
			value[0] = c1;
			multiplies.push_back(vec = add(vec, vec));
			c.push_back(c1 = c1 * 2);
		}

		if (find.size() == 0)
		{
			int index = multiplies.size() - 1;
			while (true)
			{
				if (greater_equal(div, multiplies[index]))break;
				--index;
			}
			find = multiplies[index];
			value[0] = c[index];
		}
		find.insert(find.end(), (dividend.size() - div.size()), 0);
		if (value[0] / 1000000000 != 0)
		{
			long long que = value[0];
			value[0] = que / 1000000000;
			value.push_back(que % 1000000000);
		}
		value.insert(value.end(), (dividend.size() - div.size()), 0);
		dividend = sub(dividend, find);
		while (dividend[0] == 0) // erase leading zeros
			dividend.erase(dividend.begin());
		quotient = add(quotient, value, 9);
	}
	Reminder = dividend;
	return quotient;
}

vector<long long int>longdivision(const vector<long long int>& dividend, int n = 2)
{
	int i = 0;
	vector<long long int> quotient;
	vector<long long int> temp = dividend;
	long long t = 0;
	while (i != temp.size())
	{
		t = t * 1000000000 + temp[i];
		if (t >= n)
		{
			quotient.push_back(t / n);
			t = t % n;
		}
		++i;
	}
	reminder = t;
	return quotient;
}

//power(a,b,mod n) ---> a^b mod n
vector<long long int> exp(const vector<long long int>& a, const vector<long long int>& b1, const  vector<long long int>& n)
{
	vector<long long int> e = { 1 };
	vector<long long int> b = b1;
	vector<long long int> m;
	if (b.size() == 1 && b[0] == 1) return a;
	if (b[b.size() - 1] % 2 == 0)
	{
		b = longdivision(b);
		m = exp(a, b, n);
		m = multiply(m, m);
		if (greater_equal(m, n))
		{
			doubledivision(m, n);
			m = Reminder;
		}
		return m;
	}
	else
	{
		b = sub(b, e);
		m = exp(a, b, n);
		m = multiply(m, a);
		if (greater_equal(m, n))
		{
			doubledivision(m, n);
			m = Reminder;
		}
		return m;
	}
}
//modulo(a,b) a%b
vector<long long int> gcd(const vector<long long int>& a, const vector<long long int>& b1) {
	vector<long long int> zero = { 0 };
	vector<long long int> temp;
	vector<long long int> temp1;
	temp1 = a; temp = b1;
	while (!equalvec(temp, temp1)) {
		if (greater(temp, temp1)) {
			temp = sub(temp, temp1);
			//print(temp);
		}
		else {
			temp1 = sub(temp1, temp);
			//print(temp1);
		}
	}
	return temp;
}

bool MillerRabin(vector<long long int>& n, vector<long long int>a)
{
	vector<long long int>r = { 1 };
	vector<long long int>t = { 2 };
	vector<long long int>temp;
	vector<long long int> q;
	vector<long long int>n_1;
	int k = 0;
	n_1 = sub(n, r);
	temp = n_1;

	do
	{
		q = temp;
		temp = longdivision(q);
		++k;
	} while (reminder == 0);
	--k;
	temp = exp(a, q, n);
	if (temp.size() == 1 && temp[0] == 1)
		return true;
	if (equalvec(temp, n_1)) return true;
	for (int j = 1; j < k; ++j)
	{
		temp = multiply(temp, temp);
		if (greater_equal(temp, n))
		{
			doubledivision(temp, n);
			temp = Reminder;
		}
		if (equalvec(temp, n_1))
			return true;
	}
	return false;
}
void print(vector<long long int> n)
{
	std::cout << n[0];
	for (int i = 1; i < n.size(); ++i)
	{
		std::cout << std::setw(9) << std::setfill('0') << n[i];
	}
	std::cout << "\n";
}
string BigNumRand(long long unsigned digit) {
	int a = digit / 9, b = digit - a * 9, ranNum = 0, i, min_b, max_b;
	string LargeNumber = "", temp = "", min_b_str, max_b_str;
	std::random_device rd;
	if (b != 0)
	{
		for (i = 0; i < b; i++)
		{
			min_b_str += "1";
			max_b_str += "9";
		}
		min_b = stoi(min_b_str);
		max_b = stoi(max_b_str);
		std::uniform_int_distribution<int> dist_b(min_b, max_b);
		ranNum = dist_b(rd);
		temp = std::to_string(ranNum);
		LargeNumber += temp;
	}
	std::uniform_int_distribution<int> dist_a(100000001, 999999999);
	for (i = 0; i < a; i++)
	{
		ranNum = dist_a(rd);
		temp = std::to_string(ranNum);
		LargeNumber += temp;
	}
	return LargeNumber;
}

void printvec(vector<long long int> n) {
	//std::cout << n[0];
	bool flag = false;
	for (int i = 0; i < n.size(); i++)
	{
		if (n[i] == 0 && flag == false) {
			continue;
		}
		else {
			flag = true;
		}
		if (flag == true)
			std::cout << std::setw(1) << std::setfill('0') << n[i];
	}
	std::cout << "\n";
}
void Cau1()
{
	std::cout << "----- Random mot so lon voi do dai cho truoc -----\n";
	int dodai;
	std::cout << "Nhap vao do dai chuoi so a: ";
	std::cin >> dodai;
	clock_t begin = clock();
	std::cout << BigNumRand(dodai) << std::endl;
	
	clock_t end = clock();
	double elapsed_secs = double(end - begin) / CLOCKS_PER_SEC;
	std::cout << "total time: " << elapsed_secs << "\n";
}

void Cau2()
{
	std::cout << "----- Tinh GCD cua 2 so lon -----" << std::endl;
	string A, B;
	vector<long long int> a, b, res;
	//res = convertNumber("1");
	string ps;
	int f;

	int n, m;
	std::cout << "Nhap vao do dai day so a: ";
	std::cin >> n;
	std::cout << "Nhap vao do dai chuoi so b: ";
	std::cin >> m;

	clock_t begin = clock();
	A = BigNumRand(n);
	std::cout << "Chuoi so a: " << A << "\n";
	B = BigNumRand(m);
	std::cout << "Chuoi so b: " << B << "\n";

	a = convertNumber(A);
	b = convertNumber(B);

	res = gcd(a, b);

	std::cout << "GCD cua 2 so a va b: ";
	printvec(res);

	clock_t end = clock();
	double elapsed_secs = double(end - begin) / CLOCKS_PER_SEC;
	std::cout << "total time: " << elapsed_secs << "\n";
}

void Cau3()
{
	std::cout << "----- Tinh a^x mod p voi x > 80 -----\n";
	vector<long long int> a, x, p, res;
	int m, n, t;
	std::cout << "Nhap vao do dai so a: ";
	std::cin >> m;
	std::cout << "Nhap vao do dai so x: ";
	std::cin >> n;
	std::cout << "Nhap vao do dai so p: ";
	std::cin >> t;

	clock_t begin = clock();
	std::cout << "a = ";
	a = convertNumber(BigNumRand(m));
	print(a);
	std::cout << "x = ";
	x = convertNumber(BigNumRand(n));
	print(x);
	std::cout << "p = ";
	p = convertNumber(BigNumRand(t));
	print(p);
	std::cout << "a^x mod p: ";
	res = exp(a, x, p);
	print(res);
	clock_t end = clock();
	double elapsed_secs = double(end - begin) / CLOCKS_PER_SEC;
	std::cout << "total time: " << elapsed_secs << "\n";
}

void Cau4()
{
	int Bai;
	std::cout << "4.1 Kiem tra mot so co phai so nguyen to khong\n";
	std::cout << "4.2 Random mot so nguyen to lon voi do dai cho san\n";
	std::cout << "Chon 1 trong 2 bai sau bang cach nhap so: ";
	std::cin >> Bai;
	if (Bai == 1)
	{
		std::cout << "----- Kiem tra so nguyen to lon -----\n";
		bool flag;
		string p;
		vector <long long int> P;
		vector<long long>a = { 2 };
		std::cout << "Nhap vao so can kiem tra: ";
		std::cin >> p;

		clock_t begin = clock();
		P = convertNumber(p);
		flag = MillerRabin(P, a);
		if (flag == true)
		{
			std::cout << "p la so nguyen to" << "\n";
			clock_t end = clock();
			double elapsed_secs = double(end - begin) / CLOCKS_PER_SEC;
			std::cout << "total time: " << elapsed_secs << "\n";
		}
		else
		{
			std::cout << "p khong la so nguyen to" << "\n";
			clock_t end = clock();
			double elapsed_secs = double(end - begin) / CLOCKS_PER_SEC;
			std::cout << "total time: " << elapsed_secs << "\n";
		}
	}
	else if (Bai == 2)
	{
		int n;
		string s;
		vector <long long int> S;
		vector<long long>a = { 2 };
		bool flag;
		std::cout << "----- Random mot so nguyen to lon -----\n";
		std::cout << "Nhap vao do dai so nguyen to: ";
		std:: cin >> n;
		//std::cout << "Cho mot xiu nha!!!\n";
		clock_t begin = clock();
		do
		{
			s = BigNumRand(n);
			S = convertNumber(s);
			flag = MillerRabin(S, a);
		} while (flag == false);
		print(S);
		clock_t end = clock();
		double elapsed_secs = double(end - begin) / CLOCKS_PER_SEC;
		std::cout << "total time: " << elapsed_secs << "\n";
	}
	else
	{
		return Cau4();
	}
	
}


int main()
{
	int Bai;
	std::cout << "1. Random mot so lon voi do dai cho truoc\n";
	std::cout << "2. Tinh GCD cua 2 so lon\n";
	std::cout << "3. Tinh a^x mod p voi x > 80\n";
	std::cout << "4. So nguyen to: \n";
	std::cout << "Chon 1 bai bang cach nhap so: ";
	std::cin >> Bai;
	switch (Bai)
	{
	case 1:
	{
		Cau1();
		break;
	}
	case 2:
	{
		Cau2();
		break;
	}
	case 3:
	{
		Cau3();
		break;
	}
	case 4:
		Cau4();
		break;
	default:
		break;
	}
	return main();
}