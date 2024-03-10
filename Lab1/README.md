В моєму програмному проекті було дотримано 7 принципів програмування:

+ SOLID (окрім Dependency Inversion Principle)

+ KISS

+ DRY

+ YAGNI

**S (Single Responsibility):**

Абстрактний клас Money має в собі основні методи для роботи з [грошима](./Task1/MoneyFolder/Money.cs#L12-L63) та
абстрактний клас Warehouse уособлює в собі основні методи роботи зі [складом](./Task1/Warehouse.cs#L12-L86).

**O (Open/Closed):**

Абстрактні класи Money і Warehouse є загальними, і їхні нащадки можуть додавати свої особливі методи або перевизначати. 
Приклади [MoneyUAH](./Task1/MoneyFolder/MoneyUSD.cs#L17-L20) та [MoneyUSD](./Task1/MoneyFolder/MoneyUSD.cs#L13-L16) в собі мають перевизначений метод show(),
а ToyWarehouse додає нове поле [Category](./Task1/ToysWarehouse.cs#L11).

**L (Liskov Substitution):**

Абстрактний клас Money є базовим, він представляє роботу з грошима, в нас метод show(), який виводить на екран суму.
Класи [MoneyUAH](./Task1/MoneyFolder/MoneyUSD.cs#L17-L20) та [MoneyUSD](./Task1/MoneyFolder/MoneyUSD.cs#L13-L16) вони надають конкретну його реалізацію, тобто вивід на екран суми в певній валюті.
І тому наші класи MoneyUAH і MoneyUSD можуть замінити базовий клас

**I (Interface Segregation):**

Клас Reporting в собі реалізує 3 види [інтерфейсів](./Task1/ReportingFolder), які в свою чергу представляють можливість
працювати зі звітністю окремо. 

**KISS:**

На мою думку методи, які реалізовані просто є:

+ [AddProduct](./Task1/Warehouse.cs#L24-L28), просто додає в словник новий продукт.

+ [RemoveProduct](./Task1/Warehouse.cs#L51-L63), видаляє зі словники продук, за ключем

+ [Add та Subtract](./Task1/MoneyFolder/Money.cs#L30-L63), додає або віднімає певну суму

**DRY:**

Винесено в окремий метод [частину коду](./Task1/Warehouse.cs#L44-L50), що відповідає за надислання повідомлення всім учасникам підписки.

**YAGNI:**

На мою думку до всіх класів, додано основні методи, які потрібні для роботи.


