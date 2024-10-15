// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardLsBuffCoefParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A6D")]
  public class ConceptCardLsBuffCoefParam
  {
    [Token(Token = "0x4006177")]
    public const int COEF_DEFAULT = 10000;
    [Token(Token = "0x4006178")]
    [FieldOffset(Offset = "0x8")]
    private int mRare;
    [Token(Token = "0x4006179")]
    [FieldOffset(Offset = "0xC")]
    private int[] mCoefs;
    [Token(Token = "0x400617A")]
    [FieldOffset(Offset = "0x10")]
    private int[] mFriendCoefs;

    [Token(Token = "0x17000BEA")]
    public int Rare
    {
      [Token(Token = "0x6006C99"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BEB")]
    public int[] Coefs
    {
      [Token(Token = "0x6006C9A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x17000BEC")]
    public int[] FriendCoefs
    {
      [Token(Token = "0x6006C9B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (int[]) null;
      }
    }

    [Token(Token = "0x6006C9C")]
    [Address(RVA = "0x355810", Offset = "0x354610", VA = "0x10355810")]
    public void Deserialize(JSON_ConceptCardLsBuffCoefParam json)
    {
    }

    [Token(Token = "0x6006C9D")]
    [Address(RVA = "0x355950", Offset = "0x354750", VA = "0x10355950")]
    public static void Deserialize(
      ref List<ConceptCardLsBuffCoefParam> list,
      JSON_ConceptCardLsBuffCoefParam[] json)
    {
    }

    [Token(Token = "0x6006C9E")]
    [Address(RVA = "0x355BB0", Offset = "0x3549B0", VA = "0x10355BB0")]
    public static int GetCoef(List<ConceptCardLsBuffCoefParam> list, int rare, int bt_limit)
    {
      return new int();
    }

    [Token(Token = "0x6006C9F")]
    [Address(RVA = "0x355C90", Offset = "0x354A90", VA = "0x10355C90")]
    public static int GetFriendCoef(List<ConceptCardLsBuffCoefParam> list, int rare, int bt_limit)
    {
      return new int();
    }

    [Token(Token = "0x6006CA0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardLsBuffCoefParam()
    {
    }
  }
}
