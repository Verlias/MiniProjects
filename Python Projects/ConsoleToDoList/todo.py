# Task Class & ToDoList

class Task:
    def __init__(self, title, description, due_date, priority):
        self.__title = title
        self.__description = description
        self.__due_date = due_date
        self.__priority = priority
        self.__completed = False

    # Getters
    def get_title(self):
        return self.__title

    def get_description(self):
        return self.__description

    def get_due_date(self):
        return self.__due_date

    def get_priority(self):
        return self.__priority

    def get_completed(self):
        return self.__completed

    # Setters
    def set_title(self, new_title):
        self.__title = new_title

    def set_description(self, new_description):
        self.__description = new_description

    def set_due_date(self, new_date):
        self.__due_date = new_date

    def set_priority(self, new_priority):
        self.__priority = new_priority

    def mark_as_completed(self):
        self.__completed = True

    def mark_as_uncompleted(self):
        self.__completed = False

    # Overloader
    def __str__(self):
        return f"Title: {self.__title}\nDescription: {self.__description}\nDue Date: {self.__due_date}\nPriority: {self.__priority}\nCompleted: {self.__completed}\n"


class TodoList:
    def __init__(self):
        self.__tasks = []

    def add_task(self, task):
        self.__tasks.append(task)

    def remove_task(self, title):
        for task in self.__tasks:
            if task.get_title() == title:
                self.__tasks.remove(task)
                print("Task removed successfully.")
                return
        print("Task not found.")

    def mark_as_completed(self, title):
        for task in self.__tasks:
            if task.get_title() == title:
                task.mark_as_completed()
                print("Task marked as completed.")
                return
        print("Task not found.")

    def display_tasks(self):
        tasks_str = ""
        for task in self.__tasks:
            tasks_str += str(task)
        return tasks_str



