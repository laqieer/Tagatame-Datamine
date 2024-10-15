// Decompiled with JetBrains decompiler
// Type: SRPG.ChatBlackListParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002189")]
  public class ChatBlackListParam
  {
    [Token(Token = "0x400929C")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x400929D")]
    [FieldOffset(Offset = "0xC")]
    public string uid;
    [Token(Token = "0x400929E")]
    [FieldOffset(Offset = "0x10")]
    public long blocked_at;
    [Token(Token = "0x400929F")]
    [FieldOffset(Offset = "0x18")]
    public long lastlogin;
    [Token(Token = "0x40092A0")]
    [FieldOffset(Offset = "0x20")]
    public string icon;
    [Token(Token = "0x40092A1")]
    [FieldOffset(Offset = "0x24")]
    public string skin_iname;
    [Token(Token = "0x40092A2")]
    [FieldOffset(Offset = "0x28")]
    public string job_iname;
    [Token(Token = "0x40092A3")]
    [FieldOffset(Offset = "0x2C")]
    public int exp;
    [Token(Token = "0x40092A4")]
    [FieldOffset(Offset = "0x30")]
    public Json_Unit unit;

    [Token(Token = "0x6008D21")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ChatBlackListParam()
    {
    }
  }
}
