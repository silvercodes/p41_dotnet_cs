
// === Модификаторы доступа уровня членов класса ===

// =====1. private

// =====2. protected             (наследник)

// =====3. public                (все)

// =====4. private protected     (наследник в текущей сборке)

//using _06_modificators_example;

//Logger logger = new Logger();
// logger.path = "lkj";            // ERROR
//class FileLogger : Logger
//{
//    public FileLogger()
//    {
//        this.path = "lksdj";        // ERROR
//    }
//}

// =====5. internal              (public внутри, private снаружи)
//                          эквивалент "private public"

//using _06_modificators_example;

//Logger logger = new();
// logger.level = 4;                   // ERROR

// =====6. protected internal    (public внутри, protected снаружи)
//                          эквивалент "protected public"

//using _06_modificators_example;

//// Logger logger = new();
//// logger.key = "lkj";                 // ERROR

//class DbLogger : Logger
//{
//    public DbLogger()
//    {
//        this.key = "ttt";
//    }
//}

// =====7. file


// === Модификаторы доступа уровня типа в целом ===
// 1. public
// 2. internal
// 3. file

//using _06_modificators_example;

//DbLogger logger = new();







