//from here
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/collections#indexable-collections

List<int> numbers = [ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 ];

  //remove odd numbers
  for (var index = numbers.Count - 1; index >= 0; index--)
  {
  if (numbers[index]% 2 == 1)
    {
    //remove the element by specifying
    //the zero-based index in the list
    numbers.RemoveAt(index);
    }
  }

  // iterate through the list
  // a lambda expression is placed in the foreach method
  // of the list(T) object
  numbers.ForEach(
    number  => Console.Write(number + " "));
// Output: 0 2 4 6 8 