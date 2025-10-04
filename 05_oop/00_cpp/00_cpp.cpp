#include <iostream>

// Абстрактный класс (Используется как базовый)
class Unit
{
public:
    void virtual render()
    {
        std::cout << "Unit::render()\n";
    }
    void virtual info() = 0;
};

// Абстрактный класс
class Archer : public Unit
{
public:
    void render() override
    {
        std::cout << "Archer::render()\n";
    }
};

// Обычный класс
class Warrior : public Unit
{
public:
    void render() override
    {
        std::cout << "Warrior::render()\n";
    }
    void info() override
    {
        std::cout << "Warrior::info()";
    }
};

// Интерфейсный класс (Частный случай абстрактного класса)
// Ещё такой класс называют: интерфейс или "контракт"
class Logger
{
public:
    void virtual read() = 0;
    void virtual write() = 0;
};

// Наследование от базового интерфейсного класса
// ИЛИ Наследование от интерфейса
// ИЛИ Реализация интерфейса
// ИЛИ Реализация "контракта"
class FileLogger : public Logger
{
    void virtual read() override
    {
        std::cout << "Read from file\n";
    }
    void virtual write() override
    {
        std::cout << "Write to file\n";
    }
};


int main()
{
    //Unit* u = new Unit{};               // ERROR
    //Archer* arch = new Archer{};        // ERROR
    Warrior* a = new Warrior{};

    // Logger* logger = new Logger{};     // ERROR
    FileLogger* fl = new FileLogger{};    // ERROR
}
