// Decompiled with JetBrains decompiler
// Type: SRPG.BoxGachaResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002103")]
  [FlowNode.Pin(4, "IN 演出スキップ", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "IN 演出速度アップ OFF", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "IN 演出速度アップ ON", FlowNode.PinTypes.Input, 2)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "IN アイコン表示開始", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "OT 演出初期化", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(0, "IN 演出初期化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("UI/BoxGachaResult", 32741)]
  [FlowNode.Pin(11, "OT アイコン表示終了", FlowNode.PinTypes.Output, 11)]
  public class BoxGachaResult : FlowNodePersistent
  {
    [Token(Token = "0x4008EF5")]
    private const int PIN_IN_INITIALIZE_ICON_ANIM = 0;
    [Token(Token = "0x4008EF6")]
    private const int PIN_IN_PLAY_ICON_ANIM = 1;
    [Token(Token = "0x4008EF7")]
    private const int PIN_IN_ANIM_SPEEDUP_ON = 2;
    [Token(Token = "0x4008EF8")]
    private const int PIN_IN_ANIM_SPEEDUP_OFF = 3;
    [Token(Token = "0x4008EF9")]
    private const int PIN_IN_SKIP = 4;
    [Token(Token = "0x4008EFA")]
    private const int PIN_OT_INITIALIZE_ICON_ANIM = 10;
    [Token(Token = "0x4008EFB")]
    private const int PIN_OT_PLAY_ICON_ANIM = 11;
    [Token(Token = "0x4008EFC")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string m_TemplateIconPath;
    [Token(Token = "0x4008EFD")]
    [FieldOffset(Offset = "0x1C")]
    [Space(10f)]
    [SerializeField]
    [Header("アイコンアニメ再生前のInterval")]
    private float m_StartInterval;
    [Token(Token = "0x4008EFE")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [Header("次のアイコンアニメ再生までのInterval")]
    private float m_IconOpenInterval;
    [Token(Token = "0x4008EFF")]
    [FieldOffset(Offset = "0x24")]
    [Header("アイコンアニメ再生後のInterval")]
    [SerializeField]
    private float m_EndInterval;
    [Token(Token = "0x4008F00")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Header("アイコンアニメ終了と判断するState名")]
    private string[] m_EndIconAnimStateName;
    [Token(Token = "0x4008F01")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [Header("通常再生用のTrigger")]
    private string m_IconAnimDefaultTrigger;
    [Token(Token = "0x4008F02")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    [Header("PickUp再生用のTrigger")]
    private string m_IconAnimPickupTrigger;
    [Token(Token = "0x4008F03")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    [Header("アイコンアニメスキップ用のTrigger")]
    private string m_IconAnimSkipTrigger;
    [Token(Token = "0x4008F04")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Header("Pickupアイコンアニメスキップ用のTrigger")]
    private string m_IconAnimPickupSkipTrigger;
    [Token(Token = "0x4008F05")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    [Header("アイコンアニメ diable用のTrigger")]
    private string m_IconAnimDisableTrigger;
    [Token(Token = "0x4008F06")]
    [FieldOffset(Offset = "0x40")]
    [Header("Pickupアイコンアニメ disable用のTrigger")]
    [SerializeField]
    private string m_IconAnimPickupDisableTrigger;
    [Token(Token = "0x4008F07")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    [Header("アイコンアニメEndState名")]
    private string m_IconAnimEndState;
    [Token(Token = "0x4008F08")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [Header("ピックアップアイコンアニメEndState名")]
    private string m_IconAnimPickupEndState;
    [Token(Token = "0x4008F09")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    [Header("報酬表示リスト")]
    [Space(10f)]
    private GameObject DropList;
    [Token(Token = "0x4008F0A")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [Header("報酬表示を行うContentController")]
    private ContentController ContentControllerDrop;
    [Token(Token = "0x4008F0B")]
    [FieldOffset(Offset = "0x54")]
    [Header("報酬アイコンを置くGameObject")]
    [SerializeField]
    private GameObject DropIconNodeTemplate;
    [Token(Token = "0x4008F0C")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [Header("演出スキップボタン")]
    private GameObject AllSkipButton;
    [Token(Token = "0x4008F0D")]
    [FieldOffset(Offset = "0x5C")]
    private bool is_animspeed_up;
    [Token(Token = "0x4008F0E")]
    private const float SkipInterval = 2f;
    [Token(Token = "0x4008F0F")]
    [FieldOffset(Offset = "0x60")]
    private float m_Timer;
    [Token(Token = "0x4008F10")]
    [FieldOffset(Offset = "0x64")]
    private Coroutine m_IconAnimCoroutine;
    [Token(Token = "0x4008F11")]
    [FieldOffset(Offset = "0x68")]
    private List<BoxGachaDropIconParam> mIconParams;

    [Token(Token = "0x6008A0D")]
    [Address(RVA = "0x4A8E40", Offset = "0x4A7C40", VA = "0x104A8E40", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6008A0E")]
    [Address(RVA = "0x4A90D0", Offset = "0x4A7ED0", VA = "0x104A90D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008A0F")]
    [Address(RVA = "0x4A8C70", Offset = "0x4A7A70", VA = "0x104A8C70")]
    private IEnumerator Initialize() => (IEnumerator) null;

    [Token(Token = "0x6008A10")]
    [Address(RVA = "0x4A8A50", Offset = "0x4A7850", VA = "0x104A8A50")]
    private void InitializeNodeTemplate(LoadRequest req)
    {
    }

    [Token(Token = "0x6008A11")]
    [Address(RVA = "0x4A8620", Offset = "0x4A7420", VA = "0x104A8620")]
    private void InitializeContentController()
    {
    }

    [Token(Token = "0x6008A12")]
    [Address(RVA = "0x4A85B0", Offset = "0x4A73B0", VA = "0x104A85B0")]
    private IEnumerator IconAnimation() => (IEnumerator) null;

    [Token(Token = "0x6008A13")]
    [Address(RVA = "0x4A8CE0", Offset = "0x4A7AE0", VA = "0x104A8CE0")]
    private bool IsAnimatorEndState(Animator anim, AnimatorStateInfo state) => new bool();

    [Token(Token = "0x6008A14")]
    [Address(RVA = "0x4A8DF0", Offset = "0x4A7BF0", VA = "0x104A8DF0")]
    private bool IsAnimatorStateHash(AnimatorStateInfo state, string state_name) => new bool();

    [Token(Token = "0x6008A15")]
    [Address(RVA = "0x4A9170", Offset = "0x4A7F70", VA = "0x104A9170")]
    private void UpdateContentPos(ContentNode node)
    {
    }

    [Token(Token = "0x6008A16")]
    [Address(RVA = "0x4A8470", Offset = "0x4A7270", VA = "0x104A8470")]
    private void IconAnimationSkip()
    {
    }

    [Token(Token = "0x6008A17")]
    [Address(RVA = "0x4A8340", Offset = "0x4A7140", VA = "0x104A8340")]
    private GenesisRewardDataParam CreateRewardDataParam(GachaDropData drop)
    {
      return (GenesisRewardDataParam) null;
    }

    [Token(Token = "0x6008A18")]
    [Address(RVA = "0x4A9290", Offset = "0x4A8090", VA = "0x104A9290")]
    public BoxGachaResult()
    {
    }
  }
}
