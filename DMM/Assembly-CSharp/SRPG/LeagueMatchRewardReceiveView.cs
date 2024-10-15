// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchRewardReceiveView
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
  [Token(Token = "0x20026B7")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/LeagueMatch/LeagueMatchRewardReceiveView")]
  public class LeagueMatchRewardReceiveView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B585")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B586")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList _exhibitList;
    [Token(Token = "0x400B587")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string REWARD_ICON_PREFAB_PATH;
    [Token(Token = "0x400B588")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform mMISC;
    [Token(Token = "0x400B589")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B58A")]
    [FieldOffset(Offset = "0x1C")]
    private LeagueMatchRewardReceiveModel _resultModel;

    [Token(Token = "0x600AD2A")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600AD2B")]
    [Address(RVA = "0x70CDC0", Offset = "0x70BBC0", VA = "0x1070CDC0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD2C")]
    [Address(RVA = "0x70CED0", Offset = "0x70BCD0", VA = "0x1070CED0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AD2D")]
    [Address(RVA = "0x70D0B0", Offset = "0x70BEB0", VA = "0x1070D0B0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AD2E")]
    [Address(RVA = "0x70CDE0", Offset = "0x70BBE0", VA = "0x1070CDE0")]
    private DuelRewardIconTemplate CreateRewardIconTemplate() => (DuelRewardIconTemplate) null;

    [Token(Token = "0x600AD2F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchRewardReceiveView()
    {
    }
  }
}
