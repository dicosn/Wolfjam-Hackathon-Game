import random
import time

print("Hello, foolish... person!")
time.sleep(1)
num1 = random.randint(0, 99)  # Generate a random integer
num2 = random.randint(0, 99)
user_input = input("Answer or DIE: What is "+str(num1)+" + " + str(num2) +"?\n")
print("You entered:", user_input)
won = False
if int(user_input) == num1 + num2:
    print("Immaculately correct, the best kind of correct!\n")
    time.sleep(2.0)
    won = True
else:
    print("Wrong, wrong, WRONG!!!\n")
    time.sleep(1.5)
    print("Add this to your health, genius: -(1 * 10^98)!\n")
    time.sleep(3.0)

with open("battle_result.txt", "w") as file:
    # Write content to the file
    if won:
        file.write("Won")
    else:
        file.write("Died")