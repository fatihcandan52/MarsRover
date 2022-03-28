using System;
using System.Collections.Generic;

namespace MarsRover.ConsoleApp
{
    public class Rover : IVehicle
    {
        public Position Position { get; set; }

        public Rover(Position position)
        {
            if (position == null)
                throw new ArgumentNullException("Position is not null");

            Position = position;
        }

        public void Move()
        {
            switch (Position.Direction)
            {
                case RoverDirectionEnum.E:
                    Position.X += 1;
                    break;
                case RoverDirectionEnum.S:
                    Position.Y -= 1;
                    break;
                case RoverDirectionEnum.W:
                    Position.X -= 1;
                    break;
                case RoverDirectionEnum.N:
                    Position.Y += 1;
                    break;
                default:
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Position.Direction)
            {
                case RoverDirectionEnum.E:
                    Position.Direction = RoverDirectionEnum.N;
                    break;
                case RoverDirectionEnum.S:
                    Position.Direction = RoverDirectionEnum.E;
                    break;
                case RoverDirectionEnum.W:
                    Position.Direction = RoverDirectionEnum.S;
                    break;
                case RoverDirectionEnum.N:
                    Position.Direction = RoverDirectionEnum.W;
                    break;
                default:
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Position.Direction)
            {
                case RoverDirectionEnum.E:
                    Position.Direction = RoverDirectionEnum.S;
                    break;
                case RoverDirectionEnum.S:
                    Position.Direction = RoverDirectionEnum.W;
                    break;
                case RoverDirectionEnum.W:
                    Position.Direction = RoverDirectionEnum.N;
                    break;
                case RoverDirectionEnum.N:
                    Position.Direction = RoverDirectionEnum.E;
                    break;
                default:
                    break;
            }
        }

        public void Movement(List<VehicleMovementEnum> vehicleMovements)
        {
            foreach (var item in vehicleMovements)
            {
                switch (item)
                {
                    case VehicleMovementEnum.TurnLeft:
                        TurnLeft();
                        break;
                    case VehicleMovementEnum.TurnRight:
                        TurnRight();
                        break;
                    case VehicleMovementEnum.MoveForward:
                        Move();
                        break;
                    default:
                        break;
                }
            }
        }

        public string GetPosition()
        {
            return Position.ToString();
        }
    }
}
