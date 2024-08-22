using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Mirtilo.SceneTools.Editor.Tests
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