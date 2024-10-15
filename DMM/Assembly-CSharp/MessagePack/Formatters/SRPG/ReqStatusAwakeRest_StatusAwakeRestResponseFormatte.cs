// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.ReqStatusAwakeRest_StatusAwakeRestResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000B01")]
  public sealed class ReqStatusAwakeRest_StatusAwakeRestResponseFormatter : 
    IMessagePackFormatter<ReqStatusAwakeRest.StatusAwakeRestResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A92")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A93")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6002A51")]
    [Address(RVA = "0xF2CAE0", Offset = "0xF2B8E0", VA = "0x10F2CAE0")]
    public ReqStatusAwakeRest_StatusAwakeRestResponseFormatter()
    {
    }

    [Token(Token = "0x6002A52")]
    [Address(RVA = "0xF2C7F0", Offset = "0xF2B5F0", VA = "0x10F2C7F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      ReqStatusAwakeRest.StatusAwakeRestResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6002A53")]
    [Address(RVA = "0xF2C3C0", Offset = "0xF2B1C0", VA = "0x10F2C3C0", Slot = "5")]
    public ReqStatusAwakeRest.StatusAwakeRestResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (ReqStatusAwakeRest.StatusAwakeRestResponse) null;
    }
  }
}
