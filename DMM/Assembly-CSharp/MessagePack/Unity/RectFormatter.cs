// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.RectFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000374")]
  public sealed class RectFormatter : IMessagePackFormatter<Rect>, IMessagePackFormatter
  {
    [Token(Token = "0x60012DC")]
    [Address(RVA = "0x4DD4D0", Offset = "0x4DC2D0", VA = "0x104DD4D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Rect value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012DD")]
    [Address(RVA = "0x4DD250", Offset = "0x4DC050", VA = "0x104DD250", Slot = "5")]
    public Rect Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new Rect();
    }

    [Token(Token = "0x60012DE")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RectFormatter()
    {
    }
  }
}
