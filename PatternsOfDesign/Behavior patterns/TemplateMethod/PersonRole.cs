using System;
using System.Collections.ObjectModel;

namespace PatternsOfDesign.Behavior_patterns.TemplateMethod
{
    abstract class PersonRole
    {
        public void Turn() { }

        public void CollectionResources()
        {
            foreach (var obj in BuildNewStructures())
            {
                Console.WriteLine(obj.GetType());
            }
        }
        public PersonRole FindEnemyRole(object position)
        {
            return null;
        }
        public virtual Collection<object> BuildNewStructures()
        {
            return new Collection<object>();
        }

        public virtual void Attack(PersonRole person)
        {
            if (GetType() == typeof(OrcsRole))
            {
                int a = 0;
                int b = 1;
                SendWarriors(a+b);
            }
            else
            {
                int a = 0;
                int b = 1;
                SendScouts(a + b);
            }
        }

        public abstract void BuildStructured();
        public abstract PersonRole BuildUnits(PersonRole role);

        public abstract void SendWarriors(object position);
        public abstract void SendScouts(object position);
    }
}
