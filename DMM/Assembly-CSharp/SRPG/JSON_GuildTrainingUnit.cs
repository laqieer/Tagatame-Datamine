// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildTrainingUnit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B30")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildTrainingUnit
  {
    [Token(Token = "0x4006793")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006794")]
    [FieldOffset(Offset = "0xC")]
    public string training_time;
    [Token(Token = "0x4006795")]
    [FieldOffset(Offset = "0x10")]
    public JSON_GuildTrainingUnitPeriod[] period;

    [Token(Token = "0x6007011")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildTrainingUnit()
    {
    }
  }
}
