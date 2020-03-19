This script will draw lines in the editor to any objects connected with UnityEvents. The script should be placed somewhere in your Assets, and can then be accessed from your scripts. It must be called in either OnDrawGizmos or OnDrawGizmosSelected

In action: https://gfycat.com/slipperyheftygopher

Implementation
```C#
public UnityEvent myEvent;

private void OnDrawGizmosSelected()
{
	genaralskar.DrawEventLines.Draw(myEvent, transform);
}
```

`myEvent` is your UnityEvent
`transform` is the transform where you want the lines to connect

The line will be green if the event is calling a MonoBehavior (usually custom script), or red otherwise (usually a built in componenet). These colors can be changed in the script.
This is done because if the event is not calling a MonoBehavior it must find the GameObject by name, so if two GameObjects in your project have the same name it may not connect properly.

This does not currently support UnityEvents that require information like `UnityEvent<int> myEvent`