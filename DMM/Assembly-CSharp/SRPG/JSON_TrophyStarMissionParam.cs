// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TrophyStarMissionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DA0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TrophyStarMissionParam
  {
    [Token(Token = "0x4007600")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007601")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x4007602")]
    [FieldOffset(Offset = "0x10")]
    public string begin_at;
    [Token(Token = "0x4007603")]
    [FieldOffset(Offset = "0x14")]
    public string end_at;
    [Token(Token = "0x4007604")]
    [FieldOffset(Offset = "0x18")]
    public JSON_TrophyStarMissionParam.StarSetParam[] stars;

    [Token(Token = "0x6007946")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TrophyStarMissionParam()
    {
    }

    [Token(Token = "0x2001DA1")]
    [MessagePackObject(true)]
    [Serializable]
    public class StarSetParam
    {
      [Token(Token = "0x4007605")]
      [FieldOffset(Offset = "0x8")]
      public int require_star;
      [Token(Token = "0x4007606")]
      [FieldOffset(Offset = "0xC")]
      public string reward_id;
      [Token(Token = "0x4007607")]
      [FieldOffset(Offset = "0x10")]
      public int icon;

      [Token(Token = "0x6007947")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public StarSetParam()
      {
      }
    }
  }
}
