// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.Vector4Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000370")]
  public sealed class Vector4Formatter : IMessagePackFormatter<Vector4>, IMessagePackFormatter
  {
    [Token(Token = "0x60012D0")]
    [Address(RVA = "0x4E2330", Offset = "0x4E1130", VA = "0x104E2330", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Vector4 value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012D1")]
    [Address(RVA = "0x4E20A0", Offset = "0x4E0EA0", VA = "0x104E20A0", Slot = "5")]
    public Vector4 Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Vector4();
    }

    [Token(Token = "0x60012D2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Vector4Formatter()
    {
    }
  }
}
