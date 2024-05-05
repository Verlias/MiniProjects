from abc import ABC, abstractmethod


class Book(ABC):
    def __init__(self, title, author, year):
        self.__title = title
        self.__author = author
        self.__year = year

    # Getters
    def getTitle(self):
        return self.__title

    def getAuthor(self):
        return self.__author

    def getYear(self):
        return self.__year

    # Setters
    def UpdateTitle(self, newTitle):
        self.__title = newTitle

    def UpdateAuthor(self, newAuthor):
        self.__author = newAuthor

    def UpdateYear(self, newYear):
        self.__year = newYear

    @abstractmethod
    def getInfo(self):
        pass


class nonFiction(Book):
    def __init__(self, title, author, year, type="Non-Fiction"):
        super().__init__(title, author, year)
        self.__type = type

    def getType(self):
        return self.__type

    # Abstract Method Inheritance
    def getInfo(self):
        return f"Title: {self.getTitle()}\nAuthor: {self.getAuthor()}\nYear Published: {self.getYear()}\nGenre: {self.getType()}"


class Fiction(Book):
    def __init__(self, title, author, year, type="Fiction"):
        super().__init__(title, author, year)
        self.__type = type

    def getType(self):
        return self.__type

    # Abstract Method Inheritance
    def getInfo(self):
        return f"Title: {self.getTitle()}\nAuthor: {self.getAuthor()}\nYear Published: {self.getYear()}\nGenre: {self.getType()}"


class Library:
    def __init__(self, book=[]):
        self.__book = book

    def addBook(self, newBook):
        self.__book.append(newBook)

    def removeBook(self, index):
        del self.__book[index]

    def getBook(self):
        return self.__book

    def displayBooks(self):
        displayString = f""
        books = self.getBook()
        for book in books:
            displayString += f"\n{book.getInfo()}"

        return displayString
