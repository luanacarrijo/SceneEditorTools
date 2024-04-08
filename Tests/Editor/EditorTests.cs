using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace Mirtilo.Template.Tests
{
    public class TemplateRuntimeTests
    {
        [Test]
        public void TemplateRuntimeSimplePasses()
        {
        }

        [UnityTest]
        public IEnumerator TemplateRuntimeWithEnumeratorPasses()
        {
            yield return null;
        }
    }
}