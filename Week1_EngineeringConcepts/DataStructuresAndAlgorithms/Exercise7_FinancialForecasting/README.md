# Exercise 7 – Financial Forecasting

## Objective

Implement a recursive algorithm to predict future financial values based on a fixed annual growth rate.

## Scenario

Develop a financial forecasting tool that predicts future values using recursion.

## Algorithm Used

Recursive Growth Calculation

## Formula

Future Value = Current Value × (1 + Growth Rate)

The calculation is repeated recursively for the specified number of years.

## Time Complexity

- Time Complexity: O(n)
- Space Complexity: O(n) (due to recursive call stack)

## Optimization

The recursive solution can be optimized by:

- Using an iterative approach
- Applying memoization when solving overlapping recursive problems

## Conclusion

Recursion provides a simple and readable solution for repetitive calculations, but iterative approaches are generally preferred for larger inputs because they avoid stack overhead.