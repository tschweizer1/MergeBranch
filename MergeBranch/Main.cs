namespace GitPractice;

class MergeBranch
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();
        
        //animals.Add(new Cassowary());
        //animals.Add(new BulletAnt());
        //animals.Add(new Chimpanzee());
        //animals.Add(new BlueRingedOctopus());
        
        foreach (Animal animal in animals)
        {
            animal.MakeSound();
        }
    }
}