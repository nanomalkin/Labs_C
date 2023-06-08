﻿/* Малков Даниил 21ВИ1
Предметная область: Банк
2. Перегрузка (+методы)
- перегрузка ввода/вывода (cout « объект;)
- любая арифметическая операция (get,set)
- любое сравнение
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
    int    num_account; // Номер счёта
    string Surname; // Фамилия
    string Name; // Имя 
    string Other; // Отчество
    string seriesand_number; // Серия и номер
public:
    User(){};
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


class Contribution:public User { // Класс вклада
    int id; 
    string category[5] = { "До_востребования", "Валютные_депозиты", "Сберегательный","Накопительный", "Расчётный" };
    int num_cat;
    int deposit_sum; // Сумма вклада
    int day; // День операции
    int mon; // Месяц
    int year; // Год
    int min;
    int hour;
    time_t now = time(0);
    tm* ltm = localtime(&now);
public:
    Contribution() {};
    Contribution(int id, int num, int deposSUM,tm*ltm) {
        id = id;
        num_cat = num;
        day = ltm->tm_mday;
        mon = 1 + ltm->tm_mon;
        year = 1899 + ltm->tm_year;
        min = ltm->tm_min;
        hour = ltm->tm_hour;
    }
    Contribution(const Contribution& T) {
        num_cat = T.num_cat;
        deposit_sum = T.deposit_sum; // Сумма вклада
        day = T.day; // День операции
        mon = T.mon; // Месяц
        year = T.year; // Год
        min = T.min;
        hour = T.hour;
    }

    int get_deposit_sum() {
        return deposit_sum;
    }

    void set_deposit_sum(int a) {
        deposit_sum += a;
        cout << "\nАрифметическая операция\n";
    }
    bool operator==(const Contribution& other) const {
        cout << "\nОперация равенства\n"; 
        return deposit_sum == other.deposit_sum;
    }

    friend istream& operator >> (istream& in, Contribution& contribution) // Перегрузка ввода
    {
        cout << "\nПерегрузка ввода Вклад";
        time_t now = time(0);
        tm* ltm = localtime(&now);
        cout << "\nВыберите номер аккаунта: ";
        in >> contribution.id;
        cout << "Выберите сумму вклада: ";
        in >> contribution.deposit_sum;
        cout << "Выберите номер категории:\n";
        for (int i = 0; i < 5; i++)
            cout << "  ("<< i <<")" << contribution.category[i] << endl;
        in >> contribution.num_cat;
        contribution.day = contribution.ltm->tm_mday;
        contribution.mon = 1 + contribution.ltm->tm_mon;
        contribution.year = 1900 + contribution.ltm->tm_year;
        contribution.min = contribution.ltm->tm_min;
        contribution.hour = contribution.ltm->tm_hour;
        cout << "Дата сегодня: " << contribution.day << "." << contribution.mon << "." << contribution.year << " " << contribution.hour << ":" << contribution.min;
        return in;
    }
    friend ostream& operator << (ostream& out, Contribution& contribution) { // Перегрузка вывода
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

    time_t now = time(0);
    tm* ltm = localtime(&now);

    User Daniil;
    cin >> Daniil;
    cout << Daniil;

    cout << endl;
    
    Contribution Dans;
    Contribution Tolic;

    cin >> Dans;
    cout << Dans;

    cout << "\nПополнение вклада на сумму: ";
    int plusSumm;
    cin >> plusSumm;
    Dans.set_deposit_sum(plusSumm);
    cout << "Текущая сумма вклада: " << Dans.get_deposit_sum() << endl;

    cin >> Tolic;
    if (Dans == Tolic) {
        cout << "Оба вклада имеют одинаковую сумму" << endl;
    }
    else {
        cout << "Вклады имеют различные суммы" << endl;
    }

}

