// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.ColorFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000372")]
  public sealed class ColorFormatter : IMessagePackFormatter<Color>, IMessagePackFormatter
  {
    [Token(Token = "0x60012D6")]
    [Address(RVA = "0x4B7E30", Offset = "0x4B6C30", VA = "0x104B7E30", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Color value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012D7")]
    [Address(RVA = "0x4B7BA0", Offset = "0x4B69A0", VA = "0x104B7BA0", Slot = "5")]
    public Color Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Color();
    }

    [Token(Token = "0x60012D8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ColorFormatter()
    {
    }
  }
}
