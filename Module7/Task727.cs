// Создайте схему классов A, B, C, D и E таким образом, чтобы B наследовался от A, С от A, D от B и E от C

    class A
    { 
        public virtual void Display()
        {
            Console.WriteLine("A");
        }
    }

    class B : A 
    {
        public new void Display()
        {
            Console.WriteLine("B");
        }
    }

    class C : A 
    {
        public override void Display()
        {
            Console.WriteLine("C");
        }
    }
    class D : B 
    {
        public new void Display()
        {
            Console.WriteLine("D");
        }
    }
    class E : C 
    {
        public new void Display()
        {
            Console.WriteLine("E");
        }
    }
