﻿using System.Collections.Generic;
using NUnit.Framework;

namespace Qpcr.Core.Tests
{
    public class QpcrCoreTests
    {
        private static IEnumerable<QpcrModel> GetQpcrModel()
        {
            yield return new QpcrModel()
            {
                Names = new string[,] {{"Sample-1", "Sample-2", "Sample-3"}, {"Sample-1", "Sample-2", "Sample-3"}},
                NamesOfReagents = new string[,] {{"Pink", "Green"}},
                listOfIntegers = new int[] {3, 2},
                //MaximumNumberOfPlates = 1,
                PlateSize = 96
            };
        }

        private static IEnumerable<QpcrModel> GetQpcrModelSecond()
        {
            yield return new QpcrModel()
            {
                Names = new string[,] {{"Sam 1", "Sam 2", "Sam 3"}, {"Sam 1", "Sam 3", "Sam 4"}},
                NamesOfReagents = new string[,] {{"Reag X", "Reag Y"}, {"Reag Y", "Reag Z"}},
                listOfIntegers = new int[] {1, 3},
                MaximumNumberOfPlates = 1,
                PlateSize = 96
            };
        }

        [TestCaseSource("GetQpcrModel")]
        public void CallMethod_WhenQpcrGenerated_ReturnsTrue(QpcrModel model)
        {
            var result = new QpcrGenerator().GenerateQpcr(model);

            Assert.IsNotNull(result);
        }

        //[TestCaseSource("GetQpcrModelSecond")]
        public void CallMethod_WhenQpcrGeneratedSecond_ReturnsTrue(QpcrModel model)
        {
            var result = new QpcrGenerator().GenerateQpcr(model);

            Assert.IsNotNull(result);
        }
    }
}