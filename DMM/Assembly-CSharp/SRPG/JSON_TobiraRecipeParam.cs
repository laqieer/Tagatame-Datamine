// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TobiraRecipeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D6C")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TobiraRecipeParam
  {
    [Token(Token = "0x40073EB")]
    [FieldOffset(Offset = "0x8")]
    public string recipe_iname;
    [Token(Token = "0x40073EC")]
    [FieldOffset(Offset = "0xC")]
    public int tobira_lv;
    [Token(Token = "0x40073ED")]
    [FieldOffset(Offset = "0x10")]
    public int cost;
    [Token(Token = "0x40073EE")]
    [FieldOffset(Offset = "0x14")]
    public int unit_piece_num;
    [Token(Token = "0x40073EF")]
    [FieldOffset(Offset = "0x18")]
    public int piece_elem_num;
    [Token(Token = "0x40073F0")]
    [FieldOffset(Offset = "0x1C")]
    public int unlock_elem_num;
    [Token(Token = "0x40073F1")]
    [FieldOffset(Offset = "0x20")]
    public int unlock_birth_num;
    [Token(Token = "0x40073F2")]
    [FieldOffset(Offset = "0x24")]
    public JSON_TobiraRecipeMaterialParam[] mats;

    [Token(Token = "0x6007877")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TobiraRecipeParam()
    {
    }
  }
}
