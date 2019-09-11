
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternsOfDesign.Behavior_patterns.TemplateMethod
{
    class OrcsRole:PersonRole
    {
        public readonly object[] _resources;
        public readonly List<PersonRole> _warriors;
        public readonly List<PersonRole> _scouts;

        private PersonRole _enemyRole;
        public OrcsRole(params object[] resources)
        {
            _warriors = new List<PersonRole>();
            _scouts = new List<PersonRole>();
            _resources = resources;
        }
        public override void BuildStructured()
        {
            if (_resources == null) return;
            var unit = BuildUnits(new OrcsRole(_resources[_resources.Length-1]));
            _resources.ToList().Remove(_resources[_resources.Length - 1]);
            if (_resources.Length == 0)
            {
                _warriors.Add(unit);
            }
            else
            {
                if (_resources.Length % 2 == 0)
                {
                    _scouts.Add(unit);
                }
            }
        }

        public override PersonRole BuildUnits(PersonRole role)
        {
            role.CollectionResources();
            return new OrcsRole();
        }

        public override void SendWarriors(object position)
        {
            if (_warriors.Count <= 0) return;
            if (_enemyRole == null)
                Console.WriteLine("Can't attacked enemy, because not find him");
            else
            {
                _warriors[0].Attack(_enemyRole);
                _warriors.Remove(_warriors[0]);
            }
        }

        public override void SendScouts(object position)
        {
            if (_warriors.Count > 0)
            {
                _enemyRole = FindEnemyRole(position);
                _warriors.Remove(_warriors[0]);
            }
        }
    }
}
