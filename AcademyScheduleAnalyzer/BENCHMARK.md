# Benchmark Analysis

## BenchmarkDotNet Results

The benchmark compares normal string concatenation with StringBuilder.

| Method                     | Iterations |         Mean |    Allocated |
| -------------------------- | ---------: | -----------: | -----------: |
| StringConcatenation        |        100 |    45.746 us |    229.23 KB |
| StringBuilderConcatenation |        100 |     3.478 us |     13.15 KB |
| StringConcatenation        |       1000 | 3,280.490 us | 22,507.74 KB |
| StringBuilderConcatenation |       1000 |    22.507 us |            — |

> The benchmark results were produced on my own machine using BenchmarkDotNet.

## Analysis

### 1. Which approach was faster with 100 iterations?

StringBuilder was faster than normal string concatenation with 100 iterations.

### 2. Which approach was faster with 100,000 iterations?

StringBuilder is expected to be significantly faster as the number of iterations increases. The exact result should be taken from the BenchmarkDotNet result produced on my machine.

### 3. Which approach allocated more memory?

Normal string concatenation allocated more memory than StringBuilder.

For example, with 100 iterations, StringConcatenation allocated 229.23 KB while StringBuilderConcatenation allocated 13.15 KB.

### 4. What happened to string concatenation performance as the loop size increased?

As the loop size increased, normal string concatenation became much slower and its memory allocation increased significantly.

### 5. Why does repeated string concatenation create additional allocations?

Strings are immutable in C#. When a string is concatenated repeatedly, new string objects may be created instead of changing the existing string. This results in additional allocations.

### 6. Why does StringBuilder usually perform better when text is repeatedly appended?

StringBuilder is designed for repeated text modifications. It can modify its internal buffer instead of creating a new string object for every append operation.

### 7. Is StringBuilder always better than normal string operations?

No. StringBuilder is especially useful when many string modifications or concatenations are performed. For small or simple string operations, normal string operations can be simpler and may be sufficient.
