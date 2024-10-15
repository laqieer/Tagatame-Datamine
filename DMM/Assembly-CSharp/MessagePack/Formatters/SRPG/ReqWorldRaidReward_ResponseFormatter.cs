// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqWorldRaidReward_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000896")]
  public sealed class ReqWorldRaidReward_ResponseFormatter : 
    IMessagePackFormatter<ReqWorldRaidReward.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015BC")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015BD")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002310")]
    [Address(RVA = "0xDAE3A0", Offset = "0xDAD1A0", VA = "0x10DAE3A0")]
    public ReqWorldRaidReward_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002311")]
    [Address(RVA = "0xDAE230", Offset = "0xDAD030", VA = "0x10DAE230", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqWorldRaidReward.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002312")]
    [Address(RVA = "0xDADF60", Offset = "0xDACD60", VA = "0x10DADF60", Slot = "5")]
    public ReqWorldRaidReward.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqWorldRaidReward.Response) null;
    }
  }
}
