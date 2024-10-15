// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AwardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200199E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AwardParam
  {
    [Token(Token = "0x4005DDD")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4005DDE")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x4005DDF")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4005DE0")]
    [FieldOffset(Offset = "0x14")]
    public string expr;
    [Token(Token = "0x4005DE1")]
    [FieldOffset(Offset = "0x18")]
    public string icon;
    [Token(Token = "0x4005DE2")]
    [FieldOffset(Offset = "0x1C")]
    public string bg;
    [Token(Token = "0x4005DE3")]
    [FieldOffset(Offset = "0x20")]
    public string txt_img;
    [Token(Token = "0x4005DE4")]
    [FieldOffset(Offset = "0x24")]
    public string start_at;
    [Token(Token = "0x4005DE5")]
    [FieldOffset(Offset = "0x28")]
    public int grade;
    [Token(Token = "0x4005DE6")]
    [FieldOffset(Offset = "0x2C")]
    public int tab;

    [Token(Token = "0x600687F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AwardParam()
    {
    }
  }
}
