// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisStarParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B16")]
  public class GenesisStarParam
  {
    [Token(Token = "0x400673F")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006740")]
    [FieldOffset(Offset = "0xC")]
    private GenesisStarRewardParam[] mStars;

    [Token(Token = "0x17000D0C")]
    public string Iname
    {
      [Token(Token = "0x6006FCE"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D0D")]
    public List<GenesisStarRewardParam> StarList
    {
      [Token(Token = "0x6006FCF"), Address(RVA = "0x36E070", Offset = "0x36CE70", VA = "0x1036E070")] get
      {
        return (List<GenesisStarRewardParam>) null;
      }
    }

    [Token(Token = "0x6006FD0")]
    [Address(RVA = "0x36DEF0", Offset = "0x36CCF0", VA = "0x1036DEF0")]
    public void Deserialize(JSON_GenesisStarParam json)
    {
    }

    [Token(Token = "0x6006FD1")]
    [Address(RVA = "0x36DDB0", Offset = "0x36CBB0", VA = "0x1036DDB0")]
    public static void Deserialize(ref List<GenesisStarParam> list, JSON_GenesisStarParam[] json)
    {
    }

    [Token(Token = "0x6006FD2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GenesisStarParam()
    {
    }
  }
}
