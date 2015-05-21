using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.UIBusiness.ViewModel;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Calculator.BDDTests.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        public ArithmeticViewModel ArithmeticViewModel
        {
            get
            {
                var viewModel = Utils.GetOnTestContext<ArithmeticViewModel>("CalculatorStepDefinitions_ArithmeticViewModel");

                if (viewModel == null)
                {
                    viewModel = new ArithmeticViewModel();

                    Utils.SetOnTestContext("CalculatorStepDefinitions_ArithmeticViewModel", viewModel);
                }

                return viewModel;
            }
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            ArithmeticViewModel.Model.Number = p0;
        }

        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(ArithmeticViewModel.Model.Number, p0);
        }

        [Given(@"I press add")]
        public void GivenIPressAdd()
        {
            ArithmeticViewModel.RunAdd();
        }

        [When(@"I press equals")]
        public void WhenIPressEquals()
        {
            ArithmeticViewModel.RunEquals();
        }
    }
}
