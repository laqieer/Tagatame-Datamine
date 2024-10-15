// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.RectOffsetFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x200037E")]
  public sealed class RectOffsetFormatter : IMessagePackFormatter<RectOffset>, IMessagePackFormatter
  {
    [Token(Token = "0x60012FA")]
    [Address(RVA = "0x4DDB30", Offset = "0x4DC930", VA = "0x104DDB30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RectOffset value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012FB")]
    [Address(RVA = "0x4DD8F0", Offset = "0x4DC6F0", VA = "0x104DD8F0", Slot = "5")]
    public RectOffset Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (RectOffset) null;
    }

    [Token(Token = "0x60012FC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RectOffsetFormatter()
    {
    }
  }
}
