int main() {
    const int MAX_STRINGS = 10;  // Максимальное количество строк в массиве
    const int MAX_LENGTH = 3;     // Максимальная длина строки

    std::string strings[MAX_STRINGS];
    int count = 0;

    // Ввод строк с клавиатуры
    std::cout << "Введите строки (для окончания ввода нажмите Enter без ввода текста):\n";
    for (int i = 0; i < MAX_STRINGS; ++i) {
        std::cout << i + 1 << ": ";
        std::getline(std::cin, strings[i]);
        if (strings[i].empty()) {
            break;
        }
        ++count;
    }

    // Создание нового массива с указанными условиями
    std::string newStrings[MAX_STRINGS];
    int newCount = 0;
    for (int i = 0; i < count; ++i) {
        if (strings[i].length() <= MAX_LENGTH) {
            newStrings[newCount++] = strings[i];
        }
    }

    // Вывод нового массива
    std::cout << "Новый массив строк с длиной <= 3 символов:\n";
    for (int i = 0; i < newCount; ++i) {
        std::cout << newStrings[i] << "\n";
    }

    return 0;
}