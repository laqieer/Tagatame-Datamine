// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BuyCoinHotDealParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019C0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_BuyCoinHotDealParam
  {
    [Token(Token = "0x4005E8C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005E8D")]
    [FieldOffset(Offset = "0xC")]
    public int appearance_time;
    [Token(Token = "0x4005E8E")]
    [FieldOffset(Offset = "0x10")]
    public int interval;
    [Token(Token = "0x4005E8F")]
    [FieldOffset(Offset = "0x14")]
    public string prefab_name;
    [Token(Token = "0x4005E90")]
    [FieldOffset(Offset = "0x18")]
    public int condition;
    [Token(Token = "0x4005E91")]
    [FieldOffset(Offset = "0x1C")]
    public int condition_total_num;
    [Token(Token = "0x4005E92")]
    [FieldOffset(Offset = "0x20")]
    public JSON_BuyCoinHotDealParam.JSON_HotDealConditionParam[] condition_params;
    [Token(Token = "0x4005E93")]
    [FieldOffset(Offset = "0x24")]
    public string speech;
    [Token(Token = "0x4005E94")]
    [FieldOffset(Offset = "0x28")]
    public string url;
    [Token(Token = "0x4005E95")]
    [FieldOffset(Offset = "0x2C")]
    public int sort_order;

    [Token(Token = "0x6006916")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BuyCoinHotDealParam()
    {
    }

    [Token(Token = "0x20019C1")]
    [MessagePackObject(true)]
    [Serializable]
    public class JSON_HotDealConditionParam
    {
      [Token(Token = "0x4005E96")]
      [FieldOffset(Offset = "0x8")]
      public string condition_str;
      [Token(Token = "0x4005E97")]
      [FieldOffset(Offset = "0xC")]
      public int condition_num;

      [Token(Token = "0x6006917")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_HotDealConditionParam()
      {
      }
    }
  }
}
