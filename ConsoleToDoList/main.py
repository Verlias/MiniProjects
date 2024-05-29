# Main Script

from todo import Task, TodoList


def create_task(todo, task, description, due_date, priority):
    return todo.add_task(Task(task, description, due_date, priority))

if __name__ == "__main__":

    todo = TodoList()

    while True:
        try:
            print("What would you like to do?")
            print("1. Add")
            print("2. Remove")
            print("3. Display all task")
            print("4. Complete a Task")
            print("5. Exit")

            choice = int(input("Enter your choice: "))
            if choice == 1:
                task = input("Enter your Task: ")
                description = input("Enter your Description: ")
                due_date = input("Enter your due date: ")
                priority = input("Enter your priority: ")
                create_task(todo, task, description, due_date, priority)

            elif choice == 2:
                print(todo.display_tasks())
                task = input("Enter your Task title you would like to delete : ")
                todo.remove_task(task)

            elif choice == 3:
                print(todo.display_tasks())

            elif choice == 4:
                print(todo.display_tasks())
                task_title = input("Enter the task title you completed: ")
                todo.mark_as_completed(task_title)

            elif choice == 5:
                break

        except ValueError:
            print("Invalid")