class IndexingClass
{
    private int[] array;

    public IndexingClass(int[] array)
    {
        this.array = array;
    }

    // Индексатор
    public int this[int index]
    {
        get
        {
            return array[index];
        }

        set
        {
            array[index] = value;
        }
    }
}
