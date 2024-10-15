// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.Vector2Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x200036E")]
  public sealed class Vector2Formatter : IMessagePackFormatter<Vector2>, IMessagePackFormatter
  {
    [Token(Token = "0x60012CA")]
    [Address(RVA = "0x4E18D0", Offset = "0x4E06D0", VA = "0x104E18D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Vector2 value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012CB")]
    [Address(RVA = "0x4E1710", Offset = "0x4E0510", VA = "0x104E1710", Slot = "5")]
    public Vector2 Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Vector2();
    }

    [Token(Token = "0x60012CC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Vector2Formatter()
    {
    }
  }
}
