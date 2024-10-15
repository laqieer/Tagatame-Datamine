// Decompiled with JetBrains decompiler
// Type: SRPG.ChatChannel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002194")]
  public class ChatChannel
  {
    [Token(Token = "0x40092C3")]
    [FieldOffset(Offset = "0x8")]
    public ChatChannelParam[] channels;

    [Token(Token = "0x6008D35")]
    [Address(RVA = "0x50CB30", Offset = "0x50B930", VA = "0x1050CB30")]
    public void Deserialize(JSON_ChatChannel json)
    {
    }

    [Token(Token = "0x6008D36")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatChannel()
    {
    }
  }
}
