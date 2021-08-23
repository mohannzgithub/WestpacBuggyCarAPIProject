using System;
using System.Collections.Generic;
using System.Text;
using WestpacBuggyCarAPIProject.dto;

namespace WestpacBuggyCarAPIProject.repositories
{
   public interface IModelRepository
    {
        ModelResponse GetModels();
    }
}
