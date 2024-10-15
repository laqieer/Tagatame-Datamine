// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TrophyStarMissionRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DA5")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TrophyStarMissionRewardParam
  {
    [Token(Token = "0x4007617")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007618")]
    [FieldOffset(Offset = "0xC")]
    public JSON_TrophyStarMissionRewardParam.Data[] rewards;

    [Token(Token = "0x6007952")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TrophyStarMissionRewardParam()
    {
    }

    [Token(Token = "0x2001DA6")]
    [MessagePackObject(true)]
    [Serializable]
    public class Data
    {
      [Token(Token = "0x4007619")]
      [FieldOffset(Offset = "0x8")]
      public int item_type;
      [Token(Token = "0x400761A")]
      [FieldOffset(Offset = "0xC")]
      public string item_iname;
      [Token(Token = "0x400761B")]
      [FieldOffset(Offset = "0x10")]
      public int item_num;

      [Token(Token = "0x6007953")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Data()
      {
      }
    }
  }
}
