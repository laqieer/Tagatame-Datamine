// Decompiled with JetBrains decompiler
// Type: CircularLayoutGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000295")]
[AddComponentMenu("Layout/Circular Layout Group")]
public class CircularLayoutGroup : LayoutGroup
{
  [Token(Token = "0x4000AC3")]
  [FieldOffset(Offset = "0x38")]
  [SerializeField]
  protected float m_AngleMin;
  [Token(Token = "0x4000AC4")]
  [FieldOffset(Offset = "0x3C")]
  [SerializeField]
  protected float m_AngleMax;
  [Token(Token = "0x4000AC5")]
  [FieldOffset(Offset = "0x40")]
  [SerializeField]
  protected float m_Radius;
  [Token(Token = "0x4000AC6")]
  [FieldOffset(Offset = "0x44")]
  [Range(0.0f, 1f)]
  [SerializeField]
  protected float m_Fraction;
  [Token(Token = "0x4000AC7")]
  [FieldOffset(Offset = "0x48")]
  [SerializeField]
  protected bool m_UseFullRange;
  [Token(Token = "0x4000AC8")]
  [FieldOffset(Offset = "0x4C")]
  [SerializeField]
  protected float m_FixedStride;

  [Token(Token = "0x1700019D")]
  public float AngleMin
  {
    [Token(Token = "0x6000DBB"), Address(RVA = "0x11CC830", Offset = "0x11CB630", VA = "0x111CC830")] get
    {
      return new float();
    }
    [Token(Token = "0x6000DBC"), Address(RVA = "0x11CC8C0", Offset = "0x11CB6C0", VA = "0x111CC8C0")] set
    {
    }
  }

  [Token(Token = "0x1700019E")]
  public float AngleMax
  {
    [Token(Token = "0x6000DBD"), Address(RVA = "0x11CC820", Offset = "0x11CB620", VA = "0x111CC820")] get
    {
      return new float();
    }
    [Token(Token = "0x6000DBE"), Address(RVA = "0x11CC870", Offset = "0x11CB670", VA = "0x111CC870")] set
    {
    }
  }

  [Token(Token = "0x1700019F")]
  public float Radius
  {
    [Token(Token = "0x6000DBF"), Address(RVA = "0x11CC860", Offset = "0x11CB660", VA = "0x111CC860")] get
    {
      return new float();
    }
    [Token(Token = "0x6000DC0"), Address(RVA = "0x11CC9B0", Offset = "0x11CB7B0", VA = "0x111CC9B0")] set
    {
    }
  }

  [Token(Token = "0x170001A0")]
  public float Fraction
  {
    [Token(Token = "0x6000DC1"), Address(RVA = "0x11CC850", Offset = "0x11CB650", VA = "0x111CC850")] get
    {
      return new float();
    }
    [Token(Token = "0x6000DC2"), Address(RVA = "0x11CC960", Offset = "0x11CB760", VA = "0x111CC960")] set
    {
    }
  }

  [Token(Token = "0x170001A1")]
  public bool UseFullRange
  {
    [Token(Token = "0x6000DC3"), Address(RVA = "0x661B10", Offset = "0x660910", VA = "0x10661B10")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000DC4"), Address(RVA = "0x11CCA00", Offset = "0x11CB800", VA = "0x111CCA00")] set
    {
    }
  }

  [Token(Token = "0x170001A2")]
  public float FixedStride
  {
    [Token(Token = "0x6000DC5"), Address(RVA = "0x11CC840", Offset = "0x11CB640", VA = "0x111CC840")] get
    {
      return new float();
    }
    [Token(Token = "0x6000DC6"), Address(RVA = "0x11CC910", Offset = "0x11CB710", VA = "0x111CC910")] set
    {
    }
  }

  [Token(Token = "0x6000DC7")]
  [Address(RVA = "0x11CC570", Offset = "0x11CB370", VA = "0x111CC570", Slot = "28")]
  public override void CalculateLayoutInputHorizontal()
  {
  }

  [Token(Token = "0x6000DC8")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "29")]
  public override void CalculateLayoutInputVertical()
  {
  }

  [Token(Token = "0x6000DC9")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "37")]
  public override void SetLayoutHorizontal()
  {
  }

  [Token(Token = "0x6000DCA")]
  [Address(RVA = "0x11CC580", Offset = "0x11CB380", VA = "0x111CC580", Slot = "38")]
  public override void SetLayoutVertical()
  {
  }

  [Token(Token = "0x6000DCB")]
  [Address(RVA = "0x11CC7F0", Offset = "0x11CB5F0", VA = "0x111CC7F0")]
  public CircularLayoutGroup()
  {
  }
}
