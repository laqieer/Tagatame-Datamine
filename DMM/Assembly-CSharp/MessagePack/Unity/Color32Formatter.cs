// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.Color32Formatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x200037D")]
  public sealed class Color32Formatter : IMessagePackFormatter<Color32>, IMessagePackFormatter
  {
    [Token(Token = "0x60012F7")]
    [Address(RVA = "0x4B7B00", Offset = "0x4B6900", VA = "0x104B7B00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Color32 value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012F8")]
    [Address(RVA = "0x4B78B0", Offset = "0x4B66B0", VA = "0x104B78B0", Slot = "5")]
    public Color32 Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Color32();
    }

    [Token(Token = "0x60012F9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Color32Formatter()
    {
    }
  }
}
