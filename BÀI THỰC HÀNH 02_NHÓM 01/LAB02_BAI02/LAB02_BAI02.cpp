#include <iostream>
#include <string>
#include <math.h>
#include <stdlib.h>
#include<ctime>
#include <vector>
#include <iomanip> 

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

//E-> b and n-> m
vector<long long int> getD(vector<long long int>& b, vector<long long int>& m)
{

	vector<long long int>A2, A3, B2, B3, T2, Q, temp, t;
	A2.push_back(0);
	B2.push_back(1);
	A3 = m;
	B3 = b;
	while (true)
	{
		if (B3.size() == 1 && B3[0] == 1)
		{
			if (B2[0] < 0)
			{
				B2[0] = -B2[0];
				B2 = sub(m, B2);
			}
			else if (B2[0] > 0 && greater_equal(B2, m))
			{
				B2 = sub(m, B2);
			}
			return B2;
		}

		Q = doubledivision(A3, B3);
		temp = B2;
		if (A2[0] < 0 && B2[0] < 0) //A2 & B2 are -ve
		{
			A2[0] = -A2[0];
			B2[0] = -B2[0];
			t = multiply(Q, B2);
			T2 = sub(A2, t, m);

		}
		else if (A2[0] < 0 && B2[0]>0) //A2 is -ve & B2 is +ve
		{
			A2[0] = -A2[0];
			t = multiply(Q, B2);
			T2 = add(A2, t);
			T2[0] = -T2[0];

		}
		else if (A2[0] > 0 && B2[0] < 0) //A2 is +ve & B2 is -ve
		{
			B2[0] = -B2[0];
			t = multiply(Q, B2);
			T2 = add(A2, t);
		}
		else //A2 & B2 are +ve
		{
			t = multiply(Q, B2);
			T2 = sub(A2, t, m);
		}
		//T2 = sub(A2, multiply(Q, B2), m);

		A2 = temp;//B2
		A3 = B3;
		B2 = T2;
		B3 = Reminder;
	}
}

vector<long long int> PrintPhi(vector<long long int>& x, vector<long long int>& y)
{
	vector<long long int> n;
	vector<long long int> temp, x1, y1;
	temp.push_back(1);
	x1 = sub(x, temp);
	y1 = sub(y, temp);
	n = multiply(x1, y1);
	return n;
}
vector<long long>PrintN(vector<long long int>& x, vector<long long int>& y)
{
	return multiply(x, y);
}

vector<long long int> PublicEncryption(vector<long long int>& msg, vector<long long int>& E, vector<long long int>& n)
{
	if (greater_equal(msg, n))
	{
		doubledivision(msg, n);
		msg = Reminder;
	}
	return(exp(msg, E, n));
}

vector<long long int> PrivateEncryption(vector<long long int>& msg, vector<long long int>& D, vector<long long int>& n)
{
	if (greater_equal(msg, n))
	{
		doubledivision(msg, n);
		msg = Reminder;
	}
	return(exp(msg, D, n));
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

string BigNumRand(long long unsigned n) {
	int digit;
	long long unsigned count = 1;
	do {
		digit = rand() % 10;
	} while (digit == 0);
	string result = std::to_string(digit);
	while (count < n) {
		digit = rand() % 10;
		result += std::to_string(digit);
		count++;
	}
	return result;
}

int main()
{
	string p, q, e;
	vector<long long int> P, Q, E;
	string ps;
	int f;

	std::cout << "Nhap p: ";
	std::cin >> p;
	std::cout << "Nhap q: ";
	std::cin >> q;
	std::cout << "Nhap e: ";
	std::cin >> e;

	//p = "p=12369571528747655798110188786567180759626910465726920556567298659370399748072366507234899432827475865189642714067836207300153035059472237275816384410077871";
	f = p.find("=");
	ps = p.substr(f + 1);
	P = convertNumber(ps);

	//q = "q=2065420353441994803054315079370635087865508423962173447811880044936318158815802774220405304957787464676771309034463560633713497474362222775683960029689473";
	f = q.find("=");
	ps = q.substr(f + 1);
	Q = convertNumber(ps);

	//e = "e=65537";
	f = e.find("=");
	ps = e.substr(f + 1);
	E = convertNumber(ps);

	clock_t begin = clock();
	string x = "Quit";
	vector<long long>n;
	vector<long long>phi;
	vector<long long>d;
	vector<long long>msg;
	vector<long long>massege;
	vector<long long>a = { 2 };
	bool flag;

	flag = MillerRabin(P, a);
	std::cout << "P co phai so nguyen to khong?" << "\n";
	if (flag == true)
	{
		std::cout << "Phai" << "\n";
	}
	else
	{
		std::cout << "Khong" << "\n";
		return main();
	}
	flag = MillerRabin(Q, a);
	std::cout << "Q co phai so nguyen to khong?" << "\n";
	if (flag == true)
	{
		std::cout << "Phai" << "\n";
	}
	else
	{
		std::cout << "Khong" << "\n";
		return main();
	}
	n = PrintN(P, Q);
	std::cout << "N = " << "\n";
	print(n);
	phi = PrintPhi(P, Q);
	std::cout << "Phi = " << "\n";
	print(phi);
	d = getD(E, phi);
	std::cout << "D = " << "\n";
	print(d);
	std::cout << "Nhap doan tin can ma hoa: ";
	string str, m = "";
	std::cin >> str;
	for (int i = 0; i < str.length(); i++)
	{
		int t = (int)str[i];
		m = m + std::to_string(t);
	}

	msg = convertNumber(m);
	massege = PublicEncryption(msg, E, n);
	std::cout << "EncryptPublic=<" << m << ">" << "\n";
	print(massege);
	massege = PrivateEncryption(msg, d, n);
	std::cout << "EncryptPrivate=<" << m << ">" << "\n";
	print(massege);

	clock_t end = clock();
	double elapsed_secs = double(end - begin) / CLOCKS_PER_SEC;
	std::cout << "total time: " << elapsed_secs << "\n";
	return main();
}