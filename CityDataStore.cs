namespace CityInfo.Api
{
    using CityInfo.Api.Models;

    /// <summary>
    /// Defines the <see cref="CityDataStore" />
    /// </summary>
    public class CityDataStore
    {
        /// <summary>
        /// Gets or sets the Cities
        /// </summary>
        public List<CityDto> Cities { get; set; }

        /// <summary>
        /// Gets or sets the current
        /// </summary>
        public static CityDataStore current { get; set; } = new CityDataStore();

        /// <summary>
        /// Initializes a new instance of the <see cref="CityDataStore"/> class.
        /// </summary>
        public CityDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointOfInterest = new List<PointOfInterestDto>()
                     {
                         new PointOfInterestDto() { Id = 1, Name = "Central Park1", Description = "The one with that big park."},
                         new PointOfInterestDto() { Id = 2, Name = "Empire State Building", Description = "The one with that big building."},
                         new PointOfInterestDto() { Id = 3, Name = "Statue of Liberty", Description = "The one with that big statue."}
                     }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Los Angeles",
                    Description = "The one with that big airport.",
                    PointOfInterest = new List < PointOfInterestDto >()
                    {
                        new PointOfInterestDto(){Id = 1, Name = "Central Park2", Description = "The one with that big park." },
                        new PointOfInterestDto() { Id = 2, Name = "Empire State Building", Description = "The one with that big building." },
                        new PointOfInterestDto() { Id = 3, Name = "Statue of Liberty", Description = "The one with that big statue." }
                    }
                },
                new CityDto(){ Id = 3, Name = "Chicago", Description = "The one with that big lake.",
                    PointOfInterest = new List < PointOfInterestDto >()
                    { new PointOfInterestDto() { Id = 1, Name = "Central Park3", Description = "The one with that big park." },
                      new PointOfInterestDto() { Id = 2, Name = "Empire State Building", Description = "The one with that big building." }, new PointOfInterestDto() { Id = 3, Name = "Statue of Liberty", Description = "The one with that big statue." } }}
             };
        }
    }
}
