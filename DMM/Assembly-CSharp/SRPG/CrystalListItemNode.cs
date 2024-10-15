// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalListItemNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002289")]
  public class CrystalListItemNode : ContentNode
  {
    [Token(Token = "0x4009958")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private CrystalListItem Item;
    [Token(Token = "0x4009959")]
    [FieldOffset(Offset = "0x34")]
    private CrystalListItemParam param;

    [Token(Token = "0x60093C6")]
    [Address(RVA = "0x56A300", Offset = "0x569100", VA = "0x1056A300")]
    public void Setup(
      CrystalScrollList _scroll_list,
      CrystalListItemParam _param,
      UnitData _unit_data)
    {
    }

    [Token(Token = "0x60093C7")]
    [Address(RVA = "0x56A110", Offset = "0x568F10", VA = "0x1056A110")]
    public void SetRemoveEquip(CrystalScrollList _scroll_list)
    {
    }

    [Token(Token = "0x60093C8")]
    [Address(RVA = "0x5630F0", Offset = "0x561EF0", VA = "0x105630F0")]
    public CrystalListItemNode()
    {
    }
  }
}
