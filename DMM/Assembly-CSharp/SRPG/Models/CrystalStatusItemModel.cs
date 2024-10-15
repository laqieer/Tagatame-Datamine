// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalStatusItemModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003326")]
  public class CrystalStatusItemModel
  {
    [Token(Token = "0x17001DDB")]
    public string ParamText
    {
      [Token(Token = "0x600E19D"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E19E"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001DDC")]
    public string ParamValue
    {
      [Token(Token = "0x600E19F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E1A0"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001DDD")]
    public string ParamEquipValue
    {
      [Token(Token = "0x600E1A1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E1A2"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001DDE")]
    public Color ParamEquipColor
    {
      [Token(Token = "0x600E1A3"), Address(RVA = "0xAB0F90", Offset = "0xAAFD90", VA = "0x10AB0F90")] get
      {
        return new Color();
      }
      [Token(Token = "0x600E1A4"), Address(RVA = "0xAB0FB0", Offset = "0xAAFDB0", VA = "0x10AB0FB0")] private set
      {
      }
    }

    [Token(Token = "0x17001DDF")]
    public string ParamLimit
    {
      [Token(Token = "0x600E1A5"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E1A6"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] private set
      {
      }
    }

    [Token(Token = "0x17001DE0")]
    public Color ParamLimitColor
    {
      [Token(Token = "0x600E1A7"), Address(RVA = "0xAA6C50", Offset = "0xAA5A50", VA = "0x10AA6C50")] get
      {
        return new Color();
      }
      [Token(Token = "0x600E1A8"), Address(RVA = "0xAB0FC0", Offset = "0xAAFDC0", VA = "0x10AB0FC0")] private set
      {
      }
    }

    [Token(Token = "0x600E1A9")]
    [Address(RVA = "0xAB0C50", Offset = "0xAAFA50", VA = "0x10AB0C50")]
    public void Initialize(
      ParamTypes _type,
      int _value,
      string _tag,
      int _limit,
      CrystalStatusItemModel.TextColor _color,
      bool _is_limit_add)
    {
    }

    [Token(Token = "0x600E1AA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalStatusItemModel()
    {
    }

    [Token(Token = "0x2003327")]
    public struct TextColor
    {
      [Token(Token = "0x400F160")]
      [FieldOffset(Offset = "0x0")]
      public Color value_color;
      [Token(Token = "0x400F161")]
      [FieldOffset(Offset = "0x10")]
      public Color value_over_color;
      [Token(Token = "0x400F162")]
      [FieldOffset(Offset = "0x20")]
      public Color limit_color;
      [Token(Token = "0x400F163")]
      [FieldOffset(Offset = "0x30")]
      public Color limit_add_color;
      [Token(Token = "0x400F164")]
      [FieldOffset(Offset = "0x40")]
      public Color limit_decrease_color;
    }
  }
}
