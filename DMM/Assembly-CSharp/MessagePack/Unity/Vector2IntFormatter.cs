// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.Vector2IntFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000380")]
  public sealed class Vector2IntFormatter : IMessagePackFormatter<Vector2Int>, IMessagePackFormatter
  {
    [Token(Token = "0x6001300")]
    [Address(RVA = "0x4E1B00", Offset = "0x4E0900", VA = "0x104E1B00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Vector2Int value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001301")]
    [Address(RVA = "0x4E1960", Offset = "0x4E0760", VA = "0x104E1960", Slot = "5")]
    public Vector2Int Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Vector2Int();
    }

    [Token(Token = "0x6001302")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Vector2IntFormatter()
    {
    }
  }
}
