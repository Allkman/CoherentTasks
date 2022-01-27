namespace Task1.GenericDiagonalMatrix
{
    internal class ElementChangedEventArgs<T> : EventArgs
    {
        public ElementChangedEventArgs(int index, T? oldValue, T? newValue)
        {
            Index = index;
            OldValue = oldValue;
            NewValue = newValue;
        }
        public int Index { get; set; }
        public T? OldValue { get; set; }
        public T? NewValue { get; set; }

    }
}
