// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.GradientColorKeyFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x200037A")]
  public sealed class GradientColorKeyFormatter : 
    IMessagePackFormatter<GradientColorKey>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60012EE")]
    [Address(RVA = "0x4DAE00", Offset = "0x4D9C00", VA = "0x104DAE00", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      GradientColorKey value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012EF")]
    [Address(RVA = "0x4DABE0", Offset = "0x4D99E0", VA = "0x104DABE0", Slot = "5")]
    public GradientColorKey Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new GradientColorKey();
    }

    [Token(Token = "0x60012F0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GradientColorKeyFormatter()
    {
    }
  }
}
