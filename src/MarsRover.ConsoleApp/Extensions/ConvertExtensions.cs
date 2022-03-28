using System;
using System.Collections.Generic;
using System.Globalization;

namespace MarsRover.ConsoleApp
{
    public static class ConvertExtensions
    {
        public static Int32 ToInt32(this string number)
        {
            try
            {
                return Int32.Parse(number,
                                    NumberStyles.Integer,
                                    CultureInfo.CurrentCulture.NumberFormat);
            }
            catch (Exception ex)
            {
                throw new InvalidCastException("Type conversion failed");
            }
        }

        public static RoverDirectionEnum ToRoverDirection(this string value)
        {
            try
            {
                return (RoverDirectionEnum)Enum.Parse(typeof(RoverDirectionEnum), value, true);
            }
            catch (Exception ex)
            {
                throw new InvalidCastException("Type conversion failed");
            }
        }

        public static List<VehicleMovementEnum> ToVehicleMovements(this string command)
        {
            try
            {
                List<VehicleMovementEnum> movementList = new List<VehicleMovementEnum>();
                char[] letters = command.ToCharArray();

                foreach (var item in letters)
                {
                    switch (item)
                    {
                        case 'L':
                            movementList.Add(VehicleMovementEnum.TurnLeft);
                            break;
                        case 'R':
                            movementList.Add(VehicleMovementEnum.TurnRight);
                            break;
                        case 'M':
                            movementList.Add(VehicleMovementEnum.MoveForward);
                            break;
                    }
                }

                return movementList;
            }
            catch (Exception ex)
            {
                throw new InvalidCastException("Type conversion failed");
            }
        }
    }
}
