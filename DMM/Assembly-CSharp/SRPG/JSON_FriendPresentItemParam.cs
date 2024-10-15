// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_FriendPresentItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AE8")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_FriendPresentItemParam
  {
    [Token(Token = "0x4006606")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006607")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4006608")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4006609")]
    [FieldOffset(Offset = "0x14")]
    public string item;
    [Token(Token = "0x400660A")]
    [FieldOffset(Offset = "0x18")]
    public int num;
    [Token(Token = "0x400660B")]
    [FieldOffset(Offset = "0x1C")]
    public int zeny;
    [Token(Token = "0x400660C")]
    [FieldOffset(Offset = "0x20")]
    public string begin_at;
    [Token(Token = "0x400660D")]
    [FieldOffset(Offset = "0x24")]
    public string end_at;

    [Token(Token = "0x6006F04")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_FriendPresentItemParam()
    {
    }
  }
}
