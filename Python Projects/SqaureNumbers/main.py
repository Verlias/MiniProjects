def square(number, power):
    result = 1
    
    #If power is postive
    if power > 0:
        for i in range(int(power)):
            result *= number

        remainder_power = power - int(power)
        if remainder_power != 0:
            root = number ** remainder_power
            result *= root
    #If power is negative
    else:
        for i in range(abs(int(power))):
            result /= number

        remainder_power = power - abs(int(power))
        if remainder_power != 0:
            root = number ** remainder_power
            result /= root
            result = 1/result
    
    return result

       

#Python Script to compute a Squared using for loops and  ** operators
if __name__ == '__main__':
    base_number = float(input("Enter your base number: "))
    power_number = float(input("Enter your a number to raise your base number to: ")) 
    result = square(base_number, power_number)
    print(f'{base_number} raised to the {power_number} power is {result}')


