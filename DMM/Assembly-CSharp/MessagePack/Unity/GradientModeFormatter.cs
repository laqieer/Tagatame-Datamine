// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.GradientModeFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000376")]
  public sealed class GradientModeFormatter : 
    IMessagePackFormatter<GradientMode>,
    IMessagePackFormatter
  {
    [Token(Token = "0x60012E2")]
    [Address(RVA = "0x4DB400", Offset = "0x4DA200", VA = "0x104DB400", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      GradientMode value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60012E3")]
    [Address(RVA = "0x4DB3B0", Offset = "0x4DA1B0", VA = "0x104DB3B0", Slot = "5")]
    public GradientMode Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new GradientMode();
    }

    [Token(Token = "0x60012E4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GradientModeFormatter()
    {
    }
  }
}
