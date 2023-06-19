/* Малков Даниил 21ВИ1
Предметная область: Банк
4. Абстрактные классы и виртуальные функции
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

class Bank {
public:
    Bank() { cout << "Перегрузка абстрактного класса/интерфейса"; }
    virtual void getInfo() const = 0;
    virtual void setInfo() = 0;
};

class User : public Bank {
    string Surname; // Фамилия
    string Name; // Имя 
    string Other; // Отчество
    string seriesand_number; // Серия и номер
protected:
    int    num_account; // Номер счёта
public:
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

    void getInfo() const override {
        cout << "------------\n№ " << num_account;
        cout << "\nФ: " << Surname;
        cout << "\nИ: " << Name;
        cout << "\nО: " << Other;
        cout << "\nPass: " << seriesand_number;
    }

    void setInfo() override {
        cout << "\nПерегрузка ввода User";
        cout << "\nВаш номер аккаунта: ";
        cin >> num_account;
        cout << "Введите фамилию: ";
        cin >> Surname;
        cout << "Введите имя: ";
        cin >> Name;
        cout << "Введите отчество: ";
        cin >> Other;
        cout << "Введите серию и номер паспорта: ";
        cin >> seriesand_number;
    }

    friend istream& operator >> (istream& in, User& user) // Перегрузка ввода
    {
        user.setInfo();
        return in;
    }

    friend ostream& operator << (ostream& out, const User& user) {
        user.getInfo();
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

    int get_deposit_sum() const {
        return deposit_sum;
    }

    void set_deposit_sum(int a) {
        deposit_sum += a;
        cout << "\nАрифметическая операция\n";
    }

    void getInfo() const override {
        cout << "\nПерегрузка вывода Вклад\n";
        cout << "\n№ " << id;
        cout << "\nВклад: " << category[num_cat];
        cout << "\nСумма: " << get_deposit_sum();
        cout << "\nДата: " << day << "." << mon << "." << year << " " << hour << ":" << min;
    }

    void setInfo() override {
        cout << "\nПерегрузка ввода Вклад";
        id = getNumAccount();
        cout << "\n№" << id;
        cout << "\nВыберите сумму вклада: ";
        cin >> deposit_sum;
        cout << "Выберите номер категории:\n";
        for (int i = 0; i < 5; i++)
            cout << "  (" << i << ")" << category[i] << endl;
        cin >> num_cat;
        day = ltm->tm_mday;
        mon = 1 + ltm->tm_mon;
        year = 1900 + ltm->tm_year;
        min = ltm->tm_min;
        hour = ltm->tm_hour;
        cout << "Дата сегодня: " << day << "." << mon << "." << year << " " << hour << ":" << min;
    }

    friend istream& operator >> (istream& in, Contribution& contribution)
    {
        contribution.setInfo();
        return in;
    }

    friend ostream& operator << (ostream& out, const Contribution& contribution) {
        contribution.getInfo();
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
