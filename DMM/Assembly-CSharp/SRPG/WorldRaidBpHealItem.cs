// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBpHealItem
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
  [Token(Token = "0x2002D50")]
  public class WorldRaidBpHealItem : MonoBehaviour
  {
    [Token(Token = "0x400E20D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400E20E")]
    [FieldOffset(Offset = "0x10")]
    private WorldRaidBpHealItemModel mModel;

    [Token(Token = "0x600D332")]
    [Address(RVA = "0x9E5960", Offset = "0x9E4760", VA = "0x109E5960")]
    public void SetUp(WorldRaidBpHealParam.HealInfo _info)
    {
    }

    [Token(Token = "0x600D333")]
    [Address(RVA = "0x9E58E0", Offset = "0x9E46E0", VA = "0x109E58E0")]
    public void Draw()
    {
    }

    [Token(Token = "0x600D334")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public WorldRaidBpHealItem()
    {
    }
  }
}
