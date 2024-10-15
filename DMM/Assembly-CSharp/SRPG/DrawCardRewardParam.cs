// Decompiled with JetBrains decompiler
// Type: SRPG.DrawCardRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AB0")]
  public class DrawCardRewardParam
  {
    [Token(Token = "0x40062F1")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x40062F2")]
    [FieldOffset(Offset = "0xC")]
    private DrawCardRewardParam.Data[] mRewards;

    [Token(Token = "0x17000C57")]
    public string Iname
    {
      [Token(Token = "0x6006E0E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C58")]
    public List<DrawCardRewardParam.Data> RewardList
    {
      [Token(Token = "0x6006E0F"), Address(RVA = "0x35E990", Offset = "0x35D790", VA = "0x1035E990")] get
      {
        return (List<DrawCardRewardParam.Data>) null;
      }
    }

    [Token(Token = "0x6006E10")]
    [Address(RVA = "0x35E620", Offset = "0x35D420", VA = "0x1035E620")]
    public void Deserialize(JSON_DrawCardRewardParam json)
    {
    }

    [Token(Token = "0x6006E11")]
    [Address(RVA = "0x35E4B0", Offset = "0x35D2B0", VA = "0x1035E4B0")]
    public static void Deserialize(
      ref Dictionary<string, DrawCardRewardParam> dict,
      JSON_DrawCardRewardParam[] json)
    {
    }

    [Token(Token = "0x6006E12")]
    [Address(RVA = "0x35E7C0", Offset = "0x35D5C0", VA = "0x1035E7C0")]
    public static DrawCardRewardParam GetParam(string key) => (DrawCardRewardParam) null;

    [Token(Token = "0x6006E13")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DrawCardRewardParam()
    {
    }

    [Token(Token = "0x2001AB1")]
    public class Data
    {
      [Token(Token = "0x40062F3")]
      [FieldOffset(Offset = "0x8")]
      public int Weight;
      [Token(Token = "0x40062F4")]
      [FieldOffset(Offset = "0xC")]
      public int ItemType;
      [Token(Token = "0x40062F5")]
      [FieldOffset(Offset = "0x10")]
      public string ItemIname;
      [Token(Token = "0x40062F6")]
      [FieldOffset(Offset = "0x14")]
      public int ItemNum;

      [Token(Token = "0x6006E14")]
      [Address(RVA = "0x35CD90", Offset = "0x35BB90", VA = "0x1035CD90")]
      public void Deserialize(JSON_DrawCardRewardParam.Data json)
      {
      }

      [Token(Token = "0x6006E15")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Data()
      {
      }
    }
  }
}
