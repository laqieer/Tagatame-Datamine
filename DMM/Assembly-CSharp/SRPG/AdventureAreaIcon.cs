// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureAreaIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F6A")]
  [FlowNode.Pin(1, "選択", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "選択完了", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("UI/Adventure/AdventureAreaIcon")]
  public class AdventureAreaIcon : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008480")]
    private const int PIN_INPUT_SELECT_AREA = 1;
    [Token(Token = "0x4008481")]
    private const int PIN_OUTPUT_SELECT_AREA = 2;
    [Token(Token = "0x4008482")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Image IconImage;
    [Token(Token = "0x4008483")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text AreaName;
    [Token(Token = "0x4008484")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text LevelText;
    [Token(Token = "0x4008485")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject RemainTimeObj;
    [Token(Token = "0x4008486")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text RemainTime;
    [Token(Token = "0x4008487")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject AdventureNowObj;
    [Token(Token = "0x4008488")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject AdventureEndObj;
    [Token(Token = "0x4008489")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Space(5f)]
    private Animator IconAnim;
    [Token(Token = "0x400848A")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button IconButton;
    [Token(Token = "0x400848B")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject DisableButtonObj;
    [Token(Token = "0x400848C")]
    [FieldOffset(Offset = "0x34")]
    [HeaderBar("キャンペーンバッチ")]
    [SerializeField]
    private GameObject CampaignTimeRateObj;
    [Token(Token = "0x400848D")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject CampaignCostRateObj;
    [Token(Token = "0x400848E")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject CampaignDropObj;
    [Token(Token = "0x400848F")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private float CHANGE_INTERBAL;
    [Token(Token = "0x4008490")]
    [FieldOffset(Offset = "0x44")]
    private AdventureData mData;
    [Token(Token = "0x4008491")]
    [FieldOffset(Offset = "0x48")]
    private eAdventureStatus mAdvStatus;
    [Token(Token = "0x4008492")]
    [FieldOffset(Offset = "0x4C")]
    private Coroutine mTimeUpdate;
    [Token(Token = "0x4008493")]
    [FieldOffset(Offset = "0x50")]
    private Coroutine mDelayStart;
    [Token(Token = "0x4008494")]
    [FieldOffset(Offset = "0x54")]
    private float mRemainStartTime;
    [Token(Token = "0x4008495")]
    [FieldOffset(Offset = "0x58")]
    private Coroutine mCampaignBadge;
    [Token(Token = "0x4008496")]
    [FieldOffset(Offset = "0x5C")]
    private List<GameObject> CampaignObjects;

    [Token(Token = "0x60080F0")]
    [Address(RVA = "0x418F00", Offset = "0x417D00", VA = "0x10418F00", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60080F1")]
    [Address(RVA = "0x419D90", Offset = "0x418B90", VA = "0x10419D90")]
    public void SetData(AdventureData _data, float _anim_start_delay = 0.0f)
    {
    }

    [Token(Token = "0x60080F2")]
    [Address(RVA = "0x419000", Offset = "0x417E00", VA = "0x10419000")]
    private void DrawUI()
    {
    }

    [Token(Token = "0x60080F3")]
    [Address(RVA = "0x419A20", Offset = "0x418820", VA = "0x10419A20")]
    public void Refresh(List<AdventureData> _data_list)
    {
    }

    [Token(Token = "0x60080F4")]
    [Address(RVA = "0x419B80", Offset = "0x418980", VA = "0x10419B80")]
    private IEnumerator RemainTimeUpdate() => (IEnumerator) null;

    [Token(Token = "0x60080F5")]
    [Address(RVA = "0x419FE0", Offset = "0x418DE0", VA = "0x10419FE0")]
    private IEnumerator WaitStartAnim() => (IEnumerator) null;

    [Token(Token = "0x60080F6")]
    [Address(RVA = "0x419BF0", Offset = "0x4189F0", VA = "0x10419BF0")]
    private void SelectIcon()
    {
    }

    [Token(Token = "0x60080F7")]
    [Address(RVA = "0x4199D0", Offset = "0x4187D0", VA = "0x104199D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60080F8")]
    [Address(RVA = "0x419F70", Offset = "0x418D70", VA = "0x10419F70")]
    private IEnumerator UpdateCampaignBadge() => (IEnumerator) null;

    [Token(Token = "0x60080F9")]
    [Address(RVA = "0x419CD0", Offset = "0x418AD0", VA = "0x10419CD0")]
    private void SetActiveCampaignBadge(int index)
    {
    }

    [Token(Token = "0x60080FA")]
    [Address(RVA = "0x41A050", Offset = "0x418E50", VA = "0x1041A050")]
    public AdventureAreaIcon()
    {
    }
  }
}
