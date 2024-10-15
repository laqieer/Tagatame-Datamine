// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BoxGachaItems
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020FD")]
  [Serializable]
  public class JSON_BoxGachaItems
  {
    [Token(Token = "0x4008EAC")]
    [FieldOffset(Offset = "0x8")]
    public int is_feature_item;
    [Token(Token = "0x4008EAD")]
    [FieldOffset(Offset = "0xC")]
    public string itype;
    [Token(Token = "0x4008EAE")]
    [FieldOffset(Offset = "0x10")]
    public string iname;
    [Token(Token = "0x4008EAF")]
    [FieldOffset(Offset = "0x14")]
    public int num;
    [Token(Token = "0x4008EB0")]
    [FieldOffset(Offset = "0x18")]
    public int total_num;
    [Token(Token = "0x4008EB1")]
    [FieldOffset(Offset = "0x1C")]
    public int remain_num;
    [Token(Token = "0x4008EB2")]
    [FieldOffset(Offset = "0x20")]
    public int coin;
    [Token(Token = "0x4008EB3")]
    [FieldOffset(Offset = "0x24")]
    public int gold;
    [Token(Token = "0x4008EB4")]
    [FieldOffset(Offset = "0x28")]
    public string box_set_iname;
    [Token(Token = "0x4008EB5")]
    [FieldOffset(Offset = "0x2C")]
    public string box_set_name;

    [Token(Token = "0x60089E5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BoxGachaItems()
    {
    }
  }
}
