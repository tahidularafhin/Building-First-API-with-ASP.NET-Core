﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {
            //init dummy data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="New York City",
                    Description="The one with that big park.",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=1,
                            Name="New York City",
                            Description="The most visited Urban park in the United States"
                        },
                        new PointOfInterestDto()
                        {
                            Id=2,
                            Name="Empire state building",
                            Description="102 story skyscraper located in the Manhattan"
                        },
                    }

                },
                new CityDto()
                {
                    Id=2,
                    Name="Antwerp",
                    Description="The one with cathedral that was never really finished.",
                     PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=3,
                            Name="Cathadral of our Lady",
                            Description="A Gothic style Cathadral, conceive by architect"
                        },
                        new PointOfInterestDto()
                        {
                            Id=4,
                            Name="Anterp Central station",
                            Description="The finest example of railway architecture in Belgium"
                        }
                    }
                },
                new CityDto()
                {
                    Id=3,
                    Name="Paris",
                    Description="The one with the big tower.",
                    PointsOfInterest= new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id=5,
                            Name="Eifel Tower",
                            Description="A wrought iron Lattie tower on the Camp"
                        },
                        new PointOfInterestDto()
                        {
                            Id=6,
                            Name="The Louvre",
                            Description="World largest musum"
                        }
                    }
                }
            };
        }
    }
} 
