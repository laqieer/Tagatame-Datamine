// Decompiled with JetBrains decompiler
// Type: SRPG.ChatChannelMasterParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002197")]
  public class ChatChannelMasterParam
  {
    [Token(Token = "0x40092C8")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40092C9")]
    [FieldOffset(Offset = "0xC")]
    public byte category_id;
    [Token(Token = "0x40092CA")]
    [FieldOffset(Offset = "0x10")]
    public string name;

    [Token(Token = "0x6008D3A")]
    [Address(RVA = "0x50CAB0", Offset = "0x50B8B0", VA = "0x1050CAB0")]
    public void Deserialize(Json_ChatChannelMasterParam json)
    {
    }

    [Token(Token = "0x6008D3B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatChannelMasterParam()
    {
    }
  }
}
