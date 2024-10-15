// Decompiled with JetBrains decompiler
// Type: MessagePack.Unity.RangeIntFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Formatters;
using UnityEngine;

#nullable disable
namespace MessagePack.Unity
{
  [Token(Token = "0x2000382")]
  public sealed class RangeIntFormatter : IMessagePackFormatter<RangeInt>, IMessagePackFormatter
  {
    [Token(Token = "0x6001306")]
    [Address(RVA = "0x4DD1D0", Offset = "0x4DBFD0", VA = "0x104DD1D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      RangeInt value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001307")]
    [Address(RVA = "0x4DD010", Offset = "0x4DBE10", VA = "0x104DD010", Slot = "5")]
    public RangeInt Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return new RangeInt();
    }

    [Token(Token = "0x6001308")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RangeIntFormatter()
    {
    }
  }
}
