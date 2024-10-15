// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MultiSupport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001947")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_MultiSupport
  {
    [Token(Token = "0x4005BAB")]
    [FieldOffset(Offset = "0x8")]
    public string uid;
    [Token(Token = "0x4005BAC")]
    [FieldOffset(Offset = "0xC")]
    public string fuid;
    [Token(Token = "0x4005BAD")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4005BAE")]
    [FieldOffset(Offset = "0x14")]
    public int lv;
    [Token(Token = "0x4005BAF")]
    [FieldOffset(Offset = "0x18")]
    public Json_Unit[] units;
    [Token(Token = "0x4005BB0")]
    [FieldOffset(Offset = "0x1C")]
    public JSON_ViewGuild guild;
    [Token(Token = "0x4005BB1")]
    [FieldOffset(Offset = "0x20")]
    public int isFriend;
    [Token(Token = "0x4005BB2")]
    [FieldOffset(Offset = "0x24")]
    public int cost;
    [Token(Token = "0x4005BB3")]
    [FieldOffset(Offset = "0x28")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x60066B4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MultiSupport()
    {
    }
  }
}
