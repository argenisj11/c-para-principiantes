using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class ConvertedService
    {
        public double ConvertMassUnit (MassEnum form, MassEnum to, double amount)
        {
            double ConvertAmoount=0;
            switch(form)
            {
                case MassEnum.Miligram:
                    { 
                        switch(to) 
                        {
                            case MassEnum.Gram:
                                ConvertAmoount= amount/100;
                                break;
                            case MassEnum.kilogram:
                                ConvertAmoount= amount/1000000;
                                break;
                            default : break;   
                        }

                    }
                    break;
                case MassEnum.Gram:
                    {
                        switch (to)
                        {
                            case MassEnum.Miligram:
                                ConvertAmoount = amount * 1000;
                                break;

                            case MassEnum.kilogram:
                                ConvertAmoount= amount/1000;
                                break;
                            default: break;
                        }

                    }
                    break;
                case MassEnum.kilogram:
                    {
                        switch (to)
                        {
                            case MassEnum.Gram:

                                ConvertAmoount= amount * 1000;
                                break;
                            case MassEnum.Miligram:
                                ConvertAmoount= amount / 1000000;
                                break;
                            default: break;
                        }
                        break;
                    }
            }
            return ConvertAmoount;

        }
        public double ConvertTemperatureUnit(TemperatureEnum form, TemperatureEnum to, double amount)
        {
            double ConvertAmoount = 0;
            switch (form)
            {
                case TemperatureEnum.Celsius:
                    {
                        switch (to)
                        {
                            case TemperatureEnum.Kelvin:
                                ConvertAmoount = (amount*1.8)+32;
                                break;
                            case TemperatureEnum.Fahrenheit:
                                ConvertAmoount = amount +273.15;
                                break;
                            default: break;
                        }

                    }
                    break;
                case TemperatureEnum.Kelvin:
                    {
                        switch (to)
                        {
                            case TemperatureEnum.Fahrenheit:
                             ConvertAmoount=(amount-273.15)*1.8+32 ;
                                break;

                            case TemperatureEnum.Celsius:
                                ConvertAmoount = amount - 273.15;
                                break;
                            default: break;
                        }

                    }
                    break;
                case TemperatureEnum.Fahrenheit:
                    {
                        switch (to)
                        {
                            case TemperatureEnum.Celsius:

                                ConvertAmoount = (amount - 32)*1.8;
                                break;
                            case TemperatureEnum.Kelvin:
                                ConvertAmoount = (amount - 32) * 1.8 + 273.15;
                                break;
                            default: break;
                        }
                        break;
                    }
            }
            return ConvertAmoount;

        }
        public double ConvertTimeUnit(timeEnum form, timeEnum to, double amount)
        {
            double ConvertAmoount = 0;
            switch (form)
            {
                case timeEnum.Milisecond:
                    {
                        switch (to)
                        {
                            case timeEnum.Seconds:
                                ConvertAmoount = amount / 1000;
                                break;
                            case timeEnum.Minute:
                                ConvertAmoount = amount / 60000;
                                break;
                            case timeEnum.Hours:
                                ConvertAmoount = amount / 3600000;
                                break;
                            default: break;
                        }

                    }
                    break;
                case timeEnum.Seconds:
                    {
                        switch (to)
                        {
                            case timeEnum.Milisecond:
                                ConvertAmoount = amount * 100;
                                break;

                            case timeEnum.Minute:
                                ConvertAmoount = amount / 60;
                                break;
                            case timeEnum.Hours:
                                ConvertAmoount = amount / 3600;
                                break;
                            default: break;
                        }

                    }
                    break;
                case timeEnum.Minute:
                    {
                        switch (to)
                        {
                            case timeEnum.Milisecond:

                                ConvertAmoount = amount * 600000;
                                break;
                            case timeEnum.Seconds:
                                ConvertAmoount = amount * 60;
                                break;
                            case timeEnum.Hours:
                                ConvertAmoount = amount / 60;
                                break;
                            default: break;
                        }
                        break;
                    }
                case timeEnum.Hours:
                    {
                        switch (to)
                        {
                            case timeEnum.Milisecond:

                                ConvertAmoount = amount * 3600000;
                                break;
                            case timeEnum.Seconds:
                                ConvertAmoount = amount * 3600;
                                break;
                            case timeEnum.Minute:
                                ConvertAmoount = amount * 60;
                                break;
                            default: break;
                        }
                        break;
                    }
            }
            return ConvertAmoount;

        }
    }
}
