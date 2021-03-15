package crc641a07f3ca3186cb93;


public class RoundedEntryAndroidRenderer
	extends crc643f46942d9dd1fff9.EntryRenderer
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("almentor.Droid.RoundedEntryAndroidRenderer, almentor.Android", RoundedEntryAndroidRenderer.class, __md_methods);
	}


	public RoundedEntryAndroidRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == RoundedEntryAndroidRenderer.class)
			mono.android.TypeManager.Activate ("almentor.Droid.RoundedEntryAndroidRenderer, almentor.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public RoundedEntryAndroidRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == RoundedEntryAndroidRenderer.class)
			mono.android.TypeManager.Activate ("almentor.Droid.RoundedEntryAndroidRenderer, almentor.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public RoundedEntryAndroidRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == RoundedEntryAndroidRenderer.class)
			mono.android.TypeManager.Activate ("almentor.Droid.RoundedEntryAndroidRenderer, almentor.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
