using System;
using DynamicData.Binding;

namespace CityEvents.Models;

public class CityEvent : AbstractNotifyPropertyChanged
{
	private string _header;
	private string _description;
	private string _img;
	private string _date;
	private decimal _price;
	private ushort _printLength = 135;
	private Category _category;

	public CityEvent()
	{
		_header = string.Empty;
		_description = string.Empty;
		_img = string.Empty;
		_date = string.Empty;
		_price = Decimal.Zero;
		_category = null!;
	}
	
	public string Header
	{
		get => _header;
		set => SetAndRaise(ref _header, value);
	}

	public string Description
	{
		get
		{
			if (_description.Length > _printLength)
				return _description.Substring(0, _printLength) + "...";
				
			return _description;
		}
		set => SetAndRaise(ref _description, value);
	}

	public string Image
	{
		get => _img;
		set => SetAndRaise(ref _img, value);
	}

	public string Date
	{
		get => _date;
		set => SetAndRaise(ref _date, value);
	}

	public decimal Price
	{
		get => _price;
		set => SetAndRaise(ref _price, value);
	}

	public Category Category
	{
		get => _category;
		set => SetAndRaise(ref _category, value);
	}

}
