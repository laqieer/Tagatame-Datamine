// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.GradientAlphaKeyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x200037B")]
  public sealed class GradientAlphaKeyFormatter : 
    IMessagePackFormatter<GradientAlphaKey>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60012F1")]
    [Address(RVA = "0x4DAB50", Offset = "0x4D9950", VA = "0x104DAB50", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      GradientAlphaKey value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012F2")]
    [Address(RVA = "0x4DA960", Offset = "0x4D9760", VA = "0x104DA960", Slot = "5")]
    public GradientAlphaKey Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new GradientAlphaKey();
    }

    [Token(Token = "0x60012F3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GradientAlphaKeyFormatter()
    {
    }
  }
}
