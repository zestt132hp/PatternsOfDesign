
using System;

namespace PatternsOfDesign.Behavior_patterns.TemplateMethod
{
    class MonstersRole:PersonRole
    {
        public override void BuildStructured()
        {
            Console.WriteLine("Монстры не умеют строить, поэтому тут должно быть пусто");
        }

        public override PersonRole BuildUnits(PersonRole role)
        {
            Console.WriteLine("Монстры не умуют строить сооружения");
            return this;
        }
        
        public override void SendWarriors(object position)
        {
            Attack(FindEnemyRole(position));
        }

        public override void SendScouts(object position)
        {
            Console.WriteLine("нет скаута");
        }
    }
}
