using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Mirtilo.Template.Editor.Tests
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