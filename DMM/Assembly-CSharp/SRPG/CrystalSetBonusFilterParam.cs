// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalSetBonusFilterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A9C")]
  public class CrystalSetBonusFilterParam
  {
    [Token(Token = "0x17000C2F")]
    public string Iname
    {
      [Token(Token = "0x6006D94"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D95"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17000C30")]
    public string TabName
    {
      [Token(Token = "0x6006D96"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D97"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17000C31")]
    public string Name
    {
      [Token(Token = "0x6006D98"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x6006D99"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17000C32")]
    public eCrystalFilterTypes FilterType
    {
      [Token(Token = "0x6006D9A"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new eCrystalFilterTypes();
      }
      [Token(Token = "0x6006D9B"), Address(RVA = "0x305840", Offset = "0x304640", VA = "0x10305840")] private set
      {
      }
    }

    [Token(Token = "0x17000C33")]
    public List<CrystalSetBonusFilterCondParam> Conds
    {
      [Token(Token = "0x6006D9C"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<CrystalSetBonusFilterCondParam>) null;
      }
      [Token(Token = "0x6006D9D"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x6006D9E")]
    [Address(RVA = "0x35C040", Offset = "0x35AE40", VA = "0x1035C040")]
    public bool Deserialize(JSON_CrystalSetBonusFilterParam json) => new bool();

    [Token(Token = "0x6006D9F")]
    [Address(RVA = "0x35C200", Offset = "0x35B000", VA = "0x1035C200")]
    public static void Deserialize(
      ref List<CrystalSetBonusFilterParam> param,
      JSON_CrystalSetBonusFilterParam[] json)
    {
    }

    [Token(Token = "0x6006DA0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalSetBonusFilterParam()
    {
    }
  }
}
