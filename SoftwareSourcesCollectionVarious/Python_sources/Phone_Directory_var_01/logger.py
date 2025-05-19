from data_create import name_data, surname_data, phone_data, address_data
import pathlib
import global_vars

# Для работы с форматом CSV будем использовать штатную библиотеку
import csv

# Зададим имена файлов с данными (вместе с путем)
current_path = str(pathlib.Path.cwd())
subfolder = "\\data\\"
first_file_name = "data_file.txt"
second_file_name = "data_file.csv"
first_file_name_wp = current_path + subfolder + first_file_name
second_file_name_wp = current_path + subfolder + second_file_name

# --------------------------------------------------------------------------------------
# Добавление новой записи в справочник. Данные новой записи запрашиваются с клавиатуры
# --------------------------------------------------------------------------------------
def input_data():
    name = name_data()
    surname = surname_data()
    phone = phone_data()
    address = address_data()

    if global_vars.data_format == "TXT":
        with open(first_file_name_wp, 'a', encoding='utf-8') as f:
            f.write(f"{name}\n{surname}\n{phone}\n{address}\n\n")

    elif global_vars.data_format == "CSV":
        #with open(second_file_name_wp, 'a', encoding='utf-8') as f:
        with open(second_file_name_wp, "a", encoding="utf-8") as f:
            file_writer = csv.writer(f, delimiter = ";", lineterminator="\r")
            file_writer.writerow([name, surname, phone, address])


    # var = int(input(f"В каком формате записать данные \n\n"
    # f"1 Вариант: \n" 
    # f"{name}/n{surname}/n{phone}/n{address}\n\n"
    # f"2 Вариант: \n"
    # f"{name};{surname};{phone};{address}\n"
    # f"Выберите вариант: "))

    # while var != 1 and var != 2:
    #     print("Неправильный ввод")    
    #     var = int(input('Введите число '))
     
        
    
# -----------------------------------------------------------------------------------
# Вывод записей справочника на экран
# -----------------------------------------------------------------------------------
def print_data():
    print(f'Список всех записей в справочнике:               [Формат: {global_vars.data_format}]\n')

    # Работаем с форматом TXT
    if global_vars.data_format == "TXT":
        all_records = []
        current_record = []

        with open(first_file_name_wp, "r+", encoding="utf-8") as f:
            data = f.readlines()
        
            num_record = 0
            num_field = 0
            for line in data:
                if line != '\n':
                    current_record.append(line.strip())
                    current_record[num_field] = line.strip()
                    num_field += 1
                else:
                    all_records.append([current_record[0], current_record[1], current_record[2], current_record[3]])
                    current_record.clear
                    num_record += 1
                    num_field = 0
            
            for r, record in enumerate(all_records, 1):
                print(f"Запись #{r}: {record}")
            print("\n")
    
    # Работаем с форматом CSV
    elif global_vars.data_format == "CSV":
        with open(second_file_name_wp, "r+", encoding="utf-8") as f:
            # Создаем объект reader, указываем символ-разделитель ","
            file_reader = csv.reader(f, delimiter = ";")
            # Счетчик для подсчета количества строк и вывода заголовков столбцов
            count = 0

            # Считывание данных из CSV файла
            for row in file_reader:
                if count == 0:
                    # Вывод строки, содержащей заголовки для столбцов
                    print(f"Справочник содержит такие записи:\n"
                          f"{'\t\t'.join(row)}\n")
                else:
                    # Вывод строк
                    print(f"Запись #{count}:\t{row[0]}\t\t{row[1]}\t\t{row[2]}\t\t{row[3]}")
                count += 1
            print(f'\nВсего в справочнике {count - 1} записей.\n\n')


# -----------------------------------------------------------------------------------
# Изменение одной конкретной записи в справочнике
# -----------------------------------------------------------------------------------
def change_data():  

    # Формат TXT
    if global_vars.data_format == "TXT":
        
        print_data()

        print("Введите номер записи, которую вы хотите изменить.\n"
              "Введите 0 (ноль), чтобы прервать операцию удаления.\n")
        user_select = int(input("Введите номер записи для редактирования: "))
        if user_select == 0: return

        all_records = []
        current_record = []

        with open(first_file_name_wp, "r+", encoding="utf-8") as f:
            data = f.readlines()
        
            num_record = 0
            num_field = 0
            for line in data:
                if line != '\n':
                    current_record.append(line.strip())
                    current_record[num_field] = line.strip()
                    num_field += 1
                else:
                    if num_record == user_select - 1:
                        # Вносим изменения в указанную запись
                        name = name_data()
                        surname = surname_data()
                        phone = phone_data()
                        address = address_data()
                        all_records.append([name, surname, phone, address])
                    else:
                        all_records.append([current_record[0], current_record[1], current_record[2], current_record[3]])
                    current_record.clear
                    num_record += 1
                    num_field = 0

            with open(first_file_name_wp, "w", encoding="utf-8") as f:
                for i, record in enumerate(all_records):
                    f.write("".join([all_records[i][0], "\n", all_records[i][1], "\n", all_records[i][2], "\n", all_records[i][3], "\n\n"]))
   

    # Формат CSV    
    elif global_vars.data_format == "CSV":
        rows = []
        # Покажем список записей
        print_data()

        print("Введите номер записи, которую вы хотите изменить.\n"
              "Введите 0 (ноль), чтобы прервать операцию редактирования справочника.\n")
        user_select = int(input("Введите номер записи для изменения: "))

        if user_select > 0:
            with open(second_file_name_wp, "r+", encoding="utf-8") as f:
                # Создаем объект reader, указываем символ-разделитель "; "
                file_reader = csv.reader(f, delimiter = ";")
                # Счетчик для подсчета количества строк и вывода заголовков столбцов
                count = 0

                # Считывание данных из CSV файла
                for row in file_reader:               
                    # Изменяем запись
                    if count == user_select:
                        name = name_data()
                        surname = surname_data()
                        phone = phone_data()
                        address = address_data()
                        rows.append([name, surname, phone, address])
                    else:
                        rows.append(row)
                    count += 1

            with open(second_file_name_wp, "w", encoding="utf-8") as f:
                file_writer = csv.writer(f, delimiter = ";", lineterminator="\r")
                for row in rows:
                    file_writer.writerow(row)
            
            print("Запись успешно изменена.")


# -----------------------------------------------------------------------------------
# Удаление одной конкретной записи из справочника
# -----------------------------------------------------------------------------------
def delete_data():
        # Формат TXT
        if global_vars.data_format == "TXT":
            # Покажем список записей
            print_data()

            print("Введите номер записи, которую вы хотите удалить.\n"
                  "Введите 0 (ноль), чтобы прервать операцию удаления.\n")
            user_select = int(input("Введите номер записи для удаления: "))
            if user_select == 0: return

            all_records = []
            current_record = []

            with open(first_file_name_wp, "r+", encoding="utf-8") as f:
                data = f.readlines()
        
                num_record = 0
                num_field = 0
                for line in data:
                    if line != '\n':
                        current_record.append(line.strip())
                        current_record[num_field] = line.strip()
                        num_field += 1
                    else:
                        if num_record != user_select - 1:
                            all_records.append([current_record[0], current_record[1], current_record[2], current_record[3]])
                        current_record.clear
                        num_record += 1
                        num_field = 0

                with open(first_file_name_wp, "w", encoding="utf-8") as f:
                    for i, record in enumerate(all_records):
                        f.write("".join([all_records[i][0], "\n", all_records[i][1], "\n", all_records[i][2], "\n", all_records[i][3], "\n\n"]))
                    
        # Формат CSV
        elif global_vars.data_format == "CSV":
            # Покажем список записей
            print_data()

            print("Введите номер записи, которую вы хотите удалить.\n"
                  "Введите 0 (ноль), чтобы прервать операцию удаления.\n")
            user_select = int(input("Введите номер записи для удаления: "))

            # Так как записи в файле у нас хранятся построчно, то достаточно просто просто перезаписать файл
            # с записями справочника, просто пропустив ту запись, которую мы решили удалить.
            with open(second_file_name_wp, "r", encoding="utf-8") as f:
                data = f.readlines()
            
            with open(second_file_name_wp, "w", encoding="utf-8") as f:
                for i, line in enumerate(data):
                    if i != user_select:
                        f.write(line)
