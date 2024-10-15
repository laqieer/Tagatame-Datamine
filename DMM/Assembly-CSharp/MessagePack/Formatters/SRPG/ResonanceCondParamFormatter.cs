// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ResonanceCondParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x20009AD")]
  public sealed class ResonanceCondParamFormatter : 
    IMessagePackFormatter<ResonanceCondParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40017EA")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40017EB")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002655")]
    [Address(RVA = "0xE4C5E0", Offset = "0xE4B3E0", VA = "0x10E4C5E0")]
    public ResonanceCondParamFormatter()
    {
    }

    [Token(Token = "0x6002656")]
    [Address(RVA = "0xE4C3C0", Offset = "0xE4B1C0", VA = "0x10E4C3C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ResonanceCondParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002657")]
    [Address(RVA = "0xE4C080", Offset = "0xE4AE80", VA = "0x10E4C080", Slot = "5")]
    public ResonanceCondParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ResonanceCondParam) null;
    }
  }
}
