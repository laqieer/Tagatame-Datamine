// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.TobiraDataFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000796")]
  public sealed class TobiraDataFormatter : IMessagePackFormatter<TobiraData>, IMessagePackFormatter
  {
    [Token(Token = "0x40013C4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40013C5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002010")]
    [Address(RVA = "0xCE2470", Offset = "0xCE1270", VA = "0x10CE2470")]
    public TobiraDataFormatter()
    {
    }

    [Token(Token = "0x6002011")]
    [Address(RVA = "0xCE20D0", Offset = "0xCE0ED0", VA = "0x10CE20D0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      TobiraData value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002012")]
    [Address(RVA = "0xCE1CE0", Offset = "0xCE0AE0", VA = "0x10CE1CE0", Slot = "5")]
    public TobiraData Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (TobiraData) null;
    }
  }
}
