// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidAreaParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C63")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RaidAreaParam : JSON_RaidMasterParam
  {
    [Token(Token = "0x4006F8A")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006F8B")]
    [FieldOffset(Offset = "0xC")]
    public int order;
    [Token(Token = "0x4006F8C")]
    [FieldOffset(Offset = "0x10")]
    public int period_id;
    [Token(Token = "0x4006F8D")]
    [FieldOffset(Offset = "0x14")]
    public int boss_count;
    [Token(Token = "0x4006F8E")]
    [FieldOffset(Offset = "0x18")]
    public int area_boss_id;
    [Token(Token = "0x4006F8F")]
    [FieldOffset(Offset = "0x1C")]
    public int clear_reward_id;

    [Token(Token = "0x600752D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidAreaParam()
    {
    }
  }
}
