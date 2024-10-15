// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GimmickEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C0D")]
  [Serializable]
  public class JSON_GimmickEvent
  {
    [Token(Token = "0x4001F18")]
    [FieldOffset(Offset = "0x8")]
    public int ev_type;
    [Token(Token = "0x4001F19")]
    [FieldOffset(Offset = "0xC")]
    public string skill;
    [Token(Token = "0x4001F1A")]
    [FieldOffset(Offset = "0x10")]
    public string su_iname;
    [Token(Token = "0x4001F1B")]
    [FieldOffset(Offset = "0x14")]
    public string su_tag;
    [Token(Token = "0x4001F1C")]
    [FieldOffset(Offset = "0x18")]
    public string st_iname;
    [Token(Token = "0x4001F1D")]
    [FieldOffset(Offset = "0x1C")]
    public string st_tag;
    [Token(Token = "0x4001F1E")]
    [FieldOffset(Offset = "0x20")]
    public int type;
    [Token(Token = "0x4001F1F")]
    [FieldOffset(Offset = "0x24")]
    public string cu_iname;
    [Token(Token = "0x4001F20")]
    [FieldOffset(Offset = "0x28")]
    public string cu_tag;
    [Token(Token = "0x4001F21")]
    [FieldOffset(Offset = "0x2C")]
    public string ct_iname;
    [Token(Token = "0x4001F22")]
    [FieldOffset(Offset = "0x30")]
    public string ct_tag;
    [Token(Token = "0x4001F23")]
    [FieldOffset(Offset = "0x34")]
    public int count;
    [Token(Token = "0x4001F24")]
    [FieldOffset(Offset = "0x38")]
    public int[] x;
    [Token(Token = "0x4001F25")]
    [FieldOffset(Offset = "0x3C")]
    public int[] y;

    [Token(Token = "0x600301E")]
    [Address(RVA = "0xFE4750", Offset = "0xFE3550", VA = "0x10FE4750")]
    public JSON_GimmickEvent()
    {
    }
  }
}
