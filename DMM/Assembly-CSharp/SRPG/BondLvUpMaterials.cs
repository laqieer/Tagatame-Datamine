// Decompiled with JetBrains decompiler
// Type: SRPG.BondLvUpMaterials
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200209E")]
  [MessagePackObject(true)]
  [Serializable]
  public class BondLvUpMaterials
  {
    [Token(Token = "0x4008C90")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4008C91")]
    [FieldOffset(Offset = "0xC")]
    public List<BondUsePiece> mats;

    [Token(Token = "0x60087C8")]
    [Address(RVA = "0x49AB50", Offset = "0x499950", VA = "0x1049AB50")]
    public JSON_BondUsePiece[] GetJsonBondUsePieceList() => (JSON_BondUsePiece[]) null;

    [Token(Token = "0x60087C9")]
    [Address(RVA = "0x49AEF0", Offset = "0x499CF0", VA = "0x1049AEF0")]
    public void SetParams(string unit_iname, string sub_piece_group_iname)
    {
    }

    [Token(Token = "0x60087CA")]
    [Address(RVA = "0x49B2F0", Offset = "0x49A0F0", VA = "0x1049B2F0")]
    public int TotalPieceNum(string pname = "") => new int();

    [Token(Token = "0x60087CB")]
    [Address(RVA = "0x49AD90", Offset = "0x499B90", VA = "0x1049AD90")]
    public int ItemTotalNum(string pname = "") => new int();

    [Token(Token = "0x60087CC")]
    [Address(RVA = "0x49B440", Offset = "0x49A240", VA = "0x1049B440")]
    public BondLvUpMaterials()
    {
    }
  }
}
