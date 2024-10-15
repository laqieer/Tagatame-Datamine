// Decompiled with JetBrains decompiler
// Type: SRPG.GrowParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E02")]
  public class GrowParam
  {
    [Token(Token = "0x4007951")]
    [FieldOffset(Offset = "0x8")]
    public string type;
    [Token(Token = "0x4007952")]
    [FieldOffset(Offset = "0xC")]
    public List<GrowSample> curve;

    [Token(Token = "0x6007B49")]
    [Address(RVA = "0x3DE4B0", Offset = "0x3DD2B0", VA = "0x103DE4B0")]
    public bool Deserialize(JSON_GrowParam json) => new bool();

    [Token(Token = "0x6007B4A")]
    [Address(RVA = "0x3DFC70", Offset = "0x3DEA70", VA = "0x103DFC70")]
    public int GetLevelCap() => new int();

    [Token(Token = "0x6007B4B")]
    [Address(RVA = "0x3DDBC0", Offset = "0x3DC9C0", VA = "0x103DDBC0")]
    public void CalcLevelCurveStatus(
      int rank,
      ref BaseStatus result,
      UnitParam.Status ini_status,
      UnitParam.Status max_status)
    {
    }

    [Token(Token = "0x6007B4C")]
    [Address(RVA = "0x3DE200", Offset = "0x3DD000", VA = "0x103DE200")]
    public int CalcLevelCurveValue(int rank, int ini, int max) => new int();

    [Token(Token = "0x6007B4D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GrowParam()
    {
    }
  }
}
