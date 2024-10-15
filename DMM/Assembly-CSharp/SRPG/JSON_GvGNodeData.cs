// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGNodeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20025A4")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGNodeData
  {
    [Token(Token = "0x400AEC8")]
    [FieldOffset(Offset = "0x8")]
    public int iid;
    [Token(Token = "0x400AEC9")]
    [FieldOffset(Offset = "0xC")]
    public int id;
    [Token(Token = "0x400AECA")]
    [FieldOffset(Offset = "0x10")]
    public int state;
    [Token(Token = "0x400AECB")]
    [FieldOffset(Offset = "0x14")]
    public int gid;
    [Token(Token = "0x400AECC")]
    [FieldOffset(Offset = "0x18")]
    public int declared_gid;
    [Token(Token = "0x400AECD")]
    [FieldOffset(Offset = "0x20")]
    public long capture_time;
    [Token(Token = "0x400AECE")]
    [FieldOffset(Offset = "0x28")]
    public long attack_enable_time;
    [Token(Token = "0x400AECF")]
    [FieldOffset(Offset = "0x30")]
    public int defense_party_num;

    [Token(Token = "0x600A74D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGNodeData()
    {
    }
  }
}
