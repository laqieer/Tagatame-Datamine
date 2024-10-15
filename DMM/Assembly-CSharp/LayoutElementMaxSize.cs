// Decompiled with JetBrains decompiler
// Type: LayoutElementMaxSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000298")]
[RequireComponent(typeof (RectTransform))]
[Serializable]
public class LayoutElementMaxSize : LayoutElement
{
  [Token(Token = "0x4000ACB")]
  [FieldOffset(Offset = "0x2C")]
  [SerializeField]
  private float m_MaxWidth;
  [Token(Token = "0x4000ACC")]
  [FieldOffset(Offset = "0x30")]
  [SerializeField]
  private float m_MaxHeight;
  [Token(Token = "0x4000ACD")]
  [FieldOffset(Offset = "0x34")]
  private float m_CurrentWidth;
  [Token(Token = "0x4000ACE")]
  [FieldOffset(Offset = "0x38")]
  private float m_CurrentHeight;
  [Token(Token = "0x4000ACF")]
  [FieldOffset(Offset = "0x3C")]
  private RectTransform m_RectTransform;

  [Token(Token = "0x170001A3")]
  private bool EnableMinHeight
  {
    [Token(Token = "0x6000DCE"), Address(RVA = "0x11D3CE0", Offset = "0x11D2AE0", VA = "0x111D3CE0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001A4")]
  private bool EnableMinWidth
  {
    [Token(Token = "0x6000DCF"), Address(RVA = "0x11D3D20", Offset = "0x11D2B20", VA = "0x111D3D20")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001A5")]
  private bool EnableMaxHeight
  {
    [Token(Token = "0x6000DD0"), Address(RVA = "0x11D3CA0", Offset = "0x11D2AA0", VA = "0x111D3CA0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001A6")]
  private bool EnableMaxWidth
  {
    [Token(Token = "0x6000DD1"), Address(RVA = "0x11D3CC0", Offset = "0x11D2AC0", VA = "0x111D3CC0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001A7")]
  private bool EnablePreferredHeight
  {
    [Token(Token = "0x6000DD2"), Address(RVA = "0x11D3D60", Offset = "0x11D2B60", VA = "0x111D3D60")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001A8")]
  private bool EnablePreferredWidth
  {
    [Token(Token = "0x6000DD3"), Address(RVA = "0x11D3D80", Offset = "0x11D2B80", VA = "0x111D3D80")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001A9")]
  private RectTransform rectTransform
  {
    [Token(Token = "0x6000DD4"), Address(RVA = "0x11D3EA0", Offset = "0x11D2CA0", VA = "0x111D3EA0")] get
    {
      return (RectTransform) null;
    }
  }

  [Token(Token = "0x170001AA")]
  private bool IsOverMaxWidth
  {
    [Token(Token = "0x6000DD5"), Address(RVA = "0x11D3E00", Offset = "0x11D2C00", VA = "0x111D3E00")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001AB")]
  private bool IsOverMaxHeight
  {
    [Token(Token = "0x6000DD6"), Address(RVA = "0x11D3DA0", Offset = "0x11D2BA0", VA = "0x111D3DA0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x170001AC")]
  public override float preferredHeight
  {
    [Token(Token = "0x6000DD7"), Address(RVA = "0x11D3E60", Offset = "0x11D2C60", VA = "0x111D3E60", Slot = "37")] get
    {
      return new float();
    }
    [Token(Token = "0x6000DD8"), Address(RVA = "0x11D3F20", Offset = "0x11D2D20", VA = "0x111D3F20", Slot = "38")] set
    {
    }
  }

  [Token(Token = "0x170001AD")]
  public override float preferredWidth
  {
    [Token(Token = "0x6000DD9"), Address(RVA = "0x11D3E80", Offset = "0x11D2C80", VA = "0x111D3E80", Slot = "35")] get
    {
      return new float();
    }
    [Token(Token = "0x6000DDA"), Address(RVA = "0x11D3FA0", Offset = "0x11D2DA0", VA = "0x111D3FA0", Slot = "36")] set
    {
    }
  }

  [Token(Token = "0x6000DDB")]
  [Address(RVA = "0x11D3930", Offset = "0x11D2730", VA = "0x111D3930", Slot = "29")]
  public override void CalculateLayoutInputHorizontal()
  {
  }

  [Token(Token = "0x6000DDC")]
  [Address(RVA = "0x11D3930", Offset = "0x11D2730", VA = "0x111D3930", Slot = "30")]
  public override void CalculateLayoutInputVertical()
  {
  }

  [Token(Token = "0x6000DDD")]
  [Address(RVA = "0x11D3930", Offset = "0x11D2730", VA = "0x111D3930", Slot = "10")]
  protected override void OnRectTransformDimensionsChange()
  {
  }

  [Token(Token = "0x6000DDE")]
  [Address(RVA = "0x11D3590", Offset = "0x11D2390", VA = "0x111D3590")]
  private Rect CalcChildRect() => new Rect();

  [Token(Token = "0x6000DDF")]
  [Address(RVA = "0x11D39B0", Offset = "0x11D27B0", VA = "0x111D39B0")]
  private void UpdateMaxSizes()
  {
  }

  [Token(Token = "0x6000DE0")]
  [Address(RVA = "0x11D3950", Offset = "0x11D2750", VA = "0x111D3950")]
  private static bool IsIgnoreLayout(RectTransform tr) => new bool();

  [Token(Token = "0x6000DE1")]
  private static bool SetProperty<T>(ref T currentValue, T newValue) where T : struct => new bool();

  [Token(Token = "0x6000DE2")]
  [Address(RVA = "0x11D3C60", Offset = "0x11D2A60", VA = "0x111D3C60")]
  public LayoutElementMaxSize()
  {
  }
}
