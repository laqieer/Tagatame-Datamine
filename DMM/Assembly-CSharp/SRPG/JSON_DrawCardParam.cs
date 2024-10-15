// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DrawCardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AA9")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DrawCardParam
  {
    [Token(Token = "0x40062D0")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40062D1")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x40062D2")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x40062D3")]
    [FieldOffset(Offset = "0x14")]
    public JSON_DrawCardParam.DrawInfo[] draw_infos;
    [Token(Token = "0x40062D4")]
    [FieldOffset(Offset = "0x18")]
    public int type;

    [Token(Token = "0x6006DF2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DrawCardParam()
    {
    }

    [Token(Token = "0x2001AAA")]
    [MessagePackObject(true)]
    [Serializable]
    public class DrawInfo
    {
      [Token(Token = "0x40062D5")]
      [FieldOffset(Offset = "0x8")]
      public int card_num;
      [Token(Token = "0x40062D6")]
      [FieldOffset(Offset = "0xC")]
      public int miss_num;
      [Token(Token = "0x40062D7")]
      [FieldOffset(Offset = "0x10")]
      public string dc_reward_id;

      [Token(Token = "0x6006DF3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public DrawInfo()
      {
      }
    }
  }
}
