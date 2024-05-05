from classes import *


def intInRange(lower, upper) :
    stop = False
    while (not stop):
        try:
            number = int(input())
            while(not(number >= lower and number <= upper)):
                  print('Error: you entered a value out of range. Try again.')
                  print('Enter a value between', int(lower), 'and', int(upper), end = ': ')
                  number = int(input())
            stop = True
        except Exception as e:
            print('Invalid input: an integer value was expected. Try again:', end = ' ')
    return number


def addBook(library, title, author, year, type):
    if type.lower() == "nonfiction":
        userBook = nonFiction(title, author, year)
        library.addBook(userBook)
    elif type.lower() == "fiction":
        userBook = Fiction(title, author, year)
        library.addBook(userBook)

    return


def removeBook(library):
    while True:
        try:
            print("Which book would you like to remove")
            print(library.displayBooks())
            user_input = int(input("Enter which book would you like to remove (first books starts at 1) : "))
            if user_input:
                library.removeBook(user_input - 1)
                break
            else:
                print("Invalid")
        except ValueError:
            print("Invalid input")


if __name__ == "__main__":
    print("Welcome to the Library Management System!")
    print()

    library = Library()

    while True:
        try:
            print("1. Create a add book to the library")
            print("2. Remove a book from the library")
            print("3. Display all books in the library")
            print("4. Exit")
            user_input = int(input("Please Choose your Option:"))

            if user_input == 1:
                title = input("Enter the title of the book: ")
                author = input("Enter the author of the book: ")
                print("Enter the year the book was published: ", end="")
                year = intInRange(0,9999)

                type = input("Enter the type of the book: ")
                while type.lower() != "nonfiction" and type.lower() != "fiction":
                    print("Invalid. Please enter 'nonfiction' or 'fiction'.")
                    type = input("Enter the type of the book: ")

                addBook(library, title, author, year, type)

            elif user_input == 2:
                print("Removing book...")
                removeBook(library)

            elif user_input == 3:
                print("Displaying all books in the library")
                print(library.displayBooks())
                print("----------------------")

            elif user_input == 4:
                break

            else:
                print("Invalid option. Please choose a valid option (1, 2, 3, or 4).")
                continue

        except ValueError:
            print("Invalid input. Please enter a number (1, 2, 3, or 4).")
