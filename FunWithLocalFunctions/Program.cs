Console.WriteLine("AddWrapper = {0}", AddWrapper(1, 2)); // 3
Console.WriteLine();
Console.WriteLine("AddWrapperWithSideEffect = {0}", AddWrapperWithSideEffect(1, 2)); // 4
Console.WriteLine();
Console.WriteLine("AddWrapperWithStatic = {0}", AddWrapperWithStatic(1, 2)); // 3


static int AddWrapper(int x, int y)
{
    return Add();

    int Add()
    {
        return x + y;
    }

}


static int AddWrapperWithSideEffect(int x, int y)
{
    //Do some validation here
    return Add();
    int Add()
    {
        x += 1;
        return x + y;
    }
}

static int AddWrapperWithStatic(int x, int y)
{
    //Do some validation here
    return Add(x, y);
    static int Add(int x, int y)
    {
        return x + y;
    }
}