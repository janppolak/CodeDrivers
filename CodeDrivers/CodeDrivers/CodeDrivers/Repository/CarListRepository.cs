﻿using CodeDrivers.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CodeDrivers.Repository
{

    internal interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllAvailable();
        void DisplayAllItems(IEnumerable<T> items);
        void DisplayAllAvailableItems(IEnumerable<T> items);

    }
    internal class CarListRepository : IRepository<Car>
    {
        
        public static List<Car> cars { get; set; }
        
        public static int SetId()
        {
            
            int id = 0;
            while (true)
            {
               if (cars.Any(x => x.Id == id))
                {
                    return id;
                }
                else
                {
                    id++;
                }
            }
            
        }
        public void FillRepository()
        {
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 AC", Segment = "Małe", IsAvailable = true, Traveled = 70000, PricePerDay = 60, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI Minor", Segment = "Małe", IsAvailable = true, Traveled = 50000, PricePerDay = 135, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Verna 45078 SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 600, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "RediGO T Option", Segment = "Małe", IsAvailable = true, Traveled = 46000, PricePerDay = 250, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Amaze VX i-DTEC", Segment = "Kompaktowe", IsAvailable = true, Traveled = 141000, PricePerDay = 450, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX BSIII", Segment = "Małe", IsAvailable = true, Traveled = 125000, PricePerDay = 140, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Xcent 44958 Kappa S", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 550, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Indigo Grand Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 240, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Creta 45078 VTVT S", Segment = "SUV", IsAvailable = true, Traveled = 25000, PricePerDay = 850, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "CNG", Model = "Celerio Green VXI", Segment = "Małe", IsAvailable = true, Traveled = 78000, PricePerDay = 365, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Sail 44958 Base", Segment = "Kompaktowe", IsAvailable = true, Traveled = 35000, PricePerDay = 260, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Indigo Grand Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 250, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Corolla Altis 45139 VL CVT", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 25000, PricePerDay = 1650, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 AC", Segment = "Małe", IsAvailable = true, Traveled = 70000, PricePerDay = 60, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI Minor", Segment = "Małe", IsAvailable = true, Traveled = 50000, PricePerDay = 135, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Verna 45078 SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 600, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "RediGO T Option", Segment = "Małe", IsAvailable = true, Traveled = 46000, PricePerDay = 250, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Amaze VX i-DTEC", Segment = "Kompaktowe", IsAvailable = true, Traveled = 141000, PricePerDay = 450, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX BSIII", Segment = "Małe", IsAvailable = true, Traveled = 125000, PricePerDay = 140, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Xcent 44958 Kappa S", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 550, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Indigo Grand Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 240, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Creta 45078 VTVT S", Segment = "SUV", IsAvailable = true, Traveled = 25000, PricePerDay = 850, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "CNG", Model = "Celerio Green VXI", Segment = "Małe", IsAvailable = true, Traveled = 78000, PricePerDay = 365, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Sail 44958 Base", Segment = "Kompaktowe", IsAvailable = true, Traveled = 35000, PricePerDay = 260, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Indigo Grand Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 250, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Corolla Altis 45139 VL CVT", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 25000, PricePerDay = 1650, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ciaz VXi Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 24000, PricePerDay = 585, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Venue SX Opt Diesel", Segment = "Kompaktowe", IsAvailable = true, Traveled = 5000, PricePerDay = 1195, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Enjoy TCDi LTZ 7 Seater", Segment = "Kompaktowe", IsAvailable = true, Traveled = 33000, PricePerDay = 390, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XF 44959 Litre Luxury", Segment = "Luksusowe", IsAvailable = true, Traveled = 28000, PricePerDay = 1964, YearOfProduction = 2014, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "New C-Class 220 CDI AT", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 59000, PricePerDay = 1425, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Vitara Brezza ZDi Plus AMT", Segment = "SUV", IsAvailable = true, Traveled = 4500, PricePerDay = 975, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Q5 2.0 TDI", Segment = "Luksusowe", IsAvailable = true, Traveled = 175900, PricePerDay = 1190, YearOfProduction = 2011, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "City V MT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 14500, PricePerDay = 930, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Tigor 44958 Revotron XT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 15000, PricePerDay = 525, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A6 2.0 TDI Design Edition", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 50000, PricePerDay = 1735, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "New C-Class C 220 CDI Avantgarde", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 33800, PricePerDay = 1375, YearOfProduction = 2012, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Superb Ambition 2.0 TDI CR AT", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 130400, PricePerDay = 450, YearOfProduction = 2011, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Corolla Altis G AT", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 50000, PricePerDay = 900, YearOfProduction = 2016, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova 45048 G (Diesel) 7 Seater", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 1300, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Compass 45017 Sport Plus BSIV", Segment = "SUV", IsAvailable = true, Traveled = 10000, PricePerDay = 1400, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "E-Class E 200 CGI Elegance", Segment = "Klasa Wyższa", IsAvailable = true, Traveled = 119000, PricePerDay = 850, YearOfProduction = 2010, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Magna 1.1L", Segment = "Małe", IsAvailable = true, Traveled = 60000, PricePerDay = 229, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "3 Series 320d Sport Line", Segment = "Klasa Wyższa", IsAvailable = true, Traveled = 75800, PricePerDay = 1550, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Q7 35 TDI Quattro Premium", Segment = "SUV", IsAvailable = true, Traveled = 78000, PricePerDay = 1250, YearOfProduction = 2009, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Elantra CRDi S", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 625, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio 36161 S10", Segment = "SUV", IsAvailable = true, Traveled = 50000, PricePerDay = 1050, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "City i DTEC V", Segment = "Kompaktowe", IsAvailable = true, Traveled = 74000, PricePerDay = 560, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R VXI BS IV with ABS", Segment = "Małe", IsAvailable = true, Traveled = 64000, PricePerDay = 290, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R VXI BS IV", Segment = "Małe", IsAvailable = true, Traveled = 60000, PricePerDay = 275, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio LX", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 411, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro Xing GLS", Segment = "Małe", IsAvailable = true, Traveled = 79000, PricePerDay = 150, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 44958 Kappa Asta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 15000, PricePerDay = 500, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LXi", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 100, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI Optional", Segment = "Kompaktowe", IsAvailable = true, Traveled = 18500, PricePerDay = 725, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Eeco 5 Seater AC BSIV", Segment = "Małe", IsAvailable = true, Traveled = 10200, PricePerDay = 401, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "i20 Sportz 45017 CRDi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 29000, PricePerDay = 750, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Omni Maruti Omni MPI STD BSIII 5-STR W/ IMMOBILISER", Segment = "Małe", IsAvailable = true, Traveled = 28000, PricePerDay = 310, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift ZDi BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 46000, PricePerDay = 665, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "i20 2015-2017 Sportz Option 45017 CRDi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 465, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LXi", Segment = "Małe", IsAvailable = true, Traveled = 60000, PricePerDay = 160, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Jeep CL 500 MDI", Segment = "SUV", IsAvailable = true, Traveled = 35000, PricePerDay = 250, YearOfProduction = 1996, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "City i DTEC VX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 675, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R VXI BS IV", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 300, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica DLS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 70, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Magna Plus", Segment = "Małe", IsAvailable = true, Traveled = 73300, PricePerDay = 240, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Etios GD", Segment = "Kompaktowe", IsAvailable = true, Traveled = 92000, PricePerDay = 525, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LXi", Segment = "Małe", IsAvailable = true, Traveled = 66764, PricePerDay = 151, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LXi", Segment = "Małe", IsAvailable = true, Traveled = 100000, PricePerDay = 140, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Tavera Neo LS B3 - 7(C) seats BSIII", Segment = "SUV", IsAvailable = true, Traveled = 350000, PricePerDay = 280, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Corolla Altis Diesel D4DG", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 230000, PricePerDay = 350, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio 36161 S6 Plus", Segment = "SUV", IsAvailable = true, Traveled = 60000, PricePerDay = 570, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Magna Plus", Segment = "Małe", IsAvailable = true, Traveled = 31000, PricePerDay = 300, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indigo Classic Dicor", Segment = "Kompaktowe", IsAvailable = true, Traveled = 39000, PricePerDay = 100, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova 45048 V Diesel 8-seater", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 500, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica Vista Quadrajet LS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 166000, PricePerDay = 125, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift 44986 VXi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 130, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "EcoSport 45047 Diesel Titanium BSIV", Segment = "SUV", IsAvailable = true, Traveled = 35000, PricePerDay = 925, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ciaz 44986 Delta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 750, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Civic 45139 V AT", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 54000, PricePerDay = 200, YearOfProduction = 2007, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Sportz 44958", Segment = "Małe", IsAvailable = true, Traveled = 63000, PricePerDay = 248, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Rapid 45047 TDI Elegance", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 450, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Getz GLS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 80, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Terrano XL", Segment = "SUV", IsAvailable = true, Traveled = 76000, PricePerDay = 650, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Grand i10 CRDi Sportz", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 450, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Elite i20 Diesel Era", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 650, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Amaze S i-VTEC", Segment = "Kompaktowe", IsAvailable = true, Traveled = 11958, PricePerDay = 495, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Brio S MT", Segment = "Małe", IsAvailable = true, Traveled = 20000, PricePerDay = 371, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Creta 45078 SX Option", Segment = "SUV", IsAvailable = true, Traveled = 9000, PricePerDay = 1025, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "S-Class S 350d Connoisseurs Edition", Segment = "Luksusowe", IsAvailable = true, Traveled = 6500, PricePerDay = 8150, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W8 2WD", Segment = "SUV", IsAvailable = true, Traveled = 70000, PricePerDay = 750, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 85PS Diesel RxL Optional", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 600, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro Xing XO", Segment = "Małe", IsAvailable = true, Traveled = 58000, PricePerDay = 80, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero 2011-2019 SLE", Segment = "SUV", IsAvailable = true, Traveled = 62200, PricePerDay = 325, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A6 2.0 TDI Premium Plus", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 34000, PricePerDay = 1470, YearOfProduction = 2014, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Avventura MULTIJET Emotion", Segment = "Kompaktowe", IsAvailable = true, Traveled = 53000, PricePerDay = 350, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A8 44961 TDI", Segment = "Luksusowe", IsAvailable = true, Traveled = 49000, PricePerDay = 2800, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "RediGO 1.0 S", Segment = "Małe", IsAvailable = true, Traveled = 15000, PricePerDay = 210, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Jetta 45017 TSI Comfortline", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 450, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A4 2.0 TDI 177 Bhp Premium Plus", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 53000, PricePerDay = 1150, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Civic 45139 V AT", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 63500, PricePerDay = 210, YearOfProduction = 2009, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "E-Class Exclusive E 200 BSIV", Segment = "Klasa Wyższa", IsAvailable = true, Traveled = 9800, PricePerDay = 4500, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "X1 sDrive 20d xLine", Segment = "SUV", IsAvailable = true, Traveled = 13000, PricePerDay = 2750, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "V40 D3 R Design", Segment = "Kompaktowe", IsAvailable = true, Traveled = 21000, PricePerDay = 1975, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 Zxi BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 29173, PricePerDay = 175, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "7 Series 730Ld", Segment = "Luksusowe", IsAvailable = true, Traveled = 48000, PricePerDay = 2500, YearOfProduction = 2012, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero Power Plus SLX", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 628, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Sonata CRDi M/T", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 600, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Micra Active XV Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 30000, PricePerDay = 399, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Xylo D4", Segment = "SUV", IsAvailable = true, Traveled = 87000, PricePerDay = 750, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Elite i20 Sportz Plus Dual Tone BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 15000, PricePerDay = 750, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "KWID RXT", Segment = "Małe", IsAvailable = true, Traveled = 16000, PricePerDay = 315, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Xylo E4 BS III", Segment = "SUV", IsAvailable = true, Traveled = 60000, PricePerDay = 600, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI Minor", Segment = "Małe", IsAvailable = true, Traveled = 60000, PricePerDay = 100, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 ZXI MT BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 250, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "KWID RXT", Segment = "Małe", IsAvailable = true, Traveled = 25000, PricePerDay = 350, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Creta 45017 CRDi S", Segment = "SUV", IsAvailable = true, Traveled = 60000, PricePerDay = 780, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 79350, PricePerDay = 434, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna 45078 VTVT AT S Option", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 690, YearOfProduction = 2016, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio LX BSIV", Segment = "SUV", IsAvailable = true, Traveled = 90000, PricePerDay = 555, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 Vxi BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 120, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ertiga VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 500, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Beat Diesel", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 165, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Zen LX", Segment = "Małe", IsAvailable = true, Traveled = 50000, PricePerDay = 95, YearOfProduction = 2004, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Baleno Delta 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 20000, PricePerDay = 550, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Vdi BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 100, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Nano Lx BSIV", Segment = "Małe", IsAvailable = true, Traveled = 50000, PricePerDay = 100, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova 45048 GX (Diesel) 8 Seater", Segment = "SUV", IsAvailable = true, Traveled = 100000, PricePerDay = 500, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ertiga SHVS VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 800, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Creta 45078 CRDi SX", Segment = "SUV", IsAvailable = true, Traveled = 70000, PricePerDay = 840, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Amaze S i-Vtech", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 490, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica Vista Aqua 45017 TDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 81000, PricePerDay = 125, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Tavera Neo 2 LS B4 7 Str BSIII", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 400, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Cruze LTZ", Segment = "Kompaktowe", IsAvailable = true, Traveled = 3600, PricePerDay = 1000, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Figo Aspire 44958 Ti-VCT Titanium Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 14272, PricePerDay = 530, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "EcoSport 45047 Diesel Titanium Plus BSIV", Segment = "SUV", IsAvailable = true, Traveled = 49213, PricePerDay = 840, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Sportz 1.1L", Segment = "Małe", IsAvailable = true, Traveled = 40000, PricePerDay = 229, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 Std", Segment = "Małe", IsAvailable = true, Traveled = 40000, PricePerDay = 40, YearOfProduction = 1998, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Spark 1.0 LS", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 130, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Era Plus", Segment = "Małe", IsAvailable = true, Traveled = 70000, PricePerDay = 200, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica Vista Aqua TDI BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 120, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro LP zipPlus", Segment = "Małe", IsAvailable = true, Traveled = 57000, PricePerDay = 75, YearOfProduction = 2003, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolt Quadrajet XE", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 250, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 AC BSIII", Segment = "Małe", IsAvailable = true, Traveled = 30000, PricePerDay = 100, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Era Plus", Segment = "Małe", IsAvailable = true, Traveled = 3240, PricePerDay = 280, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Magna 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 5000, PricePerDay = 540, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 44958 Asta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10000, PricePerDay = 700, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ciaz VDi Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 525, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "i20 Asta 45017 CRDi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 430, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro LE", Segment = "Małe", IsAvailable = true, Traveled = 70000, PricePerDay = 65, YearOfProduction = 2002, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Vitara Brezza VDi", Segment = "SUV", IsAvailable = true, Traveled = 35000, PricePerDay = 800, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro Xing XL eRLX Euro III", Segment = "Małe", IsAvailable = true, Traveled = 114000, PricePerDay = 75, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Getz 44986 GLS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 53772, PricePerDay = 210, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Quanto C8", Segment = "SUV", IsAvailable = true, Traveled = 140000, PricePerDay = 195, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Tavera Neo 3 LS 7 C BSIII", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 400, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Magna Plus", Segment = "Małe", IsAvailable = true, Traveled = 60000, PricePerDay = 170, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "KWID RXT", Segment = "Małe", IsAvailable = true, Traveled = 25000, PricePerDay = 225, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "LPG", Model = "Wagon R DUO LPG", Segment = "Małe", IsAvailable = true, Traveled = 90000, PricePerDay = 210, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI", Segment = "Małe", IsAvailable = true, Traveled = 120000, PricePerDay = 240, YearOfProduction = 2020, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Enjoy 44986 TCDi LS 8", Segment = "Kompaktowe", IsAvailable = true, Traveled = 175000, PricePerDay = 300, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Spark 1.0 LS", Segment = "Małe", IsAvailable = true, Traveled = 100000, PricePerDay = 99, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "City i VTEC SV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 36000, PricePerDay = 620, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Amaze VX i-DTEC", Segment = "Kompaktowe", IsAvailable = true, Traveled = 30000, PricePerDay = 500, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "XJ 5.0 L V8 Supercharged", Segment = "Luksusowe", IsAvailable = true, Traveled = 40000, PricePerDay = 2550, YearOfProduction = 2010, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Brio E MT", Segment = "Małe", IsAvailable = true, Traveled = 70000, PricePerDay = 260, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift VVT ZXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 550, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indigo CR4", Segment = "Kompaktowe", IsAvailable = true, Traveled = 155500, PricePerDay = 150, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Asta AT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 350, YearOfProduction = 2011, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 320, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift VDI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 400, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LXi", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 175, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 120, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 110PS Diesel RxZ", Segment = "SUV", IsAvailable = true, Traveled = 90000, PricePerDay = 320, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro Xing XG", Segment = "Małe", IsAvailable = true, Traveled = 110000, PricePerDay = 70, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift Dzire ZXI Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 15000, PricePerDay = 810, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 AC", Segment = "Małe", IsAvailable = true, Traveled = 100000, PricePerDay = 95, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "CNG", Model = "Alto K10 LXI CNG", Segment = "Małe", IsAvailable = true, Traveled = 40000, PricePerDay = 282, YearOfProduction = 2020, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 Std BSII", Segment = "Małe", IsAvailable = true, Traveled = 60000, PricePerDay = 80, YearOfProduction = 2004, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Nano LX SE", Segment = "Małe", IsAvailable = true, Traveled = 25000, PricePerDay = 72, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Magna 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 600, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Rapid 45078 MPI Ambition With Alloy Wheel", Segment = "Kompaktowe", IsAvailable = true, Traveled = 23000, PricePerDay = 640, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto K10 VXI", Segment = "Małe", IsAvailable = true, Traveled = 22155, PricePerDay = 380, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ciaz 45017 Delta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 650, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX", Segment = "Małe", IsAvailable = true, Traveled = 60000, PricePerDay = 150, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Asta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 280, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Nexon 44958 Revotron XM", Segment = "SUV", IsAvailable = true, Traveled = 30000, PricePerDay = 430, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero Power Plus SLX", Segment = "SUV", IsAvailable = true, Traveled = 15000, PricePerDay = 800, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Zen D", Segment = "Małe", IsAvailable = true, Traveled = 100000, PricePerDay = 75, YearOfProduction = 2003, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Vento Celeste 45047 TDI Highline AT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 650, YearOfProduction = 2016, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Eeco 7 Seater Standard BSIV", Segment = "Małe", IsAvailable = true, Traveled = 24000, PricePerDay = 390, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "City 45047 EXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 100, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "New C-Class 220 CDI AT", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 35000, PricePerDay = 1500, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 Zxi with Leather BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 78380, PricePerDay = 175, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 110PS Diesel RxZ", Segment = "SUV", IsAvailable = true, Traveled = 110000, PricePerDay = 434, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Diesel Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 170, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Diesel Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 190, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 150000, PricePerDay = 250, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Xylo E4", Segment = "SUV", IsAvailable = true, Traveled = 230000, PricePerDay = 229, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Esteem Vxi - BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 140, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift VDI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80362, PricePerDay = 600, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 44958 Sportz", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 280, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Beat Diesel LT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 150, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Cruze LTZ AT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 650, YearOfProduction = 2015, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Micra XL", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 210, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "5 Series 520d Luxury Line", Segment = "Klasa Wyższa", IsAvailable = true, Traveled = 40000, PricePerDay = 2900, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Enjoy 44986 TCDi LS 8", Segment = "Kompaktowe", IsAvailable = true, Traveled = 20000, PricePerDay = 425, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Era Plus Option", Segment = "Małe", IsAvailable = true, Traveled = 55000, PricePerDay = 265, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Linea T Jet Emotion", Segment = "Kompaktowe", IsAvailable = true, Traveled = 1136, PricePerDay = 890, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Scala RxL", Segment = "Kompaktowe", IsAvailable = true, Traveled = 55000, PricePerDay = 365, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Figo Petrol Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 43000, PricePerDay = 350, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ciaz ZDi SHVS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 685, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Rapid 45047 TDI Ambition BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 2650, PricePerDay = 940, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W6 2WD", Segment = "SUV", IsAvailable = true, Traveled = 40000, PricePerDay = 1000, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "XUV300 W8 Option", Segment = "SUV", IsAvailable = true, Traveled = 15000, PricePerDay = 1150, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ertiga SHVS ZDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 115962, PricePerDay = 450, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Terrano XE D", Segment = "SUV", IsAvailable = true, Traveled = 65000, PricePerDay = 590, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "S-Cross Facelift", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 800, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "i20 Magna 45017 CRDi (Diesel)", Segment = "Kompaktowe", IsAvailable = true, Traveled = 58000, PricePerDay = 385, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "New C-Class C 220 CDI BE Avantgare", Segment = "Klasa Średnia", IsAvailable = true, Traveled = 15000, PricePerDay = 2000, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Era Plus", Segment = "Małe", IsAvailable = true, Traveled = 54000, PricePerDay = 235, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ameo 45047 TDI Highline", Segment = "Kompaktowe", IsAvailable = true, Traveled = 56000, PricePerDay = 640, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX", Segment = "Małe", IsAvailable = true, Traveled = 120000, PricePerDay = 52, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "LPG", Model = "Omni LPG CARGO BSIII W IMMOBILISER", Segment = "Małe", IsAvailable = true, Traveled = 90000, PricePerDay = 80, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX", Segment = "Małe", IsAvailable = true, Traveled = 70000, PricePerDay = 140, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna i (Petrol)", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 120, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Renault Logan 45047 DLS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 213000, PricePerDay = 89, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Optra Magnum 2.0 LS BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 180, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio S11 BSIV", Segment = "SUV", IsAvailable = true, Traveled = 20000, PricePerDay = 1500, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Active 44958 SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10000, PricePerDay = 700, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "SX4 Celebration Diesel", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 285, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 Magna", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 390, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LXi BSIII", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 125, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 Zxi with Leather BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 225, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Era", Segment = "Małe", IsAvailable = true, Traveled = 139000, PricePerDay = 175, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova 45048 V Diesel 7-seater", Segment = "SUV", IsAvailable = true, Traveled = 160000, PricePerDay = 1075, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Mobilio V i DTEC", Segment = "Kompaktowe", IsAvailable = true, Traveled = 150000, PricePerDay = 300, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova 45048 G (Diesel) 7 Seater BS IV", Segment = "SUV", IsAvailable = true, Traveled = 163000, PricePerDay = 700, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica V2 2001-2011 DLS BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 90, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica Vista TDI LS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 120, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Beat Diesel LS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 220, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Zest Quadrajet 44986 75PS XE", Segment = "Kompaktowe", IsAvailable = true, Traveled = 140000, PricePerDay = 300, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fabia 1.2L Diesel Ambiente", Segment = "Kompaktowe", IsAvailable = true, Traveled = 87000, PricePerDay = 180, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 Std", Segment = "Małe", IsAvailable = true, Traveled = 70000, PricePerDay = 170, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Figo Petrol Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 300, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova 45048 VX (Diesel) 8 Seater", Segment = "SUV", IsAvailable = true, Traveled = 70000, PricePerDay = 1050, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Mobilio V i DTEC", Segment = "Kompaktowe", IsAvailable = true, Traveled = 150000, PricePerDay = 300, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Grand i10 44958 CRDi Asta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 465, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Beat Diesel LT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 130, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "GO Plus T Option Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10000, PricePerDay = 434, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 44958 Kappa Asta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 32000, PricePerDay = 500, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Omni MPI STD BSIV", Segment = "Małe", IsAvailable = true, Traveled = 10000, PricePerDay = 200, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Baleno Alpha 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 52000, PricePerDay = 625, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fiesta Classic 45017 SXI Duratorq", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 110, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Elite i20 Asta Option BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 11240, PricePerDay = 800, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Grand i10 CRDi Magna", Segment = "Kompaktowe", IsAvailable = true, Traveled = 66000, PricePerDay = 490, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ertiga SHVS ZDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 64000, PricePerDay = 880, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro Xing GL Plus", Segment = "Małe", IsAvailable = true, Traveled = 49000, PricePerDay = 290, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Sumo GX TC 7 Str BSIII", Segment = "SUV", IsAvailable = true, Traveled = 100000, PricePerDay = 115, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "KWID RXT", Segment = "Małe", IsAvailable = true, Traveled = 26500, PricePerDay = 360, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 AC", Segment = "Małe", IsAvailable = true, Traveled = 100000, PricePerDay = 65, YearOfProduction = 2002, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Vitara Brezza LDi Option", Segment = "SUV", IsAvailable = true, Traveled = 72000, PricePerDay = 685, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Jazz S", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 300, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "i20 45017 Sportz", Segment = "Kompaktowe", IsAvailable = true, Traveled = 44000, PricePerDay = 680, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ertiga SHVS ZDI Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 1000, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Sumo SE Plus BSIII", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 100, YearOfProduction = 2002, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Xylo E4", Segment = "SUV", IsAvailable = true, Traveled = 130000, PricePerDay = 160, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift ZDi BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 450, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ertiga VXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 20000, PricePerDay = 600, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "i20 45017 Magna ABS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 180, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LXi", Segment = "Małe", IsAvailable = true, Traveled = 195000, PricePerDay = 100, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LXi", Segment = "Małe", IsAvailable = true, Traveled = 90000, PricePerDay = 120, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Getz GL", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 130, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LX BS IV", Segment = "Małe", IsAvailable = true, Traveled = 155000, PricePerDay = 160, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero Power Plus SLX", Segment = "SUV", IsAvailable = true, Traveled = 35000, PricePerDay = 860, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 44958 Spotz", Segment = "Kompaktowe", IsAvailable = true, Traveled = 20000, PricePerDay = 650, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI Minor", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 100, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto 800 VXI", Segment = "Małe", IsAvailable = true, Traveled = 20000, PricePerDay = 282, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Asta (o)", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 300, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Asta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 270, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Verna 45078 SX CRDi (O)", Segment = "Kompaktowe", IsAvailable = true, Traveled = 29000, PricePerDay = 550, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Xylo D2 BSIV", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 450, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero SLX 2WD BSIII", Segment = "SUV", IsAvailable = true, Traveled = 70000, PricePerDay = 430, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ertiga VXI ABS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 350, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Brio 44958 E MT", Segment = "Małe", IsAvailable = true, Traveled = 20000, PricePerDay = 350, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Etios Liva G", Segment = "Małe", IsAvailable = true, Traveled = 50000, PricePerDay = 229, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto 800 LXI", Segment = "Małe", IsAvailable = true, Traveled = 50000, PricePerDay = 110, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift Dzire 44958 Vxi BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 49000, PricePerDay = 395, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio VLS AT 44959 mHAWK", Segment = "SUV", IsAvailable = true, Traveled = 70000, PricePerDay = 650, YearOfProduction = 2011, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero SLX", Segment = "SUV", IsAvailable = true, Traveled = 90000, PricePerDay = 350, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W11 Option AWD", Segment = "SUV", IsAvailable = true, Traveled = 25000, PricePerDay = 1400, YearOfProduction = 2020, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Tiago 44958 Revotron XZ", Segment = "Kompaktowe", IsAvailable = true, Traveled = 4000, PricePerDay = 360, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Marazzo M8 8Str", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10000, PricePerDay = 1300, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 110PS Diesel RxL", Segment = "SUV", IsAvailable = true, Traveled = 15000, PricePerDay = 800, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Magna Plus", Segment = "Małe", IsAvailable = true, Traveled = 30000, PricePerDay = 229, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R VXI", Segment = "Małe", IsAvailable = true, Traveled = 41000, PricePerDay = 315, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Spark 1.0 LT", Segment = "Małe", IsAvailable = true, Traveled = 28000, PricePerDay = 125, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Baleno Alpha", Segment = "Kompaktowe", IsAvailable = true, Traveled = 16000, PricePerDay = 700, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON 1.0 Kappa Magna Plus", Segment = "Małe", IsAvailable = true, Traveled = 70000, PricePerDay = 160, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Figo Aspire 44958 Ti-VCT Trend", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10832, PricePerDay = 530, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Aspire Facelift", Segment = "Kompaktowe", IsAvailable = true, Traveled = 14681, PricePerDay = 624, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Era", Segment = "Małe", IsAvailable = true, Traveled = 50000, PricePerDay = 250, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero SLX", Segment = "SUV", IsAvailable = true, Traveled = 51000, PricePerDay = 585, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna 45017 VTVT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 500, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Sail 44958 LT ABS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 30000, PricePerDay = 350, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "City i-DTEC SV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 495, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 44958 Kappa Asta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 500, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero Power Plus Plus AC BSIV PS", Segment = "SUV", IsAvailable = true, Traveled = 200000, PricePerDay = 430, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 44958 Kappa Sportz Option", Segment = "Kompaktowe", IsAvailable = true, Traveled = 44000, PricePerDay = 345, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Baleno Sigma 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10000, PricePerDay = 500, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Tiago 44958 Revotron XZ", Segment = "Kompaktowe", IsAvailable = true, Traveled = 19600, PricePerDay = 425, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI", Segment = "Małe", IsAvailable = true, Traveled = 40000, PricePerDay = 80, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Beat Diesel LS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 106, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "A-Star Vxi", Segment = "Małe", IsAvailable = true, Traveled = 46730, PricePerDay = 180, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "GO A", Segment = "Małe", IsAvailable = true, Traveled = 40000, PricePerDay = 250, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Yeti Ambition 4WD", Segment = "SUV", IsAvailable = true, Traveled = 80000, PricePerDay = 350, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Zen LXi BSII", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 60, YearOfProduction = 2002, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Verna CRDi 45078 EX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 24000, PricePerDay = 900, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Aspire Titanium Diesel BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 21170, PricePerDay = 700, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "3 Series 320d Sport", Segment = "Kompaktowe", IsAvailable = true, Traveled = 167223, PricePerDay = 2000, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ertiga SHVS ZDI Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 1000, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "X1 sDrive 20d Exclusive", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 1375, YearOfProduction = 2011, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova Crysta 45018 VX MT", Segment = "SUV", IsAvailable = true, Traveled = 141440, PricePerDay = 1800, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Tavera Neo 3 10 Seats BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 160, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Outlander 45018", Segment = "SUV", IsAvailable = true, Traveled = 140000, PricePerDay = 525, YearOfProduction = 2012, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W8 2WD", Segment = "SUV", IsAvailable = true, Traveled = 212814, PricePerDay = 850, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Baleno Alpha 44986", Segment = "Kompaktowe", IsAvailable = true, Traveled = 30000, PricePerDay = 800, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Aspire 45047 TDCi Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 88635, PricePerDay = 700, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 800, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 44958 Spotz", Segment = "Kompaktowe", IsAvailable = true, Traveled = 20000, PricePerDay = 575, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 110PS Diesel RxZ", Segment = "SUV", IsAvailable = true, Traveled = 110000, PricePerDay = 350, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Vdi BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 250, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Endeavour Titanium 4X2", Segment = "SUV", IsAvailable = true, Traveled = 149674, PricePerDay = 600, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio 45079 Turbo 9 Str", Segment = "SUV", IsAvailable = true, Traveled = 100000, PricePerDay = 370, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Baleno Vxi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 80, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica DLX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 50, YearOfProduction = 2003, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Verna CRDi 45078 EX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 900, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R VXI BS IV", Segment = "Małe", IsAvailable = true, Traveled = 35000, PricePerDay = 300, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Indica LSI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 125, YearOfProduction = 2002, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 490, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Etios Liva GD", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 300, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Nano STD", Segment = "Małe", IsAvailable = true, Traveled = 25000, PricePerDay = 55, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 Sportz", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 350, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Grand i10 44958 CRDi Asta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 8000, PricePerDay = 755, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ertiga SHVS VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 720, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero SLX", Segment = "SUV", IsAvailable = true, Traveled = 200000, PricePerDay = 229, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio S7 140 BSIV", Segment = "SUV", IsAvailable = true, Traveled = 20000, PricePerDay = 1100, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Polo Petrol Comfortline 1.2L", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 400, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Xcent 44927 CRDi Base", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 350, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Beat Diesel PS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 68000, PricePerDay = 159, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift ZXi BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 38000, PricePerDay = 550, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ritz VDi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 335, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "CNG", Model = "Indigo CS Emax CNG GLX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 72000, PricePerDay = 185, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "CNG", Model = "Eeco 5 STR With AC Plus HTR CNG", Segment = "Małe", IsAvailable = true, Traveled = 75000, PricePerDay = 229, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Estilo LXI", Segment = "Małe", IsAvailable = true, Traveled = 43000, PricePerDay = 225, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift VXI with ABS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 250, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Zest Quadrajet 44986 XM", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 400, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift VDI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 163000, PricePerDay = 470, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto K10 VXI AGS Optional", Segment = "Małe", IsAvailable = true, Traveled = 25000, PricePerDay = 300, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX", Segment = "Małe", IsAvailable = true, Traveled = 25000, PricePerDay = 145, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 Vxi BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 100, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio SLE BSIV", Segment = "SUV", IsAvailable = true, Traveled = 70000, PricePerDay = 500, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "CNG", Model = "Santro Xing GLS CNG", Segment = "Małe", IsAvailable = true, Traveled = 98000, PricePerDay = 130, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Cruze LTZ", Segment = "Kompaktowe", IsAvailable = true, Traveled = 81925, PricePerDay = 240, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Diesel Celebration Edition", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 150, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "KWID RXT Optional", Segment = "Małe", IsAvailable = true, Traveled = 40000, PricePerDay = 270, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 400, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Era Plus", Segment = "Małe", IsAvailable = true, Traveled = 46000, PricePerDay = 200, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W6 2WD", Segment = "SUV", IsAvailable = true, Traveled = 80000, PricePerDay = 550, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "KWID 1.0 RXT Optional", Segment = "Małe", IsAvailable = true, Traveled = 35000, PricePerDay = 325, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Rapid 45047 TDI AT Style BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 82080, PricePerDay = 860, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W8 2WD", Segment = "SUV", IsAvailable = true, Traveled = 200000, PricePerDay = 600, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Spark 1.0", Segment = "Małe", IsAvailable = true, Traveled = 70000, PricePerDay = 125, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 AC", Segment = "Małe", IsAvailable = true, Traveled = 40000, PricePerDay = 60, YearOfProduction = 2000, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Tavera Neo 3 10 Seats BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 300, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Fiesta 45078 ZXi Duratec", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 190, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ertiga VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 400, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Manza Aura Quadrajet BS IV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 97000, PricePerDay = 260, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift VVT VXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 30000, PricePerDay = 400, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Sportz Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 250, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 44958 Kappa Asta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10000, PricePerDay = 600, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Zen Estilo VXI BSIV", Segment = "Małe", IsAvailable = true, Traveled = 52047, PricePerDay = 175, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova 45048 G (Diesel) 8 Seater BS IV", Segment = "SUV", IsAvailable = true, Traveled = 200000, PricePerDay = 450, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Tiago 44958 Revotron XZA", Segment = "Kompaktowe", IsAvailable = true, Traveled = 15000, PricePerDay = 350, YearOfProduction = 2019, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Vitara Brezza ZDi", Segment = "SUV", IsAvailable = true, Traveled = 50000, PricePerDay = 800, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift VXI BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 250, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift VXI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10000, PricePerDay = 600, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift VDI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 600, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto 800 LXI", Segment = "Małe", IsAvailable = true, Traveled = 40000, PricePerDay = 130, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI", Segment = "Małe", IsAvailable = true, Traveled = 62009, PricePerDay = 90, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Active 44958 S", Segment = "Kompaktowe", IsAvailable = true, Traveled = 33100, PricePerDay = 595, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Era Plus", Segment = "Małe", IsAvailable = true, Traveled = 40000, PricePerDay = 190, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro GLS I - Euro I", Segment = "Małe", IsAvailable = true, Traveled = 120000, PricePerDay = 50, YearOfProduction = 1999, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI Minor", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 95, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Safari Storme VX", Segment = "SUV", IsAvailable = true, Traveled = 70000, PricePerDay = 1000, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Scorpio REV 116", Segment = "SUV", IsAvailable = true, Traveled = 220000, PricePerDay = 220, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero SLX", Segment = "SUV", IsAvailable = true, Traveled = 50000, PricePerDay = 400, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "GO Plus A", Segment = "Kompaktowe", IsAvailable = true, Traveled = 45000, PricePerDay = 315, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fortuner 4x4 MT", Segment = "SUV", IsAvailable = true, Traveled = 110000, PricePerDay = 1000, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ecosport 45047 DV5 MT Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 49000, PricePerDay = 500, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W11 AT BSIV", Segment = "SUV", IsAvailable = true, Traveled = 35000, PricePerDay = 1600, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Supro VX 8 Str", Segment = "Kompaktowe", IsAvailable = true, Traveled = 160000, PricePerDay = 500, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX", Segment = "Małe", IsAvailable = true, Traveled = 180000, PricePerDay = 70, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 AC", Segment = "Małe", IsAvailable = true, Traveled = 60000, PricePerDay = 105, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Endeavour 2.5L 4X2 MT", Segment = "SUV", IsAvailable = true, Traveled = 110000, PricePerDay = 400, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI", Segment = "Małe", IsAvailable = true, Traveled = 60000, PricePerDay = 80, YearOfProduction = 2004, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto 800 VXI", Segment = "Małe", IsAvailable = true, Traveled = 30000, PricePerDay = 300, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "KUV 100 D75 K2", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 409, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift Glam", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 250, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "New Safari DICOR 44959 EX 4x2", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 250, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 215, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fortuner 4x4 MT", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 1400, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Brio 44958 VX MT", Segment = "Małe", IsAvailable = true, Traveled = 20000, PricePerDay = 475, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Brio 44958 VX MT", Segment = "Małe", IsAvailable = true, Traveled = 22000, PricePerDay = 475, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Spark 1.0 LS", Segment = "Małe", IsAvailable = true, Traveled = 35000, PricePerDay = 75, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Sail Hatchback LS ABS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 200, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Tiago NRG Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 8000, PricePerDay = 575, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ritz VDi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 40000, PricePerDay = 150, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Vitara Brezza ZDi Plus", Segment = "SUV", IsAvailable = true, Traveled = 10000, PricePerDay = 850, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro Era", Segment = "Małe", IsAvailable = true, Traveled = 30000, PricePerDay = 350, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Endeavour 2.5L 4X2 MT", Segment = "SUV", IsAvailable = true, Traveled = 54000, PricePerDay = 550, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna 45017 VTVT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80577, PricePerDay = 330, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "City i-DTEC V", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 1044, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Verna 45078 CRDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 127500, PricePerDay = 300, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON D Lite Plus", Segment = "Małe", IsAvailable = true, Traveled = 40903, PricePerDay = 235, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Figo Petrol Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 120, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R VXI", Segment = "Małe", IsAvailable = true, Traveled = 46000, PricePerDay = 130, YearOfProduction = 2004, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Endeavour 4x4 XLT", Segment = "SUV", IsAvailable = true, Traveled = 22288, PricePerDay = 275, YearOfProduction = 2004, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Jetta 2.0 TDI Trendline", Segment = "Kompaktowe", IsAvailable = true, Traveled = 180000, PricePerDay = 270, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Polo 45047 TDI Highline", Segment = "Kompaktowe", IsAvailable = true, Traveled = 30000, PricePerDay = 500, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 Sportz", Segment = "Kompaktowe", IsAvailable = true, Traveled = 61690, PricePerDay = 400, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Asta 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 64484, PricePerDay = 600, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Q5 2.0 TDI", Segment = "SUV", IsAvailable = true, Traveled = 90000, PricePerDay = 1350, YearOfProduction = 2012, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 85PS Diesel RxE", Segment = "SUV", IsAvailable = true, Traveled = 75976, PricePerDay = 400, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Diesel Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 70000, PricePerDay = 220, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Brio E MT", Segment = "Małe", IsAvailable = true, Traveled = 85962, PricePerDay = 300, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Omni E MPI STD BS IV", Segment = "Małe", IsAvailable = true, Traveled = 120000, PricePerDay = 250, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Mobilio V i DTEC", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 600, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Brio S Option AT", Segment = "Małe", IsAvailable = true, Traveled = 75000, PricePerDay = 285, YearOfProduction = 2012, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Accord 45018 MT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 57035, PricePerDay = 350, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero SLX", Segment = "SUV", IsAvailable = true, Traveled = 70000, PricePerDay = 170, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Figo 1.2P Ambiente MT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 45000, PricePerDay = 229, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W6 2WD", Segment = "SUV", IsAvailable = true, Traveled = 72104, PricePerDay = 500, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Nano Lx", Segment = "Małe", IsAvailable = true, Traveled = 15000, PricePerDay = 75, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Active 44958 SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 30000, PricePerDay = 600, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indigo LS Dicor", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 220, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica Vista Terra 45017 TDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 164000, PricePerDay = 150, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX", Segment = "Małe", IsAvailable = true, Traveled = 124439, PricePerDay = 65, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Zen VXI", Segment = "Małe", IsAvailable = true, Traveled = 77000, PricePerDay = 120, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 240, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "KWID 1.0 RXT Optional", Segment = "Małe", IsAvailable = true, Traveled = 30000, PricePerDay = 390, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LS", Segment = "Małe", IsAvailable = true, Traveled = 50000, PricePerDay = 180, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 320, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto 800 LXI", Segment = "Małe", IsAvailable = true, Traveled = 5000, PricePerDay = 310, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R AMT VXI", Segment = "Małe", IsAvailable = true, Traveled = 24000, PricePerDay = 420, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Tiago NRG Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10000, PricePerDay = 550, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ertiga SHVS VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 78000, PricePerDay = 550, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "TUV 300 T4 Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 760, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "800 AC BSII", Segment = "Małe", IsAvailable = true, Traveled = 100000, PricePerDay = 43, YearOfProduction = 2001, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Omni MPI STD BSIV", Segment = "Małe", IsAvailable = true, Traveled = 20000, PricePerDay = 250, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro Magna BSIV", Segment = "Małe", IsAvailable = true, Traveled = 1250, PricePerDay = 500, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Zest Revotron 44958 XT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 17152, PricePerDay = 380, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W11 Option AT AWD", Segment = "SUV", IsAvailable = true, Traveled = 5000, PricePerDay = 1850, YearOfProduction = 2019, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Polo Diesel Trendline 1.2L", Segment = "Kompaktowe", IsAvailable = true, Traveled = 77000, PricePerDay = 350, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Verna CRDi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 195, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LS", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 225, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova 45048 G (Diesel) 7 Seater", Segment = "SUV", IsAvailable = true, Traveled = 65000, PricePerDay = 1125, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica Vista Quadrajet LX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 133, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Era Plus", Segment = "Małe", IsAvailable = true, Traveled = 24005, PricePerDay = 200, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Vitara Brezza ZDi Plus", Segment = "SUV", IsAvailable = true, Traveled = 20000, PricePerDay = 940, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 85PS Diesel RxL", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 400, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Era 44927", Segment = "Małe", IsAvailable = true, Traveled = 120000, PricePerDay = 120, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire ZDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 625, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift 44986 VXi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 110, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 110PS Diesel RxZ", Segment = "SUV", IsAvailable = true, Traveled = 100000, PricePerDay = 490, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX", Segment = "Małe", IsAvailable = true, Traveled = 120000, PricePerDay = 140, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Diesel ZXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 149000, PricePerDay = 175, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI BSIII", Segment = "Małe", IsAvailable = true, Traveled = 65000, PricePerDay = 90, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Ldi BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 275, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Vento Diesel Highline", Segment = "Kompaktowe", IsAvailable = true, Traveled = 65000, PricePerDay = 300, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "GO Plus T Option BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 19000, PricePerDay = 270, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 130, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto K10 VXI Airbag", Segment = "Małe", IsAvailable = true, Traveled = 30000, PricePerDay = 275, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 109000, PricePerDay = 352, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "LPG", Model = "EON LPG Magna Plus", Segment = "Małe", IsAvailable = true, Traveled = 90000, PricePerDay = 180, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX", Segment = "Małe", IsAvailable = true, Traveled = 90000, PricePerDay = 150, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Vento Diesel Highline", Segment = "Kompaktowe", IsAvailable = true, Traveled = 65000, PricePerDay = 300, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Vdi BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 300, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Bolero DI DX 7 Seater", Segment = "SUV", IsAvailable = true, Traveled = 120000, PricePerDay = 225, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Mobilio V i DTEC", Segment = "Kompaktowe", IsAvailable = true, Traveled = 44000, PricePerDay = 600, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ertiga BSIV ZXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 80000, PricePerDay = 500, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "BR-V i-VTEC S MT", Segment = "VTEC S MT", IsAvailable = true, Traveled = 5000, PricePerDay = 900, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Magna 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 61000, PricePerDay = 600, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Etios VD", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 450, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Era 44927", Segment = "Małe", IsAvailable = true, Traveled = 27633, PricePerDay = 270, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Vdi BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 310, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "LPG", Model = "Santro Xing GLS Audio LPG", Segment = "Małe", IsAvailable = true, Traveled = 100000, PricePerDay = 250, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Figo 1.2P Titanium MT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 12586, PricePerDay = 700, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Avventura Urban Cross 44986 Multijet Emotion", Segment = "Kompaktowe", IsAvailable = true, Traveled = 38083, PricePerDay = 650, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Diesel ZXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 55328, PricePerDay = 400, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Diesel Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 81632, PricePerDay = 425, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Aspire Titanium Diesel BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 155201, PricePerDay = 600, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "EcoSport 45047 TDCi Titanium BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 93283, PricePerDay = 600, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Ldi BSIII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 217871, PricePerDay = 300, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fiesta Classic 45017 Duratorq CLXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90165, PricePerDay = 450, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ecosport 45047 DV5 MT Titanium", Segment = "Kompaktowe", IsAvailable = true, Traveled = 101504, PricePerDay = 750, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Figo Titanium Diesel BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 86017, PricePerDay = 325, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "XUV500 W8 2WD", Segment = "SUV", IsAvailable = true, Traveled = 85036, PricePerDay = 900, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ikon 1.3L Rocam Flair", Segment = "Małe", IsAvailable = true, Traveled = 91086, PricePerDay = 180, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Punto 44986 Emotion", Segment = "Kompaktowe", IsAvailable = true, Traveled = 160254, PricePerDay = 350, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "EcoSport 45047 TDCi Titanium BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 125531, PricePerDay = 600, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "WR-V i-DTEC V", Segment = "DTEC V", IsAvailable = true, Traveled = 60000, PricePerDay = 900, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Laura L n K 45170 PD", Segment = "Kompaktowe", IsAvailable = true, Traveled = 100000, PricePerDay = 350, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ritz LDi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 280, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Xylo D2", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 225, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "City i DTEC S", Segment = "Kompaktowe", IsAvailable = true, Traveled = 82000, PricePerDay = 520, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio 36161 S4", Segment = "SUV", IsAvailable = true, Traveled = 60000, PricePerDay = 509, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Baleno Alpha 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 24000, PricePerDay = 556, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indigo Grand Dicor", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 225, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Amaze EX i-Dtech", Segment = "Kompaktowe", IsAvailable = true, Traveled = 65000, PricePerDay = 325, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 65000, PricePerDay = 365, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Creta 45078 CRDi SX Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 84000, PricePerDay = 850, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Etios GD SP", Segment = "Kompaktowe", IsAvailable = true, Traveled = 75000, PricePerDay = 350, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 225, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LX", Segment = "Małe", IsAvailable = true, Traveled = 50000, PricePerDay = 135, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Wagon R LXI Minor", Segment = "Małe", IsAvailable = true, Traveled = 49000, PricePerDay = 140, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "SX4 S Cross DDiS 320 Delta", Segment = "Kompaktowe", IsAvailable = true, Traveled = 560000, PricePerDay = 665, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "KWID RXT", Segment = "Małe", IsAvailable = true, Traveled = 14365, PricePerDay = 275, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fortuner 45140 4WD AT BSIV", Segment = "SUV", IsAvailable = true, Traveled = 41000, PricePerDay = 2750, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Verna 45078 SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 65000, PricePerDay = 484, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Ciaz VDi Option SHVS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 65000, PricePerDay = 565, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 61083, PricePerDay = 425, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova 45048 VX (Diesel) 8 Seater", Segment = "SUV", IsAvailable = true, Traveled = 75000, PricePerDay = 925, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio VLX 2WD AIRBAG SE BSIV", Segment = "SUV", IsAvailable = true, Traveled = 72000, PricePerDay = 565, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 110PS Diesel RxL", Segment = "SUV", IsAvailable = true, Traveled = 65000, PricePerDay = 525, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Tucson 2.0 e-VGT 2WD MT", Segment = "SUV", IsAvailable = true, Traveled = 55000, PricePerDay = 1650, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "EON Era Plus", Segment = "Małe", IsAvailable = true, Traveled = 21000, PricePerDay = 295, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "XF 5.0 Litre V8 Petrol", Segment = "Luksusowe", IsAvailable = true, Traveled = 66363, PricePerDay = 2050, YearOfProduction = 2012, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Creta 45078 VTVT AT SX Plus", Segment = "SUV", IsAvailable = true, Traveled = 11700, PricePerDay = 1475, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna VTVT 45078 AT SX Option", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10000, PricePerDay = 1100, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "GL-Class 350 CDI Blue Efficiency", Segment = "Luksusowe", IsAvailable = true, Traveled = 100000, PricePerDay = 4400, YearOfProduction = 2014, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift ZXI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 7104, PricePerDay = 670, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "S-Cross Zeta DDiS 200 SH", Segment = "Kompaktowe", IsAvailable = true, Traveled = 45974, PricePerDay = 750, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna 45078 VTVT SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 55340, PricePerDay = 760, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Polo GTI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 20000, PricePerDay = 850, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Pulse RxL", Segment = "Kompaktowe", IsAvailable = true, Traveled = 61585, PricePerDay = 390, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Celerio VXI AMT BSIV", Segment = "Małe", IsAvailable = true, Traveled = 39415, PricePerDay = 450, YearOfProduction = 2016, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Brio V MT", Segment = "Małe", IsAvailable = true, Traveled = 29654, PricePerDay = 425, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Baleno Alpha 44986", Segment = "Kompaktowe", IsAvailable = true, Traveled = 64672, PricePerDay = 770, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Creta 45078 SX Automatic Diesel", Segment = "SUV", IsAvailable = true, Traveled = 54634, PricePerDay = 1150, YearOfProduction = 2015, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "City i VTEC V", Segment = "Kompaktowe", IsAvailable = true, Traveled = 66521, PricePerDay = 775, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Innova Crysta 45018 GX AT", Segment = "SUV", IsAvailable = true, Traveled = 23974, PricePerDay = 1725, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "3 Series 320d Luxury Line", Segment = "Luksusowe", IsAvailable = true, Traveled = 43000, PricePerDay = 2150, YearOfProduction = 2016, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 85PS Diesel RxL", Segment = "SUV", IsAvailable = true, Traveled = 1000, PricePerDay = 450, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "C-Class Progressive C 220d", Segment = "Luksusowe", IsAvailable = true, Traveled = 10000, PricePerDay = 3800, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A4 3.0 TDI Quattro", Segment = "Luksusowe", IsAvailable = true, Traveled = 86000, PricePerDay = 1580, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "X5 xDrive 30d xLine", Segment = "Luksusowe", IsAvailable = true, Traveled = 30000, PricePerDay = 4950, YearOfProduction = 2019, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Creta 45078 CRDi SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 52600, PricePerDay = 535, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 Vxi BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 225, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 44958 Kappa Magna AT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 19890, PricePerDay = 550, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift ZXI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 7104, PricePerDay = 670, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ertiga VXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 11918, PricePerDay = 625, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 Magna AT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10510, PricePerDay = 520, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LT Option", Segment = "Kompaktowe", IsAvailable = true, Traveled = 41000, PricePerDay = 239, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fortuner 4x2 AT", Segment = "SUV", IsAvailable = true, Traveled = 47162, PricePerDay = 2600, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "S-Cross Zeta DDiS 200 SH", Segment = "Kompaktowe", IsAvailable = true, Traveled = 45974, PricePerDay = 750, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Magna", Segment = "Małe", IsAvailable = true, Traveled = 49824, PricePerDay = 229, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A6 2.0 TDI Premium Plus", Segment = "Luksusowe", IsAvailable = true, Traveled = 58500, PricePerDay = 1300, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro GS", Segment = "Małe", IsAvailable = true, Traveled = 56580, PricePerDay = 80, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Laura Ambiente 2.0 TDI CR MT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 52000, PricePerDay = 385, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna 45078 VTVT SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 55340, PricePerDay = 760, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 46507, PricePerDay = 600, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 85PS Diesel RxL", Segment = "SUV", IsAvailable = true, Traveled = 1000, PricePerDay = 450, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "C-Class Progressive C 220d", Segment = "Luksusowe", IsAvailable = true, Traveled = 10000, PricePerDay = 3800, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A4 3.0 TDI Quattro", Segment = "Luksusowe", IsAvailable = true, Traveled = 86000, PricePerDay = 1580, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "X5 xDrive 30d xLine", Segment = "Luksusowe", IsAvailable = true, Traveled = 30000, PricePerDay = 4950, YearOfProduction = 2019, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Creta 45078 CRDi SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 52600, PricePerDay = 535, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 Vxi BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 225, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 44958 Kappa Magna AT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 19890, PricePerDay = 550, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift ZXI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 7104, PricePerDay = 670, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ertiga VXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 11918, PricePerDay = 625, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 Magna AT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10510, PricePerDay = 520, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LT Option", Segment = "Kompaktowe", IsAvailable = true, Traveled = 41000, PricePerDay = 239, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fortuner 4x2 AT", Segment = "SUV", IsAvailable = true, Traveled = 47162, PricePerDay = 2600, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "S-Cross Zeta DDiS 200 SH", Segment = "Kompaktowe", IsAvailable = true, Traveled = 45974, PricePerDay = 750, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Magna", Segment = "Małe", IsAvailable = true, Traveled = 49824, PricePerDay = 229, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A6 2.0 TDI Premium Plus", Segment = "Luksusowe", IsAvailable = true, Traveled = 58500, PricePerDay = 1300, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro GS", Segment = "Małe", IsAvailable = true, Traveled = 56580, PricePerDay = 80, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Laura Ambiente 2.0 TDI CR MT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 52000, PricePerDay = 385, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna 45078 VTVT SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 55340, PricePerDay = 760, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 46507, PricePerDay = 600, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 85PS Diesel RxL", Segment = "Kompaktowe", IsAvailable = true, Traveled = 1000, PricePerDay = 450, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "C-Class Progressive C 220d", Segment = "Małe", IsAvailable = true, Traveled = 10000, PricePerDay = 3800, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A4 3.0 TDI Quattro", Segment = "Kompaktowe", IsAvailable = true, Traveled = 86000, PricePerDay = 1580, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "X5 xDrive 30d xLine", Segment = "SUV", IsAvailable = true, Traveled = 30000, PricePerDay = 4950, YearOfProduction = 2019, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Creta 45078 CRDi SX", Segment = "SUV", IsAvailable = true, Traveled = 52600, PricePerDay = 535, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 Vxi BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 110000, PricePerDay = 225, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 44958 Kappa Magna AT", Segment = "Małe", IsAvailable = true, Traveled = 19890, PricePerDay = 550, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift ZXI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 7104, PricePerDay = 670, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ertiga VXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 11918, PricePerDay = 625, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 Magna AT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 10510, PricePerDay = 520, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LT Option", Segment = "Kompaktowe", IsAvailable = true, Traveled = 41000, PricePerDay = 239, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fortuner 4x2 AT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 47162, PricePerDay = 2600, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "S-Cross Zeta DDiS 200 SH", Segment = "Kompaktowe", IsAvailable = true, Traveled = 45974, PricePerDay = 750, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Magna", Segment = "Kompaktowe", IsAvailable = true, Traveled = 49824, PricePerDay = 229, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A6 2.0 TDI Premium Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 58500, PricePerDay = 1300, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro GS", Segment = "Małe", IsAvailable = true, Traveled = 56580, PricePerDay = 80, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Laura Ambiente 2.0 TDI CR MT", Segment = "SUV", IsAvailable = true, Traveled = 52000, PricePerDay = 385, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna 45078 VTVT SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 55340, PricePerDay = 760, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "SUV", IsAvailable = true, Traveled = 46507, PricePerDay = 600, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Duster 85PS Diesel RxL", Segment = "Kompaktowe", IsAvailable = true, Traveled = 1000, PricePerDay = 450, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "C-Class Progressive C 220d", Segment = "Małe", IsAvailable = true, Traveled = 10000, PricePerDay = 3800, YearOfProduction = 2018, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A4 3.0 TDI Quattro", Segment = "Kompaktowe", IsAvailable = true, Traveled = 86000, PricePerDay = 1580, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "X5 xDrive 30d xLine", Segment = "Kompaktowe", IsAvailable = true, Traveled = 30000, PricePerDay = 4950, YearOfProduction = 2019, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Creta 45078 CRDi SX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 52600, PricePerDay = 535, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "SX4 Vxi BSIV", Segment = "Małe", IsAvailable = true, Traveled = 110000, PricePerDay = 225, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 44958 Kappa Magna AT", Segment = "Małe", IsAvailable = true, Traveled = 19890, PricePerDay = 550, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift ZXI BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 7104, PricePerDay = 670, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Ertiga VXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 11918, PricePerDay = 625, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Grand i10 Magna AT", Segment = "SUV", IsAvailable = true, Traveled = 10510, PricePerDay = 520, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LT Option", Segment = "Małe", IsAvailable = true, Traveled = 41000, PricePerDay = 239, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Fortuner 4x2 AT", Segment = "Małe", IsAvailable = true, Traveled = 47162, PricePerDay = 2600, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "S-Cross Zeta DDiS 200 SH", Segment = "SUV", IsAvailable = true, Traveled = 45974, PricePerDay = 750, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i10 Magna", Segment = "Kompaktowe", IsAvailable = true, Traveled = 49824, PricePerDay = 229, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "A6 2.0 TDI Premium Plus", Segment = "Kompaktowe", IsAvailable = true, Traveled = 58500, PricePerDay = 1300, YearOfProduction = 2013, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Santro GS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 56580, PricePerDay = 80, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Laura Ambiente 2.0 TDI CR MT", Segment = "SUV", IsAvailable = true, Traveled = 52000, PricePerDay = 385, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Verna 45078 VTVT SX", Segment = "Małe", IsAvailable = true, Traveled = 55340, PricePerDay = 760, YearOfProduction = 2015, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift Dzire VDI", Segment = "Małe", IsAvailable = true, Traveled = 46507, PricePerDay = 600, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Sportz 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 350, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto 800 LXI", Segment = "Małe", IsAvailable = true, Traveled = 30000, PricePerDay = 114, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "i20 Sportz 44958", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 380, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Gypsy E MG410W ST", Segment = "SUV", IsAvailable = true, Traveled = 100000, PricePerDay = 95, YearOfProduction = 1995, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio 36161 S6 Plus", Segment = "SUV", IsAvailable = true, Traveled = 35000, PricePerDay = 900, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Beat LT", Segment = "Kompaktowe", IsAvailable = true, Traveled = 90000, PricePerDay = 200, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Omni E MPI STD BS IV", Segment = "Małe", IsAvailable = true, Traveled = 11451, PricePerDay = 229, YearOfProduction = 2014, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Nexon 45047 Revotorq XZ", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 800, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Verito 45047 D4 BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 172000, PricePerDay = 150, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Swift VDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 60000, PricePerDay = 600, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Tavera LS B3 7 Seats BSII", Segment = "Kompaktowe", IsAvailable = true, Traveled = 150000, PricePerDay = 150, YearOfProduction = 2005, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Optra Magnum 2.0 LS", Segment = "Kompaktowe", IsAvailable = true, Traveled = 66000, PricePerDay = 150, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Eeco 5 Seater Standard BSIV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 5000, PricePerDay = 380, YearOfProduction = 2019, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift 44986 VXi", Segment = "Kompaktowe", IsAvailable = true, Traveled = 66508, PricePerDay = 80, YearOfProduction = 2006, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Civic 45139 MT Sport", Segment = "Kompaktowe", IsAvailable = true, Traveled = 55000, PricePerDay = 225, YearOfProduction = 2007, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Nano Lx BSIV", Segment = "Małe", IsAvailable = true, Traveled = 29900, PricePerDay = 75, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Hexa XT 4X4", Segment = "SUV", IsAvailable = true, Traveled = 3000, PricePerDay = 1600, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica Vista Quadrajet VX", Segment = "Kompaktowe", IsAvailable = true, Traveled = 85000, PricePerDay = 185, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Scorpio 45079 CRDe SLE", Segment = "SUV", IsAvailable = true, Traveled = 50000, PricePerDay = 425, YearOfProduction = 2011, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Indica Vista Aqua 45017 TDI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 120000, PricePerDay = 100, YearOfProduction = 2010, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Zen Estilo LXI BSIII", Segment = "Małe", IsAvailable = true, Traveled = 90000, PricePerDay = 140, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift Dzire AMT ZXI Plus BS IV", Segment = "Kompaktowe", IsAvailable = true, Traveled = 8000, PricePerDay = 710, YearOfProduction = 2017, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Amaze S AT i-Vtech", Segment = "Kompaktowe", IsAvailable = true, Traveled = 7900, PricePerDay = 450, YearOfProduction = 2015, GearTransmission = "Automatyczna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "RediGO T Option", Segment = "Kompaktowe", IsAvailable = true, Traveled = 50000, PricePerDay = 210, YearOfProduction = 2017, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto K10 VXI", Segment = "Małe", IsAvailable = true, Traveled = 25000, PricePerDay = 270, YearOfProduction = 2016, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Alto LXi", Segment = "Małe", IsAvailable = true, Traveled = 20000, PricePerDay = 110, YearOfProduction = 2009, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Swift VXI", Segment = "Kompaktowe", IsAvailable = true, Traveled = 17500, PricePerDay = 540, YearOfProduction = 2018, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Benzyna", Model = "Renault Logan 45017 GLX Petrol", Segment = "Kompaktowe", IsAvailable = true, Traveled = 25000, PricePerDay = 145, YearOfProduction = 2008, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Safari Storme VX", Segment = "SUV", IsAvailable = true, Traveled = 206500, PricePerDay = 360, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "LPG", Model = "i10 Magna LPG", Segment = "Małe", IsAvailable = true, Traveled = 88600, PricePerDay = 250, YearOfProduction = 2013, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Venture EX", Segment = "Małe", IsAvailable = true, Traveled = 80000, PricePerDay = 110, YearOfProduction = 2012, GearTransmission = "Manualna" });
            cars.Add(new Car { Id = SetId(), Type = "Diesel", Model = "Captiva LT", Segment = "SUV", IsAvailable = true, Traveled = 100000, PricePerDay = 250, YearOfProduction = 2008, GearTransmission = "Manualna" });


        }

        

        public void AddCar(string brand, string model, string segment, string type, string transmission, decimal price, int traveled, int year)
        {
            Car car = new Car();
            car.Id = SetId();
            car.BrandName = brand; //marka
            car.Model = model; //model
            car.Segment = segment; //klasa
            car.Type = type; // co żre
            car.GearTransmission = transmission; //skrzynia
            car.PricePerDay = price; //cena
            car.Traveled = traveled; //przejechane
            car.YearOfProduction = year; //rok produkcji
            cars.Add(car);          
        }
   
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        public IEnumerable<Car> GetAll()
        {
            return cars;
        }
        public IEnumerable<Car> GetAllAvailable()
        {
            var availableCars = cars.Where(item => item.IsAvailable == true).ToList();
            return availableCars;
        }

        public void DisplayAllItems(IEnumerable<Car> items)
        {
            
            Console.WriteLine("Wszystkie samochody z naszej ofery: ");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Id.ToString()}. {item.Type}: {item.BrandName}, {item.Model}, {item.Segment}, {item.GearTransmission}, {item.IsAvailable}");
            }
        }
        public void DisplayAllAvailableItems(IEnumerable<Car> items)
        {
            Console.WriteLine("Samochody dostępne od ręki: ");
            foreach (var item in items)
            {
                Console.WriteLine(item.Id.ToString(), item.Type, item.BrandName, item.Model, item.Segment, item.GearTransmission, item.IsAvailable);
            }
        }
    }
    //Lista dodanych samochodów będzie możliwa do wyświetlenia dla admina i usera.
    //Marka, model, kategoria (male, rodzinne, dostawcze), rodzaj paliwa, cena wynajmu/dzien, KM , skrzynia biegow,elektryczne/spalinowe

}
