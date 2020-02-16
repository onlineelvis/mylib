import operations as op


while True:
    print('==========================================')
    num1 = float(input("number1: "))
    user = input("set operation: ")
    num2 = float(input("number2: "))


    if user == '+':
        print('Result is: ', num1, '+', num2, '=', op.add(num1,num2))

    elif user == '-':
        print('Result is: ', num1, '-', num2, '=', op.sbutract(num1,num2))

    elif user == '*':
        print('Result is: ', num1, '*', num2, '=', op.multiplay(num1,num2))

    elif user == '/':
        print('Result is: ', num1, '/', num2, '=', op.divide(num1,num2))

    else:
        print('invalid operator')

    



