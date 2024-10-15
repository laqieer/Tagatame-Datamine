// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusTagatameCupParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EE5")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusTagatameCupParam
  {
    [Token(Token = "0x40081EF")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40081F0")]
    [FieldOffset(Offset = "0xC")]
    public string end_at;
    [Token(Token = "0x40081F1")]
    [FieldOffset(Offset = "0x10")]
    public string entry_end_at;
    [Token(Token = "0x40081F2")]
    [FieldOffset(Offset = "0x14")]
    public int challenge_num;
    [Token(Token = "0x40081F3")]
    [FieldOffset(Offset = "0x18")]
    public int need_win_num;
    [Token(Token = "0x40081F4")]
    [FieldOffset(Offset = "0x1C")]
    public string detail_url;
    [Token(Token = "0x40081F5")]
    [FieldOffset(Offset = "0x20")]
    public string entry_url;

    [Token(Token = "0x6007E4E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusTagatameCupParam()
    {
    }
  }
}
