// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ChatLog
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002185")]
  public class JSON_ChatLog
  {
    [Token(Token = "0x400928C")]
    [FieldOffset(Offset = "0x8")]
    public ChatLogParam[] messages;
    [Token(Token = "0x400928D")]
    [FieldOffset(Offset = "0xC")]
    public Player player;
    [Token(Token = "0x400928E")]
    [FieldOffset(Offset = "0x10")]
    public ChatLogOfficialParam[] official_messages;

    [Token(Token = "0x6008D0F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ChatLog()
    {
    }
  }
}
