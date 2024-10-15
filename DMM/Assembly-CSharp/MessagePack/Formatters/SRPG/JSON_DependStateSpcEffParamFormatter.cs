// Decompiled with JetBrains decompiler
// Type: MessagePack.Formatters.SRPG.JSON_DependStateSpcEffParamFormatter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack.Internal;
using SRPG;

#nullable disable
namespace MessagePack.Formatters.SRPG
{
  [Token(Token = "0x2000649")]
  public sealed class JSON_DependStateSpcEffParamFormatter : 
    IMessagePackFormatter<JSON_DependStateSpcEffParam>,
    IMessagePackFormatter
  {
    [Token(Token = "0x400112A")]
    [FieldOffset(Offset = "0x8")]
    private readonly AutomataDictionary ____keyMapping;
    [Token(Token = "0x400112B")]
    [FieldOffset(Offset = "0xC")]
    private readonly byte[][] ____stringByteKeys;

    [Token(Token = "0x6001C29")]
    [Address(RVA = "0xBD1B50", Offset = "0xBD0950", VA = "0x10BD1B50")]
    public JSON_DependStateSpcEffParamFormatter()
    {
    }

    [Token(Token = "0x6001C2A")]
    [Address(RVA = "0xBD17F0", Offset = "0xBD05F0", VA = "0x10BD17F0", Slot = "4")]
    public int Serialize(
      ref byte[] bytes,
      int offset,
      JSON_DependStateSpcEffParam value,
      IFormatterResolver formatterResolver)
    {
      return new int();
    }

    [Token(Token = "0x6001C2B")]
    [Address(RVA = "0xBD12B0", Offset = "0xBD00B0", VA = "0x10BD12B0", Slot = "5")]
    public JSON_DependStateSpcEffParam Deserialize(
      byte[] bytes,
      int offset,
      IFormatterResolver formatterResolver,
      out int readSize)
    {
      return (JSON_DependStateSpcEffParam) null;
    }
  }
}
