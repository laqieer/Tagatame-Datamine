// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidBossData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010CB")]
  [Serializable]
  public class JSON_RaidBossData
  {
    [Token(Token = "0x4003C86")]
    [FieldOffset(Offset = "0x8")]
    public string uid;
    [Token(Token = "0x4003C87")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4003C88")]
    [FieldOffset(Offset = "0x10")]
    public int area_id;
    [Token(Token = "0x4003C89")]
    [FieldOffset(Offset = "0x14")]
    public JSON_RaidBossInfo boss_info;
    [Token(Token = "0x4003C8A")]
    [FieldOffset(Offset = "0x18")]
    public int sos_status;
    [Token(Token = "0x4003C8B")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_RaidSOSMember[] sos_member;

    [Token(Token = "0x600471A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidBossData()
    {
    }
  }
}
