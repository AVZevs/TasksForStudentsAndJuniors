from logger import input_data, print_data, change_data, delete_data
import global_vars
from data_format_unit import change_data_format

def interface():
    while True:
        print("-----------------------------------------------------------------------")
        print("Это мой маленький телефонный справочник.")
        print("-----------------------------------------------------------------------")
        print("Что вы желаете сделать (выберите один из вариантов)?\n")
        print("[1] - Добавить новую запись в справочник\n"
              "[2] - Показать все записи в справочнике\n"
              "[3] - Изменить запись в справочнике (потребуется указать номер записи)\n"
              "[4] - Удалить запись из справочника (потребуется указать номер записи)\n\n"
             f"[5] - Выбрать формат справочника (TXT или CSV).   Текущий формат: {global_vars.data_format}\n"
              "[0] - Выход из программы")
        print("-----------------------------------------------------------------------")
    
    #while True:
        select_menu = int(input('Выберите пункт меню: '))

        while select_menu < 1 or select_menu > 5:
            if select_menu == 0: exit()
            print("Error: Выбранный пункт меню не существует!")
            select_menu = int(input('Выберите пункт меню: '))
    
        if select_menu == 1:
            print()
            input_data()
        elif select_menu == 2:
            print()
            print_data()
        elif select_menu == 3:
            print()
            change_data()
        elif select_menu == 4:
            print()
            delete_data()
        elif select_menu == 5:
            print()
            change_data_format()
