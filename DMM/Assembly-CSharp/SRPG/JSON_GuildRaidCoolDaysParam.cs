// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidCoolDaysParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B47")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidCoolDaysParam : JSON_GuildRaidMasterParam
  {
    [Token(Token = "0x4006814")]
    [FieldOffset(Offset = "0x8")]
    public int period_id;
    [Token(Token = "0x4006815")]
    [FieldOffset(Offset = "0xC")]
    public string[] schedule;

    [Token(Token = "0x600707D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidCoolDaysParam()
    {
    }
  }
}
