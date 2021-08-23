using config;
using repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using WestpacBuggyCarAPIProject.dto;

namespace WestpacBuggyCarAPIProject.repositories
{
   public class ModelRepository : BaseRepository, IModelRepository
    {
        public ModelResponse GetModels()
        {
            var URL = ReadConfigHelper.readEndPointUrl() +"models/";
            return GET<ModelResponse>(URL);
        }
    }
}
