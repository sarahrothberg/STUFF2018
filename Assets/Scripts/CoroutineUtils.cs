﻿using UnityEngine;
using System;
using System.Collections;

namespace CoroutineUtilsNamespace
{
	public static class CoroutineUtils
	{

		// /**
		//  * Usage: StartCoroutine(CoroutineUtils.Chain(...))
		//  * For example:
		//  *     StartCoroutine(CoroutineUtils.Chain(
		//  *         CoroutineUtils.Do(() => DebugBulfinch.Log("A")),
		//  *         CoroutineUtils.WaitForSeconds(2),
		//  *         CoroutineUtils.Do(() => DebugBulfinch.Log("B"))));
		//  */
		// public static IEnumerator Chain(params IEnumerator[] actions) {
		//     foreach (IEnumerator action in actions) {
		//         yield return SomeSingletonGO.instance.StartCoroutine(action);
		//     }
		// }

		/**
		 * Usage: StartCoroutine(CoroutineUtils.DelaySeconds(action, delay))
		 * For example:
		 *     StartCoroutine(CoroutineUtils.DelaySeconds(
		 *         () => DebugUtils.Log("2 seconds past"),
		 *         2);
		 */
		public static IEnumerator DelaySeconds(Action action, float delay)
		{
			yield return new WaitForSeconds(delay);
			action();
		}

		public static IEnumerator WaitForSeconds(float time)
		{
			yield return new WaitForSeconds(time);
		}

		public static IEnumerator Do(Action action)
		{
			action();
			yield return 0;
		}
	}
}