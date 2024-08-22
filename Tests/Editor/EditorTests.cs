using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;

namespace Mirtilo.SceneTools.Tests
{
    public class SceneToolsRuntimeTests
    {
        [Test]
        public void SceneToolsRuntimeSimplePasses()
        {
        }

        [UnityTest]
        public IEnumerator SceneToolsRuntimeWithEnumeratorPasses()
        {
            yield return null;
        }
    }
}