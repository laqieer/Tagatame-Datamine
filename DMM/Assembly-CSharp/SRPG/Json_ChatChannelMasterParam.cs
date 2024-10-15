// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ChatChannelMasterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002198")]
  [MessagePackObject(true)]
  public class Json_ChatChannelMasterParam
  {
    [Token(Token = "0x40092CB")]
    [FieldOffset(Offset = "0x8")]
    public int pk;
    [Token(Token = "0x40092CC")]
    [FieldOffset(Offset = "0xC")]
    public Json_ChatChannelMasterParam.Fields fields;

    [Token(Token = "0x6008D3C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ChatChannelMasterParam()
    {
    }

    [Token(Token = "0x2002199")]
    [MessagePackObject(true)]
    public class Fields
    {
      [Token(Token = "0x40092CD")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x40092CE")]
      [FieldOffset(Offset = "0xC")]
      public byte category_id;
      [Token(Token = "0x40092CF")]
      [FieldOffset(Offset = "0x10")]
      public string name;

      [Token(Token = "0x6008D3D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Fields()
      {
      }
    }
  }
}
