using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Item nut = new Part("Nut", 5);
            Item bolt = new Part("Bolt", 9);
            Item panel = new Part("Panel", 35);

            Item gizmo = new Assembly("Gizmo");
            gizmo.AddItem(panel);
            gizmo.AddItem(nut);
            gizmo.AddItem(bolt);

            Item widget = new Assembly("Widget");
            widget.AddItem(gizmo);
            widget.AddItem(nut);

            // Display the items
            Console.WriteLine(nut);
            Console.WriteLine(bolt);
            Console.WriteLine(panel);
            Console.WriteLine(gizmo);
            Console.WriteLine(widget);

            Console.Read();
        }
    }
}
