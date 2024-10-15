// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DrawCardRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AAE")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DrawCardRewardParam
  {
    [Token(Token = "0x40062EB")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40062EC")]
    [FieldOffset(Offset = "0xC")]
    public JSON_DrawCardRewardParam.Data[] rewards;

    [Token(Token = "0x6006E0C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DrawCardRewardParam()
    {
    }

    [Token(Token = "0x2001AAF")]
    [MessagePackObject(true)]
    [Serializable]
    public class Data
    {
      [Token(Token = "0x40062ED")]
      [FieldOffset(Offset = "0x8")]
      public int weight;
      [Token(Token = "0x40062EE")]
      [FieldOffset(Offset = "0xC")]
      public int item_type;
      [Token(Token = "0x40062EF")]
      [FieldOffset(Offset = "0x10")]
      public string item_iname;
      [Token(Token = "0x40062F0")]
      [FieldOffset(Offset = "0x14")]
      public int item_num;

      [Token(Token = "0x6006E0D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Data()
      {
      }
    }
  }
}
