# Basic operations on numbers in "C#"

## Simple Addition and Implicit Data Conversion

### The primary ideas you should take away from this exercise

- You can perform mathematical-like addition operations on numbers.
- Both string concatenation and addition use the plus + symbol. This is called overloading an operator, and the compiler infers the proper use based on the data types it's operating on.
- When it can, the C# compiler will implicitly convert an int into a string if it's obvious that the developer is trying to concatenate the string representation of a number for presentation purposes.
- Use parentheses to define an order of operations to explicitly tell the compiler that we want to perform certain operations before other operations.

## Math Operators

- `+` is the addition operator
- `-` is the subtraction operator
- `*` is the multiplication operator
- `/` is the division operator
- `%` is the remainder for division `int/int`
- `()` is operator to change order of operations
- no exponent operator, but can use `System.Math.Pow()` method

use decimal type if you want to see quotient after decimal point

`decimal decimalQuotient = 7 / 5.0m;` => 1.4

`decimal decimalQuotient = 7.0m / 5.0m;` => 1.4

### Data type casting

- To cast `int` to `decimal`, you add the cast operator `(decimal) intNumber` before the value.\
  `decimal quotient = (decimal)first / (decimal)second;`

### Order of operations

In math, _PEMDAS_ is an acronym that helps students remember the order in which multiple operations are performed. The order is:

- Parentheses (whatever is inside the parenthesis is performed first)
- Exponents
- Multiplication and Division (from left to right)
- Addition and Subtraction (from left to right)

  C# follows the same order as PEMDAS except for exponents.

### Recap

- Use operators like `+`, `-`, `*`, and `/` to perform basic mathematical operations.
- The division of two int values will result in the truncation of any values after the decimal point. To retain values after the decimal point, you need to cast the divisor or dividend (or both) to from int into a floating point number like decimal first, then the quotient must be of the same floating point type as well in order to avoid truncation.
- Perform a cast operation to temporarily treat a value as if it were a different data type.
- Use the `%` operator to capture the remainder after division.
- The order of operations will follow the rules of the acronym PEMDAS.

## Increment / Decrement operations

### Operators

- `+=` operator adds and assigns the value on the right of the operator to the value on the left of the operator.
- `++` operator increments the value of the variable by 1

Operators like `+=`, `-=`, `*=`, `++`, and `--` are known as compound assignment operators because they compound some operation in addition to assigning the result to the variable. The `+=` operator is specifically termed the addition assignment operator.

### Placement of `++` and `--` operator before or after variable

- If you use the operator before the value as in `++value`, then the increment will happen before the value is retrieved.
- Likewise, `value++` will increment the value after the value has been retrieved.
