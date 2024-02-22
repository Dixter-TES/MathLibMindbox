### Таблица Products
| ID_Product | Name |
| ---- | ---- |
| 1 | Колбаса |
| 2 | Арбуз |
| 3 | Клубника |
| 4 | Дыня |
| 5 | Яблоко |
| 6 | Хлеб |
| 7 | Конфеты |
| 8 | Помидор |
| 9 | Огурец |
| 10 | Орех |
| 11 | Перец |
### Таблица Categories
| ID_Category | Name |
| ---- | ---- |
| 1 | Мучное |
| 2 | Сладкое |
| 3 | Фрукты |
| 4 | Овощи |
| 5 | Мясное |
| 6 | Скидочное |
### Таблица Product_Category
| ID_Product | ID_Category |
| ---- | ---- |
| 1 | 5 |
| 1 | 6 |
| 2 | 3 |
| 3 | 3 |
| 4 | 3 |
| 5 | 3 |
| 6 | 1 |
| 7 | 2 |
| 8 | 4 |
| 9 | 4 |
| 9 | 6 |

Для решения поставленной задачи мной был сформирован следующий SQL-запрос:
`SELECT
Name AS ProductName,
(SELECT Name FROM Categories WHERE ID_Category = Product_Category.ID_Category) AS CategoryName
FROM Products
LEFT JOIN Product_Category ON Products.ID_Product = Product_Category.ID_Product;`
