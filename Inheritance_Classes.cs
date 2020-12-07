using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Challenge
{
    public enum FoodType 
    { Herbivore = 1,
        Carnivore,
        Omnivore

    }

    
    public abstract class Animalia
    {
        public bool IsLandBased { get; set; }
        public bool IsWaterBased { get; set; }
        public bool IsEndotherm { get; set; }
        public bool CanFly { get; set; }
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public abstract void Sound();

        public Animalia() { }
        public Animalia(bool isLandBased, bool isWaterBased, bool isEndotherm, bool canFly, string name, int numberOfLegs)
        {
            IsLandBased = isLandBased;
            IsWaterBased = isWaterBased;
            IsEndotherm = isEndotherm;
            CanFly = canFly;
            Name = name;
            NumberOfLegs = numberOfLegs;
        }

    }


    public class Invertebrate : Animalia
    {
        public bool HasShell { get; set; }
        public bool  HasAntennae { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Invertebrates make chittering noises, if they make any sound at all");
        }

        public Invertebrate() { }
        public Invertebrate(bool hasShell, bool hasAntennae, bool isLandBased, bool isWaterBased, bool isEndotherm, bool canFly, string name, int numberOfLegs)
            :base(isLandBased, isWaterBased, isEndotherm, canFly, name, numberOfLegs)
        {
            HasShell = hasShell;
            HasAntennae = hasAntennae;
        }
    }

    public class Fish : Animalia
    {
        public bool GivesBirthToLiveYoung { get; set; }
        public bool LivesInSaltwater { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Fish make sounds difficult for people to hear, as they are made underwater.");
        }
        public Fish() { }
        public Fish(bool givesBirthToLiveYoung, bool livesInSaltwater, bool isLandBased, bool isWaterBased, bool isEndotherm, bool canFly, string name, int numberOfLegs)
            : base(isLandBased, isWaterBased, isEndotherm, canFly, name, numberOfLegs)
        {
            GivesBirthToLiveYoung = givesBirthToLiveYoung;
            LivesInSaltwater = livesInSaltwater;
        }

    }

    public class Bird : Animalia
    {
        public bool SeasonallyMigrate { get; set; }
        public bool LivesInTrees { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Birds make a variety of sounds, and for a number of reason including mating, alerting others to predators, etc.");
        }

        public Bird() { } 
        public Bird (bool seasonallyMigrate, bool livesInTrees, bool isLandBased, bool isWaterBased, bool isEndotherm, bool canFly, string name, int numberOfLegs)
            : base(isLandBased, isWaterBased, isEndotherm, canFly, name, numberOfLegs)
        {
            SeasonallyMigrate = seasonallyMigrate;
            LivesInTrees = livesInTrees;
        }
    }
    

    public class Mammal : Animalia
    {
        public int AverageGestationalTimeInMonths { get; set; }
        public FoodType FoodType { get; set; }
        public override void Sound()
        {
            Console.WriteLine("Mammals make a variety of sounds, and for a number of reason including mating, alerting others to predators, etc.");
        }
        public Mammal() { }
        public Mammal(int averageGestationalTimeInMonths, FoodType foodtype, bool isLandBased, bool isWaterBased, bool isEndotherm, bool canFly, string name, int numberOfLegs)
            : base(isLandBased, isWaterBased, isEndotherm, canFly, name, numberOfLegs)
        {
            AverageGestationalTimeInMonths = averageGestationalTimeInMonths;
            FoodType = foodtype;

        }

    }


}
