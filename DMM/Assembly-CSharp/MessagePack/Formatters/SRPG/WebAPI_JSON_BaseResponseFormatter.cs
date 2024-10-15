// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.WebAPI_JSON_BaseResponseFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000ACE")]
  public sealed class WebAPI_JSON_BaseResponseFormatter : 
    IMessagePackFormatter<WebAPI.JSON_BaseResponse>,
    IMessagePackFormatter
  {
    [Token(Token = "0x4001A2C")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x4001A2D")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x60029B8")]
    [Address(RVA = "0xF19490", Offset = "0xF18290", VA = "0x10F19490")]
    public WebAPI_JSON_BaseResponseFormatter()
    {
    }

    [Token(Token = "0x60029B9")]
    [Address(RVA = "0xF19290", Offset = "0xF18090", VA = "0x10F19290", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      WebAPI.JSON_BaseResponse value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x60029BA")]
    [Address(RVA = "0xF18EB0", Offset = "0xF17CB0", VA = "0x10F18EB0", Slot = "5")]
    public WebAPI.JSON_BaseResponse Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (WebAPI.JSON_BaseResponse) null;
    }
  }
}
