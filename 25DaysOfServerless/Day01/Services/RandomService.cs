using System;
using System.Collections.Generic;
using System.Linq;

namespace Day01.Services
{
    public class RandomService : IRandomService
    {
        private readonly IEnumerable<string> _options;

        public RandomService(IEnumerable<string> options)
        {
            _options = options;
        }

        public string GetRandom()
        {
            // get random index
            var index = new Random().Next(_options.Count());

            // get element from options
            var value = _options.ElementAt(index);

            // return random value
            return value;
        }
    }
}
