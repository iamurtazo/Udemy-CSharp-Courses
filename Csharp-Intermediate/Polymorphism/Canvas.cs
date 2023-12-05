public class Canvas //WorkflowEngine
{
    public void DrawShapes(List<Shape> shapes)
    {
        foreach(var shape in shapes)
        {
            shape.Draw();
        }
    }
}