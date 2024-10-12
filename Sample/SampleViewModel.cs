using UnityEngine;

public class SampleViewModel : ViewModel
{
	public BindableProperty<int> SampleInt;
	public BindableProperty<float> SampleFloat;
	public BindableProperty<string> SampleString;
	public BindableProperty<Color> SampleColor;

	protected override void CreateBindableProperties()
	{
		SampleInt = CreateBindableProperty<int>(nameof(SampleInt), 1);
		SampleFloat = CreateBindableProperty<float>(nameof(SampleFloat), 1.5f);
		SampleString = CreateBindableProperty<string>(nameof(SampleString), "sample");
		SampleColor = CreateBindableProperty<Color>(nameof(SampleColor), Color.red);
	}
}