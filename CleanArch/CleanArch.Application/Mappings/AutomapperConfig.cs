using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mappings
{
    public class AutomapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new ViewModelToDomainProfile());
                config.AddProfile(new DomainToViewModelProfile());
            });
        }
    }
}
