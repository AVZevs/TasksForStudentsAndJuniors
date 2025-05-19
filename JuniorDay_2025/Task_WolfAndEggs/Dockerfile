# Используем официальный образ Apache Web Server
FROM httpd:latest

# Устанавливаем рабочую директорию внутри контейнера
WORKDIR /usr/local/apache2/htdocs/

# Копируем исходный код проекта в контейнер (но только нужные для сайта папки)
COPY . /usr/local/apache2/htdocs/


# Копируем мои настройки Apache в контейнер
COPY ./apache-config/zevs-httpd.conf /usr/local/apache2/conf/httpd.conf

# EXPOSE 80
