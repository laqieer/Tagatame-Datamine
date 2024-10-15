// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WeatherParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EF0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WeatherParam
  {
    [Token(Token = "0x400822F")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4008230")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4008231")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4008232")]
    [FieldOffset(Offset = "0x14")]
    public string icon;
    [Token(Token = "0x4008233")]
    [FieldOffset(Offset = "0x18")]
    public string effect;
    [Token(Token = "0x4008234")]
    [FieldOffset(Offset = "0x1C")]
    public int ch_cl;
    [Token(Token = "0x4008235")]
    [FieldOffset(Offset = "0x20")]
    public int is_dead_del;
    [Token(Token = "0x4008236")]
    [FieldOffset(Offset = "0x24")]
    public int is_not_overwrite;
    [Token(Token = "0x4008237")]
    [FieldOffset(Offset = "0x28")]
    public JSON_WeatherDetailParam[] details;

    [Token(Token = "0x6007E70")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WeatherParam()
    {
    }
  }
}
