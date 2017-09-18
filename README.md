# [Array.diff](https://www.codewars.com/kata/array-dot-diff/csharp)

---

Your goal in this kata is to implement an difference function, which subtracts one list from another.

It should remove all values from list `a`, which are present in list `b`.
```csharp
Kata.ArrayDiff(new int[] {1, 2}, new int[] {1}) => new int[] {2}
```
If a value is present in `b`, all of its occurrences must be removed from the other:
```csharp
Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
```

---

### 中文大意

找出在 a 裡面所有不在 b 的數字
