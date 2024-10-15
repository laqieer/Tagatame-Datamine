// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.BoundsFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000373")]
  public sealed class BoundsFormatter : IMessagePackFormatter<Bounds>, IMessagePackFormatter
  {
    [Token(Token = "0x60012D9")]
    [Address(RVA = "0x4B7390", Offset = "0x4B6190", VA = "0x104B7390", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Bounds value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012DA")]
    [Address(RVA = "0x4B7150", Offset = "0x4B5F50", VA = "0x104B7150", Slot = "5")]
    public Bounds Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Bounds();
    }

    [Token(Token = "0x60012DB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BoundsFormatter()
    {
    }
  }
}
