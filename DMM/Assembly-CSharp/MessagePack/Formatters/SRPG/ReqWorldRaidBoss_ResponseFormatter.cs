// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqWorldRaidBoss_ResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000892")]
  public sealed class ReqWorldRaidBoss_ResponseFormatter : 
    IMessagePackFormatter<ReqWorldRaidBoss.Response>,
    IMessagePackFormatter
  {
    [Token(Token = "0x40015B4")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x40015B5")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002304")]
    [Address(RVA = "0xDAD660", Offset = "0xDAC460", VA = "0x10DAD660")]
    public ReqWorldRaidBoss_ResponseFormatter()
    {
    }

    [Token(Token = "0x6002305")]
    [Address(RVA = "0xDAD4F0", Offset = "0xDAC2F0", VA = "0x10DAD4F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqWorldRaidBoss.Response value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002306")]
    [Address(RVA = "0xDAD220", Offset = "0xDAC020", VA = "0x10DAD220", Slot = "5")]
    public ReqWorldRaidBoss.Response Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqWorldRaidBoss.Response) null;
    }
  }
}
