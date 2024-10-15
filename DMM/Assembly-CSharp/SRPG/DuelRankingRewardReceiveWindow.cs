// Decompiled with JetBrains decompiler
// Type: SRPG.DuelRankingRewardReceiveWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002327")]
  [AddComponentMenu("UI/Duel/DuelRankingRewardReceiveWindow")]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  public class DuelRankingRewardReceiveWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009D02")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x4009D03")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private DuelRankingRewardReceiveWindow.eType mType;
    [Token(Token = "0x4009D04")]
    [FieldOffset(Offset = "0x10")]
    [Space(10f)]
    [SerializeField]
    private Text mRankText;
    [Token(Token = "0x4009D05")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mPointText;
    [Token(Token = "0x4009D06")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mRewardDateText;
    [Token(Token = "0x4009D07")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform mRewardRoot;
    [Token(Token = "0x4009D08")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mDuelRankingViewIn;
    [Token(Token = "0x4009D09")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mDuelRankingViewOut;
    [Token(Token = "0x4009D0A")]
    [FieldOffset(Offset = "0x28")]
    [Space(10f)]
    [StringIsResourcePath(typeof (GameObject))]
    [SerializeField]
    private string REWARD_ICON_PREFAB_PATH;
    [Token(Token = "0x4009D0B")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Transform mMISC;
    [Token(Token = "0x4009D0C")]
    [FieldOffset(Offset = "0x30")]
    private DuelRewardIconTemplate mIconTemplate;

    [Token(Token = "0x6009740")]
    [Address(RVA = "0x59BB50", Offset = "0x59A950", VA = "0x1059BB50", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009741")]
    [Address(RVA = "0x59C3C0", Offset = "0x59B1C0", VA = "0x1059C3C0")]
    private void Init()
    {
    }

    [Token(Token = "0x6009742")]
    [Address(RVA = "0x59BB70", Offset = "0x59A970", VA = "0x1059BB70")]
    private DuelRewardIconTemplate CreateRewardIconTemplate() => (DuelRewardIconTemplate) null;

    [Token(Token = "0x6009743")]
    [Address(RVA = "0x59BD10", Offset = "0x59AB10", VA = "0x1059BD10")]
    private void Init_Daily()
    {
    }

    [Token(Token = "0x6009744")]
    [Address(RVA = "0x59C100", Offset = "0x59AF00", VA = "0x1059C100")]
    private void Init_Season()
    {
    }

    [Token(Token = "0x6009745")]
    [Address(RVA = "0x59BC90", Offset = "0x59AA90", VA = "0x1059BC90")]
    private void CreateRewardIcon(JSON_DuelRewardData[] rewards)
    {
    }

    [Token(Token = "0x6009746")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public DuelRankingRewardReceiveWindow()
    {
    }

    [Token(Token = "0x2002328")]
    private enum eType
    {
      [Token(Token = "0x4009D0E")] None,
      [Token(Token = "0x4009D0F")] Daily,
      [Token(Token = "0x4009D10")] Season,
    }
  }
}
