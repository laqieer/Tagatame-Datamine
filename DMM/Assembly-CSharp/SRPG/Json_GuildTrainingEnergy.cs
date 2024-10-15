// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GuildTrainingEnergy
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002530")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_GuildTrainingEnergy
  {
    [Token(Token = "0x400AA42")]
    [FieldOffset(Offset = "0x8")]
    public long base_time;
    [Token(Token = "0x400AA43")]
    [FieldOffset(Offset = "0x10")]
    public int num;
    [Token(Token = "0x400AA44")]
    [FieldOffset(Offset = "0x14")]
    public int limit;

    [Token(Token = "0x600A3BC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GuildTrainingEnergy()
    {
    }
  }
}
