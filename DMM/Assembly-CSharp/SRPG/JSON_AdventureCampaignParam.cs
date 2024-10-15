// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdventureCampaignParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200196D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdventureCampaignParam
  {
    [Token(Token = "0x4005C97")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005C98")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x4005C99")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x4005C9A")]
    [FieldOffset(Offset = "0x14")]
    public int adv_cost_rate;
    [Token(Token = "0x4005C9B")]
    [FieldOffset(Offset = "0x18")]
    public int adv_time_rate;
    [Token(Token = "0x4005C9C")]
    [FieldOffset(Offset = "0x1C")]
    public int adv_lottery_num;
    [Token(Token = "0x4005C9D")]
    [FieldOffset(Offset = "0x20")]
    public string[] adv_areas;

    [Token(Token = "0x60067B2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdventureCampaignParam()
    {
    }
  }
}
