using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
public class Test : MonoBehaviour {
	public GameObject cube;

	// DllImport这个方法相当于是告诉Unity，有一个unityToIOS函数在外部会实现。
	// 使用这个方法必须要导入System.Runtime.InteropServices;
	[DllImport("__Internal")]
	private static extern void unityToIOS (string str);

	void OnGUI()
	{
		// 当点击按钮后，调用外部方法
		if (GUI.Button (new Rect (100, 100, 100, 30), "跳转到IOS界面")) {
			// Unity调用ios函数，同时传递数据
			unityToIOS ("Hello IOS");
		}
	}
	// 向右转函数接口
	void turnRight(string num){
		float f;
		if (float.TryParse (num, out f)) {// 将string转换为float，数据之间的传递只能以string类型
			Vector3 r = new Vector3 (cube.transform.rotation.x, cube.transform.rotation.y - 10f, cube.transform.rotation.z);
			cube.transform.Rotate (r);
		}
	}
	// 向左转函数接口
	void turnLeft(string num){
		float f;
		if (float.TryParse (num, out f)) {// 将string转换为float，数据之间的传递只能以string类型
			Vector3 r = new Vector3 (cube.transform.rotation.x, cube.transform.rotation.y - 10f, cube.transform.rotation.z);
			cube.transform.Rotate (r);
		}
	}
}
