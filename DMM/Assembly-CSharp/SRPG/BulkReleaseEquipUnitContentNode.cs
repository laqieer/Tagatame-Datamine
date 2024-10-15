// Decompiled with JetBrains decompiler
// Type: SRPG.BulkReleaseEquipUnitContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002356")]
  public class BulkReleaseEquipUnitContentNode : ContentNode
  {
    [Token(Token = "0x4009E55")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ExhibitList mExhibitList;
    [Token(Token = "0x4009E56")]
    [FieldOffset(Offset = "0x34")]
    private BulkReleaseEquipUnitContentNodeModel mModel;

    [Token(Token = "0x6009854")]
    [Address(RVA = "0x5A82E0", Offset = "0x5A70E0", VA = "0x105A82E0")]
    public void Initialize(UnitData unitdata)
    {
    }

    [Token(Token = "0x6009855")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public BulkReleaseEquipUnitContentNode()
    {
    }
  }
}
