This script will draw lines in the editor to any objects connected with UnityEvents. The script should be placed somewhere in your Assets, and can then be accessed from your scripts. It must be called in either OnDrawGizmos or OnDrawGizmosSelected

In action: https://gfycat.com/competentfocusedgelada

Implementation
```C#
public UnityEvent myEvent;

private void OnDrawGizmosSelected()
{
	Gizmos.Color = Color.green;
	genaralskar.DrawEventLines.Draw(myEvent, transform);
}
```

`myEvent` is your UnityEvent
`transform` is the transform where you want the lines to connect



This does not currently support UnityEvents that require information like `UnityEvent<int> myEvent`