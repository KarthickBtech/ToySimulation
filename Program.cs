using System;
using ToySimulation.Commands;
using ToySimulation.Common.Enum;
using ToySimulation.Models;

class Program
{
    static void Main(string[] args)
    {
        IRobot robot = new ToyRobot();
        Simulator simulator = new Simulator(robot);

        ICommand[] commands = {
            new PlaceCommand(3, 6, Direction.NORTH),
            new MoveCommand(3, 6),
            new ReportCommand(3, 6),
            new PlaceCommand(0, 0, Direction.NORTH),
            new LeftCommand(0, 0),
            new ReportCommand(0, 0)
        };

        foreach (var command in commands)
        {
            simulator.ExecuteCommand(command);
        }
    }
}