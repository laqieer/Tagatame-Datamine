// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.BoundsIntFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000384")]
  public sealed class BoundsIntFormatter : IMessagePackFormatter<BoundsInt>, IMessagePackFormatter
  {
    [Token(Token = "0x600130C")]
    [Address(RVA = "0x4B7730", Offset = "0x4B6530", VA = "0x104B7730", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      BoundsInt value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600130D")]
    [Address(RVA = "0x4B74B0", Offset = "0x4B62B0", VA = "0x104B74B0", Slot = "5")]
    public BoundsInt Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new BoundsInt();
    }

    [Token(Token = "0x600130E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BoundsIntFormatter()
    {
    }
  }
}
