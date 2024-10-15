// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.GradientFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x200037C")]
  public sealed class GradientFormatter : IMessagePackFormatter<Gradient>, IMessagePackFormatter
  {
    [Token(Token = "0x60012F4")]
    [Address(RVA = "0x4DB170", Offset = "0x4D9F70", VA = "0x104DB170", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      Gradient value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012F5")]
    [Address(RVA = "0x4DAF20", Offset = "0x4D9D20", VA = "0x104DAF20", Slot = "5")]
    public Gradient Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (Gradient) null;
    }

    [Token(Token = "0x60012F6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GradientFormatter()
    {
    }
  }
}
