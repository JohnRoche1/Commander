using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>{
                new Command {
                Id=0,
                HowTo="boil egg",
                Line="Boil water",
                Platform="Pan"
            },
            new Command {
                Id=1,
                HowTo="cut bread",
                Line="get knife",
                Platform="chopping board"
            },
            new Command {
                Id=2,
                HowTo="cup of tea",
                Line="teabag",
                Platform="cup"
            }};

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {
                Id=0,
                HowTo="boil egg",
                Line="Boil water",
                Platform="Pan"
            };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }

}