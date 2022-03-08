namespace Desafio3.Model
{
    public class Classroom
    {
        public string Name { get; set; }
        public string Link { get; set; }

        public Classroom(string name, string link)
        {
            if(name == "")
            {
                throw new Exception();
            }
            else
            {
                this.Name = name;
            }

            if(link == "")
            {
                throw new Exception();
            }
            else
            {
                this.Link = link;
            }
        }
    }
}