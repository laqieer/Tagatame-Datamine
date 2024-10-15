// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqAdventureCancel_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000AC3")]
  public sealed class ReqAdventureCancel_ResponseFormatter : 
    IMessagePackFormatter<ReqAdventureCancel.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A16")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A17")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002997")]
    [Address(RVA = "0xF0FB20", Offset = "0xF0E920", VA = "0x10F0FB20")]
    public ReqAdventureCancel_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002998")]
    [Address(RVA = "0xF0FA20", Offset = "0xF0E820", VA = "0x10F0FA20", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqAdventureCancel.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002999")]
    [Address(RVA = "0xF0F750", Offset = "0xF0E550", VA = "0x10F0F750", Slot = "5")]
    public ReqAdventureCancel.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqAdventureCancel.Response) null;
    }
  }
}
