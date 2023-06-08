
/* Малков Даниил 21ВИ1
Предметная область: Банк
1. Создать конструкторы класса:
 - По умолчанию
 - С параметром 
 - Копирование
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
    User() { // По умолч
        cout << "Конструктор по умолчанию User\n";
    };
    User(int num, string name1, string name2, string name3, string pass) { // С параметром
        num_account = num;
        Surname = name1;
        Name = name2;
        Other = name3;
        seriesand_number = pass;
        cout << "Конструктор с параметром User\n";
    }
    User(const User& T) { // Копирование
        num_account = T.num_account;
        Surname = T.Surname;
        Name = T.Name;
        Other = T.Other;
        seriesand_number = T.seriesand_number;
        cout << "Конструктор копирования User\n";
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
    Contribution() {
        cout << "Конструктор по умолчанию вклады\n";
    }
    Contribution(int id, int num, int deposSUM,tm*ltm) {
        id = id;
        num_cat = num;
        day = ltm->tm_mday;
        mon = 1 + ltm->tm_mon;
        year = 1899 + ltm->tm_year;
        min = ltm->tm_min;
        hour = ltm->tm_hour;
        cout << "Конструктор с параметром вклады\n";
    }
    Contribution(const Contribution& T) {
        num_cat = T.num_cat;
        deposit_sum = T.deposit_sum; // Сумма вклада
        day = T.day; // День операции
        mon = T.mon; // Месяц
        year = T.year; // Год
        min = T.min;
        hour = T.hour;
        cout << "Конструктор копирования вклады\n";
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
    User Den = User(1, "Малков", "Даниил", "Дмитриевич", "1234567893");
    User Vlad(Den);
}

