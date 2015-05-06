﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="MApperTestsForScenario.cs" company="PicklesDoc">
//  Copyright 2011 Jeffrey Cameron
//  Copyright 2012-present PicklesDoc team and community contributors
//
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using NFluent;
using NUnit.Framework;
using PicklesDoc.Pickles.ObjectModel;
using G = Gherkin3.Ast;

namespace PicklesDoc.Pickles.Test.ObjectModel
{
    [TestFixture]
    public class MapperTestsForScenario
    {
        private readonly Factory factory = new Factory();

        [Test]
        public void MapScenario_NullScenario_ReturnsNull()
        {
            var mapper = this.factory.CreateMapper();

            Scenario result = mapper.MapToScenario(null);

            Check.That(result).IsNull();
        }

        [Test]
        public void MapToScenario_RegularScenario_ReturnsScenario()
        {
            var scenario = this.factory.CreateScenario(
                new[] { "myTag1", "myTag2" },
                "My scenario title",
                "Description of the scenario",
                new []
                {
                    this.factory.CreateStep("Given", "I enter '50' in the calculator"),
                    this.factory.CreateStep("When", "I press 'plus' on the calculator"),
                    this.factory.CreateStep("Then", "the screen shows '50'")
                });

            var mapper = this.factory.CreateMapper();

            Scenario result = mapper.MapToScenario(scenario);

            Check.That(result.Name).IsEqualTo("My scenario title");

            Check.That(result.Description).IsEqualTo("Description of the scenario");

            Check.That(result.Steps.Count).IsEqualTo(3);
            Check.That(result.Steps[0].Keyword).IsEqualTo(Keyword.Given);
            Check.That(result.Steps[0].Name).IsEqualTo("I enter '50' in the calculator");
            Check.That(result.Steps[1].Keyword).IsEqualTo(Keyword.When);
            Check.That(result.Steps[1].Name).IsEqualTo("I press 'plus' on the calculator");
            Check.That(result.Steps[2].Keyword).IsEqualTo(Keyword.Then);
            Check.That(result.Steps[2].Name).IsEqualTo("the screen shows '50'");

            Check.That(result.Tags.Count).IsEqualTo(2);
            Check.That(result.Tags[0]).IsEqualTo("myTag1");
            Check.That(result.Tags[1]).IsEqualTo("myTag2");
        }
    }
}