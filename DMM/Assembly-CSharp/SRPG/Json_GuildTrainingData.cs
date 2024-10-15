// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GuildTrainingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200252F")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_GuildTrainingData
  {
    [Token(Token = "0x400AA3E")]
    [FieldOffset(Offset = "0x8")]
    public string expansion_id;
    [Token(Token = "0x400AA3F")]
    [FieldOffset(Offset = "0xC")]
    public int no;
    [Token(Token = "0x400AA40")]
    [FieldOffset(Offset = "0x10")]
    public long unit_iid;
    [Token(Token = "0x400AA41")]
    [FieldOffset(Offset = "0x18")]
    public long end_time;

    [Token(Token = "0x600A3BB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_GuildTrainingData()
    {
    }
  }
}
