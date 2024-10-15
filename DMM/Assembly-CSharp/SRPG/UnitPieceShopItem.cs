// Decompiled with JetBrains decompiler
// Type: SRPG.UnitPieceShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200117E")]
  public class UnitPieceShopItem
  {
    [Token(Token = "0x1700082C")]
    public string IName
    {
      [Token(Token = "0x6004AA6"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6004AA7"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x1700082D")]
    public bool IsSoldOut
    {
      [Token(Token = "0x6004AA8"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004AA9"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] private set
      {
      }
    }

    [Token(Token = "0x1700082E")]
    public int MaxBuyNum
    {
      [Token(Token = "0x6004AAA"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6004AAB"), Address(RVA = "0x29EEC0", Offset = "0x29DCC0", VA = "0x1029EEC0")] private set
      {
      }
    }

    [Token(Token = "0x1700082F")]
    public int TotalBuyNum
    {
      [Token(Token = "0x6004AAC"), Address(RVA = "0x1214720", Offset = "0x1213520", VA = "0x11214720")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000830")]
    public int BoughtNum
    {
      [Token(Token = "0x6004AAD"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
      [Token(Token = "0x6004AAE"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000831")]
    public int RemainCount
    {
      [Token(Token = "0x6004AAF"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000832")]
    public int CostNum
    {
      [Token(Token = "0x6004AB0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
      [Token(Token = "0x6004AB1"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] private set
      {
      }
    }

    [Token(Token = "0x17000833")]
    public bool IsExpired
    {
      [Token(Token = "0x6004AB2"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004AB3"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] private set
      {
      }
    }

    [Token(Token = "0x17000834")]
    public DateTime EndAt
    {
      [Token(Token = "0x6004AB4"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
      [Token(Token = "0x6004AB5"), Address(RVA = "0x34D360", Offset = "0x34C160", VA = "0x1034D360")] private set
      {
      }
    }

    [Token(Token = "0x17000835")]
    public bool HasNextStep
    {
      [Token(Token = "0x6004AB6"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004AB7"), Address(RVA = "0x7BB1C0", Offset = "0x7B9FC0", VA = "0x107BB1C0")] private set
      {
      }
    }

    [Token(Token = "0x6004AB8")]
    [Address(RVA = "0x12145F0", Offset = "0x12133F0", VA = "0x112145F0")]
    public bool Deserialize(Json_UnitPieceShopItem json) => new bool();

    [Token(Token = "0x6004AB9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitPieceShopItem()
    {
    }
  }
}
