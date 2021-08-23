using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using WestpacBuggyCarAPIProject.dto;
using WestpacBuggyCarAPIProject.repositories;

namespace WestpacBuggyCarAPIProject.Steps
{
    [Binding]
    public class ModelSteps 
    {
        private IModelRepository _modelRepository;
        private ScenarioContext _scenarioContext;
        public ModelSteps(IModelRepository modelRepository, ScenarioContext scenarioContext)
        {
            _modelRepository = modelRepository;
            _scenarioContext = scenarioContext;
           
        }

        [When(@"User call GetModelsAPI")]
        public void WhenUserCallGetModelsAPI()
        {
            var response = _modelRepository.GetModels();
            _scenarioContext.Add("ModelResponse", response);
        }
        
        [Then(@"User see Multiple Models")]
        public void ThenUserSeeMultipleModels()
        {
            ModelResponse response = new ModelResponse();
            var responseExist = _scenarioContext.TryGetValue("ModelResponse", out response);
            Assert.IsTrue(response.totalPages > 0, "No Models Found");
        }
    }
}
