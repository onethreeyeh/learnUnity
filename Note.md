### Debug

```cs
//输出变量
Debug.Log("2316");
Debug.LogFormat("My name is {0},and I am {1} years old",variable1,variable2)
```

### Input

```cs
//返回bool值 判断空格是否被按下
Input.GetKeyDown(KeyCode.Space);
//返回bool值 判断空格是否被按住
Input.GetKey(KeyCode.Space);
//返回bool值 判断空格是否回弹
Input.GetKeyUp(KeyCode.Space);
```

可以访问⬇查询各按键的KeyCode

https://docs.unity3d.com/2020.3/Documentation/ScriptReference/KeyCode.html

### Move And Jump

```cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	private float xInput;
	public Rigidbody2D rb;
	public int xSpeed;
	public int jumpForce;
    // Start is called before the first frame update
    void Start()
    {
    	xSpeed = 5;
    	jumpForce = 5;
    }

    // Update is called once per frame
    void Update()
    {
    	xInput = 0;
    	if(Input.GetKey(KeyCode.Space))
    	{
    		Debug.Log("Space is be holded");
    		rb.velocity = new Vector2(rb.velocity.x,jumpForce);
    	}
        if(Input.GetKeyDown(KeyCode.Space))
        {
        	Debug.Log("Space is be pressed");
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
        	Debug.Log("Space is UP");
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
        	Debug.Log("Up");
        }
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        	xInput = Input.GetAxisRaw("Horizontal");
        	rb.velocity = new Vector2(xInput*xSpeed,rb.velocity.y);
    }
}
```
