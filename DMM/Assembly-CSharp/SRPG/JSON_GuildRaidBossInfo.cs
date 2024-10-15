// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidBossInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F9C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidBossInfo
  {
    [Token(Token = "0x40036F7")]
    [FieldOffset(Offset = "0x8")]
    public int boss_id;
    [Token(Token = "0x40036F8")]
    [FieldOffset(Offset = "0xC")]
    public int current_hp;

    [Token(Token = "0x60040C6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidBossInfo()
    {
    }
  }
}
