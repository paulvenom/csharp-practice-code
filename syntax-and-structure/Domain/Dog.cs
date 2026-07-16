namespace Domain;
/// <summary>
/// 1 - Store a name and age of a dog.
/// 2 - Dog should be able to have an action that barks!
/// 3 - Calculate human age for the dog by multiplying dog age by 7.
/// 4 - Dog's age cannot be less than 0 or greater than 30.
/// <summary>
public class Dog
{
   public Dog(string name, int age)
   {
        Name = name;
        Age = age;
   }

   public Dog()
   {
        
   }

   public string Name { get; set; } // automatic or simplified property

   private int _age;
   public int Age
   {
    get 
    { 
        return _age; 
    }
    
    set 
    { 
        if (value < 0 || value > 30)
        {
            throw new ArgumentOutOfRangeException("Age must be between 0 and 30.");
        }
        _age = value; 

    }
   }

    public string Bark()
    {
        return "Woof!";
    }

    public string ShowHumanAge()
    {
        return $"{Name} is {HumanAge()} years old in human years.";
    }

    private int HumanAge()
    {
        return Age * 7;
    }
    
}
