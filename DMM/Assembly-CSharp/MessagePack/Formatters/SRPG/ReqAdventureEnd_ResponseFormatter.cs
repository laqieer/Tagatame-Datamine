// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAdventureEnd_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B2F")]
  public sealed class ReqAdventureEnd_ResponseFormatter : 
    IMessagePackFormatter<ReqAdventureEnd.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001AEE")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001AEF")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002ADB")]
    [Address(RVA = "0xF69F20", Offset = "0xF68D20", VA = "0x10F69F20")]
    public ReqAdventureEnd_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002ADC")]
    [Address(RVA = "0xF696F0", Offset = "0xF684F0", VA = "0x10F696F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAdventureEnd.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002ADD")]
    [Address(RVA = "0xF68F20", Offset = "0xF67D20", VA = "0x10F68F20", Slot = "5")]
    public ReqAdventureEnd.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAdventureEnd.Response) null;
    }
  }
}
