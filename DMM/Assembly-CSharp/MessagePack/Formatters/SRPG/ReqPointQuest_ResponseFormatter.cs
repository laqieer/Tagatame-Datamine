// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqPointQuest_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200097D")]
  public sealed class ReqPointQuest_ResponseFormatter : 
    IMessagePackFormatter<ReqPointQuest.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400178A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400178B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025C5")]
    [Address(RVA = "0xE34DD0", Offset = "0xE33BD0", VA = "0x10E34DD0")]
    public ReqPointQuest_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025C6")]
    [Address(RVA = "0xE349C0", Offset = "0xE337C0", VA = "0x10E349C0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqPointQuest.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025C7")]
    [Address(RVA = "0xE34540", Offset = "0xE33340", VA = "0x10E34540", Slot = "5")]
    public ReqPointQuest.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqPointQuest.Response) null;
    }
  }
}
