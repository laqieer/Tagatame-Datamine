// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.WrapModeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000375")]
  public sealed class WrapModeFormatter : IMessagePackFormatter<WrapMode>, IMessagePackFormatter
  {
    [Token(Token = "0x60012DF")]
    [Address(RVA = "0x4E2440", Offset = "0x4E1240", VA = "0x104E2440", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      WrapMode value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012E0")]
    [Address(RVA = "0x4E23F0", Offset = "0x4E11F0", VA = "0x104E23F0", Slot = "5")]
    public WrapMode Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new WrapMode();
    }

    [Token(Token = "0x60012E1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WrapModeFormatter()
    {
    }
  }
}
