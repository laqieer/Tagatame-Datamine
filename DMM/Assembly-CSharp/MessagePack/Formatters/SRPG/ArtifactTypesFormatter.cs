﻿// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ArtifactTypesFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000565")]
  public sealed class ArtifactTypesFormatter : 
    IMessagePackFormatter<ArtifactTypes>,
    IMessagePackFormatter
  {
    [Token(Token = "0x600197D")]
    [Address(RVA = "0x6937E0", Offset = "0x6925E0", VA = "0x106937E0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ArtifactTypes value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600197E")]
    [Address(RVA = "0x693790", Offset = "0x692590", VA = "0x10693790", Slot = "5")]
    public ArtifactTypes Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new ArtifactTypes();
    }

    [Token(Token = "0x600197F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArtifactTypesFormatter()
    {
    }
  }
}