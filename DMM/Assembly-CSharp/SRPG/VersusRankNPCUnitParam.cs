// Decompiled with JetBrains decompiler
// Type: SRPG.VersusRankNPCUnitParam
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
  [Token(Token = "0x2001C9C")]
  [MessagePackObject(true)]
  [Serializable]
  public class VersusRankNPCUnitParam : VersusDraftUnitParam
  {
    [Token(Token = "0x60075E9")]
    [Address(RVA = "0x373220", Offset = "0x372020", VA = "0x10373220")]
    public bool Deserialize(JSON_VersusRankNPCUnitParam json) => new bool();

    [Token(Token = "0x60075EA")]
    [Address(RVA = "0x3A13C0", Offset = "0x3A01C0", VA = "0x103A13C0")]
    public UnitData CreateUnitData(bool is_conceptcard_ls = false) => (UnitData) null;

    [Token(Token = "0x60075EB")]
    [Address(RVA = "0x3A1260", Offset = "0x3A0060", VA = "0x103A1260")]
    public static UnitData CreateNPCUnitData(int id) => (UnitData) null;

    [Token(Token = "0x60075EC")]
    [Address(RVA = "0x3A1430", Offset = "0x3A0230", VA = "0x103A1430")]
    public static void Deserialize(
      ref List<VersusRankNPCUnitParam> param,
      JSON_VersusRankNPCUnitParam[] json)
    {
    }

    [Token(Token = "0x60075ED")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public VersusRankNPCUnitParam()
    {
    }
  }
}
