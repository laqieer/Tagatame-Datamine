// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_SectionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D14")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_SectionParam
  {
    [Token(Token = "0x40071F5")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40071F6")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40071F7")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x40071F8")]
    [FieldOffset(Offset = "0x18")]
    public long start;
    [Token(Token = "0x40071F9")]
    [FieldOffset(Offset = "0x20")]
    public long end;
    [Token(Token = "0x40071FA")]
    [FieldOffset(Offset = "0x28")]
    public int hide;
    [Token(Token = "0x40071FB")]
    [FieldOffset(Offset = "0x2C")]
    public string home;
    [Token(Token = "0x40071FC")]
    [FieldOffset(Offset = "0x30")]
    public string unit;
    [Token(Token = "0x40071FD")]
    [FieldOffset(Offset = "0x34")]
    public string item;
    [Token(Token = "0x40071FE")]
    [FieldOffset(Offset = "0x38")]
    public string shop;
    [Token(Token = "0x40071FF")]
    [FieldOffset(Offset = "0x3C")]
    public string inn;
    [Token(Token = "0x4007200")]
    [FieldOffset(Offset = "0x40")]
    public string bar;
    [Token(Token = "0x4007201")]
    [FieldOffset(Offset = "0x44")]
    public string bgm;
    [Token(Token = "0x4007202")]
    [FieldOffset(Offset = "0x48")]
    public int story_part;
    [Token(Token = "0x4007203")]
    [FieldOffset(Offset = "0x4C")]
    public string release_key_quest;
    [Token(Token = "0x4007204")]
    [FieldOffset(Offset = "0x50")]
    public string message_sys_id;

    [Token(Token = "0x6007763")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_SectionParam()
    {
    }
  }
}
