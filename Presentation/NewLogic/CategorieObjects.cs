namespace NewLogic
{
    public class CategorieObjects
    {
        private string name;

        public CategorieObjects(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}