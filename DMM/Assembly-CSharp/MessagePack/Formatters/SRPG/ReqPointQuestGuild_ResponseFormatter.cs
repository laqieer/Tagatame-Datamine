// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqPointQuestGuild_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x200097F")]
  public sealed class ReqPointQuestGuild_ResponseFormatter : 
    IMessagePackFormatter<ReqPointQuestGuild.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400178E")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400178F")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60025CB")]
    [Address(RVA = "0xE33B70", Offset = "0xE32970", VA = "0x10E33B70")]
    public ReqPointQuestGuild_ResponseFormatter()
    {
    }

    [Token(Token = "0x60025CC")]
    [Address(RVA = "0xE33960", Offset = "0xE32760", VA = "0x10E33960", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqPointQuestGuild.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60025CD")]
    [Address(RVA = "0xE335E0", Offset = "0xE323E0", VA = "0x10E335E0", Slot = "5")]
    public ReqPointQuestGuild.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqPointQuestGuild.Response) null;
    }
  }
}
