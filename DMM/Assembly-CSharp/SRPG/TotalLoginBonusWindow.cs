// Decompiled with JetBrains decompiler
// Type: SRPG.TotalLoginBonusWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026E4")]
  [FlowNode.Pin(0, "Get", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/LoginBonus/TotalLoginBonusWindow")]
  [FlowNode.Pin(10, "Request", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class TotalLoginBonusWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B6DF")]
    private const int PIN_IN_GET_REWARD = 0;
    [Token(Token = "0x400B6E0")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x400B6E1")]
    private const int PIN_OUT_REQUEST = 10;
    [Token(Token = "0x400B6E2")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RectTransform IconParent;
    [Token(Token = "0x400B6E3")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ListItemEvents Item_Normal;
    [Token(Token = "0x400B6E4")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ListItemEvents Item_Taken;
    [Token(Token = "0x400B6E5")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text TotalLoginCountText;
    [Token(Token = "0x400B6E6")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button RewardButton;
    [Token(Token = "0x400B6E7")]
    [FieldOffset(Offset = "0x20")]
    private TrophyState m_CurrentTrophy;
    [Token(Token = "0x400B6E8")]
    [FieldOffset(Offset = "0x24")]
    private List<ListItemEvents> mItems;

    [Token(Token = "0x600AE2B")]
    [Address(RVA = "0x72ED00", Offset = "0x72DB00", VA = "0x1072ED00", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AE2C")]
    [Address(RVA = "0x72EE40", Offset = "0x72DC40", VA = "0x1072EE40")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AE2D")]
    [Address(RVA = "0x72F920", Offset = "0x72E720", VA = "0x1072F920")]
    private void Start()
    {
    }

    [Token(Token = "0x600AE2E")]
    [Address(RVA = "0x72EF10", Offset = "0x72DD10", VA = "0x1072EF10")]
    private void ClearItems()
    {
    }

    [Token(Token = "0x600AE2F")]
    [Address(RVA = "0x72F750", Offset = "0x72E550", VA = "0x1072F750")]
    private void Refresh(TrophyState[] trophies)
    {
    }

    [Token(Token = "0x600AE30")]
    [Address(RVA = "0x72F0D0", Offset = "0x72DED0", VA = "0x1072F0D0")]
    private void CreateIcon(TrophyState state)
    {
    }

    [Token(Token = "0x600AE31")]
    [Address(RVA = "0x72F4A0", Offset = "0x72E2A0", VA = "0x1072F4A0")]
    private void GetReward()
    {
    }

    [Token(Token = "0x600AE32")]
    [Address(RVA = "0x72F5B0", Offset = "0x72E3B0", VA = "0x1072F5B0")]
    private TrophyState[] RefreshTrophyState() => (TrophyState[]) null;

    [Token(Token = "0x600AE33")]
    [Address(RVA = "0x72F950", Offset = "0x72E750", VA = "0x1072F950")]
    public TotalLoginBonusWindow()
    {
    }
  }
}
