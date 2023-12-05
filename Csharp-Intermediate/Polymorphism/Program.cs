class Program
{
    static void Main(string[] args)
    {
        
        var dog = new Dog();
        dog.MakeSound();
        var cat = new Cat();
        cat.MakeSound();


        var shapes = new List<Shape>
        {
            new Circle(),
            new Rectangle(),
            new Triangle()
        };
        var canvas = new Canvas();
        //canvas.DrawShapes(shapes);

        //var animal = new Animal();
    }
}
