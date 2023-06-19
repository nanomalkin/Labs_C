/* Малков Даниил 21ВИ1
Предметная область: Банк
3. Наследование
- наследование класса
- использование наследуемых параметров
*/
#define _CRT_SECURE_NO_WARNINGS
#include <iostream>
#include <windows.h>
#include <stdio.h>
#include <math.h>
#include <string>
#include <cstring>
#include <string.h>
#include <ctime>

using namespace std;

class User {
    string Surname; // Фамилия
    string Name; // Имя 
    string Other; // Отчество
    string seriesand_number; // Серия и номер
public:
    int    num_account; // Номер счёта
    User() {};
    User(int num, string name1, string name2, string name3, string pass) { // С параметром
        num_account = num;
        Surname = name1;
        Name = name2;
        Other = name3;
        seriesand_number = pass;
    }
    User(const User& T) { // Копирование
        num_account = T.num_account;
        Surname = T.Surname;
        Name = T.Name;
        Other = T.Other;
        seriesand_number = T.seriesand_number;
    }

    int getNumAccount() const {
        return num_account;
    }

    void setNumAccount(int num) {
        num_account = num;
    }

    friend istream& operator >> (istream& in, User& user) // Перегрузка ввода
    {
        cout << "\nПерегрузка ввода User";
        cout << "\nВаш номер аккаунта: ";
        in >> user.num_account;
        cout << "Введите фамилию: ";
        in >> user.Surname;
        cout << "Введите имя: ";
        in >> user.Name;
        cout << "Введите отчество: ";
        in >> user.Other;
        cout << "Введите серию и номер паспорта: ";
        in >> user.seriesand_number;

        return in;
    }
    friend ostream& operator << (ostream& out, User& user) {
        out << "------------\n№ " << user.num_account;
        cout << "\nПерегрузка вывода User";
        out << "\nФ: " << user.Surname;
        out << "\nИ: " << user.Name;
        out << "\nО: " << user.Other;
        out << "\nPass: " << user.seriesand_number;
        return out;
    }
};


class Contribution : public User {
    int id;
    string category[5] = { "До_востребования", "Валютные_депозиты", "Сберегательный","Накопительный", "Расчётный" };
    int num_cat;
    int deposit_sum;
    int day;
    int mon;
    int year;
    int min;
    int hour;
    time_t now = time(0);
    tm* ltm = localtime(&now);
public:
    Contribution() {};
    Contribution(const User& user)
        : User(user), id(user.getNumAccount()) {}

    int get_deposit_sum() {
        return deposit_sum;
    }

    void set_deposit_sum(int a) {
        deposit_sum += a;
        cout << "\nАрифметическая операция\n";
    }

    friend istream& operator >> (istream& in, Contribution& contribution)
    {
        cout << "\nПерегрузка ввода Вклад";
        time_t now = time(0);
        tm* ltm = localtime(&now);
        contribution.id = contribution.getNumAccount();// устанавливаем id равным num_account
        cout << "\n№"<< contribution.id;
        cout << "\nВыберите сумму вклада: ";
        in >> contribution.deposit_sum;
        cout << "Выберите номер категории:\n";
        for (int i = 0; i < 5; i++)
            cout << "  (" << i << ")" << contribution.category[i] << endl;
        in >> contribution.num_cat;
        contribution.day = contribution.ltm->tm_mday;
        contribution.mon = 1 + contribution.ltm->tm_mon;
        contribution.year = 1900 + contribution.ltm->tm_year;
        contribution.min = contribution.ltm->tm_min;
        contribution.hour = contribution.ltm->tm_hour;
        cout << "Дата сегодня: " << contribution.day << "." << contribution.mon << "." << contribution.year << " " << contribution.hour << ":" << contribution.min;
        return in;
    }
    friend ostream& operator << (ostream& out, Contribution& contribution) {
        cout << "\nПерегрузка вывода Вклад\n";
        out << "\n№ " << contribution.id;
        out << "\nВклад: " << contribution.category[contribution.num_cat];
        out << "\nСумма: " << contribution.get_deposit_sum();
        out << "\nДата: " << contribution.day << "." << contribution.mon << "." << contribution.year << " " << contribution.hour << ":" << contribution.min;
        return out;
    }
};

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    setlocale(LC_ALL, "Rus");

    User Daniil;
    cin >> Daniil;
    cout << Daniil;

    cout << endl;

    Contribution Dans;
    Dans.setNumAccount(Daniil.getNumAccount());
    cin >> Dans;
    cout << Dans;

    return 0;
}
