using BoDi;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using WestpacBuggyCarAPIProject.repositories;

namespace WestpacBuggyCarAPIProject.Steps
{
    [Binding]
    public class BaseSteps
    {
        private IObjectContainer _container;
        public BaseSteps(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void  Init()
        {
            _container.RegisterInstanceAs<IModelRepository>(new ModelRepository());
        }
    }

}
