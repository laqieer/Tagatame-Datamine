// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_FilterRuneConditionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D37")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_FilterRuneConditionParam
  {
    [Token(Token = "0x40072B6")]
    [FieldOffset(Offset = "0x8")]
    public string cnds_iname;
    [Token(Token = "0x40072B7")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40072B8")]
    [FieldOffset(Offset = "0x10")]
    public int rarity;
    [Token(Token = "0x40072B9")]
    [FieldOffset(Offset = "0x14")]
    public int slot_index;
    [Token(Token = "0x40072BA")]
    [FieldOffset(Offset = "0x18")]
    public int set_eff;
    [Token(Token = "0x40072BB")]
    [FieldOffset(Offset = "0x1C")]
    public int evo_status;
    [Token(Token = "0x40072BC")]
    [FieldOffset(Offset = "0x20")]
    public int dedicated;
    [Token(Token = "0x40072BD")]
    [FieldOffset(Offset = "0x24")]
    public int[] party_types;

    [Token(Token = "0x60077C0")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_FilterRuneConditionParam()
    {
    }
  }
}
