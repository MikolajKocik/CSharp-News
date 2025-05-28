// for all numeric types

T Sum<T> (T[] numbers) where T : INumber<T>
{
    T total = T.zero;
    foreach (T num in numbers)
        total += num;
    return total;
}