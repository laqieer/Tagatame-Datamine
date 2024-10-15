// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.RectIntFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000383")]
  public sealed class RectIntFormatter : IMessagePackFormatter<RectInt>, IMessagePackFormatter
  {
    [Token(Token = "0x6001309")]
    [Address(RVA = "0x4DD830", Offset = "0x4DC630", VA = "0x104DD830", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RectInt value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x600130A")]
    [Address(RVA = "0x4DD5D0", Offset = "0x4DC3D0", VA = "0x104DD5D0", Slot = "5")]
    public RectInt Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new RectInt();
    }

    [Token(Token = "0x600130B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RectIntFormatter()
    {
    }
  }
}
