// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidTrainingPeriod
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FAD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidTrainingPeriod
  {
    [Token(Token = "0x400373D")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400373E")]
    [FieldOffset(Offset = "0xC")]
    public string title;
    [Token(Token = "0x400373F")]
    [FieldOffset(Offset = "0x10")]
    public int selected;

    [Token(Token = "0x60040D7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidTrainingPeriod()
    {
    }
  }
}
