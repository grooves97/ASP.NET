using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication14
{
    /// <summary>
    /// Класс для работы с Google и Twillio
    /// </summary>
    public class SocialNetwokrsService
    {
        private readonly string googleToken;
        private readonly string twillioToken;
        public SocialNetwokrsService(IOptions<SocialMediaOption> options)
        {
            googleToken = options.Value.GoogleToken;
            twillioToken = options.Value.TwillioToken;
        }

        public void ToDo()
        {
            //Используем googleToken
            //И
            //Используем twillioToken
        }
    }
}
