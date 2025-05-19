import global_vars

def change_data_format():
    #global data_format
    print(f"Укажите формат файлы с данными справочника.  Текущий формат: {global_vars.data_format}\n")
    print("[1] - Формат CSV\n"
          "[2] - Формат TXT\n"
          "[0] - Выход в главное меню\n")
    select_menu = int(input('Выберите пункт меню: '))

    while select_menu < 1 or select_menu > 2:
        if select_menu == 0: return
        print("Error: Выбранный пункт меню не существует!")
        select_menu = int(input('Выберите пункт меню: '))
    
    if select_menu == 1:
        global_vars.data_format = "CSV"
        print(f"Выбран формат данных справочника {global_vars.data_format}")
    elif select_menu == 2:
        global_vars.data_format = "TXT"
        print(f"Выбран формат данных справочника {global_vars.data_format}")
