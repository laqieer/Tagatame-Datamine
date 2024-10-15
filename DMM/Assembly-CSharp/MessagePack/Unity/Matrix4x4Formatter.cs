// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.Matrix4x4Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000379")]
  public sealed class Matrix4x4Formatter : IMessagePackFormatter<Matrix4x4>, IMessagePackFormatter
  {
    [Token(Token = "0x60012EB")]
    [Address(RVA = "0x4DC900", Offset = "0x4DB700", VA = "0x104DC900", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Matrix4x4 value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012EC")]
    [Address(RVA = "0x4DC2B0", Offset = "0x4DB0B0", VA = "0x104DC2B0", Slot = "5")]
    public Matrix4x4 Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Matrix4x4();
    }

    [Token(Token = "0x60012ED")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Matrix4x4Formatter()
    {
    }
  }
}
