﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JobTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000556")]
  public sealed class JobTypesFormatter : IMessagePackFormatter<JobTypes>, IMessagePackFormatter
  {
    [Token(Token = "0x6001950")]
    [Address(RVA = "0x6A1000", Offset = "0x69FE00", VA = "0x106A1000", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JobTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001951")]
    [Address(RVA = "0x6A0FA0", Offset = "0x69FDA0", VA = "0x106A0FA0", Slot = "5")]
    public JobTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new JobTypes();
    }

    [Token(Token = "0x6001952")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JobTypesFormatter()
    {
    }
  }
}